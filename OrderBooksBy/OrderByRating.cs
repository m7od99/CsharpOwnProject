using System;
using System.Collections.Generic;
using System.Linq;
namespace CsharpOwnProject
{
  public class OrderByRating : IOrderBy
  {
    public List<Book> Order(List<Book> books)
    {
      var booksByName = books.OrderBy(b => b.Rating).Reverse().ToList();
      return booksByName;
    }
  }
}