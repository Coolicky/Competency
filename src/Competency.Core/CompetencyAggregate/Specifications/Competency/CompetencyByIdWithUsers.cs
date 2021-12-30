using Ardalis.Specification;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class CompetencyByIdWithUsers : Specification<Entities.Competency>, ISingleResultSpecification
{
  public CompetencyByIdWithUsers(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Users);
  }
}
