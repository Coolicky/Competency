using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities.Requests;

public class SurveyRequest : Request, IAggregateRoot
{
  public SurveyRequest()
  {
    
  }
  public SurveyRequest(User recipient, string message, int daysToComplete, Survey survey, Competency competency) : base(recipient, message, daysToComplete)
  {
    Survey = survey;
    Competency = competency;
  }

  public int? SurveyId { get; set; }
  public Survey Survey { get; set; }
  public Competency Competency { get; set; }
}
