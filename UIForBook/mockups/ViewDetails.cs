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
    public partial class ViewDetails : Form
    {
        public ViewDetails()
        {
            InitializeComponent();
       
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
