using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Def
{
    public interface IService<TModel> 
        where TModel : IdModel
    {
        Task<TModel> Create(TModel model);
        Task<TModel> Get(int id);
        Task<IEnumerable<TModel>> GetAll();
        Task<int?> Delete(int id);
        Task<TModel?> Update(TModel model);
    }
}
