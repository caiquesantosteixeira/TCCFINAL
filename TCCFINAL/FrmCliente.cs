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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();

            this.Location = new Point(5, 5);
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmInicial = new Form1();
            frmInicial.ShowDialog();

        }
    }
}
