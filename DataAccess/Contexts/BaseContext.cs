using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class BaseContext<TModel> : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext<TModel>> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Testing;user=user1;password=qwerty;MultipleActiveResultSets=True");
        }
    }
}
