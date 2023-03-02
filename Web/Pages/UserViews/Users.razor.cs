using BusinessLogic.Services;
using BusinessLogic.ViewModels.UserModels;
using DataAccess;
using Microsoft.AspNetCore.Components;

namespace Web.Pages.UserViews
{
    public partial class Users
    {
        [Inject]
        protected IUserService _userService { get; set; }

        private List<UserListResult>? allUsers;
        private bool IsDeleting = false;
        protected override async Task OnInitializedAsync()
        {
            /*await Task.Run(Load._delay1);*/

            var result = await _userService.GetAll();
            allUsers = result!.ToList();
            await base.OnInitializedAsync();
        }

        public async Task Delete(int id)
        {
            IsDeleting= true;
            var deletedUser = await _userService.Delete(id);
            IsDeleting = false;
            if (deletedUser != null)
            {
                var users = await _userService.GetAll();
                if(users != null)
                {
                    allUsers = users!.ToList();
                }
            }
            IsDeleting = false;
        }

    }
}
