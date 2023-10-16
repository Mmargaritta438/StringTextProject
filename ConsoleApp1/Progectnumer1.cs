using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Progectnumer1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of lines (введите количество строк): ");

            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the number of columns (введите количество столбцов): ");

            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            
            Console.WriteLine("fill the matrix with numbers (заполни матрицу числами)");

            int count = 0;
            
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                    if (mas[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("ready matri: "); //Matrix Output (Вывод Матрицы)
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //находим максимальный элемент в матрице
            //find the maximum element in the matrix
            int max = mas[0, 0];
            for (int i =0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mas[i, j] > max)
                        max = mas[i, j];

                }
            }
            Console.WriteLine("maximum value in matrix: {0}", max);
            Console.ReadLine();
        }
    }
}
