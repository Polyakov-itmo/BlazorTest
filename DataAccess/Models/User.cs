using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class User : IdModel
    {
        public string? Name { get; set; }
        public List<Todo>? Todos { get; set; } = new();
    }
}
