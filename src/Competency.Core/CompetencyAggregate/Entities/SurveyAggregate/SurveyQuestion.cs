using Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;

public class SurveyQuestion : BaseEntity, IAggregateRoot
{
  public SurveyQuestion(Competency competency)
  {
    Competency = competency;
    Level = QuestionLevel.Beginner;
    Question = String.Empty;
    ResponseValue = 1;
    Departments = new List<Department>();
    Status = QuestionStatus.Draft;
    TrainingModules = new List<TrainingModule>();
  }
  
  public Competency Competency { get; set; }
  public QuestionLevel Level { get; set; }
  public string Question { get; set; }
  public bool Critical { get; set; }
  public int ResponseValue { get; set; }
  public List<Department> Departments { get; set; }
  public QuestionStatus Status { get; set; }
  public List<TrainingModule> TrainingModules { get; set; }

  public enum QuestionStatus
  {
    Draft = 1,
    Active = 2,
    Archived = 3,
  }

  public enum QuestionLevel
  {
    Beginner = 1,
    Intermediate = 2,
    Advanced = 3,
    Expert = 4
  }
}
