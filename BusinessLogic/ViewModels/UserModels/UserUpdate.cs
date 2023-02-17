using DataAccess.Models.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels.UserModels
{
    public class UserUpdate : IdModel
    {
        public string? Name { get; set; } = null;
    }
}
