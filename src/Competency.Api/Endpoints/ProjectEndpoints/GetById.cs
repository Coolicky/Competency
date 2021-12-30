using Ardalis.ApiEndpoints;
using Competency.Core.CompetencyAggregate.Entities;
using Competency.Core.CompetencyAggregate.Specifications;
using Competency.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Competency.Api.Endpoints.ProjectEndpoints;

public class GetById : BaseAsyncEndpoint
  .WithRequest<int>
  .WithResponse<Project>
{
  private readonly IRepository<Project> _repository;

  public GetById(IRepository<Project> repository)
  {
    _repository = repository;
  }
  
  [HttpGet(ProjectByIdSpecWithUsers.Route)]
  [SwaggerOperation(
    Summary = "Gets a single Project",
    Description = "Gets a single Project by Id",
    OperationId = "Projects.GetById",
    Tags = new[] { "ProjectEndpoints" })
  ]
  public override async Task<ActionResult<Project>> HandleAsync(int id, CancellationToken cancellationToken = new CancellationToken())
  {
    var project = await _repository.GetByIdAsync(id, cancellationToken);
    if (project == null) return NotFound();

    return project;
  }
}
