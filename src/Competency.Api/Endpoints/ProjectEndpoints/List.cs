using Ardalis.ApiEndpoints;
using Competency.Core.CompetencyAggregate;
using Competency.Core.CompetencyAggregate.Entities;
using Competency.Core.CompetencyAggregate.Specifications;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Competency.Api.Endpoints.ProjectEndpoints;

public class List : BaseAsyncEndpoint.WithRequest<CompetencyParameters>.WithResponse<PagedList<Project>>
{
  private readonly IRepository<Project> _repository;

  public List(IRepository<Project> repository)
  {
    _repository = repository;
  }

  [Authorize]
  [HttpGet( $"/{ProjectPaginatedSpec.Route}")]
  [SwaggerOperation(
    Summary = "List of Projects",
    Description = "Gets a paginated list of all Projects",
    OperationId = "Projects.GetAll",
    Tags = new[] { "ProjectEndpoints" })
  ]
  public override async Task<ActionResult<PagedList<Project>>> HandleAsync([FromQuery] CompetencyParameters parameters, CancellationToken cancellationToken = new CancellationToken())
  {
      var projectSpec = new ProjectPaginatedSpec(parameters);
      var result = await _repository.ListAsync(projectSpec, cancellationToken);
      var total = await _repository.CountAsync(cancellationToken);
      return PagedList<Project>.ToPagedList(result, total, parameters.PageNumber, parameters.PageSize);
  }
}
