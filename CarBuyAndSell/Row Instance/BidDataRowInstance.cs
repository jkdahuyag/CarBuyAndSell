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

namespace CarBuyAndSell.Row_Instance
{
    public partial class BidDataRowInstance : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private BidDto bid;
        public BidDataRowInstance(BidDto bid)
        {
            InitializeComponent();
            this.bid = bid;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            lblAmount.Text = $"{bid.BidAmount:N3}";
            lblBidder.Text = $"{bid.FirstName} {bid.LastName}";
            lblBidDate.Text = bid.BidDate.ToString();
            lblListingId.Text = $"Listing {bid.ListingId}";
        }
    }
}
