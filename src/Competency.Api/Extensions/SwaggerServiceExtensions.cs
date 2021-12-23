using Microsoft.OpenApi.Models;

namespace Competency.Api.Extensions;

public static class SwaggerServiceExtensions
{
  public static IServiceCollection AddSwaggerServices(this IServiceCollection services, IConfiguration config)
  {
    services.AddEndpointsApiExplorer();
    var scopesBaseUrl = config["AzureAd:ScopesBaseUrl"];
    var scopes = config["AzureAd:Scopes"]?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    services.AddSwaggerGen(c =>
    {
      c.AddSecurityDefinition("oauth2",
        new OpenApiSecurityScheme
        {
          Type = SecuritySchemeType.OAuth2,
          Flows = new OpenApiOAuthFlows()
          {
            Implicit = new OpenApiOAuthFlow()
            {
              AuthorizationUrl =
                new Uri(
                  $"https://login.microsoftonline.com/{config["AzureAd:TenantId"]}/oauth2/v2.0/authorize"),
              TokenUrl =
                new Uri(
                  $"https://login.microsoftonline.com/{config["AzureAd:TenantId"]}/oauth2/v2.0/token"),
              Scopes = (scopes ?? Array.Empty<string>()).Distinct().ToDictionary(r => $"{scopesBaseUrl}{r}", r => r)
            }
          }
        });
      c.AddSecurityRequirement(new OpenApiSecurityRequirement()
      {
        {
          new OpenApiSecurityScheme
          {
            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "oauth2" },
            Scheme = "oauth2",
            Name = "oauth2",
            In = ParameterLocation.Header
          },
          new List<string>()
        }
      });
    });

    return services;
  }
}
