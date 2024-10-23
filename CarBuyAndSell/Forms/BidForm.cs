using CarBuyAndSell.Dto;
using CarBuyAndSell.Helper_Functions;
using CarBuyAndSell.Models;
using CarBuyAndSell.Properties;
using CarBuyAndSell.Row_Instance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarBuyAndSell.Forms
{
    public partial class BidForm : Form
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private VehicleDto vehicle;
        private ListingDto listing;

        public BidForm(ListingDto listing)
        {
            InitializeComponent();
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            this.listing = listing;
            vehicle = globalProcedure.ProcGetVehicleById(listing.VehicleId)[0];
            LoadFormData();
            
        }

        private void LoadFormData()
        {
            this.Text = "Add Bid";
            this.btnSave.Text = "Add";

            if (listing.StatusName == "Closed")
            {
                txtAskingPrice.Enabled = false;
                btnAction.Enabled = false;
                btnSave.Enabled = false;
                btnSave.Text = "Closed";
            }
            else if (listing.ListingExpiry < DateTime.Now || listing.StatusName == "Expired")
            {
                txtAskingPrice.Enabled = false;
                btnSave.Enabled = false;
                btnSave.Text = "Expired";
            }

            if (listing.OwnerId == LoginInfo.UserId)
            {
                txtAskingPrice.Enabled = false;
                btnSave.Enabled = false;
                btnAction.Text = "Close Listing";
                btnSave.Text = "Owner";
            }
            else
            {
                btnAction.Visible = false;
            }

            string fileLoc = ImageManager.GenerateImagePathFromName(vehicle.FileName);
            if (File.Exists(fileLoc))
                picBoxVehicleImage.ImageLocation = fileLoc;
            else
                picBoxVehicleImage.Image = Resources.DefaultVehicleImage;

            lblBrandAndModel.Text = $"{vehicle.BrandName} {vehicle.Model}";
            lblOwner.Text = vehicle.OwnerName;
            lblAskingPrice.Text = $"Php {listing.AskingPrice:N3}";
            lblExpiryDate.Text = listing.ListingExpiry.ToString()?? " ";

            pnlTopBids.Controls.Clear();
            List<BidDto> bids = globalProcedure.ProcGetBidsByListingId(listing.ListingId);

            if (bids.Count > 0)
            {
                if (bids[0].BidderId == LoginInfo.UserId && (listing.StatusName == "Expired" || listing.StatusName == "Closed"))
                {
                    btnSave.Text = "Highest Bidder";
                    btnAction.Visible = true;
                    btnAction.Enabled = true;
                    btnAction.Text = "Pay for Listing";
                }

                for (int i = bids.Count > 5? 4 : bids.Count - 1; i >= 0; i--)
                {
                    var bid = bids[i];
                    BidDataRowInstance panel = new BidDataRowInstance(bid, true);
                    panel.Dock = DockStyle.Top;
                    // Add the card to the grid
                    pnlTopBids.Controls.Add(panel);
                }
            }
            else
            {
                MessageBox.Show("Record not found!");
            }

            this.globalProcedure.sqlAdapter.Dispose();
            this.globalProcedure.datCarBuyAndSellMgr.Dispose();
        }
        // Save or Update vehicle data
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation logic for inputs
            if (ValidateForm())
            {
                AddBid();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            // Basic form validation
            return !string.IsNullOrEmpty(txtAskingPrice.Text);
        }

        private void AddBid()
        {
            Bid bid = new Bid(
                    0,
                    LoginInfo.UserId,
                    listing.ListingId,
                    double.Parse(txtAskingPrice.Text),
                    DateTime.Now
                );

            if (!globalProcedure.ProcCreateBid(bid))
            {
                MessageBox.Show("Failed to add bid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (listing.StatusName == "Open")
            {
                UpdateListingStatus(2);
            }

            LoadFormData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "Close Listing")
            {
                UpdateListingStatus(3);
            }
            else if (btnAction.Text == "Pay for Listing")
            {
                int statusId = listing.StatusName == "Expired" ? 4 : 3;
                TransactionForm form = new TransactionForm(listing);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateListingStatus(statusId);
                }
            }
        }

        private void UpdateListingStatus(int status)
        {
            Listing listing = new Listing(
                    this.listing.ListingId,
                    this.listing.OwnerId,
                    this.listing.VehicleId,
                    this.listing.DateListed,
                    this.listing.Description,
                    this.listing.AskingPrice,
                    status,
                    status == 4 ? DateTime.Now : this.listing.ListingExpiry
                );

            if (!globalProcedure.ProcUpdateListing(listing)) 
            {
                MessageBox.Show("Failed to update listing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Listing updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
