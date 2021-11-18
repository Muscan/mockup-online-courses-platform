using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentController sc = new StudentController();
            Student student = new Student(1,"Test","mail",100);
            sc.AddStudent(student);
            sc.returnStudent(1, "Test", "mail", 100);
            Console.WriteLine(sc.ReturnStudentUsingId(1).Id);
            Console.ReadLine();
            
        }
    }
   
}
