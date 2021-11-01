using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CRUDRentACar.Functions
{
    class Functii
    {
        public static bool IsNotEmpty(TextBox txtBox)
        {
            if (txtBox.Text.Equals("")) return false;
            return true;
        }

        public static void MandatoryField(string field)
        {
            MessageBox.Show("Mandatory: " + field);
        }

        public static void ClearFields(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
        }

        public static void ClearLoginFields(TextBox txt1, TextBox txt2)
        {
            txt1.Clear();
            txt2.Clear();

        }


    }
}
