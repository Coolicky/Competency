using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class Certificate : BaseEntity, IAggregateRoot
{
  public Certificate()
  {
    Employees = new List<User>();
    Name = String.Empty;
    Company = String.Empty;
    Software = String.Empty;
  }
  public string Name { get; set; }
  
  public string Company { get; set; }
  
  public string Software { get; set; }
  public List<User>? Employees { get; set; }
        
  public override string ToString()
  {
    return Name;
  }
}
