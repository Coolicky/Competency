using Ardalis.EFCore.Extensions;
using Competency.Core.Entities;
using Competency.SharedKernel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Competency.Infrastructure.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }

  public DbSet<Certificate> Certificates => Set<Certificate>();
  public DbSet<Core.Entities.Competency> Competencies => Set<Core.Entities.Competency>();
  public DbSet<CompetencyRole> Roles => Set<CompetencyRole>();
  public DbSet<Department> Departments => Set<Department>();
  public DbSet<Employee> Employees => Set<Employee>();
  public DbSet<Manager> Managers => Set<Manager>();
  public DbSet<Office> Offices => Set<Office>();
  public DbSet<Project> Projects => Set<Project>();


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.ApplyAllConfigurationsFromCurrentAssembly();

    //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
}
