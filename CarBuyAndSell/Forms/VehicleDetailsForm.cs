using CarBuyAndSell.Dto;
using CarBuyAndSell.Models;
using CarBuyAndSell.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell.Forms
{
    public partial class VehicleDetailsForm : Form
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private int _vehicleId = 0;
        public VehicleDetailsForm(int vehicleId)
        {
            InitializeComponent();
            _vehicleId = vehicleId;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            LoadVehicleDetails();
        }

        private void LoadVehicleDetails()
        {
            List<VehicleDto> vehicles = globalProcedure.ProcGetVehicleById(_vehicleId);

                if (vehicles.Count > 0)
                {
                    // Load the vehicle image
                    vehiclePictureBox.Image = Resources.DefaultVehicleImage;

                    // Set vehicle details
                    lblBrandName.Text = $"Brand: {vehicles[0].BrandName}";
                    lblModel.Text = $"Model: {vehicles[0].Model}";
                    lblOwner.Text = $"Owner: {vehicles[0].OwnerName}";
                    lblMileage.Text = $"Mileage: {vehicles[0].Mileage} km";
                    lblCondition.Text = $"Condition: {vehicles[0].ConditionName}";
                    lblManufactureYear.Text = $"Manufacture Year: {vehicles[0].ManufactureYear.Year}";
                    lblPlateNumber.Text = $"Plate Number: {vehicles[0].PlateNumber}";
                }
           

        }
    }
}
