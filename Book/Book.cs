using System;
namespace CsharpOwnProject
{
  public class Book
  {
    public Book(string name, string writer, string genera, int rating)
    {
      this.Name = name;
      this.Writer = writer;
      this.Genera = genera;
      this.Rating = rating;
      Date = DateTime.Now;

    }
    
    public string Name { get; private set; }
    public string Writer { get; private set; }
    public DateTime Date { get; private set; }
    public string Genera { get; private set; }
    public int Rating { get; private set; }

    public Book(string name, int rating)
    {
      if (name is null)
      {
        throw new InvalidOperationException("You need write a name of book");
      }
      if (rating < 0 || rating > 5)
      {
        throw new InvalidOperationException("The Rating should be batween 0 and 5");
      }
      this.Name = name;
      this.Rating = rating;
      Date = DateTime.Now;
    }


  }
}