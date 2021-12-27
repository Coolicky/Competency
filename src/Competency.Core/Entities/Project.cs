using System.ComponentModel.DataAnnotations;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Project : BaseEntity, IAggregateRoot
{
  
  [Required]
  [StringLength(50, ErrorMessage = "Project Number cannot be longer than 50 characters.")]
  public string ProjectNumber { get; private set; }

  [StringLength(255, ErrorMessage = "Project Name cannot be longer than 255 characters.")]
  public string Name { get; private set; }

  public override string ToString()
  {
    return $"{ProjectNumber} - {Name}";
  }
}
