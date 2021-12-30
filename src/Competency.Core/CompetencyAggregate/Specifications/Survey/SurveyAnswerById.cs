using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class SurveyAnswerById : Specification<SurveyAnswer>, ISingleResultSpecification
{
  public SurveyAnswerById(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Question);
  }
}
