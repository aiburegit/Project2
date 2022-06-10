using Microsoft.EntityFrameworkCore;
using Project2.Data.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data.Repository
{
    public class ImplementRepository<T> : IRepository<T> where T : BaseEntity
    {
        private DataBaseContext context;
        private DbSet<T> set;
        public ImplementRepository(DataBaseContext _context)
        {
            context = _context;
            set = context.Set<T>();
        }

        public void Add(T entity)
        {
            set.Add(entity);
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.FromResult(set as IEnumerable<T>);
        }

        public Task<IEnumerable<T>> GetByIdAsync(int id)
        {
            IEnumerable<T> result = set.Where(x => x.Id == id);
            return Task.FromResult(result);
        }
    }
}
