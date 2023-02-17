using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels.TodoModels
{
    public class TodoCreate
    {
        public string? Text { get; set; } = null;
        public bool IsDone { get; set; }
        public int UserId { get; set; }
    }
}
