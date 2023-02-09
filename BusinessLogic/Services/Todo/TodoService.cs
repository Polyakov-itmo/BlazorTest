using BusinessLogic.Models.Todo;
using DataAccess.Repos.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Todo
{
    internal class TodoService : ServiceGlobal<TodoCreate, TodoUpdate, TodoResult, DataAccess.Models.Todo>
    {
        public TodoService(IBaseRepository<DataAccess.Models.Todo> _repository) : base(_repository)
        {
        }
    }
}
