using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class Department : BaseEntity, IAggregateRoot
{
  public Department()
  {
    Questions = new List<SurveyQuestion>();
    Name = String.Empty;
    Abbreviation = String.Empty;
  }

  public string Name { get; set; }
  public string Abbreviation { get; set; }
  public List<SurveyQuestion> Questions { get; set; }

  public override string ToString()
  {
    return Name;
  }
}
