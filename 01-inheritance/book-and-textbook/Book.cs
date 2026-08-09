using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Book
    {
        public string Title { get; set; }
        public   int NumberOfPages { get; set; }



        public Book()
        {
            Title = "Untitled";
            NumberOfPages = 0;
        }
        public Book(string title, int numberOfPages)
        {
            this.Title = title;
            this.NumberOfPages = numberOfPages;
        }

       
    }
    class TextBook : Book
    {
          public string GradeLevel { get; set; }


        public TextBook() : base()
        {

            GradeLevel = "Unkown";
        }
        public TextBook(string title, int numberOfPages, string gradeLevel) : base(title, numberOfPages)

        {
            this.GradeLevel = gradeLevel;

        }



    }
}
