using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(100);
            book.AddGrade(200);
            book.AddGrade(300); 

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(200, result.Average, 1);
            Assert.Equal(300, result.High, 1);
            Assert.Equal(100, result.Low, 1);
        }
    }
}
