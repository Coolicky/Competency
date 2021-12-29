using Competency.Core.CompetencyAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
{
  public void Configure(EntityTypeBuilder<Manager> builder)
  {
    builder
      .Property(r => r.IdentityGuid)
      .HasMaxLength(36)
      .IsRequired();
    
    builder
      .Property(r => r.FirstName)
      .IsRequired();
    
    builder
      .Property(r => r.LastName)
      .IsRequired();

    builder
      .Property(r => r.JobRole)
      .HasMaxLength(50);
  }
}
