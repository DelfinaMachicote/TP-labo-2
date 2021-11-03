using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{
    class Rey : Pieza
    {
        public Rey(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Mover(bool[,] tablero)
        {
            tablero[x, y] = true;
            if (y + 1 < 8)
                tablero[x, y + 1] = true;//muevo hacia arriba
            if (x + 1 < 8)
                tablero[x + 1, y] = true;//muevo hacia la derecha
            if (y - 1 >= 1)
                tablero[x, y - 1] = true;//muevo hacia abajo
            if (x - 1 >= 1)
                tablero[x - 1, y] = true;//muevo hacia la izquierda

            if (y + 1 < 8 && x + 1 < 8)
                tablero[x + 1, y + 1] = true;
            if (y + 1 < 8 && x - 1 >=0)
                tablero[x - 1, y + 1] = true;
            if (y - 1 >=0 && x + 1 < 8)
                tablero[x + 1, y - 1] = true;
            if (y - 1 >=0 && x - 1 >=0)
                tablero[x - 1, y - 1] = true;
        }
    }

}
