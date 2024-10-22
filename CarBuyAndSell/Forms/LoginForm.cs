using CarBuyAndSell.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell
{
    public partial class LoginForm : Form
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();


        public LoginForm()
        {
            InitializeComponent();
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (IsValidUser(username, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); 
            }
        }

        // Simulate user validation (replace with real user validation logic)
        private bool IsValidUser(string username, string password)
        {
            UserDto user = globalProcedure.ProcValidateUser(username, password);

            if (user != null)
            {
                // Store user info in LoginInfo class for use in other forms
                LoginInfo.UserId = user.UserId;
                LoginInfo.Username = user.Username;
                LoginInfo.Password = user.Password;
                LoginInfo.Role = user.RoleName;
                LoginInfo.ProfilePicture = user.ProfilePicture;
            }

            
            return user != null;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the main form is closed, close the entire application
            Application.Exit();
        }
    }

}
