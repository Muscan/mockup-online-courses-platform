using System;
using System.Drawing;
using static CRUDRentACar.Functions.Functii;
using static CRUDRentACar.Classes.User;
using System.Windows.Forms;
using CRUDRentACar.Classes;
using CRUDRentACar.Controllers;

namespace CRUDRentACar.Forms
{
    public partial class LoginForm : Form
    {
        private Button btnCancel;
        private Button btnLogin;
        private Button btnRegister;
        private TextBox txtBoxUserName;
        private TextBox txtBoxPassword;
        private CheckBox checkBoxAdmin;
        private Label lblUser;
        private Label lblPassword;
        private ControllerUser control;
        public LoginForm()
        {

            InitializeComponent();
            CancelBtn();
            LoginBtn();
            RegisterBtn();
            TextBoxUserName();
            TextBoxPassword();
            CheckBoxIsAdmin();
            LabelUserName();
            LabelPassword();
            control = new ControllerUser();
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

        public void LoginBtn()
        {//middle bottom
            btnLogin = new Button();
            btnLogin.Location = new Point(480, 330);
            btnLogin.Text = "Login";
            btnLogin.Width = 120;
            btnLogin.Height = 40;
            btnLogin.BackColor = Color.YellowGreen;
            this.Controls.Add(btnLogin);
            btnLogin.Click += btnLogin_Click;
        }

        public void RegisterBtn()
        {//right bottom
            btnRegister = new Button();
            btnRegister.Location = new Point(610, 330);
            btnRegister.Text = "Register";
            btnRegister.Width = 120;
            btnRegister.Height = 40;
            btnRegister.BackColor = Color.DeepSkyBlue;
            this.Controls.Add(btnRegister);
            btnRegister.Click += btnRegister_Click;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty(txtBoxUserName) == false)
            {
                MandatoryField("User.");
            }
            else if (IsNotEmpty(txtBoxPassword) == false)
            {
                MandatoryField("Password.");
            }
            else
            {
                string name = txtBoxUserName.Text;

                string pass = txtBoxPassword.Text;

                User u = control.returnUser(name, pass, checkBoxAdmin.Checked);
                if (u != null)
                {
                    bool admin = control.isUserAdmin(u);
                    if (admin)
                    {

                        ControlPanel controlPanel = new ControlPanel();

                        controlPanel.Show();
                    }
                    else
                    {

                        LoginUserRole loginUserRole = new LoginUserRole();
                        loginUserRole.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Login does not work, user is admin or does not exist");
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register formRegister = new Register();
            formRegister.Show();
        }




    }
}
