using System;
using System.Collections.Generic;
using Xunit;

namespace AllenS_CSharpFundamentals.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //Arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //Act
            var result = book.GetStatistics();

            //Assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void BookAddsGradesFromRange()
        {
            var book = new Book("");

            var gradesNotInRange = new List<double> { -1.1, -1, 101, 105};
            var gradesInRange = new List<double> { 0, 1, 99, 100};
            var result = true;

            foreach(var grade in gradesNotInRange)
            {
                result = book.AddGrade(grade);
                Assert.False(result);
            }
            foreach(var grade in gradesInRange)
            {
                result = book.AddGrade(grade);
                Assert.True(result);
            }
        }
    }
}
