using System;
using System.Collections.Generic;
namespace CsharpOwnProject
{
  public interface IOrderBy
  {
    List<Book> Order(List<Book> books);
  }
}