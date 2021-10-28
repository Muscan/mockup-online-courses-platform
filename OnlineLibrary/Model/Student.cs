using OnlineLibrary.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Model
{
    public class Student
    {
        private int id;
        private string lastName;
        private string email;
        private int age;
        private EnrolmentController enrolmentController;
        private CourseController courseController;
        private BookController bookController;

        public Student()
        {
        }

        public Student(int id, string lastName, string email, int age)
        {
            this.id = id;
            this.lastName = lastName;
            this.email = email;
            this.age = age;
            enrolmentController = new EnrolmentController();
            courseController = new CourseController();
            bookController = new BookController();
        }

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public String LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }
        public String Email
        {
            get { return email; }
            set { this.email = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public EnrolmentController EnrolmentController
        {
            get { return enrolmentController; }
            set { this.enrolmentController = value; }
        }
        public CourseController CourseController
        {
            get { return courseController; }
            set { this.courseController = value; }
        }

        public BookController BookController
        {
            get { return bookController; }
            set { this.bookController = value; }
        }
        public String StudentDesc()
        {
            string studentPropDesc = "";
            studentPropDesc += "Id: " + this.id + ", last name: " + this.lastName + ", email: " + this.email + ", age: " + this.age;
            return studentPropDesc;
        }

        public String toSaveStudent()
        {
            return id + "," + lastName + "," + email+ "," + age;
        }
    }

}
