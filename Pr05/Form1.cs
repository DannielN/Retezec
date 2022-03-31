using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr05
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
            int pocet_mezer = 0;

            foreach(char znaky in text)
            {
                if (znaky == ' ')
                {
                    pocet_mezer++;
                }
            }
            label1.Text = ("Počet mezer v textu " + pocet_mezer);
        }
    }
}
