using System.Text;
using Competency.SharedKernel;

namespace Competency.Core.CompetencyAggregate;

public class CompetencyParameters : QueryStringParameters
{
  public string SearchString { get; set; } = "";
  public CompetencyParameters(int pageSize = 25, int pageNumber = 1, string searchString = "")
  {
    PageNumber = pageNumber > 1 ? pageNumber : 1;
    PageSize = pageSize;
    SearchString = searchString;
  }

  public string ToQueryParameters()
  {
    var builder = new StringBuilder();
    builder.Append('?');
    builder.Append($"PageNumber={PageNumber}");
    builder.Append($"&PageSize={PageSize}");
    if (!string.IsNullOrWhiteSpace(SearchString))
      builder.Append($"&SearchString={SearchString}");
    return builder.ToString();
  }
  public CompetencyParameters()
  {
  }
}
