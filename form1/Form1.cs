using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double notaV1 = 0d;
            double notaV2 = 0d;
            double notaV3 = 0d;
            double notaV4 = 0d;
            double media = 0d;

            notaV1 = double.Parse(nota1.Text);
            notaV2 = double.Parse(nota2.Text);
            notaV3 = double.Parse(nota3.Text);
            notaV4 = double.Parse(nota4.Text);

            media = (notaV1 + notaV2 + notaV3 + notaV4) / 4;

            label6.Text = String.Format("Média = {0:0.0}", media);
        }
    }
}
