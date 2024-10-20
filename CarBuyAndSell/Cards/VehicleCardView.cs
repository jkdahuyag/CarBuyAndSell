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

namespace CarBuyAndSell.Cards
{
    public partial class VehicleCardView : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private VehicleDto vehicle;
        public VehicleCardView(VehicleDto vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            lblBrandAndModel.Text = vehicle.BrandName + " " + vehicle.Model;
            lblValue.Text = $"{vehicle.MarketValue:N3}";
            lblOwner.Text = vehicle.OwnerName;
            if (vehicle.FileName != "")
                pcBoxVehicleImage.ImageLocation = vehicle.FileName;
            else
                pcBoxVehicleImage.Image = Properties.Resources.DefaultVehicleImage;
        }

        private void BtnSellClick(object sender, EventArgs e)
        {
            Form form = new ListingForm(vehicle);
            form.ShowDialog();
        }

        private void ShowVehicleForm(object sender, EventArgs e)
        {
            Form form = new VehicleForm(vehicle);
            form.ShowDialog();
        }
    }
}
