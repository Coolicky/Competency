using System.ComponentModel.DataAnnotations;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Certificate : BaseEntity, IAggregateRoot
{
  
  [Required]
  [StringLength(255, ErrorMessage = "Certificate Name cannot be longer than 255 characters.")]
  public string Name { get; private set; }
  
  [StringLength(255, ErrorMessage = "Company Name cannot be longer than 255 characters.")]
  public string Company { get; private set; }
  
  [StringLength(255, ErrorMessage = "Software Name cannot be longer than 255 characters.")]
  public string Software { get; private set; }
        
  public override string ToString()
  {
    return Name;
  }
}
