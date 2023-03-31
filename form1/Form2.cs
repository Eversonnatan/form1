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
    public partial class Form2 : Form
    {
        double salario = 0d;
        double novoSalario = 0d;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            salario = double.Parse(textBox1.Text);
            novoSalario = salario * 1.05;

            label2.Text = string.Format("Novo salário = {0:c}", novoSalario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salario = double.Parse(textBox1.Text);
            novoSalario = salario * 1.1;
            label2.Text = string.Format("Novo Salário = {0:C}", novoSalario);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            salario = double.Parse(textBox1.Text);
            novoSalario = salario* 1.15;
            label2.Text = String.Format("Novo Salário = {0:c}", novoSalario);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            salario = double.Parse(textBox1.Text);
            novoSalario = salario * 1.2;
            label2.Text = string.Format("Novo Salário = {0:c}", novoSalario);
        }
    }
}
