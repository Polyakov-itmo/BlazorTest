using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Def.Internal
{
    public interface IServiceInternal<TModel> where TModel : class
    {
        Task<TModel?> GetInternal(int id);
        Task<IEnumerable<TModel>?> GetAllInternal();
        Task<TModel?> CreateInternal(TModel model);
        Task CreateRangeInternal(IEnumerable<TModel> models);
        //::TODO сделать операция обновления
        // Task<TModel?> Update(TModel model);
        Task<TModel?> DeleteInternal(int id);
    }
}
