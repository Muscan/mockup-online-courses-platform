using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Model
{
    public class Course
    {
        private int id;
        private string name;
        private string department;

        public Course()
        {
        }
        public Course(int id, string name, string department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public String Name
        {
            get { return name; }
            set { this.name = value; }
        }
        
        public String Department
        {
            get { return department; }
            set { this.department = value; }
        }

        public String CourseDesc()
        {
            string coursePropDesc = "";
            coursePropDesc += "Course ID " + this.id + " department name: " + this.name + " Faculty: " + this.department;
            return coursePropDesc;
        }

        public String toSaveCourse()
        {
            return id + "," + name + "," + department;
        }

    }    
}
