using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficosDeTortuguin
{
    class Tile
    {
        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private bool virgen;

        public bool Virgen
        {
            get { return virgen; }
            set { virgen = value; }
        }

        public Tile()
        {
            virgen = true;
        }
    }
}
