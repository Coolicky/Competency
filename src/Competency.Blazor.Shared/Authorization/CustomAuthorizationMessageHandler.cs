using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace Competency.Blazor.Shared.Authorization;

public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
{
  public CustomAuthorizationMessageHandler(IAccessTokenProvider provider, 
    NavigationManager navigation, string? baseAddress) 
    : base(provider, navigation)
  {
    ConfigureHandler(
      authorizedUrls: new[] { baseAddress });
  }
}
