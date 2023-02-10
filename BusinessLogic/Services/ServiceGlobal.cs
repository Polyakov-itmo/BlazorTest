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

        public virtual async Task<TModel> Create(TModel model)
        {
            return await repository.Create(model);
        }

        public virtual async Task<TModel> Update(TModel model)
        {
            return await repository.Update(model);
        }

        public virtual async Task<int?> Delete(int id)
        {
            var deletedModel = await repository.Delete(id);
            return deletedModel.Id;
        }

        public virtual async Task<TModel?> Get(int id)
        {
            return await repository.Get(id);

        }

        public Task<IEnumerable<TModel>> GetAll()
        {
            throw new NotImplementedException();
        }

    }
}
