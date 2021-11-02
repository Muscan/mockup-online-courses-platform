using CRUDRentACar.Classes;
using CRUDRentACar.Controllers;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CRUDRentACar
{
    public partial class FormStatus : Form
    {
        private ListView list;
        private Button btnClose;
        private ControllerMasina controllerMasina;

        public FormStatus()
        {
            InitializeComponent();
            controllerMasina = new ControllerMasina();
            list = new ListView();
            this.Controls.Add(list);
            list.Width = this.Width;
            createTable();
           /* btnClose = new Button();
            btnClose.Visible = true;
            btnClose.Location = new Point(300, 330);
            btnClose.Text = "Close";
            btnClose.Width = 120;
            btnClose.Height = 40;
            btnClose.BackColor = Color.PaleVioletRed;
            this.Controls.Add(btnClose);*/

        }

        public void createTable()
        {    //(int id, string name, string department)

            list.GridLines = true;
            list.View = View.Details;
            list.BorderStyle = BorderStyle.Fixed3D;
            list.ForeColor = ForeColor;
            list.Width = 800;
            list.Height = 600;
            this.Controls.Add(list);

      

            list.Clear();
            list.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            list.Columns.Add("Tip Combustibil", 100, HorizontalAlignment.Left);
            list.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            list.Columns.Add("An Fabricatie", 100, HorizontalAlignment.Center);
            list.Columns.Add("Kilometraj", 100, HorizontalAlignment.Left);
            list.Columns.Add("Disponibila", 100, HorizontalAlignment.Left);
            list.Columns.Add("Nume Client", 100, HorizontalAlignment.Left);

            List<Masina> l = controllerMasina.getAllCars();
            foreach (Masina masina in l)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = masina.getMarca();
                linie.SubItems.Add(masina.getCombustibil());
                linie.SubItems.Add(masina.getPret().ToString());
                linie.SubItems.Add(masina.getAn().ToString());
                linie.SubItems.Add(masina.getKilometraj().ToString());
                linie.SubItems.Add(masina.getStare().ToString());
                linie.SubItems.Add(masina.getClient());
                list.Items.Add(linie);

              
            }
           
        }
      
        /*  private void frmStatus_Load(object sender, EventArgs e)
          {
              controllerMasina = new ControllerMasina();
              controllerMasina.status(listMasini);
          }*/

        /* private void btnExit_Click(object sender, EventArgs e)
         {
             this.Close();
         }*/
    }
}
