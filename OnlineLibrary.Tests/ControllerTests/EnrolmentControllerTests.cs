using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace UnitTestsForOnlineLibrary
{
    public class EnrolmentControllerTests
    {
        private readonly ITestOutputHelper output;
        //https://xunit.net/docs/capturing-output //instead of Console.WriteLine

        public EnrolmentControllerTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public EnrolmentController Add10Enrs()
        {
            EnrolmentController controller = new EnrolmentController();
            for (int i = 0; i < 10; i++)
            {
                Enrolment s1 = new Enrolment();
                s1.Id = i;
                s1.StudentId = i;
                s1.CourseId = i;
                s1.CreatedAt = i;
                controller.Add(s1);
                output.WriteLine(s1.EnrolmentDesc());
            }
            return controller;
        }
        [Fact]
        public void AddEnrolmentIsDisplayedAndDeleted()
        {
            EnrolmentController controller = new EnrolmentController();
            Enrolment s1 = new Enrolment(1, 10, 12, 20);
            controller.Add(s1);
            output.WriteLine(controller.displayAllEnrolments());
            Assert.Equal(s1, controller.returnEnrolment(1, 10, 12, 20));
            controller.DeleteAll();//it should delete enrolment with id 1
        }

        [Fact]
        public void AddUpdateDelete10Enrolments()
        //(int id, int studentId, int courseId, int createdAt)
        {
            EnrolmentController controller = Add10Enrs();
            List<Enrolment> listEnrolments = controller.getAllEnrolments();
            for (int i = 0; i < 10; i++)
            {   //the updateStudent returns bool => updateEnrolment<list> it should be saved in a object of same type(bool in this case)
                bool isUpdated = controller.updateEnrolment(listEnrolments[i], i + 10, i + 10, i + 10, i + 10);
                Assert.True(isUpdated);
                output.WriteLine(listEnrolments[i].EnrolmentDesc());
            }
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal(listEnrolments[i], controller.returnEnrolment(i + 10, i + 10, i + 10, i + 10));
            }
            controller.DeleteAll();
        }
        [Fact]
        public void DisplayIndex()
        {
            EnrolmentController controller = Add10Enrs();
            List<Enrolment> listEnrolments = controller.getAllEnrolments();
            for (int i = 0; i < 10; i++)
            {
                int indexTested = controller.enrolmentIndex(listEnrolments[i].StudentId);
                Assert.Equal(i, indexTested);
                output.WriteLine("Actual:" + indexTested + "." + "Index Expected: " + i);

            }
            controller.DeleteAll();
        }

        [Fact]
        public void DeleteEnrolment()
        {
            EnrolmentController controller = Add10Enrs();
            for (int i = 0; i < 10; i++)
            {
                bool enrDeleted = controller.deleteEnrolment(i);
                Assert.True(enrDeleted);

            }
            output.WriteLine("Enrolments deleted");

        }


        [Fact]
        public void DeleteASpecificEnrolment()
        {
            EnrolmentController controller = Add10Enrs();
            int idUsed = 2;
            bool enrDeleted = controller.deleteEnrolment(idUsed);
            Assert.True(enrDeleted);
            output.WriteLine("Enrolment \'" + idUsed + "\' deleted");
            output.WriteLine(controller.displayAllEnrolments());
            controller.DeleteAll();
        }

        [Fact]
        public void StudentIsEnrolled()
        {
            EnrolmentController controller = new EnrolmentController();
            List<Enrolment> listaEnrolment = controller.StudentEnrolments(10);

            for (int i = 0; i < listaEnrolment.Count; i++)
            {

                output.WriteLine(listaEnrolment[i].toSaveEnrolment());

            }



        }
    }
}