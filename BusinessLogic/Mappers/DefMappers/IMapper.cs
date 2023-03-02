using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers.DefMappers
{
    public interface IMapper<TCreate, TUpdate, TResult, TListResult, TModel>
    {
        TModel CreateMap(TCreate createModel);
        TModel UpdateMap(TUpdate updateModel);
        TResult MapResult(TModel model);
        TListResult MapListResult(TModel model);
    }
}
