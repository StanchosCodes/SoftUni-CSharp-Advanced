using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsAndGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] student = Console.ReadLine().Split(" ");

                string name = student[0];
                decimal grade = decimal.Parse(student[1]);

                if (!studentsAndGrades.ContainsKey(name))
                {
                    studentsAndGrades.Add(name, new List<decimal>());
                }

                    studentsAndGrades[name].Add(grade);
            }

            // John -> 5.20 3.20 (avg: 4.20)
            foreach (var student in studentsAndGrades)
            {
                List<decimal> grades = student.Value;
                string gradesStr = string.Join(" ", grades.Select(g => g.ToString("f2")));

                Console.WriteLine($"{student.Key} -> {gradesStr} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
