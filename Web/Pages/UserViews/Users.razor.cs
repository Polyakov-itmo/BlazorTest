using BusinessLogic.Services;
using BusinessLogic.ViewModels.UserModels;
using DataAccess;
using DataAccess.Models;
using Microsoft.AspNetCore.Components;

namespace Web.Pages.UserViews
{
    public partial class Users
    {
        [Inject]
        protected IUserService _userService { get; set; }

        private List<(UserListResult user, bool isDeleting)>? allUsers;
        protected override async Task OnInitializedAsync()
        {
            /*await Task.Run(Load._delay1);*/

            await LoadUsers();
            await base.OnInitializedAsync();
        }

        public async Task LoadUsers()
        {
            var result = await _userService.GetAll();

            if(result is not null) {
                allUsers = result.Select(x => (user: x, isDeleting: false)).ToList();
            }
        }

        public async Task Delete(int id)
        {
            var deletedUser = await _userService.Delete(id);
            //await Task.Run(Load._delay1);

            if (deletedUser != null)
            {
                await LoadUsers();
            }
        }
    }
}
