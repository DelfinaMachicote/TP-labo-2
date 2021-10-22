using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{
    class Rey
    {
        public Rey()
        {
            int x;
            int y;
        }
    }
    void Mover(bool tablero[,])
    {
        if
        tablero[x, y + 1] = 1;//muevo hacia arriba
        tablero[x+1, y ] = 1;//muevo hacia la derecha
        tablero[x, y - 1] = 1;//muevo hacia abajo
        tablero[x-1, y ] = 1;//muevo hacia la izquierda
    }
}
