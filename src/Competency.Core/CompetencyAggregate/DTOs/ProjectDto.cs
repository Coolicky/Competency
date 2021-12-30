namespace Competency.Core.CompetencyAggregate.DTOs;

public class ProjectDto 
{
  public int Id { get; set; }
  public string ProjectNumber { get; set; }
  public string Name { get; set; }
  public List<UserDto>? Users { get; set; }
}

public class UserDto
{
  public int Id { get; set; }
  public string IdentityGuid { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string JobRole { get; set; }
  public string FullName => $"{FirstName} {LastName}";
}
public class OfficeDto 
{
  public int Id { get; set; }
  public string Location { get; set; }
}
