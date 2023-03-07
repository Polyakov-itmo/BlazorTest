using BusinessLogic.Services;
using BusinessLogic.ViewModels.TodoModels;
using BusinessLogic.ViewModels.UserModels;
using Microsoft.AspNetCore.Components;

namespace Web.Pages.TodoViews
{
    public partial class Todos
    {
        [Inject]
        protected ITodoService _todoService { get; set; }
        private List<(TodoListResult todo, bool isDeleting)>? allTodos;


        protected override async Task OnInitializedAsync()
        {
            await LoadTodos();
            await base.OnInitializedAsync();
        }


        public async Task LoadTodos()
        {
            var result = await _todoService.GetAll();

            if (result is not null)
            {
                allTodos = result.Select(x => (todo: x, isDeleting: false)).ToList();
            }
        }

        public async Task Delete(int id)
        {
            var deletedUser = await _todoService.Delete(id);
            //await Task.Run(Load._delay1);

            if (deletedUser != null)
            {
                await LoadTodos();
            }
        }
    }
}
