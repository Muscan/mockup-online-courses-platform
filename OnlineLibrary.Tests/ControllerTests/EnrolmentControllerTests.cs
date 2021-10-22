using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestsForOnlineLibrary
{
    public class EnrolmentControllerTests
    {
        [Fact]
        public void EnrolmentControllerAddAreAdded()
        {
            EnrolmentController econtrol = new EnrolmentController();

            Enrolment enr = new Enrolment(1, 2, 2021);
          
            econtrol.Add(enr);

            
        }
      

    }
}
