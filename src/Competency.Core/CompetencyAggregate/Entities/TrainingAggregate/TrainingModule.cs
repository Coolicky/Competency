using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;

public class TrainingModule : BaseEntity, IAggregateRoot
{
  public TrainingModule()
  {
  }

  public TrainingModule(Training training)
  {
    Code = String.Empty;
    Name = String.Empty;
    Training = training;
  }

  public string Code { get; set; }
  public string Name { get; set; }
  public virtual List<SurveyQuestion>? Questions { get; set; }
  public Training Training { get; set; }

  public override string ToString()
  {
    return $"{Code}-{Name}";
  }
}
