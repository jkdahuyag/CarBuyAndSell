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
        public int VehicleId { get; set; }
        public DateTime Date { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Profit { get; set; }
        public int PaymentMethodId { get; set; }

        public Transaction(int transactionId, int sellerId, int buyerId, int vehicleId, DateTime date, decimal salePrice, decimal profit, int paymentMethodId)
        {
            TransactionId = transactionId;
            SellerId = sellerId;
            BuyerId = buyerId;
            VehicleId = vehicleId;
            Date = date;
            SalePrice = salePrice;
            Profit = profit;
            PaymentMethodId = paymentMethodId;
        }
    }

}
