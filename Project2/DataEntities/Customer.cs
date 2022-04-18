namespace Project2.DataEntities
{
    public class Customer:BaseEnty
    {
        public string CustomerName { get; set; }
        public string CustomerRegion { get; set; }
        public string CustomerPhone { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        
    }
}
