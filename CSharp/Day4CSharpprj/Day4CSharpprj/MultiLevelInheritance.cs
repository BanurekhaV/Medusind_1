using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharpprj
{
    class Student
    {
        string RollNo;
        string Name;
        string Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll No:");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class :");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Roll No of the student :" + RollNo);
            Console.WriteLine("Name of the student :" + Name);
            Console.WriteLine("Class of the student :" + Class);
        }
    }

    class Marks : Student
    {
        protected int[] a = new int[5];
        public void GetMarks()
        {
            for(int i=0; i<a.Length;i++)
            {
                Console.Write("Enter Subject {0} Marks :", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Marks in Subject {0} {1}",i+1,a[i]);
            }            
        }
    }
    class Result : Marks
    {
        int Totalmarks = 0;
        public void GetResult()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Totalmarks = Totalmarks + a[i];
            }
        }

        public void DisplayResult()
        {
            Console.WriteLine("==========Results==========");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks =" + Totalmarks);
        }
    }
    class MultiLevelInheritance
    {
        static void Main(string[] args)
        {
            Result result = new Result();
            result.GetData();  //go to line 15
            result.GetMarks(); //go to line 36
            result.GetResult();
            result.DisplayResult();
            Console.Read();
        }
    }
}
