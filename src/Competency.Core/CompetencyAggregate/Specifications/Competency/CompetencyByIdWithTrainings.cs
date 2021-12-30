using Ardalis.Specification;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class CompetencyByIdWithTrainings : Specification<Entities.Competency>, ISingleResultSpecification
{
  public CompetencyByIdWithTrainings(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Trainings);
  }
}
