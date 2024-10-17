using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell.Models
{
    public class Listing
    {
        public int ListingId { get; set; }
        public int UserId { get; set; }
        public int VehicleId { get; set; }
        public DateTime DateListed { get; set; }
        public string Description { get; set; }
        public double AskingPrice { get; set; }
        public int StatusId { get; set; }
        public DateTime? ListingExpiry { get; set; }

        public Listing(int listingId, int userId, int vehicleId, DateTime dateListed, string description, double askingPrice, int statusId, DateTime? listingExpiry = null)
        {
            ListingId = listingId;
            UserId = userId;
            VehicleId = vehicleId;
            DateListed = dateListed;
            Description = description;
            AskingPrice = askingPrice;
            StatusId = statusId;
            ListingExpiry = listingExpiry;
        }
    }

}
