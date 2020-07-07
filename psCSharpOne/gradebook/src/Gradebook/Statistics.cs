using System;

namespace Gradebook
{
   public class Statistics
   {
      private double high;
      private double low;
      private double total;
      private double numGrades;

      public char Letter;

      public double Average;
      public double High;
      public double Low;

      public Statistics ()
      {
         low = double.MaxValue;
         high = double.MinValue;
         total = 0.0;
         numGrades = 0;
      }

      public double GetTotal ()
      {
         return total;
      }
      public double GetHigh ()
      {
         return high;
      }

      public double GetLow ()
      {
         return low;
      }

      public double GetAverage ()
      {
         return total / numGrades;
      }

      public void AddGrade(double grade)
      {
         low = Math.Min (low, grade);
         high = Math.Max (high, grade);
         total += grade;
         numGrades++;
      }
   }
}