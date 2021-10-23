using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{
    class Torre: Pieza
    {
        public Torre(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Mover(bool[,] tablero)
        {

            for (int i = x; i < 7 - x; i++)//muevo a la derecha
            {
                tablero[i, y] = true;
            }
            for (int i = x; i > 1; i--)//muevo a la izquierda
            {
                tablero[i, y] = true;
            }
            for (int i = y; i < 8 - y; i++)//muevo hacia arriba
            {
                tablero[x, i] = true;
            }
            for (int i = y; i > 1; i--)//muevo hacia abajo
            {
                tablero[x, i] = true;
            }
        }
    }
}
