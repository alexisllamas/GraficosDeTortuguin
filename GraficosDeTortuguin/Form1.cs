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


namespace GraficosDeTortuguin
{
    public partial class Form1 : Form
    {
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        private Tortuga tortu;
        private Tablero table;
        public Form1()
        {
            InitializeComponent();
            tortu = new Tortuga();
            table = new Tablero(150, 20);
            lblEstado.Text = tortu.ToString();
            dibujarTablero(table.llenarTablero());
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
                tortu.caminar(1);
            else if (e.KeyChar == Convert.ToChar(Keys.Left))
                tortu.girarIzquierda();
            else if (e.KeyChar == Convert.ToChar(Keys.Right))
                tortu.girarDerecha();

            lblEstado.Text = tortu.ToString();
        }
    }
}
