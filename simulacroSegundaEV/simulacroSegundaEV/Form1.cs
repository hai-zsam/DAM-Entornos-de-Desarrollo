using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacroSegundaEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] matriz = new int[2, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Button botonMondongo = new Button();
                    botonMondongo.Text = "P" + i + j;
                    botonMondongo.Width = 50;
                    botonMondongo.Height = 50;
                    botonMondongo.Left = j * 50;
                    botonMondongo.Top = i * 50;
                    this.Controls.Add(botonMondongo);
                    botonMondongo.Tag = i + " " + j;

                    botonMondongo.Click += meDaIgual;
                }
            }
        }

        private void meDaIgual(object sender, EventArgs e)
        {
            Button botonMondongo = (Button)sender;
            string plaza = botonMondongo.Tag.ToString();

            botonMondongo.Text = "";
            botonMondongo.BackColor = Color.Red;

            MessageBox.Show("cOCHE APARCADO CORRECTAMENTE EN P " + plaza);
        }
    }
}
