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

        public Student()
        {
        }

        public Student(int Id, string lastName, string email, int age)
        {
            this.id = Id;
            this.lastName = lastName;
            this.email = email;
            this.age = age;
          
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

      
        public String StudentDesc()
        {
            string studentPropDesc = "";
            studentPropDesc += "Student Id: " + this.Id + ", Student last name: " + this.lastName + ", Student email: " + this.email + ", Student age: " + this.age;
            return studentPropDesc;
        }

        public String toSaveStudent()
        {
            return id + "," + lastName + "," + email+ "," + age;
        }
    }

}
