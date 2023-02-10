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
        Task<TModel> CreateInternal(TModel model);
        Task<TModel> GetInternal(int id);
        Task<IEnumerable<TModel>> ListInternal();
        Task<int?> DeleteInternal(int id);
        Task<TModel?> UpdateInternal(TModel model);
    }
}
