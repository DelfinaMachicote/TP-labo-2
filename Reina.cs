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
            if (x > 5) x = 5;
            if (x < 2) x = 2;
            if (y > 5) y = 5;
            if (y < 2) y = 2;
        }
        public Reina(int x,int y)
        {
            this.x = x;
            this.y = y;
            Posiciones();//achico el tablero
        }

        public void Mover( bool[,] tablero)
        {
            
            for (int i = x; i < 8 ; i++)//muevo hacia arriba
            {
                tablero[i, y] = true;
            }
            for(int i = x; i >= 0; i--)//muevo hacia abajo
            {
                tablero[i, y] = true;
            }
            for(int i = y; i < 8; i++)//muevo a la derecha
            {
                tablero[x, i] = true;
            }
            for(int i = y; i >=0; i--)//muevo a la izquierda
            {
                tablero[x, i] = true;
            }

            for(int i=0;i<8;i++)//diagonal arriba a la derecha
            {
                if (x + i < 8 && y + i < 8)
                    tablero[x + i, y + i] = true;

            }
            for(int i = 0; i < 8; i++)//diagonal abajo a la derecha  
            {
                if (x - i >=0 && y + i < 8)
                    tablero[x - i, y + i] = true;

            }
            for (int i = 0; i < 8; i++)//diagonal arriba a la izquierda
            {
                if (x + i < 8 && y - i >=0)
                    tablero[x + i, y - i] = true;

            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la izquierda
            {
                if (x - i >=0  && y - i >=0 )
                    tablero[x - i, y - i] = true;

            }
        }
    }
}
