using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
{
  public void Configure(EntityTypeBuilder<Survey> builder)
  {
  }
}
