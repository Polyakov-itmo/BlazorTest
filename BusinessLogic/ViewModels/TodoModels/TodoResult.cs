using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels.TodoModels
{
    public class TodoResult : IdModel
    {
        public string? Text { get; set; } = null;
        public bool IsDone { get; set; }
        public string? UserName { get; set; } = null;
    }
}
