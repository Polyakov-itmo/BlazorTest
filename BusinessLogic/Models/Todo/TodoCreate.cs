using DataAccess.Inrfastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models.Todo
{
    public class TodoCreate
    {
        public string? Title { get; set; }
        public DateTime CreationDate { get; set; }
        public TodoPriority Priority { get; set; }
        public bool IsDone { get; set; } = false;
    }
}
