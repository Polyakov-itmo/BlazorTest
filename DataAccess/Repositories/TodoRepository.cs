using DataAccess.Contexts;
using DataAccess.Models;
using DataAccess.Repositories.Def;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        public TodoRepository(BaseContext context) : base(context)
        {

            var List = new List<Todo>()
            {
                new Todo()
                {
                    Title ="Купить молоко",
                    IsDone = false
                },
                new Todo()
                {
                    Title ="Купить молоко",
                    IsDone = false
                },
                new Todo()
                {
                    Title ="Купить молоко",
                    IsDone = false
                }
            };
        }
    }
}
