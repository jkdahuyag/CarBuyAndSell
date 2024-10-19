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
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            lblHeader.Text = "User List";
            ClearAndDisposeControls(pnlUserControl);

            UsersViewControl userListView = new UsersViewControl();
            userListView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(userListView);
        }

        private void ShowVehiclesView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            // if admin 
            // lblHeader.Text = "Vehicles";
            // else
            lblHeader.Text = "My Vehicles";

            ClearAndDisposeControls(pnlUserControl);

            VehiclesViewControl buyView = new VehiclesViewControl();
            buyView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(buyView);
        }

        private void ShowListingView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            // if admin 
            // lblHeader.Text = "Listings";
            // else
            lblHeader.Text = "My Listings";

            ClearAndDisposeControls(pnlUserControl);

            ListingViewControl listingView = new ListingViewControl();
            listingView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(listingView);
        }

        private void ShowAdminDashboardView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            lblHeader.Text = "Dashboard";

            ClearAndDisposeControls(pnlUserControl);

            DashboardViewControl dashboardView = new DashboardViewControl();
            dashboardView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(dashboardView);
        }

        private void ShowMarketView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            lblHeader.Text = "Market";

            ClearAndDisposeControls(pnlUserControl);

            MarketViewControl marketView = new MarketViewControl();
            marketView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(marketView);
        }

        private void ShowBidView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            // if admin 
            // lblHeader.Text = "Bids";
            // else
            lblHeader.Text = "My Bids";

            ClearAndDisposeControls(pnlUserControl);

            BidsViewControl bidView = new BidsViewControl();
            bidView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(bidView);
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

