using BusinessLogic.Mappers.DefMappers;
using BusinessLogic.Services.Def;
using BusinessLogic.ViewModels.UserModels;
using DataAccess.Models;
using DataAccess.Repositories.Def;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class UserService : Service<UserCreate, UserUpdate, UserResult, User>, IUserService
    {
        public class UserTodosResult
        {
            public string? Name { get; set; } = null;
            public List<TodosResult> Todos { get; set; } = new();
        }

        public class TodosResult
        {
            public int Id { get; set; }
            public string? Text { get; set; } = null;
            public bool IsDone { get; set; }
        }

        private readonly IRepository<User> _repository;

        public UserService(
            IRepository<User> repository,
            IMapper<UserCreate, UserUpdate, UserResult, User> mapper
        )
            : base(repository, mapper)
        {
            _repository = repository;
        }


        public override async Task<IEnumerable<UserResult>?> GetAll()
        {
            return await _repository._dbSet
                 .Select(x => new UserResult()
                 {
                     Name = x.Name,
                     TodoCount = x.Todos == null ? 0 : x.Todos.Count,
                 })
                 .ToListAsync();
        }

        public async Task<UserTodosResult?> GetWithTodos(int id)
        {
            return await _repository._dbSet
                .AsNoTracking()
                .Where(user => user.Id == id)
                .Select(user => new UserTodosResult()
                {
                    Name = user.Name,
                    Todos = user.Todos
                        .Select(todo => new TodosResult()
                            {
                                Id = todo.Id,
                                Text = todo.Text,
                                IsDone = todo.IsDone
                            }
                        )
                        .ToList()
                }).FirstAsync();
        }



    }
}
