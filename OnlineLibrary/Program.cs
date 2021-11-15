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
            /*StudentController controller = new StudentController();
            Student s1 = new Student(1, "Rodni", "email@email.com", 20);
            controller.AddStudent(s1);
            Console.WriteLine(controller.displayAllStudents());*/

            EnrolmentController controller = new EnrolmentController();
            //Enrolment enr = new Enrolment();
            //controller.Add(enr);
            //enr.toSaveEnrolment();
            //enr.EnrolmentDesc();
            //controller.StudentEnrolments(10);
            List<Enrolment> listEnrolments = controller.StudentEnrolments(12);
            StudentController studentController = new StudentController();
            Student student = new Student();
            string myStudent = student.Id.ToString(myStudent);
            for (int i = 0; i < listEnrolments.Count; i++)
            {
                
                
                Console.WriteLine(listEnrolments[i].toSaveEnrolment() + myStudent);
            }

            Console.ReadLine();


        }
    }
   
}
