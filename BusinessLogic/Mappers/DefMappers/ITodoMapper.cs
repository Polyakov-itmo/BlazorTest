using BusinessLogic.ViewModels.TodoModels;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers.DefMappers
{
    public interface ITodoMapper : IMapper<TodoCreate, TodoUpdate, TodoResult, TodoResult, Todo> { }

}
