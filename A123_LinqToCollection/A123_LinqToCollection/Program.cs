using System;
using System.Collections.Generic;
using System.Linq;

namespace A123_LinqToCollection
{
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Scores { get; set; }
    }

    class Program
    {
        static List<Student> students;
        static void Main(string[] args)
        {
            students = new List<Student>
            {
                new Student { Name = "James", Id = 1358193, Scores = new List<int> { 86, 90, 76 } },
                new Student { Name = "Jane", Id = 5612423, Scores = new List<int> { 51, 22, 98 } },
                new Student { Name = "Jae", Id = 6512442, Scores = new List<int> { 67, 25, 90 } },
                new Student { Name = "Young", Id = 1234567, Scores = new List<int> { 100, 100, 100 } } };
            Print(students);
            HighScore(0, 85);
            HighScore(1, 90);
        }

        private static void HighScore(int exam, int cut)
        {
            var highScores = from student in students
                             where student.Scores[exam] >= cut
                             select new { Name = student.Name, Score = student.Scores[exam] };

            Console.WriteLine($"students who get scores over {cut} in {exam + 1} test ");
            foreach (var item in highScores)
                Console.WriteLine($"\t{item.Name,-10}{item.Score}");
        }

        private static void Print(List<Student> students)
        {
            foreach(var item in students)
            {
                Console.Write($"{item.Id,-10}{item.Name,-10}");
                foreach (var score in item.Scores)
                    Console.Write($"{score,-5}");
                Console.WriteLine(item.Scores.Average().ToString("F2"));
            }
        }
    }
}