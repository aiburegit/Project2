using Microsoft.EntityFrameworkCore;
using Project2.DataEntities;
namespace Project2
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderState> OrderStates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }
        public DbSet<Unit> Units { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

            Database.EnsureCreated();

            Category Yogurt = new Category() { CategoryDescription = "tasty yogurts", CategoryName = "Yogurts" };
            Categories.Add(Yogurt);
            Unit unit = new Unit() { UnitName = "шт" };
            Units.Add(unit);
            Product product_Two = new Product() { ProductName = "Йогург растишка", Category = Yogurt, Unit = unit, ProductCount = 2, PriceMultiplicate = 1, ProductPrice = 456, ProductDescription = "с крошкой голубиных клювиков" };
            SaveChanges();
            Product product_One = new Product() { ProductName = "Йогург данон", Category = Yogurt, Unit = unit, ProductCount = 20, PriceMultiplicate = 1, ProductPrice = 45, ProductDescription = "вкуснейший с кусочками кожи греческой черепахи с хлопьями авакадо" };
            Products.AddRange(product_One, product_Two);
            SaveChanges();
            OrderState state = new OrderState() { State = "Ожидание" };
            OrderStates.Add(state);
            Customer customer = new Customer() { CustomerName = "Vitaly", CustomerPhone = "3123123", CustomerRegion = "kaluga" };
            Customers.Add(customer);
            SaveChanges();
            Order ord = new Order() { Customer = customer, OrderProducts = new List<Product>() { product_One, product_Two }, OrderState = state };
            Orders.Add(ord);
            SaveChanges();

        }
    }
}
