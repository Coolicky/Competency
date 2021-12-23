using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace Competency.Blazor.Extensions;

public static class ApplicationServices
{
  public static IServiceCollection AddAuthentication(this IServiceCollection services, IConfiguration config)
  {
    services.AddMsalAuthentication(options =>
    {
      var scopesBaseUrl = config["AzureAd:ScopesBaseUrl"];
      var scopes = config["AzureAd:Scopes"]?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
      config.Bind("AzureAd", options.ProviderOptions.Authentication);
      options.ProviderOptions.LoginMode = "redirect";
    
      if (scopes == null) return;
      foreach (var scope in scopes)
      {
        options.ProviderOptions.DefaultAccessTokenScopes
          .Add($"{scopesBaseUrl}{scope}");
      }
    });
    
    return services;
  }
  
  public static IServiceCollection ConfigureApiHttpClient(this IServiceCollection services, IConfiguration config)
  {
    services.AddHttpClient("WebApi",
        client => client.BaseAddress = new Uri(config["ApiServerAddress"] ?? string.Empty))
      .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
    services.AddScoped(sp => 
      new HttpClient { BaseAddress = new Uri(config["ApiServerAddress"] ?? string.Empty) });
    services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
      .CreateClient("WebApi"));
    
    return services;
  }
}
