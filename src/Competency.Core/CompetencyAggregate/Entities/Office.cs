using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class Office : BaseEntity, IAggregateRoot
{
  public Office()
  {
    Users = new List<Person>();
    Location = String.Empty;
  }

  public string Location { get; set; }
  public List<Person>? Users { get; set; }

  public override string ToString()
  {
    return Location;
  }
}
