using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace example_4_01;
class Program
{
    static void Main(string[] args)
    {
        Write("Введите количество строк: ");
        int row = int.Parse(ReadLine());
        Write("Введите количество столбцов: ");
        int col = int.Parse(ReadLine());

        int[,] matrix = new int[row, col];

        Random random = new Random();

        int s = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = random.Next(10);
                s += matrix[i, j];
                Write($"{matrix[i, j]}");
            }
           
           WriteLine();

        }
        WriteLine($"\nсумма всех элементов матрицы равна = {s}");
    }
}

