using System.ComponentModel.DataAnnotations;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Office : BaseEntity, IAggregateRoot
{
  [Required]
  [StringLength(50, ErrorMessage = "Office Location cannot be longer than 50 characters.")]
  public string Location { get; private set; }

  public override string ToString()
  {
    return Location;
  }
}
