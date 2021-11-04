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

        public void Mover(char[,] tablero)
        {
            tablero[x, y] = 'R';
            if (y + 1 < 8)
                tablero[x, y + 1] = '1';//muevo hacia arriba
            if (x + 1 < 8)
                tablero[x + 1, y] = '1';//muevo hacia la derecha
            if (y - 1 >= 1)
                tablero[x, y - 1] = '1';//muevo hacia abajo
            if (x - 1 >= 1)
                tablero[x - 1, y] = '1';//muevo hacia la izquierda

            if (y + 1 < 8 && x + 1 < 8)
                tablero[x + 1, y + 1] = '1';
            if (y + 1 < 8 && x - 1 >=0)
                tablero[x - 1, y + 1] = '1';
            if (y - 1 >=0 && x + 1 < 8)
                tablero[x + 1, y - 1] = '1';
            if (y - 1 >=0 && x - 1 >=0)
                tablero[x - 1, y - 1] = '1';
        }
    }

}
