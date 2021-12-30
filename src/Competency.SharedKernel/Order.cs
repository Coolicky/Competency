namespace Competency.SharedKernel;

public static class EnumerableExtensions
{
  public static IEnumerable<T> Order<T, TKey>(this IEnumerable<T> source, Func<T, TKey> selector, bool ascending)
  {
    return @ascending ? source.OrderBy(selector) : source.OrderByDescending(selector);
  }

}
