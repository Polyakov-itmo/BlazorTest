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
        protected BaseContext _context { get; set; }

        public Repository(BaseContext context)
        {
            _context = context;
        }

        public void Info()
        {
            throw new NotImplementedException();
        }

        public async Task<TModel> Create(TModel model)
        {
            return (await _context.Set<TModel>().AddAsync(model)).Entity;
        }

        public async Task CreateRange(IEnumerable<TModel> models)
        {
            await _context.Set<TModel>().AddRangeAsync(models);
        }


        public async Task<TModel?> Get(int id)
        {
            return await _context.Set<TModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TModel>?> GetAll()
        {
            return await _context.Set<TModel>().ToListAsync();
        }

        public async Task<TModel?> Delete(int id)
        {
            var model = await Get(id);
            if (model is not null)
            {
                return (_context.Set<TModel>().Remove(model)).Entity;
            }
            return null;
        }

        public async Task<TModel?> Update(TModel model)
        {
            var modelToUpdate = await _context.Set<TModel>().FindAsync(model.Id);
            if (modelToUpdate is null)
            {
                return null;
            }
            _context.Set<TModel>().Update(modelToUpdate);
            return modelToUpdate;

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
