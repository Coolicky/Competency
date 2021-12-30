using Competency.SharedKernel;

namespace Competency.Core.CompetencyAggregate.Entities.Requests;

public abstract class Request : BaseEntity
{
  public Request()
  {
  }
  protected Request(User recipient, string message, int daysToComplete)
  {
    Recipient = recipient;
    Message = message;
    CreatedDate = DateTime.Now;
    DueDate = CreatedDate.AddDays(daysToComplete);
  }
  
  public User? CreatedBy { get; set; }
  public User Recipient { get; set; }
  public DateTime DueDate { get; set; }
  public DateTime CreatedDate { get; set; }
  public bool Resolved { get; set; }
  public string Message { get; set; }
}
