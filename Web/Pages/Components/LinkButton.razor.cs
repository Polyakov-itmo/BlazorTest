using Microsoft.AspNetCore.Components;
using Web.Pages.Components.Base;

namespace Web.Pages.Components
{
    public partial class LinkButton : TextComponentBase
    {
        [Parameter]
        public string Url { get; set; }
    }
}
