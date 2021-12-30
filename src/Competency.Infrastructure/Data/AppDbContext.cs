using Ardalis.EFCore.Extensions;
using Competency.Core.CompetencyAggregate.Entities;
using Competency.Core.CompetencyAggregate.Entities.Requests;
using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;
using Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;
using Microsoft.EntityFrameworkCore;

namespace Competency.Infrastructure.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }

  public DbSet<SurveyRequest> SurveyRequests => Set<SurveyRequest>();
  public DbSet<Survey> Surveys => Set<Survey>();
  public DbSet<SurveyQuestion> Questions => Set<SurveyQuestion>();
  public DbSet<SurveyAnswer> Answers => Set<SurveyAnswer>();
  public DbSet<Training> Trainings => Set<Training>();
  public DbSet<TrainingModule> TrainingModules => Set<TrainingModule>();

  public DbSet<Certificate> Certificates => Set<Certificate>();

  public DbSet<Core.CompetencyAggregate.Entities.Competency> Competencies =>
    Set<Core.CompetencyAggregate.Entities.Competency>();

  public DbSet<CompetencyRole> Roles => Set<CompetencyRole>();
  public DbSet<Department> Departments => Set<Department>();
  public DbSet<User> Users => Set<User>();
  public DbSet<Office> Offices => Set<Office>();
  public DbSet<Project> Projects => Set<Project>();


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();

    //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
}
