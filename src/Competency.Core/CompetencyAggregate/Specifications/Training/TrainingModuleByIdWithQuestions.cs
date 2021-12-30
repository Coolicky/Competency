using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class TrainingModuleByIdWithQuestions : Specification<TrainingModule>, ISingleResultSpecification
{
  public TrainingModuleByIdWithQuestions(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Training)
      .Include(r => r.Questions);
  }
}
