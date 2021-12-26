using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Person : BaseEntity
{
  public string IdentityGuid { get; set; }
  public string Name { get; set; }
  public string Surname { get; set; }

  public string JobRole { get; set; }
  public override string ToString()
  {
    return $"{Name} {Surname}";
  }
  
  public Department Department { get; set; }
  public Office Office { get; set; }
  public virtual List<CompetencyRole> Roles { get; set; }
}

public class Employee : Person, IAggregateRoot
{
  public List<Project> Projects { get; set; }
  public List<Certificate> Certificates { get; set; }
  public List<Competency> Competencies { get; set; }
}

public class Manager : Person, IAggregateRoot
{
  public List<Project> Projects { get; set; }
  public List<Employee> Employees { get; set; }
}
