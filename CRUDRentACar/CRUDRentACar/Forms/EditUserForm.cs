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
    public partial class EditUserForm : Form
    {
        private Button btnCancel;
        private Button btnEdit;
        private TextBox txtBoxUserName;
        private TextBox txtBoxNewUserName;
        private TextBox txtBoxPassword;
        private CheckBox checkBoxAdmin;
        private Label lblUser;
        private Label lblNewUser;
        private Label lblPassword;
        private  ControllerUser control;
        public EditUserForm()
        {
            InitializeComponent();
            CancelBtn();
            EditBtn();
            TextBoxUserName();
            TextBoxUserNewName();
            LabelNewUserName();
            TextBoxPassword();
            CheckBoxIsAdmin();
            LabelUserName();
            LabelPassword();
            control = new ControllerUser();
        }

        public EditUserForm(ControllerUser control)
        {
            InitializeComponent();
            CancelBtn();
            EditBtn();
            TextBoxUserName();
            TextBoxUserNewName();
            LabelNewUserName();
            TextBoxPassword();
            CheckBoxIsAdmin();
            LabelUserName();
            LabelPassword();
            this.control = control;
        }

        public void TextBoxUserName()
        {
            txtBoxUserName = new TextBox();
            txtBoxUserName.Location = new Point(280, 50);
            txtBoxUserName.Width = 130;
            txtBoxUserName.Height = 30;
            this.Controls.Add(txtBoxUserName);

        }

        public void TextBoxUserNewName()
        {
            txtBoxNewUserName = new TextBox();
            txtBoxNewUserName.Location = new Point(280, 150);
            txtBoxNewUserName.Width = 130;
            txtBoxNewUserName.Height = 30;
            this.Controls.Add(txtBoxNewUserName);

        }
        public void TextBoxPassword()
        {
            txtBoxPassword = new TextBox();
            txtBoxPassword.Location = new Point(280, 250);
            txtBoxPassword.Width = 130;
            txtBoxPassword.Height = 30;
            this.Controls.Add(txtBoxPassword);

        }

        public void CheckBoxIsAdmin()
        {
            checkBoxAdmin = new CheckBox();
            checkBoxAdmin.Location = new Point(280, 330);
            checkBoxAdmin.Width = 120;
            checkBoxAdmin.Height = 30;
            checkBoxAdmin.Text = "Is ADMIN?";
            this.Controls.Add(checkBoxAdmin);

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

       public void LabelNewUserName()
         {
            lblNewUser = new Label();
            lblNewUser.Location = new Point(280, 124);
            lblNewUser.Width = 120;
            lblNewUser.Height = 30;
            lblNewUser.Text = "New User Name";
            lblNewUser.Visible = true;
            this.Controls.Add(lblNewUser);

        }
        public void LabelPassword()
        {
            lblPassword = new Label();
            lblPassword.Location = new Point(280, 224);
            lblPassword.Width = 120;
            lblPassword.Height = 30;
            lblPassword.Text = "Password";
            lblPassword.Visible = true;
            this.Controls.Add(lblPassword);

        }

        public void CancelBtn()
        {//left bottom 
            btnCancel = new Button();
            btnCancel.Visible = true;
            btnCancel.Location = new Point(410, 330);
            btnCancel.Text = "Cancel";
            btnCancel.Width = 120;
            btnCancel.Height = 40;
            btnCancel.BackColor = Color.PaleVioletRed;
            this.Controls.Add(btnCancel);
            btnCancel.Click += btnCancel_Click;
        }

        public void EditBtn()
        {//right bottom
            btnEdit = new Button();
            btnEdit.Location = new Point(610, 330);
            btnEdit.Text = "Edit";
            btnEdit.Width = 120;
            btnEdit.Height = 40;
            btnEdit.BackColor = Color.DeepSkyBlue;
            this.Controls.Add(btnEdit);
            btnEdit.Click += btnEdit_Click;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
       {
           if (IsNotEmpty(txtBoxUserName) == false)
           {
               MandatoryField("User ");
           }
           else if (IsNotEmpty(txtBoxPassword) == false)
           {
               MandatoryField("Password ");
           }
           else
           {
               string oldUser = txtBoxUserName.Text;
               string newUser = txtBoxNewUserName.Text;
               string editPassword = txtBoxPassword.Text;
               bool isAdmin = checkBoxAdmin.Checked;
               User usr = new User(newUser, editPassword, isAdmin);
               control.updateUser(oldUser, usr);
               ClearLoginFields(txtBoxUserName, txtBoxPassword);
               checkBoxAdmin.Checked = false;
           }
       }
    }
}
