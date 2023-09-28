using System;
using System.Collections.Generic;
using System.Linq;



    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var allStudentsArray = classes.SelectMany(c => c.Students).ToArray();
            
            return allStudentsArray;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
