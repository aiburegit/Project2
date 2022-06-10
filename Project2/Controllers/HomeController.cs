using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2.Data;
using Project2.Data.DataEntities;
using Project2.Data.Repository;

namespace Project2.Controllers
{
    
    public class HomeController : Controller
    {
        private DataBaseContext dbContext;
        private IRepository<Category> category;
       public HomeController(DataBaseContext context , IRepository<Category> Categories)
        {
            dbContext = context;
            category = Categories;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var result = await category.GetAllAsync();
            return result;
        }
        public void AddCategory(string name , string description)
        {
            Category category = new Category()
            {
                CategoryName = name,
                CategoryDescription = description
            };
            dbContext.Set<Category>().Add(category);
            dbContext.SaveChanges();
        }
        public void UpdateCategory(Category category)
        {
            Category old_category = dbContext.Set<Category>().Where(c => c.Id == category.Id).FirstOrDefault();
            old_category = category;
            dbContext.Entry(old_category).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            
            Category category = dbContext.Set<Category>().Where(c => c.Id == id).FirstOrDefault();
            if (category != null)
            {
                dbContext.Set<Category>().Remove(category);
                dbContext.SaveChanges();
            }
            
        }
        public IEnumerable<Unit> GetUnits()
        {
            return dbContext.Set<Unit>().ToList();
        }
        public void AddUnit(string name, string description)
        {
            Unit unit = new Unit()
            {
                UnitName = name,
                
            };
            dbContext.Set<Unit>().Add(unit);
            dbContext.SaveChanges();
        }
        public void UpdateUnit(Unit unit)
        {
            Unit old_unit = dbContext.Set<Unit>().Where(c => c.Id == unit.Id).FirstOrDefault();
            old_unit = unit;
            dbContext.Entry(unit).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void DeleteUnit(int id)
        {

            Unit unit = dbContext.Set<Unit>().Where(c => c.Id == id).FirstOrDefault();
            if (unit != null)
            {
                dbContext.Set<Unit>().Remove(unit);
                dbContext.SaveChanges();
            }

        }
        public IEnumerable<Region> GetRegions()
        {
            return dbContext.Set<Region>().ToList();
        }
        public void AddRegion(string name, string description)
        {
            Region region = new Region()
            {
                RegionName = name,

            };
            dbContext.Set<Region>().Add(region);
            dbContext.SaveChanges();
        }
        public void UpdateRegion(Unit unit)
        {
            Unit old_unit = dbContext.Set<Unit>().Where(c => c.Id == unit.Id).FirstOrDefault();
            old_unit = unit;
            dbContext.Entry(unit).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void DeleteRegion(int id)
        {

            Region region = dbContext.Set<Region>().Where(c => c.Id == id).FirstOrDefault();
            if (region != null)
            {
                dbContext.Set<Region>().Remove(region);
                dbContext.SaveChanges();
            }

        }
        public IEnumerable<Customer> GetCustomers()
        {
            var result = dbContext.Set<Customer>().Include(c => c.CustomerRegion);
            return result;
        }
        public void DeleteCustomer(int id)
        {

            Customer region = dbContext.Set<Customer>().Where(c => c.Id == id).FirstOrDefault();
            if (region != null)
            {
                dbContext.Set<Customer>().Remove(region);
                dbContext.SaveChanges();
            }

        }
        public IEnumerable<Product> GetProducts()
        {
            var result = dbContext.Set<Product>().Include(c => c.Category).Include(c => c.Unit);
            return result;
        }
    }
}
