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
    public class UserService : Service<UserCreate, UserUpdate, UserResult, UserListResult, User>, IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(
            IRepository<User> repository,
            IMapper<UserCreate, UserUpdate, UserResult, UserListResult, User> mapper
        )
            : base(repository, mapper)
        {
            _repository = repository;
        }

        //public async Task

    }
}
