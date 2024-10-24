﻿using CarBuyAndSell.Dto;
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
            LoadFormData();
        }

        private void LoadFormData()
        {
            lblBrandAndModel.Text = vehicle.BrandName + " " + vehicle.Model;
            lblValue.Text = $"Php {vehicle.MarketValue:N3}";
            lblOwner.Text = vehicle.OwnerName;

            if(globalProcedure.ProcCheckVehicleListingStatus(vehicle.VehicleId))
            {
                btnSell.Enabled = false;
                btnSell.Text = "Already Listed";
            }   

            if (vehicle.FileName != "")
                picBoxVehicleImage.ImageLocation = ImageManager.GenerateImagePathFromName(vehicle.FileName);
            else
                picBoxVehicleImage.Image = Properties.Resources.DefaultVehicleImage;
        }

        private void BtnSellClick(object sender, EventArgs e)
        {
            if (globalProcedure.ProcCheckVehicleListingStatus(vehicle.VehicleId))
            {
                Form form = new ListingForm(vehicle);
                form.ShowDialog();
            }
        }

        private void ShowVehicleForm(object sender, EventArgs e)
        {
            Form form = new VehicleForm(vehicle);
            form.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Form form = new VehicleForm(vehicle);
            form.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this vehicle?", "Delete Vehicle", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                globalProcedure.ProcDeleteVehicle(vehicle.VehicleId);
                MessageBox.Show("Vehicle Deleted");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}
