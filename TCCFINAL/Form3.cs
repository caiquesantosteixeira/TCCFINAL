﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCFINAL
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Location = new Point(5, 5);
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
