using System;
using System.Collections.Generic;
using System.Text;

namespace AllenS_CSharpFundamentals
{
    public class Book
    {
        //Constructor
        public Book(string name)
        {
            grades = new List<double>();
            //this.name = name - changing "name" to "Name", "this" is not needed
            Name = name;
        }

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var sumGrade = 0.0;
            //var highestGrade = double.MinValue;
            //var lowestGrade = double.MaxValue;
            /*Alternative Loops
            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            var index = 0;
            //if - needed in case grades = 0
            if(grades.Count > 0)
            {
                do
                {
                    result.High = Math.Max(grades[index], result.High);
                    result.Low = Math.Min(grades[index], result.Low);
                    result.Average += grades[index];
                    index++;
                }
                while (index < grades.Count);
            }
            var index = 0;
            while(index < grades.Count)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
                index++;
            }
            */

            for(var index = 0; index<grades.Count; index++)
            {
                if (grades[index] == 666)
                {
                    break;
                }

                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            }

            Console.WriteLine($"Grade Sum: {sumGrade}");

            result.Average /= grades.Count;

            switch(result.Average)
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
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
        //Private - access only inside Book.cs
        private List<double> grades;
        public string Name;
    }
}
