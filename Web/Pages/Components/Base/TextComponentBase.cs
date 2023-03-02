using Microsoft.AspNetCore.Components;

namespace Web.Pages.Components.Base
{
    public abstract class TextComponentBase : ComponentBase
    {
        [Parameter]
        public string Text { get; set; }
        [Parameter]
        public string Style { get; set; }

    }
}
