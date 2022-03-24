using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* button šifrování  */
            string text = (textBox1.Text);
            int velikost = Convert.ToInt32(textBox2.Text);
            string sifra = string.Empty;
            int hodnota = 0;

            foreach(char pismenko in text)
            {
                int ascii = (int)pismenko;
                if (ascii >= 65 && ascii <= 90) /* pokud je pismenko velke */
                {
                    hodnota = ascii + velikost; /* ascii 120 = x, posun = 5 hodnota = 120+5, if (hodnota > 122),  hodnota = 125
                                                 pomocna 125 - 122 = 3 hodnota = 97+pomocna */
                    if (hodnota >= 90)
                    {
                        int help = hodnota - 90;
                        hodnota = 65 + help;
                    }
                    sifra += (char)hodnota;
                    textBox3.Text = ("" + sifra);
                }
                else if (ascii >= 97 && ascii <= 122) /* pokud je pismenko maly */
                { 
                    hodnota = ascii + velikost; /* ascii 120 = x, posun = 5 hodnota = 120+5, if (hodnota > 122),  hodnota = 125
                                                 pomocna 125 - 122 = 3 hodnota = 97+pomocna */
                    if (hodnota >= 122)
                    {
                        int help = hodnota - 122;
                        hodnota = 96 + help;
                    }
                    sifra += (char)hodnota;
                    textBox3.Text = ("" + sifra);
                }
            }

            label3.Text = ("Ascii hodnota " + hodnota);
        }
    }
}
