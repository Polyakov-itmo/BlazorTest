using BusinessLogic.Mappers.DefMappers;
using BusinessLogic.Services.Def;
using BusinessLogic.ViewModels.TodoModels;
using DataAccess.Models;
using DataAccess.Repositories.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class TodoService : Service<TodoCreate, TodoUpdate, TodoResult, Todo>, ITodoService
    {
        private readonly IRepository<Todo> _repository;

        public TodoService(
            IRepository<Todo> repository,
            IMapper<TodoCreate, TodoUpdate, TodoResult, Todo> mapper
        )
            : base(repository, mapper) 
        {
            _repository = repository;
        }
    }
}
