using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;

namespace Competency.Core.CompetencyAggregate.Entities.Requests;

public class SurveyRequest : Request
{
  public SurveyRequest(Person recipient, string message, int daysToComplete, Survey survey, Competency competency) : base(recipient, message, daysToComplete)
  {
    Survey = survey;
    Competency = competency;
  }

  public Survey Survey { get; set; }
  public Competency Competency { get; set; }
}
