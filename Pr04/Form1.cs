﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr04
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
            int poziceV = 0;
            foreach(char znaky in text)
            {
                if (znaky >= 65 && znaky <= 95){
                    text = text.Remove(poziceV,1);
                }
                else            
                {
                    poziceV++;
                }
            }
            textBox2.Text = (text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = (textBox1.Text);

            text = text.Replace("*", "");
            textBox2.Text = (text);
        }
    }
}
