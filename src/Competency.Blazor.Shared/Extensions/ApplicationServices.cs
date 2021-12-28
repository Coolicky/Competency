using Blazored.LocalStorage;
using Competency.Blazor.Shared.Profiles;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace Competency.Blazor.Shared.Extensions;

public static class ApplicationServices
{
  public static IServiceCollection AddApplicationServices(this IServiceCollection services)
  {
    services.AddMudServices();
    services.AddBlazoredLocalStorage();
    services.AddScoped<ProfileService>();
    return services;
  } 
}
