using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace DemoBlazorTypeScript.Services.Interops
{
    public interface IParagraphInteropService
    {
        ValueTask SetInnerHtml(ElementReference elementReference, string innerHtml);
    }
}
