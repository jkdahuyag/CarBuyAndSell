using System;

namespace CarBuyAndSell.Dto
{
    public class VehicleDto
    {
        public int VehicleId { get; set; }
        public string BrandName { get; set; }
        public string TransmissionTypeName { get; set; }
        public string ConditionName { get; set; }
        public string OwnerName { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureYear { get; set; }
        public string PlateNumber { get; set; }
        public double Mileage { get; set; }
        public double MarketValue { get; set; }
        public string FileName { get; set; }

        public VehicleDto(int vehicleId, string brandName, string transmissionTypeName, string conditionName, string ownerName, string model, DateTime manufactureYear, string plateNumber, double mileage, double marketValue, string fileName)
        {
            VehicleId = vehicleId;
            BrandName = brandName;
            TransmissionTypeName = transmissionTypeName;
            ConditionName = conditionName;
            OwnerName = ownerName;
            Model = model;
            ManufactureYear = manufactureYear;
            PlateNumber = plateNumber;
            Mileage = mileage;
            MarketValue = marketValue;
            FileName = fileName;
        }
    }
}
