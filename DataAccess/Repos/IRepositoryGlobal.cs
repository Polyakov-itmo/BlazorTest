using DataAccess.Repos.Todo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos
{
    public interface IRepositoryGlobal
    {
        ITodoRepository Todos { get; }

        void Save();
    }
}
