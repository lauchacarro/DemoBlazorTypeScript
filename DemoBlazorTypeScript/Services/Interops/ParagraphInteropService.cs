using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DemoBlazorTypeScript.Services.Interops
{
    public class ParagraphInteropService : IParagraphInteropService
    {
        private readonly IJSRuntime _jSRuntime;
        public ParagraphInteropService(IJSRuntime jSRuntime)
        {
            _jSRuntime = jSRuntime;
        }

        public ValueTask SetInnerHtml(ElementReference elementReference, string innerHtml)
        {
            return _jSRuntime.InvokeVoidAsync("ParagraphTagFunctions.setInnerHtml", elementReference, innerHtml);
        }
    }
}
