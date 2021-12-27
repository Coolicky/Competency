using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Employee : Person, IAggregateRoot
{
  public virtual List<Project> Projects { get; private set; }
  public virtual List<Certificate> Certificates { get; private set; }
  public virtual List<Competency> Competencies { get; private set; }
}
