using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities;

public class User : BaseEntity, IAggregateRoot
{
  public User()
  {
  }

  protected User(string identityGuid)
  {
    IdentityGuid = identityGuid;
    Roles = new List<CompetencyRole>();
    Projects = new List<Project>();
    FirstName = String.Empty;
    LastName = String.Empty;
    JobRole = String.Empty;
    Certificates = new List<Certificate>();
    Competencies = new List<Competency>();
    Employees = new List<User>();
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
  
  public List<Certificate>? Certificates { get; set; }
  public List<Competency>? Competencies { get; set; }
  public List<User>? Employees { get; set; }
}
