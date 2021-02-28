using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpOwnProject
{
  public class BookLibrary
  {
    public BookLibrary()
    {
      _book = new List<Book>();
    }
    private List<Book> _book { get; set; }
    private int Index { get; set; } = 0;

    public void AddBook(Book book)
    {
      _book.Add(book);
      Index++;
    }
    public void RemoveBook(Book book)
    {
      _book.Remove(book);
    }
    public void Clear()
    {
      _book.Clear();
    }
    public void SortedByRating()
    {
      _book.Sort(delegate (Book a, Book b) { return a.Rating.CompareTo(b.Rating); });
      _book.Reverse();

      ShowBooks();
    }
    public void SortedByName()
    {
      _book.Sort(delegate (Book a, Book b) { return a.Name.CompareTo(b.Name); });

      ShowBooks();
    }
    public void SortedByDate()
    {
      _book.Sort(delegate (Book a, Book b) { return a.Date.CompareTo(b.Date); });

      ShowBooks();
    }
    public void ShowBooks()
    {
      foreach (Book book in _book)
      {
        Console.WriteLine($"Book Name: {book.Name} , Your Rating: {book.Rating}");
        Console.WriteLine($"You Add this book at {book.Date}");
        Console.WriteLine($"*****************************************************");
      }
    }

    public void SelectBook(string name)
    {
      var book = _book.Find(b => b.Name.ToLower() == name.ToLower());

      Console.WriteLine($"Book Name: {book.Name} , Your Rating: {book.Rating}");
      Console.WriteLine($"You Add this book at {book.Date}");
      Console.WriteLine($"*****************************************************");

    }

    public void ShowAllBooksWithThisRating(int rating)
    {
      var books = _book.FindAll(b => b.Rating == rating);
      Console.WriteLine($"The Books with {rating} star rating are {books.Count} :");

      foreach (var book in books)
      {
        Console.WriteLine($"Book Name: {book.Name} , Your Rating: {book.Rating}");
        Console.WriteLine($"You Add this book at {book.Date}");
        Console.WriteLine($"*****************************************************");
      }
    }
  }

}