using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;


namespace GraficosDeTortuguin
{
    public partial class Form1 : Form
    {
        private Tortuga tortu;
        private bool tortugaCamina;
        private PictureBox tortuga;
        public Form1()
        {
            InitializeComponent();
            tortu = new Tortuga(250, 70);
            tortugaCamina = true;
            lblEstado.Text = tortu.ToString();
            tortuga = tortu.dibujarTortuga();
            Controls.Add(tortuga);
            dibujarTablero(tortu.llenarTableroGrafico());
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
            tortuga.BackgroundImage = tortu.dibujarTortuga().BackgroundImage;
        }

        private void cmdGirarIzquierda_Click(object sender, EventArgs e)
        {
            tortu.girarIzquierda();
            lblEstado.Text = tortu.ToString();
            tortuga.BackgroundImage = tortu.dibujarTortuga().BackgroundImage;
        }

        private void cmdCaminar_Click(object sender, EventArgs e)
        {
            if (txtCaminar.Text.Length != 0)
            {
                byte cuantos = Convert.ToByte(txtCaminar.Text);
                for (int i = 0; i < cuantos; i++)
                {
                    tortu.caminar();
                    lblEstado.Text = tortu.ToString();
                    tortuga.Location = tortu.dibujarTortuga().Location;
                    txtTablero.Text = tortu.imprimirTablero();
                    Thread.Sleep(500);
                }
            }
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            txtTablero.Text = tortu.imprimirTablero();
        }

        private void dibujarTablero(Panel[,] paneles)
        {
            for (byte i = 0; i < Config.numCuadros; i++)
            {
                for (byte j = 0; j < Config.numCuadros; j++)
                {
                    Controls.Add(paneles[i, j]);
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Up))
                tortu.caminar();
            else if (e.KeyChar == Convert.ToChar(Keys.Left))
                tortu.girarIzquierda();
            else if (e.KeyChar == Convert.ToChar(Keys.Right))
                tortu.girarDerecha();

            lblEstado.Text = tortu.ToString();
        }

        private void Run()
        {
        }
    }
}
