using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class CompetencyRole : BaseEntity, IAggregateRoot
{
  public CompetencyRole()
  {
  }

  public CompetencyRole(string name)
  {
    Name = name;
    Users = new List<Person>();
  }

  public string Name { get; }
  public List<Person>? Users { get; set; }
}
