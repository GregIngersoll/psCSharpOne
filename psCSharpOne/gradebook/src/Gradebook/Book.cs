using System;
using System.Collections.Generic;

namespace Gradebook
{

   public class Book 
   {
      private List<double> grades;
      public string Name;

      private Statistics statistics;

      public void AddLetterGrade (char ch)
      {
         switch (ch)
         {
            case 'A' :
               AddGrade (90.0);
               break;

            case 'B':
               AddGrade (80.0);
               break;

            case 'C':
               AddGrade (70.0);
               break;

            default:
               AddGrade (60.0);
               break;

         }
      }
      public List<double> GetGrades()
      {
         return grades;
      }

      public Book(string name)
      {
         statistics = new Statistics();
         grades = new List<double>();
         Name = name;
      }

      public void AddGrade(double grade)
      {
         if ((grade <= 100) && (grade >= 0))
         {
            grades.Add(grade);
            statistics.AddGrade(grade);
         }
         else
         {
            Console.WriteLine("Invalid grade");
         }
      }

      public Statistics GetStats()
      {
         return statistics;
      }

      public Statistics GetStatistics()
      {
         var result = new Statistics();
         result.Average = 0.0;
         result.High = double.MinValue;
         result.Low = double.MaxValue;

         for (int index =0; index < grades.Count; index++)
         {
            if (grades[index] == 42.1)
            {
               continue;
            }

            result.Low = Math.Min (grades[index], result.Low);
            result.High = Math.Max (grades[index], result.High);
            result.Average += grades[index];
         }
         result.Average /= grades.Count;

         switch (result.Average)
         {
            case var d when d >= 90.0:
               result.Letter = 'A';
               break;

            case var d when d >= 80.0:
               result.Letter = 'B';
               break;

            case var d when d >= 70.0:
               result.Letter = 'C';
               break;

            case var d when d >= 60.0:
               result.Letter = 'D';
               break;

            default:
               result.Letter = 'D';
               break;
         }
         return result;
      }

   }
}