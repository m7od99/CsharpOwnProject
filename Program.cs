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
      lab.ShowBooks();
      lab.SortedByRating();
      lab.SortedByName();
      lab.SelectBook("Magic Emperor");
      lab.ShowAllBooksWithThisRating(5);
    }
  }
}
