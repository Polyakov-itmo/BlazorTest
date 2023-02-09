using DataAccess.Contexts;
using DataAccess.Models;
using DataAccess.Repos.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos.Todo
{
    public class TodoRepository : BaseRepository<DataAccess.Models.Todo>, ITodoRepository
    {
        public TodoRepository(BaseContext context) : base(context)
        {
        }
    }
}
