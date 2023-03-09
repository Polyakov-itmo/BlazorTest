using BusinessLogic.Mappers.DefMappers;
using BusinessLogic.Services.Def;
using BusinessLogic.ViewModels.TodoModels;
using DataAccess.Models;
using DataAccess.Models.Def;
using DataAccess.Repositories.Def;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLogic.Services
{
    public class TodoService : Service<TodoCreate, TodoUpdate, TodoResult, TodoListResult, Todo>, ITodoService
    {
        private readonly IRepository<Todo> todoRepository;

        public TodoService(
            IRepository<Todo> _todoRepository,
            IMapper<TodoCreate, TodoUpdate, TodoResult, TodoListResult, Todo> mapper
        )
            : base(_todoRepository, mapper) 
        {
            todoRepository = _todoRepository;
        }

        public override async Task<IEnumerable<TodoListResult>?> GetAll()
        {
            return await todoRepository._dbSet
                .AsNoTracking()
                .Select(x => new TodoListResult()
                {
                    Id = x.Id,
                    Text = x.Text,
                    IsDone = x.IsDone,
                    UserId = x.UserId,
                    UserName = x.User.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NameModel>> ListSelection()
        {
            return await todoRepository._dbSet
                .Select(x => new NameModel()
                {
                    Id = x.Id,
                    Name = x.Text,
                })
                .ToListAsync();

        }

    }
}
