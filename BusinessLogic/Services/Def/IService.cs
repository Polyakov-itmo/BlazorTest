using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Def
{
    public interface IService<TCreate, TUpdate, TResult, TModel> 
        where TCreate : class
        where TUpdate : class
        where TResult : class
        where TModel : IIdModel
    {
        Task<TModel> Create(TCreate model);
        Task<TResult> Get(int? id);
        Task<IEnumerable<TResult>> GetAll();
        Task<int?> Delete(int? id);
        Task<TModel?> Update(TUpdate model);
    }
}
