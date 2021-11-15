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
            EnrolmentController controller = new EnrolmentController();
            CourseController courseController = new CourseController();
            StudentController studentController = new StudentController();
            controller.DeleteAll();
            //courseController.DeleteAll();
            //studentController.DeleteAll();
            Student std = new Student(50, "Opa", "mail@aol.com", 49);
            studentController.AddStudent(std);
            Console.WriteLine(studentController.ReturnStudentUsingId(std.Id));

            Enrolment enr1 = new Enrolment(10,10,77,2001);
            controller.Add(enr1);
            Console.WriteLine(controller.ReturnEnrolmentUsingId(enr1.Id).EnrolmentDesc());

            Enrolment enr2 = new Enrolment(11, 10, 33, 2022);
            controller.Add(enr2);
            Console.WriteLine(controller.ReturnEnrolmentUsingId(enr2.Id).EnrolmentDesc());

            Enrolment enr = new Enrolment(23, 33, 43, 2003);
            controller.Add(enr);
            Console.WriteLine(controller.ReturnEnrolmentUsingId(enr.Id).EnrolmentDesc());
            //List<Enrolment> le = new List<Enrolment>(); //it is already initialized in EnrolmentController
            //calling the method StudentEnrolments I need to call the object which contains that method
            
            Student student = studentController.ReturnStudentUsingId(10);
            List<Enrolment> le = controller.StudentEnrolments(student.Id);

            
            Console.WriteLine("Student with id " + student.Id + " with name " + student.LastName + " is enrolled at " );
            for (int i = 0; i < le.Count; i++)
            {//for each enrollment there is a new course
                Course course = courseController.ReturnCoursesUsingId(le[i].CourseId);
                //Console.WriteLine("Course ID: " + course.Id + " department name: " + course.Name + " Faculty: " + course.Department );
                Console.WriteLine(course.CourseDesc());
            }
            Console.ReadLine();
        }
    }
   
}
