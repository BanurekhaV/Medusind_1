using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3CSharpPrj
{
    class Student
    {
        int stdid;
        string stdname;
        float stdmarks;
        //constructor declarations
        //1.
        public Student()
        {
            stdid = 10;
            stdname = "Neeranjan";
            stdmarks = 87;
        }
        //2.
        public Student(int id, string name)
        {
            stdid = id;
            stdname = name;
        }

        //3.
        public Student(int stdid, string stdname, float stdmarks)
        {
            this.stdid = stdid;
            this.stdname = stdname;
            this.stdmarks = stdmarks;
        }

        public void showstudent()
        {
            Console.WriteLine($"{stdid} ,{stdname}, {stdmarks}");
        }
        ~Student()
        {
            Console.WriteLine("bye from Student");
            Console.Read();
        }
    }
    class Constructors
    {
        static void Main()
        {
            Student stud = new Student();
            stud.showstudent();
            Student stud2 = new Student(11, "Manya");
            stud2.showstudent();
            Student stud3 = new Student(100, "Hasmukh", 85);
            stud3.showstudent();
            stud2 = null;
            GC.Collect();
          //  stud3.showstudent();
            Console.Read();
        }
    }
}
