using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Competency.Blazor.Admin;
using Competency.Blazor.Shared.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var services = builder.Services;
var config = builder.Configuration;

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

services.ConfigureApiHttpClient(config);
services.AddAzureAuthentication(config);

await builder.Build().RunAsync();
