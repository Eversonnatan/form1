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
    public partial class Form3 : Form
    {
        
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;


            int novaLarguraImg = 100;
            int novaAlturaImg = 100;
                novaLarguraImg++;
                novaAlturaImg++;

                pictureBox1.Size = new Size(novaLarguraImg, novaAlturaImg);
                label1.Text = String.Format("{0:0} clique(s)", contador);
             contador++;
    
        }
    }
}
