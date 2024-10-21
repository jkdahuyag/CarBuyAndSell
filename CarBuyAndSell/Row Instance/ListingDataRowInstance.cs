﻿using CarBuyAndSell.Dto;
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
    public partial class ListingDataRowInstance : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private ListingDto listing;
        public ListingDataRowInstance(ListingDto listing)
        {
            InitializeComponent();
            this.listing = listing;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            lblBuyer.Text = $"{listing.FirstName} {listing.LastName}";
            lblDateListed.Text = $"{listing.DateListed}";
            lblExpiry.Text = $"{listing.ListingExpiry}";
            lblHighestBid.Text = $"100000";
            lblStatus.Text = listing.StatusName;
            lblListingId.Text = $"{listing.ListingId}";

        }
    }
}
