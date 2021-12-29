using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class Manager : Person, IAggregateRoot
{
  public Manager()
  {
  }
  public List<Employee>? Employees { get; set; }
  
  public Manager(string identityGuid) : base(identityGuid)
  {
    Employees = new List<Employee>();
  }
}
