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

            for (int i = this.x; i < 8 ; i++)//muevo a la derecha
            {
                tablero[i, this.y] = true;
            }
            for (int i = this.x; i >=0; i--)//muevo a la izquierda
            {
                tablero[i, this.y] = true;
            }
            for (int i = this.y; i < 8 ; i++)//muevo hacia arriba
            {
                tablero[this.x, i] = true;
            }
            for (int i = this.y; i >=0; i--)//muevo hacia abajo
            {
                tablero[this.x, i] = true;
            }
        }
    }
}
