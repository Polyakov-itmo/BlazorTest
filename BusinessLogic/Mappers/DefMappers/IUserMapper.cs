using BusinessLogic.ViewModels.UserModels;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers.DefMappers
{
    public interface IUserMapper : IMapper<UserCreate, UserUpdate, UserResult, User> { }
}
