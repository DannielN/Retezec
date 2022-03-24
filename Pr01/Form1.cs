using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr01
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
            text = text.ToLower();
            string samohlasky = "aeiouyáéěíóúůý"; 
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";

            int pocet_samohlasek = 0;
            int pocet_souhlasek = 0;

            foreach(char pismenko in text)
            {
                if (samohlasky.Contains(pismenko))
                {
                    pocet_samohlasek++;
                }
                else if (souhlasky.Contains(pismenko))
                {
                    pocet_souhlasek++;
                }
            }
            int delka = (textBox1.Text.Length) - (pocet_samohlasek + pocet_souhlasek);
            label1.Text = ("Počet samohlásek " + pocet_samohlasek + " , počet souhlásek " + pocet_souhlasek + " , počet mezer " + delka);
        }
    }
}
