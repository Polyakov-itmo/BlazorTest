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
    public class Service<TCreate, TUpdate, TResult, TListResult, TModel> : ServiceInternal<TModel>, IService<TCreate, TUpdate, TResult, TListResult, TModel> where TModel : IdModel
    {
        private IRepository<TModel> _repository;
        private IMapper<TCreate, TUpdate, TResult, TListResult, TModel> _mapper;

        public Service(
            IRepository<TModel> repository,
            IMapper<TCreate, TUpdate, TResult, TListResult, TModel> mapper
        )
            : base(repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        

        public virtual async Task<TModel> Create(TCreate createModel)
        {
            var model = _mapper.CreateMap(createModel);
            return await CreateInternal(model);
        }

        public virtual async Task CreateRange(IEnumerable<TCreate> createModels)
        {
            var models = createModels.ToList().Select(x => _mapper.CreateMap(x));
            await CreateRangeInternal(models!);
        }

        public virtual async Task<TModel?> Delete(int id)
        {
            return await DeleteInternal(id);
        }

        public virtual async Task<TResult?> Get(int id)
        {
            var result = await _repository._dbSet
                .AsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return _mapper.MapResult(result!);
        }

        public virtual async Task<IEnumerable<TListResult>?> GetAll()
        {
            var models = await GetAllInternal();
            return models!.Select(x => _mapper.MapListResult(x));
        }

        // Task<Todo> Update(TUpdate model);
    }
}
