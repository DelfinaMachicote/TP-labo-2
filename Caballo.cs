using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{
    class Caballo : Pieza
    {
        public Caballo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Mover(bool[,] tablero)
        {
            if ((x + 1 < 8 )&& (y + 2 < 8))
                tablero[x + 1, y + 2] = true;//arriba a la derecha
            if ((x - 1 <  8 )&&( y + 2 < 8) && x - 1 >= 1)
                tablero[x - 1, y + 2] = true;//arriba a la izquierda
            if (x + 2 < 8 && y + 1 < 8)
                tablero[x + 2, y + 1] = true;//a la derecha arriba
            if ((x + 2 < 8) && y - 1 < 8 && y - 1 >= 1)
                tablero[x + 2, y - 1] = true;//a la derecha abajo
            if (x - 2 < 8 && y + 1 < 8 && x - 2 >= 1)
                tablero[x - 2, y + 1] = true;//a la izquierda arriba
            if (x - 2 < 8 && y - 1 < 8 && y - 1 >= 1 && x - 2 >= 1)
                tablero[x - 2, y - 1] = true;//a la izquierda abajo
            if (x + 1 < 8 && y - 2 < 8 && y - 2 >= 1)
                tablero[x + 1, y - 2] = true;//abajo a la derecha
            if (x - 1 < 8 && y - 2 < 8 && x - 1 >= 1 && y - 2 >= 2)
                tablero[x - 1, y - 2] = true;//abajo a la izquierda
        }
    }
}
