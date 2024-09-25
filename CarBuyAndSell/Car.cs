using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell
{
    public class Car
    {
        public int ItemNo { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string SellStatus { get; set; }

        public Car(int itemNo, string brandName, string model, int price, string sellStatus)
        {
            ItemNo = itemNo;
            BrandName = brandName;
            Model = model;
            Price = price;
            SellStatus = sellStatus;
        }
    }
}
