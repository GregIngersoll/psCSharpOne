using System;
using System.Collections.Generic;

namespace Gradebook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Greg's Grade Book");

            while (true)
            {
               Console.WriteLine("Enter double or Q to quit");
               string input = Console.ReadLine();

               if (input.ToUpper() == "Q")
               {
                  break;
               }

               double grade = double.Parse (input);
               book.AddGrade(grade);
            }

            var stats = book.GetStatistics();

            var average = stats.Average;
            var highest = stats.High;
            var lowest = stats.Low;

            Console.WriteLine ($"The lowest grade is {lowest:N1}");
            Console.WriteLine ($"The highest grade is {highest:N1}");
            Console.WriteLine ($"The average grade is {average:N1}");
        }
    }
}
