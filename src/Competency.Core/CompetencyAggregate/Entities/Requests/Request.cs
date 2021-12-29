using Competency.SharedKernel;

namespace Competency.Core.CompetencyAggregate.Entities.Requests;

public abstract class Request : BaseEntity
{
  public Request()
  {
  }
  protected Request(Person recipient, string message, int daysToComplete)
  {
    Recipient = recipient;
    Message = message;
    CreatedDate = DateTime.Now;
    DueDate = CreatedDate.AddDays(daysToComplete);
  }
  
  public Person? CreatedBy { get; set; }
  public Person Recipient { get; set; }
  public DateTime DueDate { get; set; }
  public DateTime CreatedDate { get; set; }
  public bool Resolved { get; set; }
  public string Message { get; set; }
}
