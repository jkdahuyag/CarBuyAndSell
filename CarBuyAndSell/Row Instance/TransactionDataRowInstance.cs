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
    public partial class TransactionDataRowInstance : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private TransactionDto transaction;
        public TransactionDataRowInstance(TransactionDto transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            lblTransactionId.Text = $"Id No. {transaction.TransactionId}";
            lblBuyer.Text = $"{transaction.BuyerFirstName} {transaction.BuyerLastName}";
            lblSeller.Text = $"{transaction.SellerFirstName} {transaction.SellerLastName}";
            lblAmount.Text = $"{transaction.Amount:N3}";
            lblDate.Text = transaction.TransactionDate.Date.ToString();
            lblMethod.Text = transaction.PaymentMethodName;
        }
    }
}
