using DataAccess;
using Web.Infrastructure.Enums;
using DataAccess.Models;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Components;

namespace Web.Pages.UserViews
{
    public partial class UserCreate
    {
        #region[Params]
        public string UserName = "";
        public User? user;
        private bool Creating = false;
        private bool isNotify = false;
        #endregion[Params]

        #region[Notification]
        private NotificationStatusEnum NotificationStatus;
        private string NotificationTitle = "Success";
        private string NotificationSubTitle = "User was created";
        #endregion[Notification]

        [Inject]
        protected IUserService _userService { get; set; }

        private bool CheckInputs()
        {
            if (!String.IsNullOrEmpty(UserName))
            {
                return true;
            }
            return false;
        }

        public void ClearInputs()
        {
            UserName = "";
        }

        public async Task SubmitUser()
        {
            BusinessLogic.ViewModels.UserModels.UserCreate userToCreate = new();
            if (CheckInputs())
            {
                Creating = true;
                userToCreate.Name = UserName;
                ClearInputs();
               /* await Task.Run(Load._delay1);*/
                user = await _userService.Create(userToCreate);
                Creating = false;

                if (user != null)
                {
                    SetNotify(true, NotificationStatusEnum.Succes);
                }
                else
                {
                    SetNotify(true, NotificationStatusEnum.Fail);

                }
                await Task.Run(Load._delay1);

                SetNotify(false, NotificationStatusEnum.Default);

            }
        }

        private void SetNotify(bool isShow, NotificationStatusEnum status)
        {
            NotificationStatus = status;
            isNotify = isShow;
        }
    }
}
