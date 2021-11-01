using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CRUDRentACar.Classes
{
    class Client
    {
        private String nume;
        private String prenume;
        private int varsta;
        private int id;


        public Client()
        {

        }
        public Client(int id, String nume, String prenume, int varsta)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
        }
        public String getNume()
        {
            return nume;
        }
        public String getPrenume()
        {
            return prenume;
        }
        public int getVarsta()
        {
            return varsta;
        }

        public int getId()
        {
            return id;
        }


        public void setNume(String nume)
        {
            this.nume = nume;
        }
        public void setPrenume(String prenume)
        {
            this.prenume = prenume;
        }
        public void setVarsta(int varsta)
        {
            this.varsta = varsta;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public string userDesc()
        {
            string userDetails = "";
            return userDetails;
        }
        public void afisareUser()
        {
            MessageBox.Show(this.userDesc());
        }
        public String toSaveClient()
        {
            return id + "," + nume + "," + prenume + "," + varsta;
        }
    }
}
