using CarBuyAndSell.Dto;
using CarBuyAndSell.Forms;
using CarBuyAndSell.Helper_Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell.Cards
{
    public partial class ListingCardView : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private ListingDto listing;
        private VehicleDto vehicle;
        public ListingCardView(ListingDto listing)
        {
            InitializeComponent();
            this.listing = listing;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            vehicle = globalProcedure.ProcGetVehicleById(listing.VehicleId)[0];
            lblBrandAndModel.Text = vehicle.BrandName + " " + vehicle.Model;
            lblValue.Text = $"Php {listing.AskingPrice:N3}";
            lblOwner.Text = vehicle.OwnerName;
            if (vehicle.FileName != "")
                pcBoxVehicleImage.ImageLocation = ImageManager.GenerateImagePathFromName(vehicle.FileName);
            else
                pcBoxVehicleImage.Image = Properties.Resources.DefaultVehicleImage;
        }

        private void BtnBiddingClick(object sender, EventArgs e)
        {
            Form form = new BidForm(listing);
            form.ShowDialog();
        }

        private void ShowVehicleForm(object sender, EventArgs e)
        {
            Form form = new VehicleForm(vehicle);
            form.ShowDialog();
        }
    }
}
