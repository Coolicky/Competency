using System.Text.Json.Serialization;

namespace Competency.SharedKernel;

public class PagedList<T>
{
  public int CurrentPage { get; private set; }
  public int TotalPages { get; private set; }
  public int PageSize { get; private set; }
  public int TotalCount { get; private set; }

  public IEnumerable<T>? Items { get; set; }

  public bool HasPrevious => CurrentPage > 1;
  public bool HasNext => CurrentPage < TotalPages;

  public PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
  {
    TotalCount = count;
    PageSize = pageSize;
    CurrentPage = pageNumber;
    TotalPages = (int)Math.Ceiling(count / (double)pageSize);

    Items = new List<T>(items);
  }
  
  [JsonConstructor]
  public PagedList(){}
  
  public static PagedList<T> ToPagedList(IEnumerable<T> source, int total, int pageNumber, int pageSize)
  {
    var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
    
    return new PagedList<T>(items, total, pageNumber, pageSize);
  }
  
  public static PagedList<T> Empty(int pageNumber, int pageSize)
  {
    return new PagedList<T>(Array.Empty<T>(), 0, pageNumber, pageSize);
  }
}
