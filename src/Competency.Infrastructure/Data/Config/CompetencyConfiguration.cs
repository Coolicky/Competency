using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class CompetencyConfiguration : IEntityTypeConfiguration<Core.CompetencyAggregate.Entities.Competency>
{
  public void Configure(EntityTypeBuilder<Core.CompetencyAggregate.Entities.Competency> builder)
  {
    builder
      .Property(r => r.Name)
      .HasMaxLength(255)
      .IsRequired();
  }
}
