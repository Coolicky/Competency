using Competency.Core.CompetencyAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
  public void Configure(EntityTypeBuilder<Office> builder)
  {
    builder
      .Property(r => r.Location)
      .HasMaxLength(50)
      .IsRequired();
  }
}
