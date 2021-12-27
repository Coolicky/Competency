using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Graph;

namespace Competency.Blazor.Shared.Authorization;

public class GraphAuthenticationProvider : IAuthenticationProvider
{
  public GraphAuthenticationProvider(IAccessTokenProvider tokenProvider)
  {
    TokenProvider = tokenProvider;
  }

  public IAccessTokenProvider TokenProvider { get; }

  public async Task AuthenticateRequestAsync(HttpRequestMessage request)
  {
    var result = await TokenProvider.RequestAccessToken(
      new AccessTokenRequestOptions()
      {
        Scopes = new[] { "https://graph.microsoft.com/User.Read" }
      });

    if (result.TryGetToken(out var token))
    {
      request.Headers.Authorization ??= new AuthenticationHeaderValue(
        "Bearer", token.Value);
    }
  }
}
