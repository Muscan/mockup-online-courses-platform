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
    public partial class StudentDetails2 : Form
    {
        private ListView listView;
        
        public StudentDetails2()
        {
            InitializeComponent();
            listView = new ListView();
            listView.BackColor = Color.Gray;
            listView.GridLines = true;
            listView.Size = new Size(820,500);
            listView.Name = "StudentDetails2";
            listView.Columns = new ListView(ColumnHeader);
            listView.FullRowSelect = true;
            this.Controls.Add(listView);

            
            
        }

        
        private void StudentDetails2_Load(object sender, EventArgs e)
        {

        }
    }
}
