using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class UserByIdentityWithEmployees : Specification<User>, ISingleResultSpecification
{
  public UserByIdentityWithEmployees(string identity)
  {
    Query
      .Where(r => r.IdentityGuid == identity)
      .Include(r => r.Department)
      .Include(r => r.Office)
      .Include(r => r.Roles)
      .Include(r => r.Projects)
      .Include(r => r.Employees);
  }
}
