using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Check_2
{
  internal class Book : Library
  {
    public string bookTitle { get; set; }
    public int bookPages { get; set; }
    public int bookPublish { get; set; }
    public int currentYear = Convert.ToInt32(DateTime.Now.Year.ToString());
    public int bookYearsPublished { get; set; }

  }
}
