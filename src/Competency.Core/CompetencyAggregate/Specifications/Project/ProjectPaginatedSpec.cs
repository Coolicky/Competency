using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class ProjectPaginatedSpec : Specification<Project>
{
  public ProjectPaginatedSpec(CompetencyParameters parameters)
  {
    if (string.IsNullOrWhiteSpace(parameters.SearchString))
    {
      Query
        .OrderBy(r => r.Name)
        .Skip((parameters.PageNumber - 1) * parameters.PageSize)
        .Take(parameters.PageSize);
    }
    else
    {
      Query
        .Where(r => r.Name.ToLower().Contains(parameters.SearchString.ToLower())
                    || r.ProjectNumber.ToLower().Contains(parameters.SearchString.ToLower()))
        .OrderBy(r => r.Name)
        .Skip((parameters.PageNumber - 1) * parameters.PageSize)
        .Take(parameters.PageSize);
    }
  }

  public const string Route = "Projects";
}
