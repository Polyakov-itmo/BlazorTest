using Microsoft.AspNetCore.Components;
using Web.Infrastructure.Enums;

namespace Web.Pages.Components
{
    public partial class Notification
    {
        #region [Parameter]
        [Parameter]
        public NotificationStatusEnum Status { get; set; }
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public string SubTitle { get; set; }
        #endregion [Parameter]

        public string SetStatus(NotificationStatusEnum status)
        {
            switch (status)
            {
                case NotificationStatusEnum.Succes:
                    return "notification-side__success";
                case NotificationStatusEnum.Fail:
                    return "notification-side__fail";
                case NotificationStatusEnum.Error:
                    return "notification-side__error";
                case NotificationStatusEnum.Warning:
                    return "notification-side__warning";
                case NotificationStatusEnum.Default:
                    return "notification-side__default";
                default: return "notification-side__default";
            }
        }
    }
}
