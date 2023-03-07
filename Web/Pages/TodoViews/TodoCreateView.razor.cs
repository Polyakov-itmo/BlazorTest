using BusinessLogic.Services;
using BusinessLogic.ViewModels.TodoModels;
using BusinessLogic.ViewModels.UserModels;
using DataAccess.Models;
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
        public Todo? CreatedTodo;
        private bool isNotify = false;
        #endregion[State]



        protected override async Task OnInitializedAsync()
        {
            //var userSelection = await _userService.
        }
    }
}
