using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Def
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> _dbSet { get; }
        Task<T> Create(T model);
        Task CreateRange(IEnumerable<T> models);
        Task<T?> Get(int id);
        Task<T?> GetFirst();
        Task<IEnumerable<T>?> GetAll();
        Task<T?> Delete(int id);
        Task DeleteAll();
       /* Task<T?> Update(T model);*/
        void Save();
        public void Info();
    }
}
