using Ardalis.Specification;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class CompetencyByIdWithQuestions : Specification<Entities.Competency>, ISingleResultSpecification
{
  public CompetencyByIdWithQuestions(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Questions);
  }
}
