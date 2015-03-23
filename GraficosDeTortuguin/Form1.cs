using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficosDeTortuguin
{
    public partial class Form1 : Form
    {
        Tortuga tortu;
        public Form1()
        {
            InitializeComponent();
            tortu = new Tortuga();
            lblEstado.Text = tortu.ToString();
        }

        private void cmdPlumaAbajo_Click(object sender, EventArgs e)
        {
            tortu.plumaAbajo();
            lblEstado.Text = tortu.ToString();
        }

        private void cmdPlumaArriba_Click(object sender, EventArgs e)
        {
            tortu.plumaArribaa();
            lblEstado.Text = tortu.ToString();
        }

        private void cmdGirarDerecha_Click(object sender, EventArgs e)
        {
            tortu.girarDerecha();
            lblEstado.Text = tortu.ToString();
        }

        private void cmdGirarIzquierda_Click(object sender, EventArgs e)
        {
            tortu.girarIzquierda();
            lblEstado.Text = tortu.ToString();
        }

        private void cmdCaminar_Click(object sender, EventArgs e)
        {
            byte cuantos = Convert.ToByte(txtCaminar.Text);
            tortu.caminar(cuantos);
            lblEstado.Text = tortu.ToString();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            txtTablero.Text = tortu.imprimirTablero();
        }
    }
}
