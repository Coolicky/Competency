using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Manager : Person, IAggregateRoot
{
  public virtual List<Project> Projects { get; private set; }
  public virtual List<Employee> Employees { get; private set; }
}
