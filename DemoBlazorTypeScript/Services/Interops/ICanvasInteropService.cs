using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DemoBlazorTypeScript.Services.Interops
{
    interface ICanvasInteropService
    {
        ValueTask AddPasteEventListener<TValue>(ElementReference canvas, DotNetObjectReference<TValue> dotNetObjectReference) where TValue : class;
        ValueTask<string> GetCanvasBase64(ElementReference canvas);
        ValueTask SetBase64IntoCanvas<TValue>(ElementReference canvas, string imageBase64, DotNetObjectReference<TValue> dotNetObjectReference) where TValue : class;
    }
}
