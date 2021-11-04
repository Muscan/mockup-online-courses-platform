using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDRentACar.Forms
{
    public partial class LoginUserRole : Form
    {
        private Button btnCancel;
        public LoginUserRole()
        {
            InitializeComponent();
            CancelBtn();
        }
        public void CancelBtn()
        {//left bottom 
            btnCancel = new Button();
            btnCancel.Visible = true;
            btnCancel.Location = new Point(350, 330);
            btnCancel.Text = "Cancel";
            btnCancel.Width = 120;
            btnCancel.Height = 40;
            btnCancel.BackColor = Color.PaleVioletRed;
            this.Controls.Add(btnCancel);
            btnCancel.Click += btnCancel_Click;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
