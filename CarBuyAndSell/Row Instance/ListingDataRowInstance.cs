using CarBuyAndSell.Dto;
using CarBuyAndSell.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell.Row_Instance
{
    public partial class ListingDataRowInstance : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private ListingDto listing;
        private BidDto highestBid;
        public ListingDataRowInstance(ListingDto listing)
        {
            InitializeComponent();
            this.listing = listing;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            VehicleDto vehicle = globalProcedure.ProcGetVehicleById(listing.VehicleId)[0];
            lblVehicle.Text = $"{vehicle.BrandName} {vehicle.Model}";
            lblDateListed.Text = $"{listing.DateListed}";
            lblExpiry.Text = $"{listing.ListingExpiry}";

            highestBid = globalProcedure.ProcGetBidsByListingId(listing.ListingId).OrderByDescending(x => x.BidAmount).FirstOrDefault();
            if (highestBid != null){
                lblHighestBid.Text = $"{highestBid.BidAmount}";
                lblHighestBidder.Text = $"{highestBid.FirstName} {highestBid.LastName}";
            }
            else{
                lblHighestBid.Text = "No Bids Yet";
                lblHighestBidder.Text = "No Bids Yet";
            }
            lblStatus.Text = listing.StatusName;
            lblListingId.Text = $"{listing.ListingId}";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this listing?", "Delete Listing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                globalProcedure.ProcDeleteListing(listing.ListingId);
                MessageBox.Show("Listing Deleted");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            this.Parent.Invalidate();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ListingForm form = new ListingForm(listing);
            form.ShowDialog();
            this.Parent.Invalidate();
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            BidForm form = new BidForm(listing);
            form.ShowDialog();
        }
    }
}
