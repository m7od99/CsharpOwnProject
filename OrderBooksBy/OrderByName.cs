using System.Collections.Generic;
using System.Linq;
namespace CsharpOwnProject
{
  public static class OrderByName 
  {
    public static List<Book> Order(List<Book> books)
    {
      var booksByName = books.OrderBy(b => b.Name).ToList();
      return booksByName;
    }
  }
}