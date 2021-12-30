using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class UserByIdWithEmployees : Specification<User>, ISingleResultSpecification
{
  public UserByIdWithEmployees(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Department)
      .Include(r => r.Office)
      .Include(r => r.Roles)
      .Include(r => r.Projects)
      .Include(r => r.Employees);
  }
}
