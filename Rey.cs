using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{
    class Rey:Pieza
    {
        public Rey(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        void Mover(bool[,] tablero)
        {

            tablero[x, y + 1] = true;//muevo hacia arriba
            tablero[x + 1, y] = true;//muevo hacia la derecha
            tablero[x, y - 1] = true;//muevo hacia abajo
            tablero[x - 1, y] = true;//muevo hacia la izquierda
        }
    }
   
}
