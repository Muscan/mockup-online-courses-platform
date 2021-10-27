using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace UnitTestsForOnlineLibrary
{
    public class StudentControllerTests
    {//(int id, string lastName, string email, int age)
        private readonly ITestOutputHelper output;
        //https://xunit.net/docs/capturing-output //instead of Console.WriteLine

        public StudentControllerTests(ITestOutputHelper output)
        {
            this.output = output;
        }
        public StudentController Add10Students()
        {
            StudentController controller = new StudentController();
            for (int i = 0; i < 10; i++)
            {
                Student s1 = new Student();
                s1.Id = i;
                s1.LastName = "Last name " + i;
                s1.Email = "Email " + i;
                s1.Age = i;
                controller.AddStudent(s1);
                output.WriteLine(s1.StudentDesc());
            }
            return controller;
        }
        [Fact]
        public void AddStudentIsDisplayedAndDeleted()
        {
            StudentController studentController = new StudentController();
            Student s1 = new Student(1, "Rodni", "email@email.com", 20);
            //Student s2 = new Student(1, "Rodni", "email@email.com", 20);
            studentController.AddStudent(s1);
            output.WriteLine(studentController.displayAllStudents());
            Assert.Equal(s1, studentController.returnStudent(1, "Rodni", "email@email.com", 20));
            studentController.deleteStudent(1);//it should delete student with id 1
        }

        [Fact]
        public void AddUpdateDelete10Students()
        {
            StudentController controllerStudents = Add10Students();
            List<Student> listStudents= controllerStudents.getAllStudents();
            for (int i = 0; i < 10; i++)
            {   //the updateStudent returns bool => updateStundet<list> it should be saved in a object of same type(bool in this case)
                bool isUpdated = controllerStudents.updateStudent(listStudents[i], i + 10, "NewLastName" +i, "NewEmail" + i, i + 10);
                Assert.True(isUpdated);
                output.WriteLine(listStudents[i].StudentDesc());
            }
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal(listStudents[i], controllerStudents.returnStudent(i + 10, "NewLastName" + i, "NewEmail" + i, i + 10));
            }
            controllerStudents.DeleteAll();
        }
        [Fact]
        public void DisplayIndex()
        {
            StudentController controllerStudents = Add10Students();
            List<Student> listStudents = controllerStudents.getAllStudents();
            for (int i = 0; i < 10; i++)
            {
                int indexTested = controllerStudents.studentIndex(listStudents[i].Id);
                Assert.Equal(i, indexTested);
                output.WriteLine("Actual:" + indexTested + "." + "Index Expected: " + i); //listStudents[i].StudentDesc());

            }
            controllerStudents.DeleteAll();
        }

        [Fact]
        public void DeleteStudent()
        {
            StudentController controllerStudents = Add10Students();
            for (int i = 0; i < 10; i++)
            {
                bool usersDeleted = controllerStudents.deleteStudent(i);
                Assert.True(usersDeleted);
                
            }
            output.WriteLine("Students deleted");

        }
        [Fact]
        public void DeleteASpecificStudent()
        {
            StudentController controllerStudents = Add10Students();
            int idUsed = 2;
                bool userDeleted = controllerStudents.deleteStudent(idUsed);
                Assert.True(userDeleted);
            output.WriteLine("Student \'"+ idUsed +"\' deleted");
            output.WriteLine(controllerStudents.displayAllStudents());
            controllerStudents.DeleteAll();
        }
    }
}
