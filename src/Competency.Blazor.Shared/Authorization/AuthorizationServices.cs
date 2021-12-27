using Ardalis.GuardClauses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Authentication.WebAssembly.Msal.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;

namespace Competency.Blazor.Shared.Authorization;

public static class AuthorizationServices
{
  public static IServiceCollection AddGraphClientService(
    this IServiceCollection services, params string[] scopes)
  {
    services.Configure<RemoteAuthenticationOptions<MsalProviderOptions>>(
      options =>
      {
        foreach (var scope in scopes)
        {
          options.ProviderOptions.AdditionalScopesToConsent.Add(scope);
        }
      });

    services.AddScoped<IAuthenticationProvider, 
      GraphAuthenticationProvider>();
    services.AddScoped<IHttpProvider, GraphHttpClientProvider>(sp => 
      new GraphHttpClientProvider(new HttpClient()));
    services.AddScoped(sp =>
    {
      return new GraphServiceClient(
        sp.GetRequiredService<IAuthenticationProvider>(),
        sp.GetRequiredService<IHttpProvider>());
    });

    return services;
  }
  
  public static IServiceCollection AddAzureAuthentication(this IServiceCollection services, IConfiguration config)
  {
    services.AddMsalAuthentication(options =>
    {
      var scopesBaseUrl = config["AzureAd:ScopesBaseUrl"];
      var scopes = config["AzureAd:Scopes"]?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
      config.Bind("AzureAd", options.ProviderOptions.Authentication);
      options.ProviderOptions.LoginMode = "redirect";
    });
    
    return services;
  }
  
  public static IServiceCollection ConfigureHttpClient(this IServiceCollection services, string? name, string? baseAddress)
  {
    Guard.Against.NullOrEmpty(name, "Http Client Name", "Http Client Name has not been provided.");
    Guard.Against.NullOrEmpty(baseAddress, "Http Request Base Address", "Http Base Address has not been provided.");
    
    services.AddScoped<CustomAuthorizationMessageHandler>(provider =>
    {
      var accessTokenProvider = provider.GetRequiredService<IAccessTokenProvider>();
      var navigationManager = provider.GetRequiredService<NavigationManager>();
      return new CustomAuthorizationMessageHandler(accessTokenProvider, navigationManager, baseAddress);
    });
    services.AddHttpClient(name, cl =>
    {
      cl.BaseAddress = new Uri(baseAddress);
    }).AddHttpMessageHandler<CustomAuthorizationMessageHandler>();
    
    return services;
  }
}
