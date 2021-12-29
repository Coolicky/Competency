using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;

public class Training : BaseEntity, IAggregateRoot
{
  public Training(Competency competency)
  {
    Code = String.Empty;
    Name = String.Empty;
    Competency = competency;
    Modules = new List<TrainingModule>();
  }
  
  public string Code { get; set; }
  public string Name { get; set; }
  public List<TrainingModule> Modules { get; set; }
  public Competency Competency { get; set; }

  public override string ToString()
  {
    return $"{Code}-{Name}";
  }
}
