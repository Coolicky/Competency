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
    Users = new List<User>();
  }

  public string Name { get; }
  public List<User>? Users { get; set; }
}
