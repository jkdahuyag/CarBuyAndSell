﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int OwnerId { get; set; }
        public int BrandId { get; set; }
        public int ConditionId { get; set; }
        public int TransmissionTypeId { get; set; }
        public int StatusId { get; set; }
        public string LocationStored { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureYear { get; set; }
        public string PlateNumber { get; set; }
        public DateTime DateListed { get; set; }
        public double Mileage { get; set; }

        public Vehicle(int vehicleId, int brandId, int conditionId, int transmissionTypeId, int statusId, string locationStored, string model, DateTime manufactureYear, string plateNumber, DateTime dateListed, double mileage, int ownerId)
        {
            VehicleId = vehicleId;
            OwnerId = ownerId;
            BrandId = brandId;
            ConditionId = conditionId;
            TransmissionTypeId = transmissionTypeId;
            StatusId = statusId;
            LocationStored = locationStored;
            Model = model;
            ManufactureYear = manufactureYear;
            PlateNumber = plateNumber;
            DateListed = dateListed;
            Mileage = mileage;
        }
    }


}