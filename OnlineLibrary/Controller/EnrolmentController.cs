using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Controller
{
    public class EnrolmentController
    {
        private List<Enrolment> enrolments;
        public EnrolmentController()
        {
            enrolments = new List<Enrolment>();
            loadEnrolment();
        }
        public List<Enrolment> getAllEnrolments()
        {
            return enrolments;
        }
        public int enrolmentIndex(int id)
        {
            for (int i = 0; i < enrolments.Count(); i++)
            {
                if (enrolments[i].StudentId == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public void saveToFileEnrolment()
        {
            StreamWriter write = new StreamWriter(@"D:\C# Basics\OnlineLibrary\OnlineLibrary\Files\Enrolments.txt");
            write.WriteLine(this.toStringObjectEnrolmentFile());
            write.Close();
        }
        public string toStringObjectEnrolmentFile()
        {
            string enrolmentData = "";
            for (int i = 0; i<enrolments.Count; i++)
            {
                enrolmentData += enrolments[i].toSaveEnrolment() + "\n";
            }
            return enrolmentData;
        }
        public void loadEnrolment()
        {
            StreamReader reader = new StreamReader(@"D:\C# Basics\OnlineLibrary\OnlineLibrary\Files\Enrolments.txt");
            String line = "";
            line = reader.ReadLine();
            while (line != "" && line != null)
            {
                String[] enrolmentForFile = line.Split(',');
                //(int studentId, int courseId, int createdAt)
                int studentId = int.Parse(enrolmentForFile[0]);
                int courseId = int.Parse(enrolmentForFile[1]);
                int createdAt = int.Parse(enrolmentForFile[2]);
                Enrolment enrolment = new Enrolment(studentId, courseId, createdAt);
                enrolments.Add(enrolment);
                line = reader.ReadLine();
            }
            reader.Close();
            
        }
        public bool Add(Enrolment enrolment)
        {
            int index = enrolmentIndex(enrolment.StudentId);
            if (index == -1)
            {
                this.enrolments.Add(enrolment);
                this.saveToFileEnrolment();
                Console.WriteLine("Enrolment addded");
                return true;
            }
            Console.WriteLine("Enrolment exists ");
            return false;
        }
        public bool updateEnrolment(Enrolment enr, int newStudentId, int newCourseId, int newCreatedAt)
        {
            int index = enrolmentIndex(enr.StudentId);
            if (index != -1)
            {
                enrolments[index].StudentId = newStudentId;
                enrolments[index].CourseId = newCourseId;
                enrolments[index].CreatedAt = newCreatedAt;
                saveToFileEnrolment();
                Console.WriteLine( "Enrolemnt updated " + enr.StudentId);
                return true;
            }
            Console.WriteLine("Enrolment not updated ");
            return false;
        }

        public void DeleteAll()
        {
            enrolments.Clear();
            saveToFileEnrolment();
        }


        public String displayAllEnrolments()
        {
            string allStudents = "";
            for (int i = 0; i < enrolments.Count; i++)

            {
                allStudents += enrolments[i].EnrolmentDesc() + "\n";
            }
            return allStudents;
        }

        public Enrolment returnEnrolment(int studentId, int courseID, int createdAt)
        {
            for (int i = 0; i < enrolments.Count; i++)

            {
                if (enrolments[i].StudentId.Equals(studentId)
                 && enrolments[i].CourseId.Equals(courseID)
                 && enrolments[i].CreatedAt.Equals(createdAt))
                { 
                    return enrolments[i];
                }
            }
            return null;
        }
        public bool deleteEnrolment(int id)
        {
            int index = enrolmentIndex(id);
            if (index != -1)
            {
                enrolments.RemoveAt(index);
                Console.WriteLine("Enrolment deleted ");
                saveToFileEnrolment();
                return true;
            }
            else
            {
                Console.WriteLine("Enrolment not deleted ");
                return false;
            }


        }



        ///functie ce returneaza toate enrolmenturile unui student 
        ///5-->functionalitati  pe care ar trbeui sa le contina aplicatia 
        /*adaugat private EnrolmentController enrolmentController;
         private CourseController courseController;
         private BookController bookController;
        - Adaugat in constructor
        */
    }
}
