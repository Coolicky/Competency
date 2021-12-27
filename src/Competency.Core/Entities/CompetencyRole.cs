using System.ComponentModel.DataAnnotations;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class CompetencyRole : BaseEntity, IAggregateRoot
{
  [Required]
  [StringLength(25, ErrorMessage = "Role Name cannot be longer than 25 characters.")]
  public string Name { get; private set; }
}
