using DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos.Def
{
    public class BaseRepository<TModel>: IBaseRepository
    {
        private IBaseContext<TModel> _context;
        public BaseRepository(IBaseContext context) {
            _context = context;
        }


        public int Create(TModel)
        {
            _context.

        }

    }
}
