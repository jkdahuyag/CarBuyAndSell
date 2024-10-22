using CarBuyAndSell.UserControls;
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
            if (LoginInfo.Role == "Admin")
            {
                btnDashboard.Visible = true;
                btnDashboard.Text = "Dashboard";
                btnBids.Text = "Bids";
                btnListings.Text = "Listings";
                btnUsers.Text = "Users";
                btnTransactions.Text = "Transactions";
                btnVehicles.Text = "Vehicles";
            }
            else
            {
                btnDashboard.Visible = false;
            }
        }


        private void ShowUserListView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            lblViewName.Text = "User List";
            ClearAndDisposeControls(pnlUserControl);

            UsersViewControl userListView = new UsersViewControl();
            userListView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(userListView);
        }

        private void ShowVehiclesView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;

            if (LoginInfo.Role == "admin")
                lblViewName.Text = "Vehicles";
            else
                lblViewName.Text = "My Vehicles";

            ClearAndDisposeControls(pnlUserControl);

            VehiclesViewControl buyView = new VehiclesViewControl();
            buyView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(buyView);
        }

        private void ShowListingView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;

            if (LoginInfo.Role == "admin")
                lblViewName.Text = "Listings";
            else
                lblViewName.Text = "My Listings";

            ClearAndDisposeControls(pnlUserControl);

            ListingViewControl listingView = new ListingViewControl();
            listingView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(listingView);
        }

        private void ShowAdminDashboardView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            
            lblViewName.Text = "Dashboard";

            ClearAndDisposeControls(pnlUserControl);

            DashboardViewControl dashboardView = new DashboardViewControl();
            dashboardView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(dashboardView);
        }

        private void ShowMarketView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            lblViewName.Text = "Market";

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
            lblViewName.Text = "My Bids";

            ClearAndDisposeControls(pnlUserControl);

            BidsViewControl bidView = new BidsViewControl();
            bidView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(bidView);
        }


        private void ShowTransactionsView()
        {
            Panel pnlUserControl = this.Controls.Find("pnlUserControl", true)[0] as Panel;
            lblViewName.Text = "Transactions";

            ClearAndDisposeControls(pnlUserControl);

            TransactionsViewControl transactionsView = new TransactionsViewControl();
            transactionsView.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(transactionsView);
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

        private void BtnTransactions_Click(object sender, EventArgs e)
        {
            ShowTransactionsView();
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

        private void BtnLogoutClick(object sender, EventArgs e)
        {
            LoginInfo.UserId = 0;
            LoginInfo.Username = "";
            LoginInfo.Password = "";
            LoginInfo.Role = "";

            Form form = new LoginForm();
            form.Show();

            this.Hide();
        }
    }
}

