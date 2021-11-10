using System;
using System.Windows.Forms;
using static CRUDRentACar.Functions.Functii;
using static CRUDRentACar.Classes.User;
using CRUDRentACar.Classes;
using CRUDRentACar.Controllers;


namespace CRUDRentACar.Forms
{
    public partial class Menu : Form
    {
        private ToolStripDropDownButton menu;
        public Menu()
        {
            InitializeComponent();
            StatusParcAutoToolStripMenuItem();
        }

        public void StatusParcAutoToolStripMenuItem()
        {
            menu = new ToolStripDropDownButton();
            menu.Enabled = true;
           //menu.DropDownItems.AddRange
            
        }

    }
}
