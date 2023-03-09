using BusinessLogic.Services;
using BusinessLogic.ViewModels.TodoModels;
using BusinessLogic.ViewModels.UserModels;
using DataAccess.Models;
using DataAccess.Models.Def;
using Microsoft.AspNetCore.Components;

namespace Web.Pages.TodoViews
{
    public partial class TodoCreateView
    {
        [Inject]
        protected ITodoService _todoService { get; set; }
        [Inject]
        protected IUserService _userService { get; set; }

        #region[State]
        public TodoCreate todoToCreate = new();
        public IEnumerable<IdModel>? userSelection { get; set; }
        public Todo? CreatedTodo;
        private bool isNotify = false;
        private bool isCreated = false;
        #endregion[State]



        protected override async Task OnInitializedAsync()
        {
            userSelection = await _userService.ListSelection();
        }

        private async Task CreateTodo()
        {
            var result = await _todoService.Create(todoToCreate);
            if(result is not null)
            {
                isCreated = true;
            }
        }
    }
}
