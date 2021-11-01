using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UIForBook
{
    public partial class ViewCourses : Form
    {
        private ListView list;

        private CourseController controlCourse;
        
        public ViewCourses()
        {
            InitializeComponent();
            controlCourse = new CourseController();
            list = new ListView();
            this.Controls.Add(list);
            list.Width = this.Width;
            createTable();
        }

        public void createTable()
        {    //(int id, string name, string department)

            list.GridLines = true;
            list.View = View.Details;
            list.BorderStyle = BorderStyle.Fixed3D;
            list.ForeColor = ForeColor;
           
            list.Columns.Add("ID ", 100, HorizontalAlignment.Left);
            list.Columns.Add("Name ", 100, HorizontalAlignment.Center);
            list.Columns.Add("Department ", 100, HorizontalAlignment.Right);

            List<Course> l = controlCourse.getAllCourses();
            foreach(Course course in l)
            {
                ListViewItem row = new ListViewItem();
                row.Text = course.Id.ToString();
                row.SubItems.Add(course.Name);
                row.SubItems.Add(course.Department);
                list.Items.Add(row);
            }
        }
    }
}
