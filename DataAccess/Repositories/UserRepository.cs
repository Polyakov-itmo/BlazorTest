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
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(BaseContext context) : base(context)
        {
        }
    }
}
