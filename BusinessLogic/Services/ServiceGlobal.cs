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
    internal class ServiceGlobal<TCreate, TUpdate, TResult, TModel> : ServiceBase, IService<TCreate, TUpdate, TResult, TModel> 
        where TCreate : class
        where TUpdate : class
        where TResult : class
        where TModel : IIdModel
        

    {
        private readonly IBaseRepository<TModel> repository;
        public ServiceGlobal(IBaseRepository<TModel> _repository) { 
            repository = _repository;
        }

        public virtual async Task<int> Create(TCreate model)
        {
            var modelToCreate = Mapper.Map<TModel>(model);
            var createdModel = await repository.Create(modelToCreate);
            return createdModel.Id;

        }

        public virtual async Task<int> Update(TUpdate model)
        {
            var modelToUpdate = Mapper.Map<TModel>(model);
            var updatedModel = await repository.Update(modelToUpdate);
            return updatedModel.Id;
        }

        public virtual async Task<int> Delete(int? id)
        {
            var deletedModel = await repository.Delete(id);
            return deletedModel.id;
        }

        public Task<TResult> Get(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TResult>> GetAll()
        {
            throw new NotImplementedException();
        }

        
    }
}
