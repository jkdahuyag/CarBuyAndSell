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
            List<Vehicle> vehicles = globalProcedure.FncGetVehicles();

                if (vehicles.Count > 0)
                {
                    // Load the vehicle image
                    vehiclePictureBox.Image = Resources.DefaultVehicleImage;

                    // Set vehicle details
                    lblBrandName.Text = $"Brand: {vehic}";
                    lblModel.Text = $"Model: {dataTable.Rows[0]["brand_name"].ToString()}";
                    lblOwner.Text = $"Owner: {dataTable.Rows[0]["owner_name"].ToString()}";
                    lblMileage.Text = $"Mileage: {dataTable.Rows[0]["mileage"].ToString()} km";
                    lblCondition.Text = $"Condition: {dataTable.Rows[0]["condition_name"].ToString()}";
                    lblManufactureYear.Text = $"Manufacture Year: {dataTable.Rows[0]["manufacture_year"].ToString()}";
                    lblPlateNumber.Text = $"Plate Number: {dataTable.Rows[0]["plate_number"].ToString()}";
                }
           

        }
    }
}
