using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{
    class Alfil:Pieza
    {
        public Alfil(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Mover(bool[,] tablero)
        {
            for (int i = 0; i < 8; i++)//diagonal arriba a la derecha
            {
                if (x + i < 8 && y + i < 8)
                    tablero[x + i, y + i] = true;

            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la derecha  
            {
                if (x - i >= 0 && y + i < 8)
                    tablero[x - i, y + i] = true;

            }
            for (int i = 0; i < 8; i++)//diagonal arriba a la izquierda
            {
                if (x + i < 8 && y - i >= 0)
                    tablero[x + i, y - i] = true;

            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la izquierda
            {
                if (x - i >= 0 && y - i >= 0)
                    tablero[x - i, y - i] = true;

            }
        }
    }
}
