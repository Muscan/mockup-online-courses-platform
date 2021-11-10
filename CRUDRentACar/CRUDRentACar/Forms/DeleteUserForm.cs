using System;

using System.Drawing;

using System.Windows.Forms;
using CRUDRentACar.Classes;
using CRUDRentACar.Controllers;
using static CRUDRentACar.Functions.Functii;
using static CRUDRentACar.Classes.User;
using System.Collections.Generic;

namespace CRUDRentACar.Forms
{
    public partial class DeleteUserForm : Form
    {
        private Button btnDelete;
        private Button btnCancel;
        private TextBox txtBoxUserName;
        private ControllerUser control;
        private Label lblUser;
        public DeleteUserForm()
        {
            InitializeComponent();
            TextBoxUserName();
            LabelUserName();
            DeleteBtn();
            CancelBtn();
            control = new ControllerUser();
        }


        public void LabelUserName()
        {
            lblUser = new Label();
            lblUser.Location = new Point(280, 24);
            lblUser.Width = 120;
            lblUser.Height = 30;
            lblUser.Text = "User Name";
            lblUser.Visible = true;
            this.Controls.Add(lblUser);

        }
        public void TextBoxUserName()
        {
            txtBoxUserName = new TextBox();
            txtBoxUserName.Location = new Point(280, 50);
            txtBoxUserName.Width = 130;
            txtBoxUserName.Height = 30;
            this.Controls.Add(txtBoxUserName);

        }

        public void DeleteBtn()
        {//left bottom 
            btnDelete = new Button();
            btnDelete.Visible = true;
            btnDelete.Location = new Point(220, 330);
            btnDelete.Text = "Delete";
            btnDelete.Width = 120;
            btnDelete.Height = 40;
            btnDelete.BackColor = Color.Gray;
            this.Controls.Add(btnDelete);
            btnDelete.Click += btnDeleteUser_Click;
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxUserName) == false)
            {
                MandatoryField("User to delete.");
            }
            else
            {
                control.DeleteUser(txtBoxUserName.Text);
                txtBoxUserName.Clear();
                

            }
        }
    }
}
