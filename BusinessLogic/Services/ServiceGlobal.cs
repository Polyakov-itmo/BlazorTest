using BusinessLogic.Mapping;
using BusinessLogic.Services.Def;
using DataAccess.Models.Def;
using DataAccess.Repos.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    internal class ServiceGlobal<TModel> : ServiceBase, IService<TModel> 
        where TModel : IdModel
        

    {
        protected  IBaseRepository<TModel> repository;
        public ServiceGlobal(IBaseRepository<TModel> _repository) { 
            repository = _repository;
        }




        public virtual async Task<TModel> CreateInternal(TModel model)
        {
            return await repository.Create(model);
        }

        public virtual async Task<TModel> UpdateInternal(TModel model)
        {
            return await repository.Update(model);
        }
        public virtual async Task<int?> DeleteInternal(int id)
        {
            var deletedModel = await repository.Delete(id);
            return deletedModel.Id;
        }
        public virtual async Task<TModel?> GetInternal(int id)
        {
            return await repository.Get(id);

        }
        public Task<IEnumerable<TModel>> ListInternal()
        {
            throw new NotImplementedException();
        }

    }
}
