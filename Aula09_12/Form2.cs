﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula09_12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "O nome " + input.Text + "é comum";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "O nome " + input.Text + "é diferente";
        }
    }
}
