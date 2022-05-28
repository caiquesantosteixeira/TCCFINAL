using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        

        private void k(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            calcularMedia(txt2m1, txt2m2, txt2m3, txt2m4, txt2m5, txtRm2);
        }

        private void calcularMedia(DecimalTextBox d1, DecimalTextBox d2, DecimalTextBox d3, DecimalTextBox d4, DecimalTextBox d5, TextBox ret) 
        {
            var val1 = Convert.ToDecimal(d1.Text.Trim());
            var val2 = Convert.ToDecimal(d2.Text.Trim());
            var val3 = Convert.ToDecimal(d3.Text.Trim());
            var val4 = Convert.ToDecimal(d4.Text.Trim());
            var val5 = Convert.ToDecimal(d5.Text.Trim());

            ret.Text = ((val1 + val2 + val3 + val4 + val5) / 5).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calcularMedia(txt6m1, txt6m2, txt6m3, txt6m4, txt6m5, txtrm6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcularMedia(txt4m1, txt4m2, txt4m3, txt4m4, txt4m5, txtRm4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcularMedia(txt8m1, txt8m2, txt8m3, txt8m4, txt8m5, txtrm8);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRm2.Text) &&
                !string.IsNullOrEmpty(txtRm4.Text) &&
                !string.IsNullOrEmpty(txtrm6.Text) &&
                !string.IsNullOrEmpty(txtrm8.Text))
            {
                var form2 = new Form2(
                    Convert.ToDecimal(txtRm2.Text),
                    Convert.ToDecimal(txtRm4.Text),
                    Convert.ToDecimal(txtrm6.Text),
                    Convert.ToDecimal(txtrm8.Text)
                    );
                form2.ShowDialog();
            }
            else 
            {
                MessageBox.Show("é necessário cálcular todas as distâncias");
            }
        }
    }
}
