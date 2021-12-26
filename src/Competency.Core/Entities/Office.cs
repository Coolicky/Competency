namespace Competency.Core.Entities;

public class Office
{
  public string Location { get; set; }

  public override string ToString()
  {
    return Location;
  }
}
