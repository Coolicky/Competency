using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Competency.Blazor.Admin;
using Competency.Blazor.Shared.Authorization;
using Competency.Blazor.Shared.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var services = builder.Services;
var config = builder.Configuration;

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

services.AddGraphClientService();
services.ConfigureHttpClient("WebApi", config["DataApi:BaseAddress"]);
services.AddAzureAuthentication(config);
services.AddApplicationServices();
services.RegisterClientServices(config["DataApi:Scope"], "WebApi");

await builder.Build().RunAsync();
