using DataAccess.Contexts;
using DataAccess.Models.Def;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Def
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : IdModel
    {
        private BaseContext _context { get; set; }
        public DbSet<TModel> _dbSet { get; }

        public Repository(BaseContext context)
        {
            _context = context;
            _dbSet = context.Set<TModel>();
        }

        public virtual void Info()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TModel?> GetFirst()
        {
            return await _dbSet.AsNoTracking().FirstAsync();
        }

        public virtual async Task<TModel?> Get(int id)
        {
            return await _dbSet.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<TModel>?> GetAll()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<TModel?> Create(TModel model)
        {
            var addedModel = (await _dbSet.AddAsync(model)).Entity;
            Save();
            return addedModel;
        }

        public virtual async Task CreateRange(IEnumerable<TModel> models)
        {
            await _dbSet.AddRangeAsync(models);
            Save();
        }

        public virtual async Task<TModel?> Delete(int id)
        {
            bool os = false;
            try
            {
                var model = await Get(id);
                var state = _context.Entry(model).State;
               
                if (model is not null)
                {
                    _context.Entry(model).State = EntityState.Deleted;
                    Save();
                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }

        public virtual async Task DeleteAll()
        {
            _dbSet.RemoveRange(_dbSet.ToList());
        }


        public virtual void Save()
        {
            _context.SaveChanges();
        }
    }
}
