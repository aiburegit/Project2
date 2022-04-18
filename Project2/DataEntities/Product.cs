namespace Project2.DataEntities
{
    public class Product : BaseEnty
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        
        public int ProductCount { get; set; }
        public int ProductPrice { get; set; }
        public float PriceMultiplicate { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
