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

        private Tortuga tortu;
        public Form1()
        {
            InitializeComponent();
            tortu = new Tortuga();
            lblEstado.Text = tortu.ToString();
            dibujarTablero();
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

        private void dibujarTablero()
        {
            int tamanoCuadro = 20;
            int numCuadros = 20;
            var clr1 = Color.DarkGray;
            var clr2 = Color.White;

            for (byte i = 0; i < numCuadros; i++)
            {
                for (byte j = 0; j < numCuadros; j++)
                {
                    // create new Panel control which will be one 
                    // chess board tile
                    Panel newPanel = new Panel();
                    newPanel.Size = new Size(tamanoCuadro, tamanoCuadro);
                    newPanel.Location = new Point((tamanoCuadro + 1) * i  + 150, (tamanoCuadro + 1) * j  + 20);

                    // add to Form's Controls so that they show up
                    Controls.Add(newPanel);

                    // color the backgrounds
                    newPanel.BackColor = Color.DarkGoldenrod;
                }
            }
        }
    }
}
