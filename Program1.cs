using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKTdiemTP
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void showinfo()
        {
            Console.Write("Name: " + Name);
            Console.Write("\nAge: " + Age);
        }
        
    }
    class Student : Person 
    { 
        public string StudentID {  get; set; }
        public override void showinfo()
        {
            base.showinfo();
            Console.WriteLine("\nStudent");
            Console.Write("Student ID: " + StudentID);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Name = "John Doe ";
            student.Age = 20;
            
            student.StudentID = "S12345\n";
            student.showinfo();
            
        }
    }
}
