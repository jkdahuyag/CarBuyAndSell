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
            this.Text = "Add Bid";
            this.btnSave.Text = "Add";
        }

        private void LoadFormData()
        {
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
                for (int i = 4; i >= 0; i--)
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

            if (globalProcedure.ProcCreateBid(bid))
            {
                MessageBox.Show("Bid added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add bid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
