using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarBuyAndSell.Models;
using CarBuyAndSell.Dto;
using CarBuyAndSell.Helper_Functions;
using CarBuyAndSell.Properties;
using System.IO;
namespace CarBuyAndSell.Forms
{
    public partial class UserForm : Form
    {
        private bool _isEditMode;
        private UserDto _user;
        private GlobalProcedure globalProcedure = new GlobalProcedure();
        private string fileName = "";

        public UserForm(UserDto user)
        {
            InitializeComponent();
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            _user = user;
            _isEditMode = user != null;
            LoadFormData();

            this.Text = _isEditMode ? "Edit User" : "Add User";
            this.btnSave.Text = _isEditMode ? "Save" : "Add";
        }

        private void LoadFormData()
        {
            PicBoxProfilePicture.Image = Resources.defaultUserImage;
            cmbRole.DataSource = Enum.GetValues(typeof(Enums.Role));
            if (_isEditMode)
            {
                cmbRole.SelectedIndex = 0;
                string fileLoc = ImageManager.GenerateImagePathFromName(_user.ProfilePicture);

                if (File.Exists(fileLoc))
                    PicBoxProfilePicture.ImageLocation = fileLoc;

                cmbRole.SelectedIndex = _user.RoleName == "Admin" ? 0 : 1;
                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                txtAddress.Text = _user.Address;
                txtUsername.Text = _user.Username;
                txtPhoneNumber.Text = _user.Number;
            }
        }

        // Save or Update user data
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation logic for inputs
            if (ValidateForm())
            {
                if (_isEditMode)
                {
                    UpdateUser();
                }
                else
                {
                    AddNewUser();
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
            return !string.IsNullOrEmpty(txtFirstName.Text) &&
                   !string.IsNullOrEmpty(txtLastName.Text) &&
                   !string.IsNullOrEmpty(txtUsername.Text) &&
                   !string.IsNullOrEmpty(txtPassword.Text);
        }

        private void AddNewUser()
        {
            Models.User newUser = new Models.User(
                0, 
                (int)cmbRole.SelectedValue,
                txtFirstName.Text, 
                txtLastName.Text, 
                txtAddress.Text, 
                txtUsername.Text, 
                txtPassword.Text, 
                txtPhoneNumber.Text,
                fileName
            );

            if (globalProcedure.ProcCreateUser(newUser)) {  
                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser()
        {
            Models.User user = new Models.User(
                _user.UserId,
                cmbRole.SelectedIndex + 1,
                txtFirstName.Text,
                txtLastName.Text,
                txtAddress.Text,
                txtUsername.Text,
                txtPassword.Text,
                txtPhoneNumber.Text,
                fileName
            );

            if (globalProcedure.ProcUpdateUser(user))
            {
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditPhoto_Click(object sender, EventArgs e)
        {
            PicBoxProfilePicture.ImageLocation = ImageManager.GenerateImagePathFromFileManager();
            fileName = ImageManager.FileName;
        }
    }
}
