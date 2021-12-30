using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;
using Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class Competency : BaseEntity, IAggregateRoot
{
  public Competency()
  {
    Users = new List<User>();
    Trainings = new List<Training>();
    Questions = new List<SurveyQuestion>();
    Name = String.Empty;
  }
  public string Name { get; set; }
  public List<User>? Users { get; set; }
  public List<Training>? Trainings { get; set; }
  public List<SurveyQuestion>? Questions { get; set; }
        
  public override string ToString()
  {
    return Name;
  }
}
