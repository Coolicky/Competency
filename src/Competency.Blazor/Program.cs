using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Competency.Blazor;
using Competency.Blazor.Shared.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var services = builder.Services;
var config = builder.Configuration;

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

services.AddGraphClientService();
services.ConfigureHttpClient("WebApi", config["DataApi:BaseAddress"]);
services.AddAzureAuthentication(config);

  
await builder.Build().RunAsync();
