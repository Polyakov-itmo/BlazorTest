using DataAccess.Models;
using DataAccess.Repositories.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
