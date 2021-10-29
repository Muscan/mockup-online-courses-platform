using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIForBook
{
    public partial class MockupDetails : Form
    {

        private Button btnView;
        private Button btnDetails;
        private Button btnBooks;
        private Button btnBack;
        private Button btnClose;
        public MockupDetails()
        {
            InitializeComponent();

            btnView = new Button();
            btnView.Location = new Point(30, 30);
            btnView.Text = "View Courses";
            btnView.Width = 120;
            btnView.Height = 40;

            btnView.Click += exemplu_Click;

            this.Controls.Add(btnView);

            btnBooks = new Button();
            btnBooks.Location = new Point(180, 30);
            btnBooks.Text = "View Books";
            btnBooks.Width = 120;
            btnBooks.Height = 40;
            btnBooks.BackColor = Color.Aquamarine;
            this.Controls.Add(btnBooks);

            btnDetails = new Button();
            btnDetails.Location = new Point(330, 30);
            btnDetails.Text = "View Details";
            btnDetails.Width = 120;
            btnDetails.Height = 40;
            btnDetails.BackColor = Color.DeepSkyBlue;
            this.Controls.Add(btnDetails);

            btnBack = new Button();
            btnBack.Location = new Point(480, 330);
            btnBack.Text = "Back";
            btnBack.Width = 120;
            btnBack.Height = 40;
            btnBack.BackColor = Color.YellowGreen;
            this.Controls.Add(btnBack);


            btnClose = new Button();
            btnClose.Location = new Point(610, 330);
            btnClose.Text = "Close";
            btnClose.Width = 120;
            btnClose.Height = 40;
            btnClose.BackColor = Color.PaleVioletRed;
            this.Controls.Add(btnClose);

        }
        

        private void Student2_Load(object sender, EventArgs e)
        {
        }

        public void exemplu_Click(object sender ,EventArgs e)
        {


            MessageBox.Show("Eu sunt Mihai ");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
