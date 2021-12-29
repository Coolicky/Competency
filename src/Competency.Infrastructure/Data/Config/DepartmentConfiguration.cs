using Competency.Core.CompetencyAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
  public void Configure(EntityTypeBuilder<Department> builder)
  {
    builder
      .Property(r => r.Name)
      .HasMaxLength(50)
      .IsRequired();
    
    builder
      .Property(r => r.Abbreviation)
      .HasMaxLength(5)
      .IsRequired();
  }
}
