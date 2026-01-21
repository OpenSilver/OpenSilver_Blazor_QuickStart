using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OpenSilver.Blazor;
using Radzen;
using System.Threading.Tasks;

namespace OpenSilver_Blazor_QuickStart.Browser
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            // Register Radzen services (required for Radzen components)
            builder.Services.AddRadzenComponents();

            // Initialize OpenSilver.Blazor
            Initializer.UseBlazorForOpenSilver(builder);

            var host = builder.Build();
            await host.RunAsync();
        }
    }
}
