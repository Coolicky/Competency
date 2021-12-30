using System.Net.Http.Json;
using System.Text;
using Ardalis.Specification;
using Competency.Blazor.Shared.Interfaces;
using Competency.Blazor.Shared.Interfaces.Competency;
using Competency.Core.CompetencyAggregate;
using Competency.Core.CompetencyAggregate.Entities;
using Competency.Core.CompetencyAggregate.Specifications;
using Competency.SharedKernel;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace Competency.Blazor.Shared.Services;

public class ProjectsService : IProjectsService
{
  private readonly IAccessTokenProvider _tokenProvider;
  private readonly IHttpClientFactory _clientFactory;
  private readonly string[] _scope;
  private readonly string _apiName;
  public ProjectsService(IAccessTokenProvider tokenProvider, IHttpClientFactory clientFactory, string[] scope,
    string apiName)
  {
    _tokenProvider = tokenProvider;
    _clientFactory = clientFactory;
    _scope = scope;
    _apiName = apiName;
  }
  
  public async Task<PagedList<Project>> GetList()
  {
    try
    {
      var client = await HttpClientWithToken.GetClient(_tokenProvider, _clientFactory, _scope, _apiName);
      if (client == null) return PagedList<Project>.Empty(1, int.MaxValue);
      
      var result = await client.GetFromJsonAsync<PagedList<Project>>(ProjectPaginatedSpec.Route);
      if (result == null) return PagedList<Project>.Empty(1, int.MaxValue);
      return result;
    }
    catch (Exception exception)
    {
      return PagedList<Project>.Empty(1, int.MaxValue);
    }
  }

  public async Task<PagedList<Project>> GetList(CompetencyParameters parameters)
  {
    try
    {
      var client = await HttpClientWithToken.GetClient(_tokenProvider, _clientFactory, _scope, _apiName);
      if (client == null) return PagedList<Project>.Empty(1, int.MaxValue);

      var builder = new StringBuilder(ProjectPaginatedSpec.Route);
      builder.Append(parameters.ToQueryParameters());
      
      var result = await client.GetFromJsonAsync<PagedList<Project>>(builder.ToString());
      if (result == null) return PagedList<Project>.Empty(1, int.MaxValue);
      return result;
    }
    catch (Exception exception)
    {
      return PagedList<Project>.Empty(1, int.MaxValue);
    }
  }

  public async Task<Project> Get(int id)
  {
    throw new NotImplementedException();
  }

  public async Task<Project> Get(Specification<Project> spec)
  {
    throw new NotImplementedException();
  }

  public async Task<Project> Add(Project entity)
  {
    throw new NotImplementedException();
  }

  public async Task<Project> Update(Project entity)
  {
    throw new NotImplementedException();
  }

  public async Task DeleteEmployee(int id)
  {
    throw new NotImplementedException();
  }
}
