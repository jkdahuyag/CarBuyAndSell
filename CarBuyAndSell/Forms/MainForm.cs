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

        private void ShowUserListView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            UserList userListView = new UserList();
            userListView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(userListView);
        }

        private void ShowBuyView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            BuyViewControl buyView = new BuyViewControl();
            buyView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(buyView);
        }

        private void ShowListingView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            Listing listingView = new Listing();
            listingView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(listingView);
        }

        private void ShowAdminDashboardView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            DashboardViewControl dashboardView = new DashboardViewControl();
            dashboardView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(dashboardView);
        }

        private void BtnUserList_Click(object sender, EventArgs e)
        {
            ShowUserListView();
        }


        private void BtnVehicles_Click(object sender, EventArgs e)
        {
            ShowBuyView(); // Display Buy tab content
        }

        private void BtnListing_Click(object sender, EventArgs e)
        {
            ShowListingView(); // Display Sell tab content
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
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

        private void BtnMarket_Click(object sender, EventArgs e)
        {
            ShowMarketView();
        }

        private void ShowMarketView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            MarketViewControl marketView = new MarketViewControl();
            marketView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(marketView);
        }

        private void BtnBid_Click(object sender, EventArgs e)
        {
            ShowBidView();
        }

        private void ShowBidView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            BidsViewControl bidView = new BidsViewControl();
            bidView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(bidView);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the main form is closed, close the entire application
            Application.Exit();
        }
    }
}

