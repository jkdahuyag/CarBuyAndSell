using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuyAndSell.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public Brand(int brandId, string brandName)
        {
            BrandId = brandId;
            BrandName = brandName;
        }
    }

}
