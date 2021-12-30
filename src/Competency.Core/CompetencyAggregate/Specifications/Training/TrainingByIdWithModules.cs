using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class TrainingByIdWithModules : Specification<Training>, ISingleResultSpecification
{
  public TrainingByIdWithModules(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Competency)
      .Include(r => r.Modules);
  }
}
