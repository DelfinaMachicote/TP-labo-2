﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{
    class Alfil:Pieza
    {
        public Alfil()
        {
            int x;
            int y;
        }
        void Mover(bool tablero[,])
        {
            for (int i = 0; i < 8; i++)//diagonal arriba a la derecha
            {
                if (x + i > 8 || y + i > 8)
                    break;
                tablero[x + i, y + i] = 1;
            }
            for (int i = 0; i < 8; i++)//diagonal arriba a la izquierda
            {
                if (x - i < 1 || y + i > 8)
                    break;
                tablero[x - i, y + i] = 1;
            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la derecha
            {
                if (x + i > 8 || y - i < 1)
                    break;
                tablero[x + i, y - i] = 1;
            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la izquierda
            {
                if (x - i > 8 || y - i > 8)
                    break;
                tablero[x - i, y - i] = 1;
            }
        }
    }
}