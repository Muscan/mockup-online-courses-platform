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

        public Student(int id, string lastName, string email, int age)
        {
            this.id = id;
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
            studentPropDesc += "Id " + this.id + "last name " + this.lastName + "email " + this.email + "age " + this.age;
            return studentPropDesc;
        }

        public String toSaveBook()
        {
            return id + "," + lastName + "," + email+ "," + age;
        }
    }

}
