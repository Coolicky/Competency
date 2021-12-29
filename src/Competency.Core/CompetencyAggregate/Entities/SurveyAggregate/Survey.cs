﻿using Competency.SharedKernel;
using Competency.SharedKernel.Interfaces;

namespace Competency.Core.CompetencyAggregate.Entities.SurveyAggregate;

public class Survey : BaseEntity, IAggregateRoot
{
  // TODO: Make Admin Dashboard set these values
  private const double Need = 0.7;
  private const double CriticalNeed = 0.9;

  public Survey(Employee employee, Competency competency, List<SurveyAnswer> answers)
  {
    Employee = employee;
    Competency = competency;
    Answers = answers;
    Notes = String.Empty;
    Status = SurveyStatus.Draft;
    DateTime = DateTime.Now;
  }

  public virtual Employee Employee { get; private set; }
  public virtual Competency Competency { get; private set; }
  public virtual List<SurveyAnswer> Answers { get; private set; }
  public string Notes { get; private set; }
  public SurveyStatus Status { get; private set; }
  public DateTime DateTime { get; private set; }
  public double BeginnerResult => GetValue(SurveyQuestion.QuestionLevel.Beginner, false);
  public double IntermediateResult => GetValue(SurveyQuestion.QuestionLevel.Intermediate, false);
  public double AdvancedResult => GetValue(SurveyQuestion.QuestionLevel.Advanced, false);
  public double ExpertResult => GetValue(SurveyQuestion.QuestionLevel.Expert, false);
  public double BeginnerCriticalResult => GetValue(SurveyQuestion.QuestionLevel.Beginner, true);
  public double IntermediateCriticalResult => GetValue(SurveyQuestion.QuestionLevel.Intermediate, true);
  public double AdvancedCriticalResult => GetValue(SurveyQuestion.QuestionLevel.Advanced, true);
  public double ExpertCriticalResult => GetValue(SurveyQuestion.QuestionLevel.Expert, true);
  public double FinalResult => FinalGrade();

  private double GetValue(SurveyQuestion.QuestionLevel level, bool critical)
  {
    List<SurveyAnswer> answers;

    if (critical)
    {
      answers = Answers
        .Where(r => r.Question.Level == level && r.Question.Critical)
        .ToList();
    }
    else
    {
      answers = Answers
        .Where(r => r.Question.Level == level)
        .ToList();
    }

    if (!answers.Any()) return 1;

    var total = answers
      .Select(r => r.Question.ResponseValue)
      .Sum();
    var result = answers
      .Where(r => r.Answer)
      .Select(r => r.Question.ResponseValue)
      .Sum();

    var percentage = Convert.ToDouble(result) / Convert.ToDouble(total);

    return Math.Round(percentage, 4);
  }
  private int FinalGrade()
  {
    var beginner = BeginnerResult >= Need
                   && BeginnerCriticalResult >= CriticalNeed;
    var intermediate = IntermediateResult >= Need
                       && IntermediateCriticalResult >= CriticalNeed
                       && beginner;
    var advanced = AdvancedResult >= Need
                   && AdvancedCriticalResult >= CriticalNeed
                   && intermediate;
    var expert = ExpertResult >= Need
                 && ExpertCriticalResult >= CriticalNeed
                 && advanced;
    var list = new List<bool> { beginner, intermediate, advanced, expert };
    return list.Count(r => r);
  }

  public enum SurveyStatus
  {
    Draft,
    Finished,
    Rejected
  }
}
