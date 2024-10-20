using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell.Dto
{
    public class BidDto
    {
        public int BidId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ListingId { get; set; }
        public double BidAmount { get; set; }
        public DateTime BidDate { get; set; }

        public BidDto(int bidId, string firstName, string lastName, int listingId, double bidAmount, DateTime bidDate)
        {
            BidId = bidId;
            FirstName = firstName;
            LastName = lastName;
            ListingId = listingId;
            BidAmount = bidAmount;
            BidDate = bidDate;
        }
    }
}
