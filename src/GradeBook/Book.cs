using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        List<double> grades;
        string name;

        public Book()
        {
            grades = new List<double>();
        }

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Low = double.MaxValue;
            result.High = double.MinValue;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

        public void ShowStatistics(Statistics statistic)
        {
            Console.WriteLine($"The lowest grade is {statistic.Low}");
            Console.WriteLine($"The highest grade is {statistic.High}");
            Console.WriteLine($"The average grade is {statistic.Average:N1}");
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}