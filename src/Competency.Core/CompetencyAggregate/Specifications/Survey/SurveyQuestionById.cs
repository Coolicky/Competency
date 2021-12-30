using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class SurveyQuestionById : Specification<SurveyQuestion>, ISingleResultSpecification
{
  public SurveyQuestionById(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Competency)
      .Include(r => r.Departments);
  }
}
