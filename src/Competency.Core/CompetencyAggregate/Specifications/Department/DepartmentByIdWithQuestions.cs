using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class DepartmentByIdWithQuestions : Specification<Department>, ISingleResultSpecification
{
  public DepartmentByIdWithQuestions(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Questions);
  }
}
