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
        public IEnumerable<NameModel>? userSelection { get; set; }
        public Todo? CreatedTodo;
        private bool isNotify = false;
        private bool isCreated = false;
        private string Error = "Нет ошибок";
        #endregion[State]



        protected override async Task OnInitializedAsync()
        {
            userSelection = await _userService.ListSelection();
        }

        private void ClearInputs()
        {
            todoToCreate.Text = string.Empty;
            todoToCreate.IsDone = false;
            todoToCreate.UserId = 0;
        }

        private bool CheckInputs()
        {
            return !String.IsNullOrEmpty(todoToCreate.Text);
        }

        private async Task CreateTodo()
        {
            if (CheckInputs())
            {
                var result = await _todoService.Create(todoToCreate);
                ClearInputs();
                if (result is not null)
                {
                    isCreated = true;
                }
            }
            else
            {
                Error = "Поле текста задания пустое";
            }
        }
    }
}
