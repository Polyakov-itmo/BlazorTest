using DataAccess;
using Web.Infrastructure.Enums;
using DataAccess.Models;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Components;
using BusinessLogic.ViewModels.UserModels;

namespace Web.Pages.UserViews
{
    public partial class UserCreateView
    {
        #region[State]
        public UserCreate userToCreate = new();
        public User? CreatedUser;
        private bool Creating = false;
        private bool isNotify = false;
        #endregion[State]

        #region[Notification]
        private NotificationStatusEnum NotificationStatus;
        private string NotificationTitle = "Success";
        private string NotificationSubTitle = "User was created";
        #endregion[Notification]

        [Inject]
        protected IUserService _userService { get; set; }

        private bool CheckInputs()
        {
            if (!String.IsNullOrEmpty(userToCreate.Name))
            {
                return true;
            }
            return false;
        }

        public void ClearInputs()
        {
            userToCreate.Name = "";
        }

        public async Task SubmitUser()
        {
            if (CheckInputs())
            {
                Creating = true;

                //await Task.Run(Load._delay1);

                CreatedUser = await _userService.Create(userToCreate);
                ClearInputs();

                Creating = false;

                await ShowNotify(NotificationStatusEnum.Succes);
            }
        }

        private void StopNotify()
        {
            isNotify = false;
        }

        private async Task ShowNotify(NotificationStatusEnum status)
        {
            NotificationStatus = status;
            isNotify = true;
            await Task.Run(Load._delay1);
            StopNotify();
        }
    }
}
