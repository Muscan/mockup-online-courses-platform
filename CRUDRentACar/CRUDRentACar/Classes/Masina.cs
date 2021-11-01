using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDRentACar.Classes
{
    class Masina
    {
        private String marca;
        private bool stare;
        private int pret;
        private int an;
        private int kilometraj;
        private String combustibil;
        private String numeClient;
        public Masina() { }
        public Masina(String marca, String combustibil, int pret, int an, int kilometraj, bool stare, String numeClient)
        {
            this.marca = marca;
            this.combustibil = combustibil;
            this.pret = pret;
            this.an = an;
            this.kilometraj = kilometraj;
            this.stare = stare;
            this.numeClient = numeClient;
        }


        public String getMarca()
        {
            return marca;
        }
        public String getCombustibil()
        {
            return combustibil;
        }
        public int getPret()
        {
            return pret;
        }
        public int getAn()
        {
            return an;
        }
        public int getKilometraj()
        {
            return kilometraj;
        }
        public bool getStare()
        {
            return stare;
        }

        public void setMarca(String marca)
        {
            this.marca = marca;
        }
        public void setCombustibil(String combustibil)
        {
            this.combustibil = combustibil;
        }
        public void setAn(int an)
        {
            this.an = an;
        }
        public void setPret(int pret)
        {
            this.pret = pret;
        }
        public void setKilometraj(int kilometraj)
        {
            this.kilometraj = kilometraj;
        }
        public void setStare(bool stare)
        {
            this.stare = stare;
        }
        public String getClient()
        {
            return numeClient;
        }
        public void setClient(String numeClient)
        {
            this.numeClient = numeClient;
        }

        //descriere
        public string carDescription()
        {
            string carDetails = "";
            /* TBD carDetails += "Marca: " + this.marca + "\n";
             carDetails += "Pret: " + this.pret + "\n";
             carDetails += "Motor: " + this.motor + "\n";
             carDetails += "Culoare: " + this.culoare + "\n";
             carDetails += "An fabricatie: " + this.anFabricatie + "\n";
             carDetails += "Tractiune: " + this.tractiune + "\n";
             carDetails += "Status: " + this.status + "\n";*/
            return carDetails;
        }

        public void afisareMasina()
        {
            Console.WriteLine(this.carDescription());
        }
        public String toSave()
        {
            return marca + "," + combustibil + "," + pret + "," + an + "," + kilometraj + "," + stare + "," + numeClient;
        }

    }
}
