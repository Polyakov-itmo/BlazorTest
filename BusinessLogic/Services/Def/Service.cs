using BusinessLogic.Mappers.DefMappers;
using BusinessLogic.Services.Def.Internal;
using DataAccess.Models.Def;
using DataAccess.Repositories.Def;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Def
{
    public class Service<TCreate, TUpdate, TResult, TModel> : ServiceInternal<TModel>, IService<TCreate, TUpdate, TResult, TModel> where TModel : IdModel
    {
        private IRepository<TModel> _repository;
        private IMapper<TCreate, TUpdate, TResult, TModel> _mapper;

        public Service(
            IRepository<TModel> repository,
            IMapper<TCreate, TUpdate, TResult, TModel> mapper
        )
            : base(repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TModel> Create(TCreate createModel)
        {
            var model = _mapper.CreateMap(createModel);
            return await CreateInternal(model);
        }

        public async Task CreateRange(IEnumerable<TCreate> createModels)
        {
            var models = createModels.ToList().Select(x => _mapper.CreateMap(x));
            await CreateRangeInternal(models!);
        }

        public async Task<TModel?> Delete(int id)
        {
            return await DeleteInternal(id);
        }

        public async Task<TResult?> Get(int id)
        {
            var result = await _repository._dbSet
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return _mapper.MapResult(result!);
        }

        public async Task<IEnumerable<TResult>?> GetAll()
        {
            var models = await GetAllInternal();
            return models!.Select(x => _mapper.MapResult(x));
        }

        // Task<Todo> Update(TUpdate model);
    }
}
