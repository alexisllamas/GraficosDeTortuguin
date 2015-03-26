using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficosDeTortuguin
{
    class Tablero
    {
        private byte[,] matriz;
        private int _x;
        private int _y;
        private int torX;
        private int torY;
        
        public Tablero(int x, int y)
        {
            matriz = new byte[Config.numCuadros, Config.numCuadros];
            llenarMatriz();
            _x = x;
            _y = y;
            torX = x + Config.tamanoCuadro;
            torY = y + Config.tamanoCuadro;
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
                        matriz[i, j] = 4;

                    else if (i == 0)
                        matriz[i, j] = 2;

                    else if (j == Config.numCuadros-1)
                        matriz[i, j] = 6;

                    else if (i == Config.numCuadros-1)
                        matriz[i, j] = 8;
                    else
                        matriz[i, j] = 5;
                }
            }

            matriz[0, 0] = 1;
            matriz[0, Config.numCuadros-1] = 3;
            matriz[Config.numCuadros-1, 0] = 7;
            matriz[Config.numCuadros-1, Config.numCuadros-1] = 9;
        }

        public Panel[,] llenarTablero()
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
                    newPanel.Location = new Point(Config.tamanoCuadro * i + _x, Config.tamanoCuadro * j + _y);

                    paneles[i, j] = newPanel;

                    newPanel.BackgroundImageLayout = ImageLayout.Stretch;

                    if (i == 0 && j == 0)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.EsIA;
                    else if (i == 0 && j == Config.numCuadros-1)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.EsIAb;
                    else if (i == Config.numCuadros-1 && j == 0)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.EsDA;
                    else if (i == Config.numCuadros-1 && j == Config.numCuadros-1)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.EsDAb;
                    else if (i == 0)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.BorI;
                    else if (i == Config.numCuadros-1)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.BorD;
                    else if (j == 0)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.BorArr;
                    else if(j==Config.numCuadros-1)
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.BorAb;
                    else
                        newPanel.BackgroundImage = GraficosDeTortuguin.Properties.Resources.Cen;
                }
            }
            return paneles;
        }
    }
}
