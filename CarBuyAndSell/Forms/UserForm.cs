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
namespace CarBuyAndSell.Forms
{
    public partial class UserForm : Form
    {
        private bool _isEditMode;
        private Models.User _user;

        public UserForm(Models.User user)
        {
            InitializeComponent();
            _user = user;
            _isEditMode = user != null;
            LoadFormData();
        }

        private void LoadFormData()
        {
            //cmbRole.DataSource = GetRoles(); // e.g., list of roles (Admin, User, etc.)

            // If editing, load user data
            if (_isEditMode)
            {
                cmbRole.SelectedItem = _user.Role;
                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                txtAddress.Text = _user.Address;
                txtUsername.Text = _user.Username;
                txtPhoneNumber.Text = _user.Number;
            }
        }

        // Save or Update user data
        private void btnSave_Click(object sender, EventArgs e)
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
                0, (int)cmbRole.SelectedValue, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtUsername.Text, txtPassword.Text, txtPhoneNumber.Text
           );

            //SaveUser(newUser);
        }

        private void UpdateUser()
        {
            _user.Role = (int)cmbRole.SelectedValue;
            _user.FirstName = txtFirstName.Text;
            _user.LastName = txtLastName.Text;
            _user.Address = txtAddress.Text;
            _user.Username = txtUsername.Text;
            _user.Password = txtPassword.Text;  // Ideally this should be hashed
            _user.Number = txtPhoneNumber.Text;

            // Save updated user data
            //SaveUser(_user);
        }
    }
}
