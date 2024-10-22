using CarBuyAndSell.Dto;
using CarBuyAndSell.Helper_Functions;
using CarBuyAndSell.Models;
using CarBuyAndSell.Properties;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell.Forms
{
    public partial class VehicleForm : Form
    {
        private bool isEditMode;
        private VehicleDto vehicle;
        private List<Brand> brands;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        private string fileName = "";

        public VehicleForm(VehicleDto vehicle)
        {
            InitializeComponent();
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            this.vehicle = vehicle;
            isEditMode = vehicle != null;
            LoadFormData();

            this.Text = isEditMode ? "Edit Vehicle" : "Add Vehicle";
            this.btnSave.Text = isEditMode ? "Save" : "Add";
        }

        private void LoadFormData()
        {
            PicBoxVehicleImage.Image = Resources.DefaultVehicleImage;

            cmbCondition.DataSource = Enum.GetValues(typeof(Enums.Condition));
            cmbTransmissionType.DataSource = Enum.GetValues(typeof(Enums.TransmissionType));
            brands = globalProcedure.ProcGetBrands();
            cmbBrand.DataSource = brands.Select(x => x.BrandName).ToList();
            cmbBrand.SelectedIndex = 0;
            cmbCondition.SelectedIndex = 0;
            cmbTransmissionType.SelectedIndex = 0;

            if (isEditMode)
            {
                fileName = vehicle.FileName;
                string fileLoc = ImageManager.GenerateImagePathFromName(vehicle.FileName);

                if (File.Exists(fileLoc))
                    PicBoxVehicleImage.ImageLocation = fileLoc;

                cmbCondition.SelectedIndex = (int)Enum.Parse(typeof(Enums.Condition), String.Concat(vehicle.ConditionName.Split())) - 1;
                cmbTransmissionType.SelectedIndex = (int)Enum.Parse(typeof(Enums.TransmissionType), String.Concat(vehicle.TransmissionTypeName.Split())) - 1;
                cmbBrand.SelectedIndex = cmbBrand.FindStringExact(vehicle.BrandName);
                txtModel.Text = vehicle.Model;
                txtManufactureYear.Text = vehicle.ManufactureYear.Year.ToString();
                txtMileage.Text = vehicle.Mileage.ToString();
                txtPlateNumber.Text = vehicle.PlateNumber;
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
                    UpdateVehicle();
                }
                else
                {
                    AddNewVehicle();
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
            return !string.IsNullOrEmpty(txtManufactureYear.Text) &&
                   !string.IsNullOrEmpty(txtMileage.Text) &&
                   !string.IsNullOrEmpty(txtModel.Text) &&
                   !string.IsNullOrEmpty(txtPlateNumber.Text) &&
                   (cmbBrand.SelectedItem != null);
        }

        private void AddNewVehicle()
        {
            Vehicle vehicle = new Vehicle(
                0,
                brands[cmbBrand.SelectedIndex].BrandId,
                cmbCondition.SelectedIndex + 1,
                cmbTransmissionType.SelectedIndex + 1,
                fileName,
                txtModel.Text,
                new DateTime(int.Parse(txtManufactureYear.Text), 1, 1),
                txtPlateNumber.Text,
                double.Parse(txtMileage.Text),
                LoginInfo.UserId
            );

            if (globalProcedure.ProcCreateVehicle(vehicle))
            {
                MessageBox.Show("Vehicle added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateVehicle()
        {
            Vehicle vehicle = new Vehicle(
                this.vehicle.VehicleId,
                brands[cmbBrand.SelectedIndex].BrandId,
                cmbCondition.SelectedIndex + 1,
                cmbTransmissionType.SelectedIndex + 1,
                fileName,
                txtModel.Text,
                new DateTime(int.Parse(txtManufactureYear.Text),1,1),
                txtPlateNumber.Text,
                double.Parse(txtMileage.Text),
                LoginInfo.UserId
            );

            if (globalProcedure.ProcUpdateVehicle(vehicle))
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

        private void BtnEditPhoto_Click(object sender, EventArgs e)
        {
            PicBoxVehicleImage.ImageLocation = ImageManager.GenerateImagePathFromFileManager();
            fileName = ImageManager.FileName;
        }
    }
}
