using Competency.SharedKernel;

namespace Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;

public class SurveyAnswer : BaseEntity
{
  public SurveyAnswer()
  {
  }

  public SurveyAnswer(SurveyQuestion question)
  {
    Question = question;
    Notes = String.Empty;
  }

  public SurveyQuestion Question { get; set; }
  public bool Answer { get; set; }
  public string Notes { get; set; }
}
