using System.ComponentModel.DataAnnotations;
using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.Entities;

public class Competency : BaseEntity, IAggregateRoot
{
  [Required]
  [StringLength(255, ErrorMessage = "Competency Name cannot be longer than 255 characters.")]
  public string Name { get; private set; }
  // public virtual List<Question> Questions { get; private set; }
  public virtual List<Employee> Users { get; private set; }
  // public virtual List<Training> Trainings { get; private set; }
        
  public override string ToString()
  {
    return Name;
  }
}
