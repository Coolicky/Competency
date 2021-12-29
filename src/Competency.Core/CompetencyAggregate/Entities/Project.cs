using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class Project : BaseEntity, IAggregateRoot
{
  public Project()
  {
    Users = new List<Person>();
    ProjectNumber = String.Empty;
    Name = String.Empty;
  }
  public string ProjectNumber { get; set; }
  public string Name { get; set; }
  public List<Person> Users { get; set; }

  public override string ToString()
  {
    return $"{ProjectNumber} - {Name}";
  }
}
