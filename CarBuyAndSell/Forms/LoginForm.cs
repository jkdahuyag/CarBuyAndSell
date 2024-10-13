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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Example: Hard-coded user credentials (replace with database check in real apps)
            if (IsValidUser(username, password))
            {
                // Open the main form upon successful login
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // Show error message if login fails
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Simulate user validation (replace with real user validation logic)
        private bool IsValidUser(string username, string password)
        {
            // In a real app, replace this logic with a database check
            return username == "admin" && password == "password123";
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the main form is closed, close the entire application
            Application.Exit();
        }
    }

}
