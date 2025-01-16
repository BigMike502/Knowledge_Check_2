using System.Runtime.InteropServices;

namespace Knowledge_Check_2
{
  internal class Program
  {
    static void Main(string[] args)
    {

      var recordlist = new List<Book>();
      Console.WriteLine("How many books do you have? ");
      int recordCount = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"{Environment.NewLine}Press Enter to continue entering book information....");
      Console.WriteLine($"{Environment.NewLine}Please only use Letters and Numbers.");
      Console.ReadLine();
      Console.Clear();

            
      for (int i = 0; i < recordCount; i++)
      {
        int h = i + 1;
        Book book = new Book();
        Console.WriteLine($"Enter in book {h}'s Title.");
        book.bookTitle = Console.ReadLine();

        Console.WriteLine($"{Environment.NewLine}Please enter in {book.bookTitle} page count.");
        book.bookPages = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{Environment.NewLine}{book.bookTitle} is in what Genre.");
        book.bookGenre = Console.ReadLine();

        Console.WriteLine($"{Environment.NewLine}Please enter in {book.bookTitle} publishing year.");
        book.bookPublish = Convert.ToInt32(Console.ReadLine());

        book.bookYearsPublished = book.currentYear - book.bookPublish;

        Console.WriteLine($"{Environment.NewLine}{book.bookTitle} is currently {book.bookYearsPublished}'s old!");
        
        if (h < recordCount)
        {
           Console.WriteLine($"{Environment.NewLine}Press Enter to tabulate book {h+1}'s data!");   
        }
        else
        {
          Console.WriteLine($"{Environment.NewLine}Press Enter to see all the information for all {h} of your books!");
        }
                
        Console.ReadLine();
        Console.Clear();

        recordlist.Add(book);

      }

      foreach (var i in recordlist)
      {
        Console.WriteLine($"{Environment.NewLine}The books name is {i.bookTitle} its genre is {i.bookGenre}, it has {i.bookPages}.");
        Console.WriteLine($"{i.bookTitle} was written in {i.bookPublish} it is {i.bookYearsPublished} years old!");
      }
    }
  }
}
