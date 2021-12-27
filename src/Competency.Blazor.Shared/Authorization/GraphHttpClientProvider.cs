using Microsoft.Graph;

namespace Competency.Blazor.Shared.Authorization;

public class GraphHttpClientProvider : IHttpProvider
{
  private readonly HttpClient http;

  public GraphHttpClientProvider(HttpClient http)
  {
    this.http = http;
  }

  public ISerializer Serializer { get; } = new Serializer();

  public TimeSpan OverallTimeout { get; set; } = TimeSpan.FromSeconds(300);

  public void Dispose()
  {
    http.Dispose();
  }

  public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
  {
    return http.SendAsync(request);
  }

  public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, 
    HttpCompletionOption completionOption, 
    CancellationToken cancellationToken)
  {
    return http.SendAsync(request, completionOption, cancellationToken);
  }
}
