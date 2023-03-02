using DataAccess.Models;
using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels.UserModels
{
    public class UserListResult : IdModel
    {
        public string? Name { get; set; } = null;

        public int TodoCount { get; set; }
    }
}
