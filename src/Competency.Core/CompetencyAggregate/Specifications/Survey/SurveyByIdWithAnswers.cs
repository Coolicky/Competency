using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class SurveyByIdWithAnswers : Specification<Survey>, ISingleResultSpecification
{
  public SurveyByIdWithAnswers(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.User)
      .Include(r => r.Competency)
      .Include(r => r.Answers);
  }
}
