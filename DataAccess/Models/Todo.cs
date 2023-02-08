using System.ComponentModel.DataAnnotations;
using DataAccess.Models.Def;

namespace DataAccess.Models
{
    public class Todo : IdModel
    {
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public int Priority { get; set; }

        public bool isDone { get; set; }
    }
}
