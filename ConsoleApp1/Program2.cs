using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program2
    {
        int fila = 0;
        int columna = 0;
        static void Main(string[] args)
        {
            Program2 p = new Program2();
            string[,] tablero = new string[3, 3];
            int turno = 0;
            int casilla = 0;
            string actual = "";
            do
            {
                Console.Write("Digite la casilla que desea marcar");
                casilla = Convert.ToInt32(Console.ReadLine());
                p.ColumnaFila(casilla);
                if (turno % 2 == 0)
                {
                    tablero[p.fila, p.columna] = "x";
                    actual = "X";
                }
                else
                {
                    tablero[p.fila, p.columna] = "o";
                    actual = "o";
                }

                if (turno >= 4)
                {

                    if (p.GanoHorizontal(tablero))
                    {
                        Console.WriteLine("gano {0}", actual);
                        break;
                    }
                    else if (p.GanoVertical(tablero))
                    {
                        Console.WriteLine("gano {0}", actual);
                        break;
                    }
                    else if (p.GanoDiagonal(tablero))
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

        public void ColumnaFila(int x)
        {
            switch (x)
            {
                case 1:
                    this.fila = 0;
                    this.columna = 0;
                    break;
                case 2:
                    this.fila = 0;
                    this.columna = 1;
                    break;
                case 3:
                    this.fila = 0;
                    this.columna = 2;
                    break;
                case 4:
                    this.fila = 1;
                    this.columna = 0;
                    break;
                case 5:
                    this.fila = 1;
                    this.columna = 1;
                    break;
                case 6:
                    this.fila = 1;
                    this.columna = 2;
                    break;
                case 7:
                    this.fila = 2;
                    this.columna = 0;
                    break;
                case 8:
                    this.fila = 2;
                    this.columna = 1;
                    break;
                case 9:
                    this.fila = 2;
                    this.columna = 2;
                    break;
            }
        }

        public bool GanoHorizontal(string[,] a)
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

        public bool GanoVertical(string[,] a)
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

        public bool GanoDiagonal(string[,] a)
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
                if ((a[0, 2] == a[1, 1]) && (a[2, 0] == a[1, 1]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
