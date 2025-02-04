﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinqDemo_Enumerable_ExtensionMethod_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){ StudentID = 1, StudentName = "John",Age =18},
                new Student(){ StudentID = 2, StudentName = "Steve",Age =21},
                new Student(){ StudentID = 3, StudentName = "Bill",Age =18},
                new Student(){ StudentID = 4, StudentName = "Ram",Age =20},
                new Student(){ StudentID = 5, StudentName = "Ron",Age =21},
            };
            var teenAgerStudents = from s in studentList.GetTeenAgerStudents() select s;
            foreach (var student in teenAgerStudents)
                Console.WriteLine("Student Name: " + student.StudentName);
            Console.Read();
        }
        
    }
    public static class EnumerableExtensionMethods
    {
        public static IEnumerable<Student> GetTeenAgerStudents(this IEnumerable<Student> source)
        {
            foreach (Student student in source)
            {
                Console.WriteLine("Accessing Student: " + student.StudentName);
                if (student.Age > 12 && student.Age < 20)
                    yield return student;

            }

        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    
}
