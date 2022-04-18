using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project2.DataEntities;

namespace Project2.Controllers
{
    
    public class HomeController : ControllerBase
    {
        private MyDbContext dbContext;
       public HomeController(MyDbContext context)
        {
            dbContext = context;
        }
        public IEnumerable<Category> GetCategories()
        {
            return dbContext.Set<Category>().ToList();
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
    }
}
