using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Microsoft.Net.Http.Headers;

namespace Competency.Api.Extensions;

public static class ApplicationServices
{
  public static IServiceCollection AddAuthentication(this IServiceCollection services, IConfiguration config)
  {
    services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
      .AddMicrosoftIdentityWebApi(config.GetSection("AzureAd"));
    
    return services;
  }
  
  public static IServiceCollection ConfigureCors(this IServiceCollection services)
  {
    services.AddCors(options =>
    {
      options.AddDefaultPolicy(policyBuilder =>
      {
        policyBuilder.WithHeaders(HeaderNames.Authorization).AllowAnyMethod();
      });
    });
    
    return services;
  }
}
