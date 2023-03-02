using BusinessLogic.Services.Def.Internal;
using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Def
{
    public interface IService<TCreate, TUpdate, TResult, TListResult, TModel> : IServiceInternal<TModel> where TModel : IdModel
    {
        Task<TModel> Create(TCreate createModel);
        Task CreateRange(IEnumerable<TCreate> createModels);
        Task<TModel?> Delete(int id);
        Task<TResult?> Get(int id);
        Task<IEnumerable<TListResult>?> GetAll();
        // Task<Todo> Update(TUpdate model);
    }
}
