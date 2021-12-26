namespace Competency.Core.Entities;

public class Competency
{
  
  public int Id { get; set; }
  public string Name { get; set; }
  // public virtual List<Question> Questions { get; set; }
  public virtual List<Employee> Users { get; set; }
  // public virtual List<Training> Trainings { get; set; }
        
  public override string ToString()
  {
    return Name;
  }
}
