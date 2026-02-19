using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICAPREEXAMEN
{
    public partial class Form1 : Form
    {
        int contador = 0;
        double[] articulos = new double[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addArticulo_Click(object sender, EventArgs e)
        {
            if (contador < articulos.Length)
            {
                articulos[contador] = Convert.ToDouble(textBox1.Text);
                contador++;
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("No se pueden añadir más artículos");
            }
        }

        private void finalizarCompra_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(articulos);
            form2.ShowDialog();
        }
    }
}
