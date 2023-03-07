using DataAccess.Models;
using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels.TodoModels
{
    public class TodoListResult : IdModel
    {
        public string Text { get; set; }
        public bool IsDone { get; set; }

        public int? UserId { get; set; }
        public string? UserName { get; set; }
    }
}
