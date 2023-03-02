using BusinessLogic.Services.Def;
using BusinessLogic.ViewModels.UserModels;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IUserService : IService<UserCreate, UserUpdate, UserResult, UserListResult, User> {
    
    
    }

}
