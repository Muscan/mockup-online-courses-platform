using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Controller
{
    public class CourseController
    {
        private List<Course> courses;
        public CourseController()
        {
            courses = new List<Course>();
            readCourseTxt();
        }
        public List<Course> getAllCourses()
        {
            return courses;
        }
        public int courseIndex(int id)
        {
            for (int i = 0; i < courses.Count(); i++)
            {
                if (courses[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public void CourseSaveToFile()
        {
            StreamWriter write = new StreamWriter(@"D:\C# Basics\OnlineLibrary\OnlineLibrary\Files\Courses.txt");
            write.WriteLine(this.toStringObjectCourseFile());
            write.Close();
        }

        public void readCourseTxt()
        {
            StreamReader reader = new StreamReader(@"D:\C# Basics\OnlineLibrary\OnlineLibrary\Files\Courses.txt");
            String line = "";
            line = reader.ReadLine();
            while (line != "" && line != null)
            {
                String[] courseForFile = line.Split(',');
                int id = int.Parse(courseForFile[0]);
                string name = courseForFile[1];
                string department = courseForFile[2];
                Course course = new Course(id, name, department);
                courses.Add(course);
                line = reader.ReadLine();
            }
            reader.Close();
        }
        public bool Add(Course course)
        {
            int index = courseIndex(course.Id);
            if (index == -1)
            {
                this.courses.Add(course);
                this.CourseSaveToFile();
                Console.WriteLine("Course added :" + course.Id + "," + course.Name + "," + course.Department);
                return true;
            }
            Console.WriteLine("Course exists");
            return false;
        }

        public bool updateCourse(Course course, int newId, string newName, string newDepartment)
        {
            int index = courseIndex(course.Id);
            if (index != -1)
            {
                courses[index].Id = newId;
                courses[index].Name = newName;
                courses[index].Department = newDepartment;
                CourseSaveToFile();
                Console.WriteLine("Course updated:" + course.Id);
                return true;
            }
            Console.WriteLine("Course not found");
            return false;
        }
        public bool deleteCourse(int id)
        {
            int index = courseIndex(id);
            if (index != -1)
            {
                courses.RemoveAt(index);
                Console.WriteLine("Course deleted ");
                CourseSaveToFile();
                return true;
            }
            else
            {
                Console.WriteLine("course not deleted ");
                return false;
            }
      
        }
        public void DeleteAll()
        {
            courses.Clear();
            CourseSaveToFile();
        }

        public string toStringObjectCourseFile()
        {
            string courseData = "";
            for (int i = 0; i < courses.Count; i++)
            {
                courseData += courses[i].toSaveCourse() + "\n";
            }
            return courseData;

        }

        public String displayAllCourses()
        {
            string allCourses = "";
            for (int i = 0; i < courses.Count; i++)

            {
                allCourses += courses[i].CourseDesc() + "\n";
            }
            return allCourses;
        }

        public Course returnCourses(int id, string name, string department)
        {
            for (int i = 0; i < courses.Count; i++)

            {
                if (courses[i].Id.Equals(id)
                 && courses[i].Name.Equals(name)
                 && courses[i].Department.Equals(department))
                 
                {
                    return courses[i];
                }
            }
            return null;
        }
        public Course ReturnCoursesUsingId(int id)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Id.Equals(id))
                {
                    return courses[i];
                }
            }
            return null;
        }
    }
}
