using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell.Models
{
    public class Bid
    {
        public int BidId { get; set; }
        public int UserId { get; set; }
        public int ListingId { get; set; }
        public double BidAmount { get; set; }
        public DateTime BidDate { get; set; }

        public Bid(int bidId, int userId, int listingId, double bidAmount, DateTime bidDate)
        {
            BidId = bidId;
            UserId = userId;
            ListingId = listingId;
            BidAmount = bidAmount;
            BidDate = bidDate;
        }
    }
}
