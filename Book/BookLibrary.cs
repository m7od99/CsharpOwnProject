using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpOwnProject
{
  public class BookLibrary
  {
    public BookLibrary()
    {
      _books = new List<Book>();
    }
    private List<Book> _books { get; set; }

    public void AddBook(Book book)
    {
      _books.Add(book);
    }
    public void RemoveBook(Book book)
    {
      _books.Remove(book);
    }
    public void Clear()
    {
      _books.Clear();
    }
    public void SelectBook(string name)
    {
      var book = _books.Find(b => b.Name.ToLower() == name.ToLower());

      Console.WriteLine($"Book Name: {book.Name} , Your Rating: {book.Rating}");
      Console.WriteLine($"You Add this book at {book.Date}");
      Console.WriteLine($"*****************************************************");

    }

    public void ShowAllBooksWithThisRating(int rating)
    {
      var books = _books.FindAll(b => b.Rating == rating);
      Console.WriteLine($"The Books with {rating} star rating are {books.Count} :");

      foreach (var book in books)
      {
        Console.WriteLine($"Book Name: {book.Name} , Your Rating: {book.Rating}");
        Console.WriteLine($"You Add this book at {book.Date}");
        Console.WriteLine($"*****************************************************");
      }
    }

    public override string ToString()
    {
      return string.Join(Environment.NewLine, _books);
    }

    public List<Book> OrderBooksBy(Order order)
    {
      if (order == 0)
      {
        return OrderByName.Order(_books);
      }
      else
      {
        return OrderByRating.Order(_books);
      }
      
    }
  }

}