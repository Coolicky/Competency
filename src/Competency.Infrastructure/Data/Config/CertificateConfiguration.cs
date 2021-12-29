using Competency.Core.CompetencyAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
{
  public void Configure(EntityTypeBuilder<Certificate> builder)
  {
    builder
      .Property(r => r.Name)
      .HasMaxLength(255)
      .IsRequired();

    builder
      .Property(r => r.Company)
      .HasMaxLength(255);

    builder
      .Property(r => r.Software)
      .HasMaxLength(255);
  }
}
