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

        public MainForm()
        {
            InitializeComponent();
            btnVehicles.Select();
            ShowVehiclesView();
        }


        private void ShowUserListView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            UsersViewControl userListView = new UsersViewControl();
            userListView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(userListView);
        }

        private void ShowVehiclesView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            VehiclesViewControl buyView = new VehiclesViewControl();
            buyView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(buyView);
        }

        private void ShowListingView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            ListingViewControl listingView = new ListingViewControl();
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

        private void ShowMarketView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            MarketViewControl marketView = new MarketViewControl();
            marketView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(marketView);
        }

        private void ShowBidView()
        {
            Panel contentPanel = this.Controls.Find("contentPanel", true)[0] as Panel;

            ClearAndDisposeControls(contentPanel);

            BidsViewControl bidView = new BidsViewControl();
            bidView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(bidView);
        }

        private void BtnMarket_Click(object sender, EventArgs e)
        {
            ShowMarketView();
        }

        
        private void BtnBid_Click(object sender, EventArgs e)
        {
            ShowBidView();
        }

        
        private void BtnUserList_Click(object sender, EventArgs e)
        {
            ShowUserListView();
        }


        private void BtnVehicles_Click(object sender, EventArgs e)
        {
            ShowVehiclesView();
        }

        private void BtnListing_Click(object sender, EventArgs e)
        {
            ShowListingView();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            ShowAdminDashboardView();
        }


        // Helper function to safely clear and dispose controls
        private void ClearAndDisposeControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.Dispose();
            }
            parent.Controls.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }
    }
}

