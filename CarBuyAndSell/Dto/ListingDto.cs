using System;

namespace CarBuyAndSell.Dto
{
    public class ListingDto
    {
        public int ListingId { get; set; }
        public int VehicleId { get; set; }
        public DateTime DateListed { get; set; }
        public double AskingPrice { get; set; }
        public DateTime? ListingExpiry { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StatusName { get; set; }
        public int OwnerId { get; set; }

        public ListingDto(int listingId, int vehicleId, DateTime dateListed, double askingPrice, DateTime? listingExpiry, string description, string firstName, string lastName, string statusName, int ownerId)
        {
            ListingId = listingId;
            VehicleId = vehicleId;
            DateListed = dateListed;
            AskingPrice = askingPrice;
            ListingExpiry = listingExpiry;
            Description = description;
            FirstName = firstName;
            LastName = lastName;
            StatusName = statusName;
            OwnerId = ownerId;
        }
    }
}
