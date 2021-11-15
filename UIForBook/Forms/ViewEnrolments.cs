using OnlineLibrary.Controller;
using OnlineLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIForBook.Forms
{
    public partial class ViewEnrolments : Form
    {
        private ListView list;
        private EnrolmentController enrolmentController;

        private Student student;
        public ViewEnrolments()
        {
            InitializeComponent();
        }
 
        private void ViewEnrolments_Load(object sender, EventArgs e)
        {


        }

        public ViewEnrolments(Student student)
        {
            InitializeComponent();
            enrolmentController = new EnrolmentController();
            list = new ListView();
            this.student = student;
            //createTableEnrolments();
                       
        }

        public void createTableEnrolments()
        {
            list.GridLines = true;
            list.View = View.Details;
            list.BorderStyle = BorderStyle.Fixed3D;
            list.Columns.Add("Id Stdent", 100, HorizontalAlignment.Left);
            list.Columns.Add("Id Courses", 100, HorizontalAlignment.Center);
            list.Columns.Add("Departament", 100, HorizontalAlignment.Right);

            //Lis<> l = enrolmentController.getAllEnrolments();
            //foreach (Course course in list)
            //{
            //    ListViewItem row = new ListViewItem();

            //}
        }

       

        
    }
}
