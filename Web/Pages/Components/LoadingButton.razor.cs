using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Web.Pages.Components.Base;

namespace Web.Pages.Components
{
    public partial class LoadingButton : TextComponentBase
    {
        #region [State]
        #endregion [State]

        #region Params
        [Parameter]
        public bool Show { get; set; }
        [Parameter]
        public EventCallback<MouseEventArgs> Callback { get; set; }
        #endregion

        public async Task OnCLickEvent()
        {
            await Callback.InvokeAsync();
        }
    }
}
