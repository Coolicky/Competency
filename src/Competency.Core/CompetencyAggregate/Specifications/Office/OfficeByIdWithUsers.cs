using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class OfficeByIdWithUsers : Specification<Office>, ISingleResultSpecification
{
  public OfficeByIdWithUsers(int id)
  {
    Query.Where(office => office.Id == id)
      .Include(office => office.Users);
  }
}
