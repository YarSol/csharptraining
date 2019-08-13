using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scot's grade book");
            book.AddGrade(12);
            book.AddGrade(7);
            book.AddGrade(78);

            book.ShowStatistics(book.GetStatistics());

            
        }
    }
}
