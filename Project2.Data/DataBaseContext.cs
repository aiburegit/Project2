using Microsoft.EntityFrameworkCore;
using Project2.Data.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderState> OrderStates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Region> Regions { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
            Database.EnsureCreated();
           /* Region kaluga = new Region() { RegionName = "Калужская обл." };
            
            Region moscow = new Region() { RegionName = "Московская обл." };
            Regions.AddRange(kaluga, moscow);
            
            Category Yogurt = new Category() { CategoryDescription = "Натуральные йогурты", CategoryName = "Йогурт" };
            Category FeezeyWather = new Category { CategoryDescription = "Беригите зубы", CategoryName = "Газировка" };
            Categories.AddRange(Yogurt , FeezeyWather);
            Unit unit = new Unit() { UnitName = "шт" };
            Unit unit_bottle = new Unit() { UnitName = "бутылка" };
            Units.AddRange(unit, unit_bottle);
            Product product_Two = new Product() { ProductName = "Активия", Category = Yogurt, Unit = unit, ProductCount = 30, PriceMultiplicate = 1, ProductPrice = 456, ProductDescription = "Йогурт активия с кусочками манго" };
            SaveChanges();
            Product product_One = new Product() { ProductName = "Данон", Category = Yogurt, Unit = unit, ProductCount = 20, PriceMultiplicate = 1, ProductPrice = 45, ProductDescription = "Йогурт данон с шоколадной крошкой" };
            Product bottle = new Product() { ProductName = "Coca-cola", Category = FeezeyWather, Unit = unit_bottle, ProductCount = 40, PriceMultiplicate = 1, ProductPrice = 45, ProductDescription = "Газ. напиток Кока-кола" };
            Product fanta = new Product() { ProductName = "Fanta", Category = FeezeyWather, Unit = unit_bottle, ProductCount = 50, PriceMultiplicate = 1, ProductPrice = 45, ProductDescription = "Газ. напиток Фанта" };
            Products.AddRange(product_One, product_Two, bottle , fanta);
            SaveChanges();
            OrderState state = new OrderState() { State = "Ожидание" };
            OrderState state_ready = new OrderState() { State = "Отправлен" };
            OrderStates.AddRange(state, state_ready);
            Customer customer = new Customer() { CustomerName = "Виталий Сергеевич", CustomerPhone = "3123123", CustomerRegion = kaluga };
            Customer customeborys = new Customer() { CustomerName = "Борис Борисович", CustomerPhone = "777777", CustomerRegion = moscow };
            Customers.Add(customer);
            SaveChanges();
            Order ord = new Order() { Customer = customer, OrderProducts = new List<Product>() { product_One, product_Two }, OrderState = state };
            Orders.Add(ord);
            SaveChanges();
           */
            
            
        }
    }
}
