using DataAccess.Contexts;
using DataAccess.Repos.Todo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos
{
    public class RepositoryGlobal : IRepositoryGlobal
    {
        private BaseContext _context;
        private ITodoRepository _todos;

        public RepositoryGlobal(BaseContext context)
        {
            _context = context;
        }

        public ITodoRepository Todos
        {
            get {
                if(_todos == null)
                {
                    _todos = new TodoRepository(_context);
                }
                return _todos;
            }
            
        }


        public async void Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
