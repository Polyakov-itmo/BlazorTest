using BusinessLogic.Models.Todo;
using BusinessLogic.Services.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Todo
{
    public interface ITodoService : IService<TodoCreate, TodoUpdate, TodoResult, DataAccess.Models.Todo>
    {
        
    }
}
