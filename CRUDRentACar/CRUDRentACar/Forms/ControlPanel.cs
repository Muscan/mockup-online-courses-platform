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
    public partial class ControlPanel : Form
    {
        private ControllerUser control;
        private Button btnClose;
        private Button printAllUsers;
        private Button btnAddUser;
        private Button btnEdit;
        private Button btnDelete;
        private ListView lstUsers;
        public ControlPanel()
        {
            InitializeComponent();
            control = new ControllerUser();
            CloseBtn();
            PrintAllBtn();
            AddUserBtn();
            EditBtn();
            DeleteBtn();
            createTable();

        }

        public void AddUserBtn()
        {//right bottom
            btnAddUser = new Button();
            btnAddUser.Location = new Point(350, 310);
            btnAddUser.Text = "Add User";
            btnAddUser.Width = 120;
            btnAddUser.Height = 40;
            btnAddUser.BackColor = Color.DeepSkyBlue;
            this.Controls.Add(btnAddUser);
            btnAddUser.Click += btnAddUser_Click;
        }

        public void EditBtn()
        {//right bottom
            btnEdit = new Button();
            btnEdit.Location = new Point(220, 310);
            btnEdit.Text = "Edit";
            btnEdit.Width = 120;
            btnEdit.Height = 40;
            btnEdit.BackColor = Color.DeepSkyBlue;
            this.Controls.Add(btnEdit);
            btnEdit.Click += btnEdit_Click;
        }
        public void CloseBtn()
        {
            btnClose = new Button();
            btnClose.Visible = true;
            btnClose.Location = new Point(610, 310);
            btnClose.Text = "Close";
            btnClose.Width = 120;
            btnClose.Height = 40;
            btnClose.BackColor = Color.PaleVioletRed;
            this.Controls.Add(btnClose);
            btnClose.Click += btnExit_Click;
        }

        public void PrintAllBtn()
        {//middle bottom
            printAllUsers = new Button();
            printAllUsers.Location = new Point(480, 310);
            printAllUsers.Text = "Print All Users";
            printAllUsers.Width = 120;
            printAllUsers.Height = 40;
            printAllUsers.BackColor = Color.YellowGreen;
            this.Controls.Add(printAllUsers);
            printAllUsers.Click += printAllUsers_Click;
        }

        public void DeleteBtn()
        {//middle bottom
            btnDelete = new Button();
            btnDelete.Location = new Point(90, 310);
            btnDelete.Text = "Delete";
            btnDelete.Width = 120;
            btnDelete.Height = 40;
            btnDelete.BackColor = Color.Gray;
            this.Controls.Add(btnDelete);
            btnDelete.Click += btnDelete_Click;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printAllUsers_Click(object sender, EventArgs e)
        {
            
            control.AfisareUsers(lstUsers);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Register formRegister = new Register();
            formRegister.Show();
            control.AfisareUsers(lstUsers);
            //TBD It should print all users when clicked but is not working
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm(control);
            editUserForm.Show();
            control.AfisareUsers(lstUsers);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUserForm formDelete = new DeleteUserForm();
            formDelete.Show();
            control.AfisareUsers(lstUsers);
        }




        public void createTable()
        {    //(int id, string name, string department)
            lstUsers = new ListView();
            lstUsers.GridLines = true;
            lstUsers.View = View.Details;
            lstUsers.BorderStyle = BorderStyle.Fixed3D;
            lstUsers.ForeColor = ForeColor;
            lstUsers.Width = 400;
            lstUsers.Height = 300;
            this.Controls.Add(lstUsers);



            lstUsers.Clear();
            lstUsers.Columns.Add("User ", 100, HorizontalAlignment.Left);
            lstUsers.Columns.Add("Parola ", 100, HorizontalAlignment.Left);
            lstUsers.Columns.Add("Admin ", 100, HorizontalAlignment.Left);
       

            List<User> users = control.GetAllUsers();
            foreach (User user in users)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = user.getUser();
                linie.SubItems.Add(user.getPassword());
                linie.SubItems.Add(user.getIsAdmin().ToString());
           
                lstUsers.Items.Add(linie);
            }

        }
    }
}
