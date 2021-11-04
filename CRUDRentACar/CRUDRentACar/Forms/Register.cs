using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUDRentACar.Functions.Functii;
using static CRUDRentACar.Classes.User;
using CRUDRentACar.Classes;
using CRUDRentACar.Controllers;

namespace CRUDRentACar.Forms
{
    public partial class Register : Form
    {
        private Button btnCancel;
        private Button btnRegister;
        private TextBox txtBoxUserName;
        private TextBox txtBoxPassword;
        private CheckBox checkBoxAdmin;
        private Label lblUser;
        private Label lblPassword;
        private ControllerUser control;
        public Register()
        {
            InitializeComponent();
            CancelBtn();
            RegisterBtn();
            TextBoxUserName();
            TextBoxPassword();
            CheckBoxIsAdmin();
            LabelUserName();
            LabelPassword();
            control = new ControllerUser();
        }

        public void TextBoxUserName()
        {
            txtBoxUserName = new TextBox();
            txtBoxUserName.Location = new Point(280, 50);
            txtBoxUserName.Width = 130;
            txtBoxUserName.Height = 30;
            this.Controls.Add(txtBoxUserName);

        }

        public void TextBoxPassword()
        {
            txtBoxPassword = new TextBox();
            txtBoxPassword.Location = new Point(280, 150);
            txtBoxPassword.Width = 130;
            txtBoxPassword.Height = 30;
            this.Controls.Add(txtBoxPassword);

        }

        public void CheckBoxIsAdmin()
        {
            checkBoxAdmin = new CheckBox();
            checkBoxAdmin.Location = new Point(280, 250);
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
        public void LabelPassword()
        {
            lblPassword = new Label();
            lblPassword.Location = new Point(280, 124);
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
            btnCancel.Location = new Point(350, 330);
            btnCancel.Text = "Cancel";
            btnCancel.Width = 120;
            btnCancel.Height = 40;
            btnCancel.BackColor = Color.PaleVioletRed;
            this.Controls.Add(btnCancel);
            btnCancel.Click += btnCancel_Click;
        }

        public void RegisterBtn()
        {//right bottpm
            btnRegister = new Button();
            btnRegister.Location = new Point(610, 330);
            btnRegister.Text = "Register";
            btnRegister.Width = 120;
            btnRegister.Height = 40;
            btnRegister.BackColor = Color.DeepSkyBlue;
            this.Controls.Add(btnRegister);
            btnRegister.Click += btnRegisterUser_Click;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxUserName) == false)
            {
                MandatoryField("Name.");
            }
            else if (IsNotEmpty(txtBoxPassword) == false)
            {
                MandatoryField("password.");
            }
            else
            {
                string registerUser = txtBoxUserName.Text;
                string registerPassword = txtBoxPassword.Text;
                bool admin = checkBoxAdmin.Checked;
                User user = new User(registerUser, registerPassword, admin);
                control.Add(user);
                control.saveToFileUserTxt();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
