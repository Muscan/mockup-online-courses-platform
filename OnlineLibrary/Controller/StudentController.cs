using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Controller
{
    
    public class StudentController
    {

        private List<Student> students;
        public StudentController()
        {
            students = new List<Student>();
            readStudent();
        }
        public List<Student> getAllStudents()
        {
            return students;
        }
        public int studentIndex(int id)
        {
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].Id == id)
                {
                    return i;
                }

            }
            return -1;
        }

        public string toStringStudentFile()
        {
            string studentData = "";
            for (int i = 0; i < students.Count; i++)
            {
                studentData += students[i].toSaveStudent() + "\n";
            }
            return studentData;
        }
        public void saveStudent()
        {
            StreamWriter write = new StreamWriter(@"D:\C# Basics\OnlineLibrary\OnlineLibrary\Files\Students.txt");
            write.WriteLine(this.toStringStudentFile());
            write.Close();
        }
        public void readStudent()
        {
            StreamReader  reader = new StreamReader(@"D:\C# Basics\OnlineLibrary\OnlineLibrary\Files\Students.txt");
            String line = "";
            line = reader.ReadLine();
            while (line != "" && line != null)
            {
                String[] studentFile = line.Split(',');
                int id = int.Parse(studentFile[0]);
                string lastName = studentFile[1];
                string email = studentFile[2];
                int age = int.Parse(studentFile[3]);
                Student student = new Student(id, lastName, email, age);
                students.Add(student);
                line = reader.ReadLine();
            }
        }
        public bool AddStudent(Student student)
        {
            int index = studentIndex(student.Id);
            if (index == 1)
            {
                this.students.Add(student);
                this.saveStudent();
                Console.WriteLine("Student added " + student.Id);
                return true;
            }
            Console.WriteLine("Student exists");
            return false;
        }
        // public Student(int id, string lastName, string email, int age)
        public bool updateStudent(Student student, int newId, string newLastName, string newEmail, int newAge)
        {
            int index = studentIndex(student.Id);
            if (index != -1)
            {
                students[index].Id = newId;
                students[index].LastName = newLastName;
                students[index].Email = newEmail;
                students[index].Age = newAge;
                saveStudent();
                Console.WriteLine("Student updated: " +student.Id);
                return true;
            }
            Console.WriteLine("Student not found!");
            return false;
        }

        public void deleteStudent(int id)
        {
            int index = studentIndex(id);
            if (index != -1)
            {
                students.RemoveAt(index);
                Console.WriteLine("Student deleted ");
            }
            else
            {
                Console.WriteLine("Student not deleted ");
            }
            saveStudent();

        }
        public void DeleteAll()
        {
            students.Clear();
            saveStudent();
        }

    }
}
