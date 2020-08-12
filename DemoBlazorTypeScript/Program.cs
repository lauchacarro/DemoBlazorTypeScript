using System;
using System.Net.Http;
using System.Threading.Tasks;

using DemoBlazorTypeScript.Services.Interops;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DemoBlazorTypeScript
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<IParagraphInteropService, ParagraphInteropService>();
            builder.Services.AddSingleton<ICanvasInteropService, CanvasInteropService>();

            await builder.Build().RunAsync();
        }
    }
}
