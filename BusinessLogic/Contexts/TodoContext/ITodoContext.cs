using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts.TodoContext
{
    internal interface ITodoContext : BaseContext<Todo>, IBaseContext
    {
    }
}
