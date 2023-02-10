using DataAccess.Inrfastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models.Todo
{
    public class TodoUpdate
    {
        public string? Title { get; set; }
        public TodoPriority Priority { get; set; }
        public bool IsDone { get; set; }
    }
}
