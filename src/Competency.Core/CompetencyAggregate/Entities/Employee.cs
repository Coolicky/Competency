using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class Employee : Person, IAggregateRoot
{
  public Employee()
  {
  }

  public List<Certificate>? Certificates { get; set; }
  public List<Competency>? Competencies { get; set; }

  public Employee(string identityGuid) : base(identityGuid)
  {
    Certificates = new List<Certificate>();
    Competencies = new List<Competency>();
  }
}
