using Ardalis.Specification;
using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;

namespace Competency.Core.CompetencyAggregate.Specifications;

public sealed class SurveyById : Specification<Survey>, ISingleResultSpecification
{
  public SurveyById(int id)
  {
    Query
      .Where(r => r.Id == id)
      .Include(r => r.User)
      .Include(r => r.Competency);
  }
}
