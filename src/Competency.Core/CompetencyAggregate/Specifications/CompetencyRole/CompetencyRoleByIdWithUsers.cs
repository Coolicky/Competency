using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class CompetencyRoleByIdWithUsers : Specification<CompetencyRole>, ISingleResultSpecification
{
  public CompetencyRoleByIdWithUsers(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Users);
  }
}
