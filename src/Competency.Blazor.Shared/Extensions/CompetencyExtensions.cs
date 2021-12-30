using Ardalis.GuardClauses;
using Competency.Blazor.Shared.Interfaces.Competency;
using Competency.Blazor.Shared.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Competency.Blazor.Shared.Extensions;

public static class CompetencyExtensions
{
  public static IServiceCollection RegisterClientServices(this IServiceCollection services, string? scopes, string apiName)
  {
    Guard.Against.NullOrEmpty(scopes, "Http Scopes", "Scopes have not been provided.");
    Guard.Against.NullOrEmpty(apiName, "Http API Name", "API Name has not been provided.");

    var splitScopes = scopes.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    
    services.AddScoped<IProjectsService>(provider =>
    {
      var accessTokenProvider = provider.GetRequiredService<IAccessTokenProvider>();
      var clientFactory = provider.GetRequiredService<IHttpClientFactory>();
      return new ProjectsService(accessTokenProvider, clientFactory, splitScopes, apiName);
    });
    
    return services;
  }
}
