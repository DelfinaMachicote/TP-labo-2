using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{
    class Reina : Pieza
    {
        void Posiciones()//restricciones para colocar la reina en el tablero: cuadrado [3X6]
        {
            if (x > 6) x = 6;
            if (x < 3) x = 3;
            if (y > 6) y = 6;
            if (y < 3) y = 3;
        }
        public Reina(int x,int y)
        {
            this.x = x;
            this.y = y;
            Posiciones();//achico el tablero
        }

        public void Mover( bool[,] tablero)
        {
            
            for (int i = x; i < 8 - x; i++)//muevo a la derecha
            {
                tablero[i, y] = true;
            }
            for(int i = x; i > 1; i--)//muevo a la izquierda
            {
                tablero[i, y] = true;
            }
            for(int i = y; i < 8-y; i++)//muevo hacia arriba
            {
                tablero[x, i] = true;
            }
            for(int i = y; i > 1; i--)//muevo hacia abajo
            {
                tablero[x, i] = true;
            }

            for(int i=0;i<8;i++)//diagonal arriba a la derecha
            {
                if (x + i < 8 && y + i < 8)
                    tablero[x + i, y + i] = true;

            }
            for(int i = 0; i < 8; i++)//diagonal arriba a la izquierda
            {
                if (x - i >1 && y + i < 8)
                    tablero[x - i, y + i] = true;

            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la derecha
            {
                if (x + i < 8 && y - i >1)
                    tablero[x + i, y - i] = true;

            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la izquierda
            {
                if (x - i >=1  && y - i >=1 )
                    tablero[x - i, y - i] = true;

            }
        }
    }
}
