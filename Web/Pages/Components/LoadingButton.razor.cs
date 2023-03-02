using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Web.Pages.Components.Base;

namespace Web.Pages.Components
{
    public partial class LoadingButton : TextComponentBase
    {
        #region Params
        [Parameter]
        public EventCallback<MouseEventArgs> Callback { get; set; }
        [Parameter]
        public bool Show { get; set; }
        #endregion

        public void OnCLickEvent()
        {
            Callback.InvokeAsync();
        }
    }
}
