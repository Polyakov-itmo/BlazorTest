using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts.TodoContext
{
    public class TodoContext : BaseContext<Todo>, IBaseContext
    {
        public TodoContext(DbContextOptions<BaseContext<Todo>> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; } = default!;
    }
}
