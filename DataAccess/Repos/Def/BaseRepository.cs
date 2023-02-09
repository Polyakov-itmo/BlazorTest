using DataAccess.Contexts;
using DataAccess.Models.Def;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos.Def
{
    public abstract class BaseRepository<TModel>: IBaseRepository<TModel> where TModel : IdModel
    {
        protected BaseContext _context { get; set; }

        public BaseRepository(BaseContext context) {
            _context = context;
        }

        public void Info()
        {
            throw new NotImplementedException();
        }

        public async Task<TModel> Create(TModel model)
        {
            var item = (await _context.Set<TModel>().AddAsync(model)).Entity;
            return item;
        }
        
        public async Task<TModel?> Get(int id)
        {
            return await _context.Set<TModel>().FindAsync(id);
        }

        public async Task<IEnumerable<TModel>> GetAll()
        {
            return await _context.Set<TModel>().ToListAsync();
        }

        public async Task<TModel?> Delete(int id)
        {
            var modelToDelete = await _context.Set<TModel>().FindAsync(id);
            if(modelToDelete is null) {
                return null;
            }
             _context.Set<TModel>().Remove(modelToDelete);
            return modelToDelete;
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
    }
}
