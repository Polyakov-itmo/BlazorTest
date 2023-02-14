using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Def
{
    public interface IRepository<T>
    {
        public void Info();
        Task<T> Create(T model);
        Task<T?> Get(int id);
        Task<IEnumerable<T>?> GetAll();
        Task<T?> Delete(int id);
        Task<T?> Update(T model);
        void Save();
    }
}
