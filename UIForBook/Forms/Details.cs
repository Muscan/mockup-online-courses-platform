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
using UIForBook.Forms;
//Entry program
namespace UIForBook
{
    public partial class Details : Form
    {
        private Button btnView;
        private Button btnDetails;
        private Button btnBooks;
        private Button btnBack;
        private Button btnClose;
        private Button btnEnrolments;

        private Student student;
        
        public Details()
        {
            InitializeComponent();
            ViewCourses();
            ViewBooks();
            ViewDetails();
            EnrolmentsBtn();
            Back();
            CloseBtn();
            student = new Student(10, "Jimmy", "mail@aol.hu", 85);
           
        }
        public void ViewCourses()
        {
            btnView = new Button();
            btnView.Location = new Point(30, 30);
            btnView.Text = "View Courses";
            btnView.Width = 120;
            btnView.Height = 40;
            Controls.Add(btnView);
            btnView.Click += btnView_Click;
        }
        public void ViewBooks()
        {
            btnBooks = new Button();
            btnBooks.Location = new Point(180, 30);
            btnBooks.Text = "View Books";
            btnBooks.Width = 120;
            btnBooks.Height = 40;
            btnBooks.BackColor = Color.Aquamarine;
            this.Controls.Add(btnBooks);
        }


        public void ViewDetails()
        {
            btnDetails = new Button();
            btnDetails.Location = new Point(330, 30);
            btnDetails.Text = "View Details";
            btnDetails.Width = 120;
            btnDetails.Height = 40;
            btnDetails.BackColor = Color.DeepSkyBlue;
            this.Controls.Add(btnDetails);
        }

        public void EnrolmentsBtn()
        {
            btnEnrolments = new Button();
            btnEnrolments.Location = new Point(480, 30);
            btnEnrolments.Text = "Enrolments";
            btnEnrolments.Width = 120;
            btnEnrolments.Height = 40;
            btnEnrolments.BackColor = Color.AliceBlue;
            this.Controls.Add(btnEnrolments);
            btnEnrolments.Click += btnEnrolments_Click;
        }

        public void Back()
        {
            btnBack = new Button();
            btnBack.Location = new Point(480, 330);
            btnBack.Text = "Back";
            btnBack.Width = 120;
            btnBack.Height = 40;
            btnBack.BackColor = Color.YellowGreen;
            this.Controls.Add(btnBack);
           
        }


        public void CloseBtn()
        {
            btnClose = new Button();
            btnClose.Location = new Point(610, 330);
            btnClose.Text = "Close";
            btnClose.Width = 120;
            btnClose.Height = 40;
            btnClose.BackColor = Color.PaleVioletRed;
            this.Controls.Add(btnClose);
            btnClose.Click += btnClose_Click;

        }
       

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewCourses couresForm = new ViewCourses();
            couresForm.Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Details_Load(object sender, EventArgs e)
        {
        }
        private void btnEnrolments_Click(object sender, EventArgs eventArgs)
        {
            ViewEnrolments formEnrolments = new ViewEnrolments(student);
            formEnrolments.Show();
        }
    }
}