using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestsForOnlineLibrary
{
    public class CourseControllerTests
    {
        [Fact]
        public void CourseControllerAddAreAdded()
        {
            CourseController courses = new CourseController();

            Course course = new Course(1, "Math", "Science");
          
            courses.Add(course);
           
            Assert.Equal(0, courses.courseIndex(1));
        }
      

    }
}
