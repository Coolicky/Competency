using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Project : BaseEntity, IAggregateRoot
{
  public string ProjectNumber { get; set; }

  public string Name { get; set; }

  public override string ToString()
  {
    return $"{ProjectNumber} - {Name}";
  }
}
