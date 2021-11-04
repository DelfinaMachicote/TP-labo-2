using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{
    class Caballo : Pieza
    {
        void Posiciones()//restricciones para colocar la reina en el tablero: cuadrado [3X6]
        {
            if (x > 5) x = 5;
            if (x < 2) x = 2;
            if (y > 5) y = 5;
            if (y < 2) y = 2;
        }
        public Caballo(int x, int y)
        {
            this.x = x;
            this.y = y;
            Posiciones();
        }
        public void Mover(char[,] tablero)
        {
            tablero[x, y] = 'C';

            if ((x + 1 < 8) && (y + 2 < 8))
            {
                if(tablero[x + 1, y + 2]=='0')
                    tablero[x + 1, y + 2] = '1';//arriba a la derecha
            }
                

            if ((x + 1 < 8) && (y - 2 >= 0))
            {
                if(tablero[x + 1, y - 2]=='0')
                    tablero[x + 1, y - 2] = '1';//arriba a la izquierda
            }


            if (x + 2 < 8 && y + 1 < 8)
            {
                if(tablero[x + 2, y + 1] == '0')
                    tablero[x + 2, y + 1] = '1';//a la derecha arriba
            }

            if ((x - 2 >= 0) && y + 1 < 8)
            {
                if(tablero[x - 2, y + 1]=='0')
                    tablero[x - 2, y + 1] = '1';//a la derecha abajo
            }
            if (x + 2 < 8 && y - 1 >= 0)
            {
                if(tablero[x + 2, y - 1]=='0')
                    tablero[x + 2, y - 1] = '1';//a la izquierda arriba
            }
                

            if (x - 2 >= 0 && y - 1 >= 0)
            {
                if(tablero[x - 2, y - 1]=='0')
                    tablero[x - 2, y - 1] = '1';//a la izquierda abajo
            }
                

            if (x - 1 >= 0 && y + 2 < 8)
            {
                if(tablero[x - 1, y + 2]=='0')
                    tablero[x - 1, y + 2] = '1';//abajo a la derecha
            }
                

            if (x - 1 >= 0 && y - 2 >= 0)
            {
                if(tablero[x - 1, y - 2]=='0')
                    tablero[x - 1, y - 2] = '1';//abajo a la izquierda
            }
                
        }
    }
}
