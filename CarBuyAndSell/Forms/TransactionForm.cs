using CarBuyAndSell.Dto;
using CarBuyAndSell.Helper_Functions;
using CarBuyAndSell.Models;
using CarBuyAndSell.Properties;
using CarBuyAndSell.Row_Instance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell.Forms
{
    public partial class TransactionForm : Form
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private ListingDto listing;

        public TransactionForm(ListingDto listing)
        {
            InitializeComponent();
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            this.listing = listing;
            LoadFormData();
            this.Text = "Add Transaction";
        }

        private void LoadFormData()
        {
            lblHeader.Text = $"You will be sending money to: {listing.FirstName} {listing.LastName}";
            cmbPaymentMethod.DataSource = Enum.GetValues(typeof(Enums.PaymentMethod));
            BidDto highestBid = globalProcedure.ProcGetBidsByListingId(listing.ListingId)[0];
            lblPartial.Text = highestBid.BidAmount.ToString();
            lblService.Text = $"{(highestBid.BidAmount * 0.5f):N3}";
            lblTotal.Text = $"{(highestBid.BidAmount * 1.5f):N3}";
        }
        // Save or Update vehicle data
        private void BtnContinue_Click(object sender, EventArgs e)
        {
            AddTransaction();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddTransaction()
        {
            Transaction transaction = new Transaction(
                    0,
                    listing.OwnerId,
                    LoginInfo.UserId,
                    listing.ListingId,
                    DateTime.Now,
                    Convert.ToDouble(lblTotal.Text),
                    cmbPaymentMethod.SelectedIndex + 1
                );

            if (globalProcedure.ProcCreateTransaction(transaction))
            {
                MessageBox.Show("Transaction added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
