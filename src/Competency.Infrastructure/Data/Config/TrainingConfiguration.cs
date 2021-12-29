using Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class TrainingConfiguration : IEntityTypeConfiguration<Training>
{
  public void Configure(EntityTypeBuilder<Training> builder)
  {
    builder
      .Property(r => r.Code)
      .IsRequired();
    
    builder
      .Property(r => r.Name)
      .IsRequired();
  }
}
