using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficosDeTortuguin
{
    class Tortuga
    {
        private byte[,] tablero;
        private byte[,] tableroGrafico;
        private int x;
        private Image[] tortuImagenes = {GraficosDeTortuguin.Properties.Resources.tortuDer, 
                                            GraficosDeTortuguin.Properties.Resources.tortuAba,
                                            GraficosDeTortuguin.Properties.Resources.tortuIzq,
                                            GraficosDeTortuguin.Properties.Resources.tortuArr};
        private int _tabX;
        private int _tabY;

        public Tortuga(int tabX, int tabY)
        {
            _tabX = tabX;
            _tabY = tabY;
            tablero = new byte[20, 20];
            x = 0;
            y = 0;
            llenarTablero();
            plumaArriba = true;
            direccion = 0;
        }
        public int X
        {
            get { return x; }
        }
        private int y;

        public int Y
        {
            get { return y; }
        }
        private bool plumaArriba;
        private byte direccion;

        public byte Direccion
        {
            get { return direccion; }
        }
        private string[] direcciones = { "derecha", "abajo", "izquierda", "arriba" };

        private void llenarTablero()
        {
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    tablero[i, j] = 0;
                }
            }
        }

        public string imprimirTablero()
        {
            string cadenita = "";
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    cadenita += tablero[i, j].ToString() + " ";
                }
                cadenita += Environment.NewLine;
            }
            return cadenita;
        }

        public void plumaAbajo()
        {
            plumaArriba = false;
            tablero[y, x] = 1;
        }

        public void plumaArribaa()
        {
            plumaArriba = true;
        }

        public void caminar()
        {
            if (direccion == 0)
            {
                if (x + 1 < 20)
                {
                    x++;
                    if (!plumaArriba)
                        tablero[y, x] = 1;
                }
            }
            else if (direccion == 1)
            {
                if (y + 1 < 20)
                {
                    y++;
                    if (!plumaArriba)
                        tablero[y, x] = 1;
                }
            }
            else if (direccion == 2)
            {
                if (x - 1 >= 0)
                {
                    x--;
                    if (!plumaArriba)
                        tablero[y, x] = 1;
                }
            }
            else
            {
                if (y - 1 >= 0)
                {
                    y--;
                    if (!plumaArriba)
                        tablero[y, x] = 1;
                }
            }
        }

        public void girarDerecha()
        {
            if (direccion + 1 < 4)
                direccion++;
            else
                direccion = 0;
        }

        public void girarIzquierda()
        {
            if (direccion - 1 >= 0)
                direccion--;
            else
                direccion = 3;
        }

        private void llenarMatriz()
        {
            /*
             * 1 2 3
             * 4 5 6
             * 7 8 9
             * 
             * */

            for (int i = 0; i < Config.numCuadros; i++)
            {
                for (int j = 0; j < Config.numCuadros; j++)
                {
                    if (j == 0)
                        tableroGrafico[i, j] = 4;

                    else if (i == 0)
                        tableroGrafico[i, j] = 2;

                    else if (j == Config.numCuadros - 1)
                        tableroGrafico[i, j] = 6;

                    else if (i == Config.numCuadros - 1)
                        tableroGrafico[i, j] = 8;
                    else
                        tableroGrafico[i, j] = 5;
                }
            }

            tableroGrafico[0, 0] = 1;
            tableroGrafico[0, Config.numCuadros - 1] = 3;
            tableroGrafico[Config.numCuadros - 1, 0] = 7;
            tableroGrafico[Config.numCuadros - 1, Config.numCuadros - 1] = 9;
        }

        public Panel[,] llenarTableroGrafico()
        {
            /*
             * 1 2 3
             * 4 5 6
             * 7 8 9
             * 
             * */
            Panel[,] paneles = new Panel[Config.numCuadros, Config.numCuadros];
            for (byte i = 0; i < Config.numCuadros; i++)
            {
                for (byte j = 0; j < Config.numCuadros; j++)
                {
                    Panel newPanel = new Panel();
                    newPanel.Size = new Size(Config.tamanoCuadro, Config.tamanoCuadro);
                    newPanel.Location = new Point((Config.tamanoCuadro + 1) * i + _tabX, (Config.tamanoCuadro + 1) * j + _tabY);

                    paneles[i, j] = newPanel;

                    newPanel.BackgroundImageLayout = ImageLayout.Stretch;

                    if (i == 0 && j == 0)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.EsIA;
                    else if (i == 0 && j == Config.numCuadros - 1)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.EsIAb;
                    else if (i == Config.numCuadros - 1 && j == 0)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.EsDA;
                    else if (i == Config.numCuadros - 1 && j == Config.numCuadros - 1)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.EsDAb;
                    else if (i == 0)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.BorI;
                    else if (i == Config.numCuadros - 1)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.BorD;
                    else if (j == 0)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.BorArr;
                    else if (j == Config.numCuadros - 1)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.BorAb;
                    else
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.Cen;
                }
            }
            return paneles;
        }

        public PictureBox dibujarTortuga()
        {
            int x2 = x;
            int y2 = y;
            x2 *= Config.tamanoCuadro + 1;
            y2 *= Config.tamanoCuadro + 1;
            x2 += _tabX + Config.tamanoCuadro + Config.tamanoCuadro / 4;
            y2 += _tabY + Config.tamanoCuadro + Config.tamanoCuadro / 4;

            PictureBox tortuguin = new PictureBox();

            tortuguin.Location = new Point(x2, y2);
            tortuguin.Size = new Size(Config.tamanoCuadro / 2, Config.tamanoCuadro / 2);
            tortuguin.BackgroundImage = tortuImagenes[direccion];
            tortuguin.BackgroundImageLayout = ImageLayout.Stretch;

            return tortuguin;
        }

        public override string ToString()
        {
            return String.Format("La tortuga está mirando hacia {0}, se encuentra en la posicion ({1}, {2}) y la pluma está {3}", direcciones[direccion], x, y, plumaArriba ? "arriba" : "abajo");
        }
    }
}
