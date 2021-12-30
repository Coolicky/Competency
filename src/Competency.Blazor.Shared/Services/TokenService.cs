using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace Competency.Blazor.Shared.Interfaces;

public static class HttpClientWithToken
{
  public static async Task<HttpClient?> GetClient(IAccessTokenProvider tokenProvider,
    IHttpClientFactory clientFactory,
    IEnumerable<string> scope,
    string apiName)
  {
    var tokenResult = await tokenProvider.RequestAccessToken(
      new AccessTokenRequestOptions { Scopes = scope });

    if (!tokenResult.TryGetToken(out var token)) return null;

    try
    {
      var client = clientFactory.CreateClient(apiName);
      client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token.Value);
      return client;
    }
    catch (AccessTokenNotAvailableException e)
    {
      e.Redirect();
    }

    return null;
  }
}
