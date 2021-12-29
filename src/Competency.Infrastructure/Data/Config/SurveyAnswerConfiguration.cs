using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class SurveyAnswerConfiguration : IEntityTypeConfiguration<SurveyAnswer>
{
  public void Configure(EntityTypeBuilder<SurveyAnswer> builder)
  {
  }
}
