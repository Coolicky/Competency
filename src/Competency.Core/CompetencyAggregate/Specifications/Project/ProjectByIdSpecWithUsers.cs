using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class ProjectByIdSpecWithUsers : Specification<Project>, ISingleResultSpecification
{
  public ProjectByIdSpecWithUsers(int id)
  {
    Query
      .Where(project => project.Id == id)
      .Include(r => r.Users);
  }
}
