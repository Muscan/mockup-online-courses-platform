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
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripItem operatiiToolStripMenuItem;
        private ToolStripItem updateToolStripMenuItem;


        public Menu()
        {
            InitializeComponent();
            StatusParcAutoToolStripMenuItem();
        }

        public void StatusParcAutoToolStripMenuItem()
        {
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            operatiiToolStripMenuItem});
            //,updateToolStripMenuItem});

            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            toolStripDropDownButton1.Click += new System.EventHandler(toolStripDropDownButton1_Click);

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
