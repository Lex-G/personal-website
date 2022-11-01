using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;
using MudBlazor.Services;
using Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["API_Prefix"] ?? builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

builder.Services.AddSingleton<LayoutService>();

await builder.Build().RunAsync();
