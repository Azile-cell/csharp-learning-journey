using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Book book = new Book("Shaka", 34);
            Console.WriteLine("----Book Details-----");
            Console.WriteLine("Title name: "+ book.Title+"\nNumber of pages: "+ book.NumberOfPages);

          TextBook textBook = new TextBook("Shaka", 34, "Grade 11");
            Console.WriteLine("\n----TextBook Details-----");
            Console.WriteLine("Title name: " + textBook.Title + "\nNumber of pages: " + textBook.NumberOfPages+"\nGrade Level: "+ textBook.GradeLevel);
            Console.ReadKey();
             

        }
    }
}
