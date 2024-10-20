using System;

namespace CarBuyAndSell.Dto
{
    public class TransactionDto
    {
        public int TransactionId { get; set; }
        public string BuyerFirstName{ get; set; }
        public string BuyerLastName{ get; set; }
        public string SellerFirstName { get; set; }
        public string SellerLastName{ get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string PaymentMethodName { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }

        public TransactionDto(int transactionId, string buyerFirstName, string buyerLastName, string sellerFirstName, string sellerLastName, double amount, DateTime transactionDate, string paymentMethodName, int buyerId, int sellerId)
        {
            TransactionId = transactionId;
            BuyerFirstName = buyerFirstName;
            BuyerLastName = buyerLastName;
            SellerFirstName = sellerFirstName;
            SellerLastName = sellerLastName;
            Amount = amount;
            TransactionDate = transactionDate;
            PaymentMethodName = paymentMethodName;
            BuyerId = buyerId;
            SellerId = sellerId;
        }
    }
}
