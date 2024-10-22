using CarBuyAndSell.Dto;
using CarBuyAndSell.Helper_Functions;
using CarBuyAndSell.Models;
using CarBuyAndSell.Properties;
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
    public partial class ListingForm : Form
    {
        private bool isEditMode;
        private ListingDto listing;
        private VehicleDto vehicle;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        private string fileName = "";

        public ListingForm()
        {
            InitializeComponent();
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
        }
        public ListingForm(VehicleDto vehicle) : this()
        {
            this.vehicle = vehicle;
            isEditMode = false;
            LoadFormData();
            this.Text = "Add Listing";
            this.btnSave.Text = "Add";
        }

        public ListingForm(ListingDto listing) : this()
        {
            this.listing = listing;
            vehicle = globalProcedure.ProcGetVehicleById(listing.VehicleId)[0];
            isEditMode = true;
            LoadFormData();

            this.Text = "Edit Listing";
            this.btnSave.Text = "Save";
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
            lblValue.Text = $"Php {vehicle.MarketValue:N3}";

            if (isEditMode)
            {
                txtDescription.Text = listing.Description;
                txtAskingPrice.Text = listing.AskingPrice.ToString();
            }
        }
        // Save or Update vehicle data
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation logic for inputs
            if (ValidateForm())
            {
                if (isEditMode)
                {
                    UpdateListing();
                }
                else
                {
                    AddNewListing();
                }

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
            return !string.IsNullOrEmpty(txtDescription.Text) &&
                   !string.IsNullOrEmpty(txtAskingPrice.Text);
        }

        private void AddNewListing()
        {
            Listing listing = new Listing(
                    0,
                    LoginInfo.UserId,
                    vehicle.VehicleId,
                    DateTime.Now,
                    txtDescription.Text,
                    double.Parse(txtAskingPrice.Text),
                    1
                );

            if (globalProcedure.ProcCreateListing(listing))
            {
                MessageBox.Show("Vehicle added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListing()
        {
            int condition = this.listing.ListingExpiry == null || this.listing.ListingExpiry > DateTime.Now ? 1 : 4;
            Listing listing = new Listing(
                    0,
                    LoginInfo.UserId,
                    vehicle.VehicleId,
                    DateTime.Now,
                    txtDescription.Text,
                    double.Parse(txtAskingPrice.Text),
                    1
                );

            if (globalProcedure.ProcUpdateListing(listing))
            {
                MessageBox.Show("Vehicle updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
