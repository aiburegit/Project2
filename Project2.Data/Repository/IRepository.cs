using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Data.Repository
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> GetByIdAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public void Add(T entity);

    }
}
