using Competency.Core.CompetencyAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class CompetencyRoleConfiguration : IEntityTypeConfiguration<CompetencyRole>
{
  public void Configure(EntityTypeBuilder<CompetencyRole> builder)
  {
    builder
      .Property(r => r.Name)
      .HasMaxLength(50)
      .IsRequired();
  }
}
