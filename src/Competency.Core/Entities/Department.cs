using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Department : BaseEntity, IAggregateRoot
{
  public string Name { get; set; }
  public string Abbreviation { get; set; }

  public override string ToString()
  {
    return Name;
  }
}
