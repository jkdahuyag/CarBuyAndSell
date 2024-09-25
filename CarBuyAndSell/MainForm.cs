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
    public partial class MainForm : Form
    {
        private List<string> cars = new List<string>();
        private int currentPage = 1;
        private const int carsPerPage = 10;

        public MainForm()
        {
            InitializeComponent();
            LoadCars();
            ShowBuyView();
        }


        private void LoadCars()
        {
            for (int i = 1; i <= 100; i++)
            {
                cars.Add("Car " + i);
            }
        }

        // Method to display Buy View
        private void ShowBuyView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            // Clear and dispose of previous controls
            ClearAndDisposeControls(contentPanel);

            // Create and add the BuyViewControl
            BuyViewControl buyView = new BuyViewControl();
            buyView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(buyView);
        }

        // Method to display Sell View
        private void ShowSellView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;
            // Clear and dispose of previous controls
            ClearAndDisposeControls(contentPanel);
            // Create and add the BuyViewControl
            SellViewControl sellView = new SellViewControl();
            sellView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(sellView);

            // Add more components for the Sell view here, such as a form to input car details.
        }

        // Method to display Admin Dashboard View
        private void ShowAdminDashboardView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;
            contentPanel.Controls.Clear(); // Clear current content

            Label adminLabel = new Label();
            adminLabel.Text = "This is the Admin Dashboard";
            adminLabel.AutoSize = true;
            adminLabel.Padding = new Padding(10);
            adminLabel.BorderStyle = BorderStyle.FixedSingle;
            contentPanel.Controls.Add(adminLabel);

            // Add more components for the Admin Dashboard view here.
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            ShowBuyView(); // Display Buy tab content
        }

        private void SellBtn_Click(object sender, EventArgs e)
        {
            ShowSellView(); // Display Sell tab content
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            ShowAdminDashboardView(); // Display Admin Dashboard content
        }

        private void PrevPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ShowBuyView(); // Repopulate the Buy view with previous page
            }
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < (cars.Count + carsPerPage - 1) / carsPerPage)
            {
                currentPage++;
                ShowBuyView(); // Repopulate the Buy view with next page
            }
        }

        // Helper function to safely clear and dispose controls
        private void ClearAndDisposeControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.Dispose(); // Ensure controls are disposed
            }
            parent.Controls.Clear(); // Clear all controls
        }
    }
}

