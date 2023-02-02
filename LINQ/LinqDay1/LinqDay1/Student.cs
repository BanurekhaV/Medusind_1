using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDay1
{
    class Student
    {
        int StudentId;
        string StudentName;
        int Age;

        static void Main()
        {
            List<Student> studentlist = new List<Student>()
            {
                new Student(){StudentId=1, StudentName="Jamuna",Age=13},
                new Student(){StudentId=2, StudentName="Monisha",Age=21},
                new Student(){StudentId=3, StudentName="Brijesh",Age=18},
                new Student(){StudentId=4, StudentName="Ram",Age=20},
                new Student(){StudentId=5, StudentName="Arpita",Age=15}
            };

            //Using Method Syntax, List out all teenage students

            var teenagestudentnames = studentlist.Where(s => s.Age > 12 && s.Age < 20).Select(n=>n.StudentName).ToList();

            var teenagestudents = studentlist.Where(s => s.Age > 12 && s.Age < 20).ToList();
           
            foreach (var item in teenagestudentnames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            foreach (var item in teenagestudents)
            {
                Console.WriteLine($"ID {item.StudentId}, Name is {item.StudentName} and Age is {item.Age}");
            }

            //all numbers divisible by 3
            List<int> numbers = new List<int>() { 16, 23, 12, 19, 42, 28, 57, 7, 9, 30 };

            List<int> divby3 = numbers.FindAll(x => (x % 3) == 0);

            foreach(var n in divby3)
            {
                Console.WriteLine(n);
            }

            //find student with id 4

            Student stud = studentlist.Find(st => st.StudentId == 4);
            Console.WriteLine("ID ={0}, Name = {1}, and Age = {2}",stud.StudentId, stud.StudentName,stud.Age);

            //sort the students on student name

            var sortedstdlist = studentlist.OrderByDescending(n => n.StudentName);

            foreach(var item in sortedstdlist)
            {
                Console.WriteLine(item.StudentId + " " +item.StudentName + " "+ item.Age);
            }
            Console.Read();
        }
    }
}
