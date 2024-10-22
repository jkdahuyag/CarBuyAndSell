using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public int ListingId { get; set; }
        public DateTime TransactionDate { get; set; }
        public double SalePrice { get; set; }
        public int PaymentMethodId { get; set; }

        public Transaction(int transactionId, int sellerId, int buyerId, int listingId, DateTime transactionDate, double salePrice, int paymentMethodId)
        {
            TransactionId = transactionId;
            SellerId = sellerId;
            BuyerId = buyerId;
            ListingId = listingId;
            TransactionDate = transactionDate;
            SalePrice = salePrice;
            PaymentMethodId = paymentMethodId;
        }
    }

}
