using Competency.Core.CompetencyAggregate.Entities.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class SurveyRequestConfiguration : IEntityTypeConfiguration<SurveyRequest>
{
  public void Configure(EntityTypeBuilder<SurveyRequest> builder)
  {
  }
}
