using BusinessLogic.Mappers.DefMappers;
using BusinessLogic.ViewModels.TodoModels;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public class TodoMapper : ITodoMapper
    {
        public Todo CreateMap(TodoCreate createModel)
        {
            return new Todo()
            {
                /* Id = createModel.Id,*/
                Text = createModel.Text,
                UserId = createModel.UserId
            };
        }

        public Todo UpdateMap(TodoUpdate updateModel)
        {
            return new Todo()
            {
                Id = updateModel.Id,
                Text = updateModel.Text,
                UserId = updateModel.UserId
            };
        }

        public TodoResult MapResult(Todo model)
        {
            return new TodoResult()
            {
                Id = model.Id,
                Text = model.Text,
                UserName = model.User.Name
            };
        }
        public TodoListResult MapListResult(Todo model)
        {
            return new TodoListResult()
            {
                Id = model.Id,
                Text = model.Text,
                UserName = model.User.Name
            };
        }

    }

}
