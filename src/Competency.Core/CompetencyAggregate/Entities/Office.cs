using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class Office : BaseEntity, IAggregateRoot
{
  public Office()
  {
    Users = new List<User>();
    Location = String.Empty;
  }

  public string Location { get; set; }
  public List<User>? Users { get; set; }

  public override string ToString()
  {
    return Location;
  }
}
