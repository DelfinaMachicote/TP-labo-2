using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_labo_2
{

    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int cont_tableros = 0;
            //bool[,] matrizOriginal = random(n, 50); //Creo la matriz random
            bool[,] tablero = new bool[8, 8];
            int cont_posiciones = 0;

            

            //genero todas las piezas sin restricciones en las posiciones
            Reina reina = new Reina(rnd.Next(0, 7), rnd.Next(0, 7));
            Rey rey = new Rey(rnd.Next(0, 7), rnd.Next(0, 7));
            Torre torre1= new Torre(rnd.Next(0, 7), rnd.Next(0, 7));
            Torre torre2 = new Torre(rnd.Next(0, 7), rnd.Next(0, 7));
            Alfil alfil1=new Alfil(rnd.Next(0, 7), rnd.Next(0, 7));
            Alfil alfil2 = new Alfil(rnd.Next(0, 7), rnd.Next(0, 7));
            Caballo caballo1=new Caballo(rnd.Next(0, 7), rnd.Next(0, 7));
            Caballo caballo2 = new Caballo(rnd.Next(0, 7), rnd.Next(0, 7));

            


            while (cont_tableros <= 10)
            {
               
                //me aseguro de que se cumplan todas las restricciones
                Asignar(reina, rey, torre1, torre2, alfil1, alfil2, caballo1, caballo2);

                //muevo cada pieza
                reina.Mover(tablero);
                rey.Mover(tablero);
                alfil1.Mover(tablero);
                alfil2.Mover(tablero);
                torre1.Mover(tablero);
                torre2.Mover(tablero);
                caballo1.Mover(tablero);
                caballo2.Mover(tablero);

                //cuento los casilleros del tablero que se llenaron
                cont_posiciones = Contar(tablero);

                //si el tablero esta lleno, se imprime
                if(cont_posiciones == 64)
                {
                    cont_tableros++;
                    Console.WriteLine("Tablero numero ", cont_tableros);
                    Imprimir(tablero);
                }
            }

        }
        public static void Asignar(Reina reina,Rey rey, Torre t1,Torre t2,Alfil a1,Alfil a2,Caballo c1, Caballo c2)
        {//pasamos todas las piezas por separado porque salta error cada vez que casteamos la clase padre


            Random rnd = new Random();

            

            t1.y = 0;//la torre 1 estara en la columna 1
            t2.y = 7;//la torre 2 estara en la columna 8

            //verifico que ninguna pieza este en las mismas columnas que las torres
            if (rey.y == 7 || rey.y == 0)
            {
                rey.y = rnd.Next(1, 6);
            }
            if (a1.y == 7 || a1.y == 0)
            {
                a1.y = rnd.Next(1, 6);
            }
            if (a2.y == 7 || a2.y == 0)
            {
                a2.y = rnd.Next(1, 6);
            }
            if (c1.y == 7 || c1.y == 0)
            {
                c1.y = rnd.Next(1, 6);
            }
            if (c2.y == 7 || c2.y == 0)
            {
                c2.y = rnd.Next(1, 6);
            }

            if (t1.x == t2.x)//las torres no pueden estar en la misma fila
            {
                if (t2.x + 1 <= 7)
                    t2.x = t2.x + 1;//si esto pasa, incremento la fila de t2
                else t2.x = 0;
            }
            if(reina.x== t1.x || reina.x == t2.x)//si la reina esta en la misma fila que alguna de las dos torres, incremento una fila
            {
                if (reina.x + 1 <= 5)
                {
                    reina.x = reina.x + 1;
                }
                else reina.x = 2;
            }
            //veo que la reina no se superponga con ninguna pieza
            while((reina.x==rey.x&& reina.y == rey.y)|| (reina.x == a1.x && reina.y == a1.y)||(reina.x == a2.x && reina.y == a2.y)|| (reina.x == c2.x && reina.y == c2.y) || (reina.x == c1.x && reina.y == c1.y))
            {
                reina.x = rnd.Next(2, 5);
                reina.y = rnd.Next(2, 5);
            }
            //veo que el rey no se superponga con ninguna pieza
            while ((reina.x == rey.x && reina.y == rey.y) || (rey.x == a1.x && rey.y == a1.y) || (rey.x == a2.x && rey.y == a2.y) )
            {
                rey.x = rnd.Next(0, 7);
                rey.y = rnd.Next(1, 6);
            }
            //veo que el alfil 1 no se superponga con ninguna pieza
            while ((a1.x == rey.x && a1.y == rey.y)  || (reina.x == a1.x && reina.y == a1.y)|| (a1.x == a2.x && a1.y == a2.y)|| (a1.x == c1.x && a1.y == c1.y)|| (a1.x == c2.x && a1.y == c2.y))
            {
                a1.x = rnd.Next(0, 7);
                a1.y = rnd.Next(1, 6);
            }
            //veo que el alfil 2 no se superponga con ninguna pieza
            while ((a2.x == rey.x && a2.y == rey.y) || (reina.x == a2.x && reina.y == a2.y) || (a1.x == a2.x && a1.y == a2.y) || (a2.x == c1.x && a2.y == c1.y) || (a2.x == c2.x && a2.y == c2.y))
            {
                a2.x = rnd.Next(0, 7);
                a2.y = rnd.Next(1, 6);
            }
            //veo que el caballo 1 no se superponga con ninguna pieza
            while ((reina.x == c1.x && reina.y == c1.y) || (c1.x == a2.x && c1.y == a2.y) || (a1.x == c1.x && a1.y == c1.y) || (c1.x == c2.x && c1.y == c2.y)|| (a2.x == c1.x && a2.y == c1.y))
            {
                c1.x = rnd.Next(0, 7);
                c1.y = rnd.Next(1, 6);
            }
            //veo que el caballo 2 no se superponga con ninguna pieza
            while ((reina.x == c2.x && reina.y == c2.y) || (c2.x == a2.x && c2.y == a2.y) || (c2.x == c1.x && c2.y == c1.y) || (a1.x == c2.x && a1.y == c2.y) || (a2.x == c2.x && a2.y == c2.y))
            {
                c2.x = rnd.Next(0, 7);
                c2.y = rnd.Next(1, 6);
            }
        }

        public static int Contar(bool[,] tablero)
        {
            int contador = 0;
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (tablero[i, j] == true)
                        contador++;
                }
            }
            return contador;
        }

        public static void Imprimir(bool[,] tablero)
        {
            
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    Console.WriteLine(tablero[j, i]);
                }
                Console.WriteLine("\n");
            }
        }
    }   
}
