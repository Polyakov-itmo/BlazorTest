using BusinessLogic.Mappers.DefMappers;
using BusinessLogic.Services.Def;
using BusinessLogic.ViewModels.UserModels;
using DataAccess.Models;
using DataAccess.Models.Def;
using DataAccess.Repositories;
using DataAccess.Repositories.Def;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class UserService : Service<UserCreate, UserUpdate, UserResult, UserListResult, User>, IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(
            IRepository<User> userRepository,
            IMapper<UserCreate, UserUpdate, UserResult, UserListResult, User> mapper
        )
            : base(userRepository, mapper)
        {
            _userRepository = userRepository;
        }


        public override async Task<IEnumerable<UserListResult>?> GetAll()
        {
            return await _userRepository._dbSet
                .Select(x => new UserListResult()
                {
                    Id = x.Id,
                    Name = x.Name,
                    TodoCount = x.Todos.Count(),
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<NameModel>> ListSelection()
        {

            return await _userRepository._dbSet
                .Select(x => new NameModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                })
                .ToListAsync();

        }

    }
}
