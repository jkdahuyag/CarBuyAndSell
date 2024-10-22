using CarBuyAndSell.Dto;
using CarBuyAndSell.Forms;
using CarBuyAndSell.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell.Row_Instance
{
    public partial class BidDataRowInstance : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private BidDto bid;
        public BidDataRowInstance(BidDto bid, bool mini = false)
        {
            InitializeComponent();
            this.bid = bid;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            lblAmount.Text = $"{bid.BidAmount:N3}";
            lblBidder.Text = $"{bid.FirstName} {bid.LastName}";
            lblBidDate.Text = bid.BidDate.ToString();
            lblListingId.Text = $"Listing {bid.ListingId}";
            if (mini)
            {
                btnDelete.Visible = false;
                pnlControls.Visible = false;
                tableLayoutPanel1.ColumnStyles[tableLayoutPanel1.ColumnCount - 1].Width = 0;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this bid?", "Delete Bid", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                globalProcedure.ProcDeleteBid(bid.BidId);
                MessageBox.Show("Bid Deleted");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            this.Parent.Invalidate();
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            ListingDto listing = globalProcedure.ProcGetListingById(bid.ListingId)[0];
            BidForm form = new BidForm(listing);
            form.ShowDialog();
        }
    }
}
