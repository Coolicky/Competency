using System.ComponentModel.DataAnnotations;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Department : BaseEntity, IAggregateRoot
{
  [Required]
  [StringLength(50, ErrorMessage = "Office Location cannot be longer than 50 characters.")]
  public string Name { get; private set; }
  
  [Required]
  [StringLength(5, ErrorMessage = "Office Location cannot be longer than 5 characters.")]
  public string Abbreviation { get; private set; }

  public override string ToString()
  {
    return Name;
  }
}
