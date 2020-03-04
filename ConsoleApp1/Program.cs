using System;

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
                    else if (p.ganoVertical(tablero)) {
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
            } while (true);

        }


        public  bool ganoHorizontal(string[,] a)
        {
            int i = 0;
            int j = 0;
            while (i < 3) {
                if ((a[i, j] == a[i, j + 1]) && (a[i, j + 2] == a[i, j]))
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public  bool ganoVertical(string[,] a)
        {
            int i = 0;
            int j = 0;
            while (i < 3) {
                if ((a[i, j] == a[i + 1, j]) && (a[i + 2, j] == a[i, j]))
                {
                    return true;
                }
                j++;
            }
            return false;
        }

        public  bool ganoDiagonal(string[,] a)
        {
            int i = 0;
            int j = 0;
            if ((a[i, j] == a[i + 1, j + 1]) && (a[i + 2, j + 2] == a[i, j]))
            {
                return true;
            }
            else if ((a[i, j + 2] == a[i + 1, j + 1]) && (a[i + 2, j] == a[i, j])) {
                return true;
            }
            return false;
        }
    } 
}
