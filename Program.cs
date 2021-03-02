using System;

namespace CsharpOwnProject
{
  class Program
  {
    static void Main(string[] args)
    {
      var lab = new BookLibrary();
      lab.AddBook(new Book("Trash of Family Count", 2));
      lab.AddBook(new Book("The Bigging After the End", 4));
      lab.AddBook(new Book("Against The Gods", 5));
      lab.AddBook(new Book("Magic Emperor", 1));
      lab.AddBook(new Book("Emperor's Domination", 5));

      lab.SelectBook("Magic Emperor");
      lab.ShowAllBooksWithThisRating(5);
      Console.WriteLine(lab.ToString());

      Console.WriteLine("**********************************************************");

      var orders = lab.OrderBooksBy(Order.Name);
      foreach (var book in orders)
      {
        Console.WriteLine(book);
      }

      Console.WriteLine("**********************************************************");

      Console.WriteLine(lab.ToString());

      Console.WriteLine("**********************************************************");

      var orderBy = lab.OrderBooksBy(Order.Rating);
      foreach (var book in orderBy)
      {
        Console.WriteLine(book);
      }
    }
  }
}
