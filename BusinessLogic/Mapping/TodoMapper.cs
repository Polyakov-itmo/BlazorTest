using BusinessLogic.Models.Todo;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mapping
{
    public static class TodoMapper
    {

        public static Todo Map(TodoCreate model)
        {
            return new Todo()
            {
                Title = model.Title,
                CreationDate = model.CreationDate,
                Priority = model.Priority,
                IsDone = model.IsDone
            };
        }

        public  static Todo Map(TodoUpdate model)
        {
            return new Todo()
            {
                Title = model.Title,
                CreationDate = DateTime.Now,
                Priority = model.Priority,
                IsDone = model.IsDone
            };
        }

        public static Todo Map(TodoResult model)
        {
            return new Todo()
            {
                Id= model.Id,
                Title = model.Title,
                CreationDate = model.CreationDate,
                Priority = model.Priority,
                IsDone = model.IsDone
            };
        }
    }
}
