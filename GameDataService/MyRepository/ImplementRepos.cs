using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDataService.Models;
using GameDataService.Option;
using Microsoft.EntityFrameworkCore;


namespace GameDataService.MyRepository
{
    public class ImplementRepos<T> : Repository<T> where T : BaseEnty
    {
       public GameDBContext db;
       public DbSet<T> _dbSet;

       public ImplementRepos(GameDBContext context)
        {
            db = context;
            _dbSet = context.Set<T>();
        }

        public void Create(T enty)
        {
           _dbSet.Add(enty);
            db.SaveChanges();
        }

        public void DeleteById(int id)
        {
            db.Remove(_dbSet.Where(t => t.Id == id).FirstOrDefault());
            db.SaveChanges();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            var data = _dbSet as IEnumerable<T>;
            return Task.FromResult(data);
        }

        public Task<T> GetById(int id)
        {
            var data = _dbSet.Where(t => t.Id == id).FirstOrDefault();
            return Task.FromResult(data);
        }

        public void Update(T enty)
        {
           if(enty != null)
            {
                db.Update(enty);
                db.Entry(enty).State = EntityState.Modified;
            }
           db.SaveChanges();
        }
        

    }
}
