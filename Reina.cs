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
          //  Posiciones();//achico el tablero
        }

        public void Mover( char[,] tablero)
        {
            
            for (int i = x; i < 8 ; i++)//muevo hacia arriba
            {
                if(tablero[i, y] !='A'&& tablero[i, y] != 'R' && tablero[i, y] != 'C' && tablero[i, y] != 'T')
                {
                    tablero[i, y] = '1';
                }
                
            }
            for(int i = x; i >= 0; i--)//muevo hacia abajo
            {
                if (tablero[i, y] == '0')
                    tablero[i, y] = '1';
            }
            for(int i = y; i < 8; i++)//muevo a la derecha
            {
                if (tablero[x, i] == '0')
                    tablero[x, i] = '1';
            }
            for(int i = y; i >=0; i--)//muevo a la izquierda
            {
                if (tablero[x, i] == '0')
                    tablero[x, i] = '1';
            }

            for(int i=0;i<8;i++)//diagonal arriba a la derecha
            {
                if (x + i < 8 && y + i < 8) {
                    if (tablero[x + i, y + i] == '0')
                    {

                        tablero[x + i, y + i] = '1';
                    }
                }
                    
                   

            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la derecha  
            {
                if (x - i >= 0 && y + i < 8)
                {
                    if (tablero[x - i, y + i] == '0')
                    {

                        tablero[x - i, y + i] = '1';
                    }
                }
            }
            for (int i = 0; i < 8; i++)//diagonal arriba a la izquierda
            {
                if (x + i < 8 && y - i >= 0) {
                    if (tablero[x + i, y - i] == '0')
                    {

                        tablero[x + i, y - i] = '1';
                    }
                }
                    
            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la izquierda
            {
                if (x - i >= 0 && y - i >= 0) {
                    if (tablero[x - i, y - i] == '0')
                    {

                        tablero[x - i, y - i] = '1';
                    }
                }
                    
            }
            tablero[x, y] = 'D';
        }
    }
}
