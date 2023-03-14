using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Def
{
    public class NameModel : IdModel, INameModel
    {
        public string Name { get; set;}
    }
}
