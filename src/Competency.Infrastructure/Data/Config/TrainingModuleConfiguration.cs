using Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class TrainingModuleConfiguration : IEntityTypeConfiguration<TrainingModule>
{
  public void Configure(EntityTypeBuilder<TrainingModule> builder)
  {
    builder
      .Property(r => r.Code)
      .IsRequired();
    
    builder
      .Property(r => r.Name)
      .IsRequired();
  }
}
