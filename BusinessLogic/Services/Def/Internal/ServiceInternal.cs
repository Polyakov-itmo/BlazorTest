using DataAccess.Models.Def;
using DataAccess.Repositories.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Def.Internal
{
    public class ServiceInternal<TModel> : IServiceInternal<TModel>
    where TModel : IdModel
    {
        private IRepository<TModel> _repository;

        public ServiceInternal(IRepository<TModel> repository)
        {
            _repository = repository;
        }

        public async Task<TModel?> CreateInternal(TModel model)
        {
            return await _repository.Create(model);
        }

        public async Task CreateRangeInternal(IEnumerable<TModel> models)
        {
            await _repository.CreateRange(models);
        }

        public Task<TModel?> DeleteInternal(int id)
        {
            return _repository.Delete(id);
        }

        public async Task<TModel?> GetInternal(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<IEnumerable<TModel>?> GetAllInternal()
        {
            return await _repository.GetAll();
        }

        //::TODO сделать операция обновления
        // public async Task<TModel?> Update(TModel model)
        // {
        //     throw new NotImplementedException();
        // }
    }

}
