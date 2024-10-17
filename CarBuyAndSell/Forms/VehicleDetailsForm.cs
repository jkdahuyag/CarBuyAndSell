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
            if (!this.globalProcedure.fncConnectToDatabase())
                MessageBox.Show("Not Connected");
            LoadVehicleDetails();
        }

        private void LoadVehicleDetails()
        {
            try
            {
                MySqlCommand gProcCmd = globalProcedure.sqlCommand;

                this.globalProcedure.sqlBuyAndSellAdapter = new MySqlDataAdapter();
                this.globalProcedure.datBuyAndSell = new DataTable();

                gProcCmd.Parameters.Clear();
                gProcCmd.CommandText = "procGetVehicleById";
                gProcCmd.CommandType = CommandType.StoredProcedure;
                gProcCmd.Parameters.AddWithValue("@p_vehicle_id", _vehicleId);
                this.globalProcedure.sqlBuyAndSellAdapter.SelectCommand = this.globalProcedure.sqlCommand;
                this.globalProcedure.datBuyAndSell.Clear();
                this.globalProcedure.sqlBuyAndSellAdapter.Fill(this.globalProcedure.datBuyAndSell);

                if (globalProcedure.datBuyAndSell.Rows.Count > 0)
                {
                    DataTable dataTable = globalProcedure.datBuyAndSell;

                    // Load the vehicle image
                    vehiclePictureBox.Image = Resources.DefaultVehicleImage;

                    // Set vehicle details
                    lblBrandName.Text = $"Brand: {dataTable.Rows[0]["brand_name"].ToString()}";
                    lblModel.Text = $"Model: {dataTable.Rows[0]["brand_name"].ToString()}";
                    lblOwner.Text = $"Owner: {dataTable.Rows[0]["owner_name"].ToString()}";
                    lblMileage.Text = $"Mileage: {dataTable.Rows[0]["mileage"].ToString()} km";
                    lblCondition.Text = $"Condition: {dataTable.Rows[0]["condition_name"].ToString()}";
                    lblManufactureYear.Text = $"Manufacture Year: {dataTable.Rows[0]["manufacture_year"].ToString()}";
                    lblPlateNumber.Text = $"Plate Number: {dataTable.Rows[0]["plate_number"].ToString()}";
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }

                this.globalProcedure.sqlBuyAndSellAdapter.Dispose();
                this.globalProcedure.datBuyAndSell.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
