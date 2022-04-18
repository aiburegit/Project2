namespace Project2.DataEntities
{
    public class Order : BaseEnty
    {
        public List<Product> OrderProducts { get; set; } = new List<Product>();
        public int OrderStateId { get; set; }
        public OrderState OrderState { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
