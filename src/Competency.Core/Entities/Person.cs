using System.ComponentModel.DataAnnotations;
using Competency.SharedKernel;

namespace Competency.Core.Entities;

public class Person : BaseEntity
{
  [Required] [StringLength(36)] public string IdentityGuid { get; private set; }

  [Required]
  [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters.")]
  [Display(Name = "First Name")]
  public string FirstName { get; private set; }

  [Required]
  [Display(Name = "Last Name")]
  public string LastName { get; private set; }

  public string JobRole { get; private set; }

  [Display(Name = "Full Name")] public string FullName => $"{FirstName} {LastName}";

  public int DepartmentId { get; private set; }
  public virtual Department Department { get; private set; }
  public int OfficeId { get; private set; }
  public virtual Office Office { get; private set; }
  public virtual List<CompetencyRole> Roles { get; private set; }
}
