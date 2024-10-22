namespace CarBuyAndSell
{
    public class BrandDistribution
    {
        public string Brand { get; set; }
        public int BrandCount { get; set; }

        public BrandDistribution(string brand, int count)
        {
            Brand = brand;
            BrandCount = count;
        }
    }
}