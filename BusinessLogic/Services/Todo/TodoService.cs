using AutoMapper;
using BusinessLogic.Models.Todo;
using DataAccess.Repos.Def;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Todo
{
   internal class TodoService : 
        ServiceGlobal<DataAccess.Models.Todo>, 
        ITodoService
    {
        private readonly IBaseRepository<DataAccess.Models.Todo> _todoREpository;
        public TodoService(IBaseRepository<DataAccess.Models.Todo> _repository) : base(_repository)
        {
            _todoREpository = _repository;
        }
    }


    
}
