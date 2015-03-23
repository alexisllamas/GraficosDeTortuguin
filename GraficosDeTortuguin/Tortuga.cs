using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficosDeTortuguin
{
    class Tortuga
    {
        private byte[,] tablero;
        private byte x;
        private byte y;
        private bool plumaArriba;
        private byte direccion;
        private string[] direcciones = { "derecha", "abajo", "izquierda", "arriba" };

        public Tortuga()
        {
            tablero = new byte[20,20];
            x = 0;
            y = 0;
            llenarTablero();
            plumaArriba = true;
            direccion = 0;
        }

        private void llenarTablero()
        {
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    tablero[x, y] = 0;
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
        }

        public void plumaArribaa()
        {
            plumaArriba = true;
        }

        public void caminar(byte pasos)
        {
            if(direccion == 0)
            {
                for (int i = 1; i <= pasos; i++)
                    if (y + 1 < 20)
                    {
                        y++;
                        if (!plumaArriba)
                            tablero[x, y] = 1;
                    }
            }
            else if (direccion == 1)
            {
                for (int i = 1; i <= pasos; i++)
                    if (x + 1 < 20)
                    {
                        x++;
                        if (!plumaArriba)
                            tablero[x, y] = 1;
                    }
            }
            else if (direccion == 2)
            {
                for (int i = 1; i <= pasos; i++)
                    if (y - 1 >= 0)
                    {
                        y--;
                        if(!plumaArriba)
                            tablero[x, y] = 1;
                    }
            }
            else
            {
                for (int i = 1; i <= pasos; i++)
                    if (x - 1 >= 0)
                    {
                        x--;
                        if (!plumaArriba)
                            tablero[x, y] = 1;
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

        public override string ToString()
        {
            return String.Format("La tortuga está mirando hacia {0}, se encuentra en la posicion ({1}, {2}) y la pluma está {3}", direcciones[direccion], x, y, plumaArriba ? "arriba" : "abajo");
        }
    }
}
