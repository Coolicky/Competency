using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities.Requests;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class SurveyRequestByIdWithModules : Specification<SurveyRequest>, ISingleResultSpecification
{
  public SurveyRequestByIdWithModules(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.Survey)
      .Include(r => r.Competency);
  }
}
