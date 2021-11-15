using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Model
{
    public class Enrolment
    {
        private int id;
        private int studentId;
        private int courseId;
        private int createdAt;//timestamp?

        public Enrolment()
        {
        }

        public Enrolment(int Id,int studentId, int courseId, int createdAt)
        {
            this.id = Id;
            this.studentId = studentId;
            this.courseId = courseId;
            this.createdAt = createdAt;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }

        }
        public int StudentId
        {
            get { return studentId; }
            set { this.studentId = value; }
        }
        public int CourseId
        {
            get { return courseId; }
            set { this.courseId = value; }
        }
        
        public int CreatedAt
        {
            get { return createdAt; }
            set { this.createdAt = value; }
        }
        public String EnrolmentDesc()
        {
            string enrolmentPropDesc = "";
            enrolmentPropDesc += "Enrolment Id: " + this.Id + ", student id: " + this.studentId + ", course id: " + this.courseId + ", created at: " + this.createdAt;
            return enrolmentPropDesc;
        }

        public String toSaveEnrolment()
        {
            return Id + ", " + studentId + "," + courseId + "," + createdAt;
        }

    }
}
