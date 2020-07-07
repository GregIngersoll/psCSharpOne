using System;
using System.Collections.Generic;
using Xunit;


namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
           // Arrange
           var book = new Book ("");
           book.AddGrade (89.1);
           book.AddGrade (90.5);
           book.AddGrade (77.5);

           // Act
           var result = book.GetStatistics();

           // Assert
           Assert.Equal (85.7, result.Average);
           Assert.Equal (result.Letter, 'B');
        }

        [Fact]
        public void AddGradeToBookPositive ()
        {
           // Arrange
           var book = new Book("");

           // Act
           book.AddGrade (89.1);

           // Assert
           List<double> grades = book.GetGrades();
           Assert.Contains (89.1, grades);
        }

        [Fact]
        public void AddGradeToBookNegative ()
        {
           // Arrange
           var book = new Book("");

           // Act
           book.AddGrade (105.0);
           book.AddGrade (-4.0);

           // Assert
           List<double> grades = book.GetGrades();
           Assert.DoesNotContain (105.0, grades);
           Assert.DoesNotContain (-4.0, grades);
        }
    }
}
