using System.Collections.Generic;
using System.Linq;
namespace CsharpOwnProject
{
  public class OrderByName : IOrderBy
  {
    public List<Book> Order(List<Book> books)
    {
      var booksByName = books.OrderBy(b => b.Name).ToList();
      return booksByName;
    }
  }
}