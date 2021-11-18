using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace UnitTestsForOnlineLibrary
{
    public class CourseControllerTests
    {
        
        private readonly ITestOutputHelper output;
        //https://xunit.net/docs/capturing-output //instead of Console.WriteLine

        public CourseControllerTests(ITestOutputHelper output)
        {
            this.output = output;
        }
        public CourseController Add10Courses()
        {//(int id, string name, string department)
            CourseController controller = new CourseController();
            for (int i = 0; i < 10; i++)
            {
                Course s1 = new Course();
                s1.Id = i;
                s1.Name = "Name "+ i;
                s1.Department = "Department " + i;
                controller.Add(s1);
                output.WriteLine(s1.CourseDesc());
            }
            return controller;
        }

       /* [Fact]
        public void AddCourseIsDisplayedAndDeleted()
        {
            CourseController controller = new CourseController();
            Course s1 = new Course(1, "Course ","Spanish");
            controller.Add(s1);
            output.WriteLine(controller.displayAllCourses());
            Assert.Equal(s1, controller.returnCourses(1, "Course ", "Spanish"));
            controller.deleteCourse(1);//it should delete enrolment with id 1
        }*/

        [Fact]
        public void AddUpdateDelete10Enrolments()
        //(int id, string name, string department)
        {
            CourseController controller = Add10Courses();
            List<Course> lstCourse = controller.getAllCourses();
            for (int i = 0; i < 10; i++)
            {
                bool isUpdated = controller.updateCourse(lstCourse[i], i + 10, "NewCourse "+ i, "NewDepartment "+ i);
                Assert.True(isUpdated);
                output.WriteLine(lstCourse[i].CourseDesc());
            }
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal(lstCourse[i], controller.returnCourses(i + 10, "NewCourse " + i, "NewDepartment " + i));
            }
            //controller.DeleteAll();
        }
        [Fact]
        public void DisplayIndex()
        {
            CourseController controller = Add10Courses();
            List<Course> lstCourse = controller.getAllCourses();
            for (int i = 0; i < 10; i++)
            {
                int indexTested = controller.courseIndex(lstCourse[i].Id);
                Assert.Equal(i, indexTested);
                output.WriteLine("Actual:" + indexTested + "." + "Index Expected: " + i);

            }
            //controller.DeleteAll();
        }

        [Fact]
        public void DeleteCourse()
        {
            CourseController controller = Add10Courses();
            for (int i = 0; i < 10; i++)
            {
                bool courseDeleted = controller.deleteCourse(i);
                Assert.True(courseDeleted);

            }

            output.WriteLine("Courses deleted ");
        }

        [Fact]
        public void DisplayCourseUsingId()
        {
            CourseController cc = Add10Courses();
            List<Course> lc = cc.getAllCourses();
            for (int i = 0; i < lc.Count; i++)
            {
                output.WriteLine(lc[i].CourseDesc());

            }

            output.WriteLine("Course using ID is displayed");
        }

    }

}

