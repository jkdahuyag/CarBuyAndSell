using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell
{
    public class Enums
    {
        public enum Role
        {
            Admin = 1,
            User = 2
        }

        public enum Condition
        {
            New = 1,
            ExtraClean = 2,
            Clean = 3,
            Average = 4,
            Rough = 5
        }

        public enum ListingStatus
        {
            Open = 1,
            Active = 2,
            Closed = 3,
            Expired= 4
        }

        public enum BidStatus
        {
            Pending = 1,
            Accepted = 2,
            Denied = 3
        }

        public enum PaymentMethod
        {
            Cash = 1,
            BankTransfer = 2,
            Check = 3
        }

        public enum TransmissionType
        {
            Automatic = 1,
            Manual = 2,
            Hybrid = 3
        }
    }
}
