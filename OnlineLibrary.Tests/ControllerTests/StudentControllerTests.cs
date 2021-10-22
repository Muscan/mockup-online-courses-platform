using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestsForOnlineLibrary
{
    public class StudentControllerTests
    {//(int id, string lastName, string email, int age)
        [Fact]
        public void AddStudent()
        {
            StudentController studentController = new StudentController();
            Student s1 = new Student(1, "Rodni", "email@email.com", 20);
            studentController.AddStudent(s1);
            
        }

        [Fact]
        public void StudentControllerAddStudentsAreAdded()
        {
            StudentController controllerStudents = new StudentController();
            for (int i = 0; i < 10; i++)
            {
                Student s1 = new Student();
                s1.Id = i;
                s1.LastName = "Last name " + i;
                s1.Email = "Email " + i;
                controllerStudents.AddStudent(s1);
                Console.WriteLine(controllerStudents.toStringStudentFile());
                
            }
            
        }
      

    }
}
