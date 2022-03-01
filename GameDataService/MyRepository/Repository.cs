using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataService.MyRepository
{
    public interface Repository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        void Update(T enty);
        void DeleteById(int id);
        void Create(T enty);
    }
}
