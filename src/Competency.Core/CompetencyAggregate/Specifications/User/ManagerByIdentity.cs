using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class UserByIdentity : Specification<User>, ISingleResultSpecification
{
  public UserByIdentity(string identity)
  {
    Query.Where(r => r.IdentityGuid == identity)
      .Include(r => r.Department)
      .Include(r => r.Office)
      .Include(r => r.Roles)
      .Include(r => r.Projects)
      .Include(r => r.Certificates)
      .Include(r => r.Competencies)
      .Include(r => r.Employees);
  }
}
