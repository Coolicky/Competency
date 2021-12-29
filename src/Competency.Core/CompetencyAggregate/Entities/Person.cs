using Competency.SharedKernel;

namespace Competency.Core.CompetencyAggregate.Entities;

public abstract class Person : BaseEntity
{
  public Person()
  {
  }

  protected Person(string identityGuid)
  {
    IdentityGuid = identityGuid;
    Roles = new List<CompetencyRole>();
    Projects = new List<Project>();
    FirstName = String.Empty;
    LastName = String.Empty;
    JobRole = String.Empty;
  }

  public string IdentityGuid { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }

  public string JobRole { get; set; }
  public string FullName => $"{FirstName} {LastName}";
  public Department? Department { get; set; }
  public Office? Office { get; set; }
  public List<CompetencyRole>? Roles { get; set; }
  public List<Project>? Projects { get; set; }
}
