using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = (textBox1.Text);
            int CifraK = 0;
            int pocet_cifer = 0;
            foreach(char pismenko in text)
            {
               if (pismenko >= 48 && pismenko <= 57) /* posledni v textboxu */
                {
                    pocet_cifer++;
                    CifraK = pismenko-48;
                    break;
                }
            }
            int delka = textBox1.TextLength; /* delka textu v textboxu */
            //label1.Text = ("Zkouska " + delka); 
            if (pocet_cifer != 0)
            {
                if (delka < CifraK) /* malo znaku, smaze se cely text */
                {
                    textBox2.Text = (""); 
                }
                else /* smaze K znaku */
                {    /* kdo se smeje 8 naposled // delka text = // pomocna = 23 - 8 // pomocna remove - CifraK  */
                    int value_help = delka - CifraK;
                    text = text.Remove(value_help, CifraK);
                    textBox2.Text = (text);
                }
            }
            else
            {
                textBox2.Text = (text);
            }

        }
    }
}
