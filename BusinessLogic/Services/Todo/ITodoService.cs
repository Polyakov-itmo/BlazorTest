using BusinessLogic.Models.Todo;
using BusinessLogic.Services.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Todo
{
    /*public interface ITodoService : IService<DataAccess.Models.TodoCreate, DataAccess.Models.Todo, DataAccess.Models.Todo, DataAccess.Models.Todo>
    {
        
    }*/

    public interface ITodoService<TodoCreate, TodoUpdate, TodoResult> : IService<DataAccess.Models.Todo>
    {

    }
}
