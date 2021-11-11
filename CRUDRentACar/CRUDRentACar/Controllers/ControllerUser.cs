using CRUDRentACar.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static CRUDRentACar.Controllers.ControllerMasina;

namespace CRUDRentACar.Controllers
{
     public class ControllerUser
    {
        private List<User> users;
        public ControllerUser()
        {
            users = new List<User>();
            readUserTxt();
        }
        //returns all the Users
        public List<User> GetAllUsers()
        {
            return users;
        }
        //Finds the user index
        public int userIndex(string user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].getUser().Equals(user))
                {
                    return i;
                }
            }
            return -1;
        }
        //Save to file
        public void saveToFileUserTxt()
        {
            StreamWriter write = new StreamWriter(@"../../../Files/Users.txt");
            write.WriteLine(this.toStringObjectUserFile());
            write.Close();
        }

        public string toStringObjectUserFile()
        {
            string tot = "";
            for (int i = 0; i < users.Count; i++)
            {
                tot += users[i].toSaveUser() + "\n";

            }
            return tot;
        }

        //update password
        public void UpdatePassword(string nume, string password)
        {
            int index = userIndex(nume);
            if (index != -1)
            {

                users[index].setPassword(password);

            }
            else
                MessageBox.Show("User not found or pw not changed");

        }
        //Add user
        public bool Add(User user)
        {
            int index = userIndex(user.getUser());
            if (index == -1)
            {
                this.users.Add(user);
                Console.WriteLine("User added ");
                saveToFileUserTxt();
                return true;
            }
            MessageBox.Show("User exists ");
            return false;
        }

        //update User, pw and isAdmin
        public bool updateUser(User user)
        {
            int index = userIndex(user.getUser());
            if (index != -1)
            {
                users[index].setUser(user.getUser());
                users[index].setPassword(user.getPassword());
                users[index].setIsAdmin(user.getIsAdmin());
                saveToFileUserTxt();
                return true;
            }
            MessageBox.Show("User not found.");
            return false;
        }

        //update User, pw and isAdmin v2
        public bool updateUser(String oldUser, User newUser)
        {
            int index = userIndex(oldUser);
            if (index != -1)
            {
                users[index].setUser(newUser.getUser());
                users[index].setPassword(newUser.getPassword());
                users[index].setIsAdmin(newUser.getIsAdmin());
                saveToFileUserTxt();
                return true;
            }
            MessageBox.Show("User not found.");
            return false;
        }
        //delete user
        public bool DeleteUser(string user)
        {
            int indexOfUser = userIndex(user);
            if (indexOfUser != -1)
            {
                MessageBox.Show("User " + users[indexOfUser].getUser() + " deleted");
                this.users.RemoveAt(indexOfUser);
                saveToFileUserTxt();
                return true;
            }
            MessageBox.Show("User not found");
            return false;
        }
        //update name
        public void updateName(string nume)
        {
            int index = userIndex(nume);
            if (index != -1)
            {
                users[index].setUser(nume);
            }
            else MessageBox.Show("User name not updated");
        }

        //reads from file
        public void readUserTxt()
        {
            StreamReader read = new StreamReader(@"../../../Files/Users.txt");
            String line = "";
            line = read.ReadLine();

            while (line != "" && line != null)
            {
                string[] formattedUser = line.Split(",");
                string user = formattedUser[0];
                string password = formattedUser[1];
                bool isAdmin = bool.Parse(formattedUser[2]);
                User userToAdd = new User(user, password, isAdmin);
                users.Add(userToAdd);
                line = read.ReadLine();
            }
            read.Close();
        }
        public string toStringFromFile()

        {
            string tot = "";
            for (int i = 0; i < users.Count; i++)
            {
                tot += users[i].toSaveUser() + "\n";
            }
            return tot;
        }

        public User returnUser(string nume, string password, bool adminRole)
        {
            for (int i = 0; i < users.Count; i++)
            {

                if (users[i].getUser().Equals(nume)
                 && users[i].getPassword().Equals(password)
                 && users[i].getIsAdmin() == adminRole)
                {

                    return users[i];
                }
            }

            return null;
        }

        public bool isUserAdmin(User userRole)

        {
            if (userRole.getIsAdmin() == true)
            {
                return true;
            }
            return false;
        }

        public void AfisareUsers(ListView listUsers)
        {
            listUsers.Clear();
            listUsers.Columns.Add("User", 100, HorizontalAlignment.Left);
            listUsers.Columns.Add("Password", 100, HorizontalAlignment.Left);
            listUsers.Columns.Add("Is Admin", 100, HorizontalAlignment.Left);
            for (int i = 0; i < users.Count; i++)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = users[i].getUser();
                linie.SubItems.Add(users[i].getPassword());
                linie.SubItems.Add(users[i].getIsAdmin().ToString());
                listUsers.Items.Add(linie);
            }
        }
     

    }
}
