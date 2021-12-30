using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class Project : BaseEntity, IAggregateRoot
{
  public Project()
  {
    Users = new List<User>();
    ProjectNumber = String.Empty;
    Name = String.Empty;
  }
  public string ProjectNumber { get; set; }
  public string Name { get; set; }
  public List<User>? Users { get; set; }

  public override string ToString()
  {
    return $"{ProjectNumber} - {Name}";
  }
}
