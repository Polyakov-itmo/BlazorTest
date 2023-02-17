using BusinessLogic.Mappers.DefMappers;
using BusinessLogic.ViewModels.UserModels;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public class UserMapper : IUserMapper
    {
        public User CreateMap(UserCreate createModel)
        {
            return new User() { Name = createModel.Name, Todos = new() };
        }

        public UserResult MapResult(User model)
        {
            return new UserResult() { Name = model.Name };
        }

        public User UpdateMap(UserUpdate updateModel)
        {
            return new User() { Id = updateModel.Id, Name = updateModel.Name };
        }
    }

}
