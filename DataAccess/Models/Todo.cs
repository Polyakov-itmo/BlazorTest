using System.ComponentModel.DataAnnotations;
using DataAccess.Inrfastructure;
using DataAccess.Models.Def;

namespace DataAccess.Models
{
    public class Todo : IdModel
    {
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public TodoPriority? Priority { get; set; }

        public bool IsDone { get; set; }
    }
}
