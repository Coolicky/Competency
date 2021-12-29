using Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;
using Competency.Core.CompetencyAggregate.Entities.TrainingAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Competency.Infrastructure.Data.Config;

public class SurveyQuestionConfiguration : IEntityTypeConfiguration<SurveyQuestion>
{
  public void Configure(EntityTypeBuilder<SurveyQuestion> builder)
  {
    builder
      .HasMany(r => r.TrainingModules)
      .WithMany(r => r.Questions)
      .UsingEntity<Dictionary<string, object>>("SurveyQuestionTrainingModule",
        j => j.HasOne<TrainingModule>().WithMany().OnDelete(DeleteBehavior.Restrict),
        j => j.HasOne<SurveyQuestion>().WithMany().OnDelete(DeleteBehavior.Restrict));
  }
}
