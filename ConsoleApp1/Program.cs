﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string[,] tablero = new string[3, 3];
            int turno = 0;
            int fila = 0;
            int columna = 0;
            string actual = "";
            do
            {
                Console.Write("Digite la fila que desea marcar");
                fila = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite la columna que desea marcar");
                columna = Convert.ToInt32(Console.ReadLine());
                if (turno % 2 == 0)
                {
                    tablero[fila, columna] = "x";
                    actual = "X";
                }
                else
                {
                    tablero[fila, columna] = "o";
                    actual = "o";
                }

                if (turno >= 4)
                {

                    if (p.ganoHorizontal(tablero))
                    {
                        Console.WriteLine("gano {0}", actual);
                        break;
                    }
                    else if (p.ganoVertical(tablero))
                    {
                        Console.WriteLine("gano {0}", actual);
                        break;
                    }
                    else if (p.ganoDiagonal(tablero))
                    {
                        Console.WriteLine("gano {0}", actual);
                        break;
                    }
                }
                turno++;
                if (turno == 9)
                {
                    Console.WriteLine("EMPATE");
                    break;
                }
            } while (true);

        }


        public bool ganoHorizontal(string[,] a)
        {
            int i = 0;
            int j = 0;
            while (i < 3)
            {
                if (a[i, j] != null && a[i, j + 1] != null && a[i, j + 2] != null)
                {
                    if ((a[i, j] == a[i, j + 1]) && (a[i, j + 2] == a[i, j]))
                    {
                        return true;
                    }
                }
                i++;
                j = 0;
            }
            return false;
        }

        public bool ganoVertical(string[,] a)
        {
            int i = 0;
            int j = 0;
            while (j < 3)
            {
                if (a[i, j] != null && a[i + 2, j] != null && a[i + 1, j] != null)
                {
                    if ((a[i, j] == a[i + 1, j]) && (a[i + 2, j] == a[i, j]))
                    {
                        return true;
                    }
                }
                j++;
                i = 0;
            }
            return false;
        }

        public bool ganoDiagonal(string[,] a)
        {
            if (a[0, 0] != null && a[1, 1] != null && a[2, 2] != null)
            {
                if ((a[0, 0] == a[1, 1]) && (a[2, 2] == a[0, 0]))
                {
                    return true;
                }
            }

            else if (a[2, 0] != null && a[1, 1] != null && a[0, 2] != null)
            {
                if ((a[0, 2] == a[1, 1]) && (a[2, 0] == a[0, 0]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

