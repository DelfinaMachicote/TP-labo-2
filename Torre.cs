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
        public void Mover(char[,] tablero)
        {
            for (int i = x; i < 8; i++)//muevo hacia arriba
            {
                if (tablero[i, y] != 'A' && tablero[i, y] != 'R' && tablero[i, y] != 'C' && tablero[i, y] != 'T')
                {
                    tablero[i, y] = '1';
                }

            }
            for (int i = x; i >= 0; i--)//muevo hacia abajo
            {
                if (tablero[i, y] == '0')
                    tablero[i, y] = '1';
            }
            for (int i = y; i < 8; i++)//muevo a la derecha
            {
                if (tablero[x, i] == '0')
                    tablero[x, i] = '1';
            }
            for (int i = y; i >= 0; i--)//muevo a la izquierda
            {
                if (tablero[x, i] == '0')
                    tablero[x, i] = '1';
            }
            tablero[x, y] = 'T';
        }
    }
}
