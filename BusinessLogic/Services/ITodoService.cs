using BusinessLogic.Services.Def;
using BusinessLogic.ViewModels.TodoModels;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface ITodoService : IService<TodoCreate, TodoUpdate, TodoResult, TodoResult,Todo>
    {
    }
}
