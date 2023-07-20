//Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
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
            return (from c in classes
                    from s in c.Students
                    select s).ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}