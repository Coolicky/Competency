namespace Competency.SharedKernel;

public abstract class QueryStringParameters
{
  const int MaxPageSize = 100;
  public int PageNumber { get; set; } = 1;
  
  private int _pageSize = 25;
  public int PageSize
  {
    get
    {
      return _pageSize;
    }
    set
    {
      _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
    }
  }
}
