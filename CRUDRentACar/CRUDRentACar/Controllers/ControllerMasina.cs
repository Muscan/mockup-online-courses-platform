using CRUDRentACar.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CRUDRentACar.Controllers
{
    class ControllerMasina
    {
        private List<Masina> masini;
        public ControllerMasina()
        {
            masini = new List<Masina>();

            readFileTxt();
        }
        public List<Masina> getAllCars()
        {
            return masini;
        }
        //Finds the index of the car
        public int carIndex(string marca)
        {
            for (int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getMarca().Equals(marca))
                {
                    return i;
                }
            }
            return -1;
        }
        //Updates the car
        public void UpdateCombustibil(string nume, string combustibil)
        {
            int index = carIndex(nume);
            if (index != -1)
            {
                masini[index].setCombustibil(combustibil);
            }
            else
                MessageBox.Show("Masina nu a fost gasita");
        }

        public void UpdateAn(string nume, int an)
        {
            int index = carIndex(nume);
            if (index != -1)
            {
                masini[index].setAn(an);
            }
            else MessageBox.Show("Masina nu a fost gasita");
        }

        public void UpdateKM(string nume, int km)
        {
            int index = carIndex(nume);
            if (index != -1)
            {
                masini[index].setKilometraj(km);
            }
            else MessageBox.Show("Masina nu a fost gasita");
        }

        public bool UpdatePret(string nume, int pret)
        {
            int index = carIndex(nume);
            if (index != -1)
            {
                masini[index].setPret(pret);
                return true;
            }
            MessageBox.Show("Masina nu a fost gasita");
            return false;
        }
        //Add
        public bool Add(Masina masina)
        {
            int index = carIndex(masina.getMarca());
            if (index == -1)
            {
                this.masini.Add(masina);
                MessageBox.Show("Item Added!");
                saveToFileTxt();
                return true;
            }
            MessageBox.Show("Item exists");
            return false;
        }

        //delete 
        public bool Delete(string masina)
        {
            int index = carIndex(masina);
            if (index != -1)
            {
                MessageBox.Show("Item " + masini[index].getMarca() + " deleted");
                this.masini.RemoveAt(index);
                saveToFileTxt();
                return true;
            }
            MessageBox.Show("Item not found ");
            return false;
        }

        //stream reader

        public void readFileTxt()
        {
            // masini.Clear();
            StreamReader read = new StreamReader(@"../../../Files/Masini.txt");
            String line = "";
            line = read.ReadLine();

            while (line != "" && line != null)
            {
                string[] formattedWord = line.Split(",");
                string marca = formattedWord[0];
                string combustibil = formattedWord[1];
                int pret = int.Parse(formattedWord[2]);
                int an = int.Parse(formattedWord[3]);
                int kilometri = int.Parse(formattedWord[4]);
                bool stare = bool.Parse(formattedWord[5]);
                string numeClient = formattedWord[6];
                Masina masina = new Masina(marca, combustibil, pret, an, kilometri, stare, numeClient);
                masini.Add(masina);
                line = read.ReadLine();
            }
            read.Close();
        }
        public string toStringObjectFromFile()
        {
            string tot = "";
            for (int i = 0; i < masini.Count; i++)
            {
                tot += masini[i].toSave() + "\n";

            }
            return tot;
        }

        public void saveToFileTxt()
        {
            StreamWriter write = new StreamWriter(@"../../../Files/Masini.txt");
            write.WriteLine(this.toStringObjectFromFile());
            write.Close();
        }

        public void status(ListView listMasini)
        {
            listMasini.Clear();
            listMasini.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            listMasini.Columns.Add("Tip Combustibil", 100, HorizontalAlignment.Left);
            listMasini.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            listMasini.Columns.Add("An Fabricatie", 100, HorizontalAlignment.Center);
            listMasini.Columns.Add("Kilometraj", 100, HorizontalAlignment.Left);
            listMasini.Columns.Add("Disponibila", 100, HorizontalAlignment.Left);
            listMasini.Columns.Add("Nume Client", 100, HorizontalAlignment.Left);


            foreach (Masina masina in masini)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = masina.getMarca();
                linie.SubItems.Add(masina.getCombustibil());
                linie.SubItems.Add(masina.getPret().ToString());
                linie.SubItems.Add(masina.getAn().ToString());
                linie.SubItems.Add(masina.getKilometraj().ToString());
                linie.SubItems.Add(masina.getStare().ToString());
                linie.SubItems.Add(masina.getClient());
                listMasini.Items.Add(linie);
            }
        }

        public Masina getMasina(string marca)
        {
            for (int i = 0; i < masini.Count; i++)
            {
                if (masini[i].getMarca().Equals(marca))
                    return masini[i];
            }
            return null;

        }
        //if car is available
        public bool isAvailable(String marca)
        {
            if (getMasina(marca) != null)
            {
                return getMasina(marca).getStare();
            }

            return false;

        }

        public void rentCar(TextBox client, TextBox marca)
        {
            String numeC = client.Text;
            String numeM = marca.Text;

            if (isAvailable(numeM) == true)
            {
                changeClientName(numeM, numeC);
                changeStatus(numeM);

                saveToFileTxt();
                MessageBox.Show("Masina a fost inchiriata cu succes!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Masina nu poate fi inchiriata", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void returnCar(TextBox marcaReturn, TextBox client)
        {


            String marca = marcaReturn.Text;
            String clientText = client.Text;


            if (isAvailable(marca) == false)
            {

                changeStatus(marca);
                changeClientName(marca, clientText);
                saveToFileTxt();
                MessageBox.Show("Masina returnata");

            }
            else
            {
                MessageBox.Show("Masina nu e disponibila");
            }
        }

        public void changeStatus(String marca)
        {
            Masina masina = getMasina(marca);
            {
                masina.setStare(!masina.getStare());
            }
        }

        public void changeClientName(String marca, String nume)
        {
            Masina masina = getMasina(marca);//initialize the Masina object
            if (isAvailable(marca))
            {
                masina.setClient(nume);
                //for the car extracted from the list client name is set 
            }
            else
            {
                masina.setClient("Name not added for the new car");
            }
        }

        public void returnStatus(String marca)
        {
            Masina masina = getMasina(marca);
            masina.setStare(false);
            masina.setClient("Car is available");
        }
    }
}
