namespace Competency.Core.Entities;

public class Certificate
{
  
  public int Id { get; set; }
  public string Name { get; set; }
  public string Company { get; set; }
  public string Software { get; set; }
        
  public override string ToString()
  {
    return Name;
  }
}
