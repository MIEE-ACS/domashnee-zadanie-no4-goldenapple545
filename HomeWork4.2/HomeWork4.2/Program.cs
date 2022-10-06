using System;
//using Internal;
using System.Collections.Generic;

namespace HomeWork4._2
{
    class Program
    {
        static int[,] randomMatrixInt(int n, int m) //Функция заполнения матрицы рандомными числами в диапозоне [-10, 10]
        {
            Random rnd = new Random();
            int[,] mas = new int[n, m];

            Console.WriteLine("Матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(-10, 10);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");

            return mas;
        }


        static void Main(string[] args)
        {
            int count = 0, maxN = -1, maxim = 0;



            Console.WriteLine("Введите кол-во столбцов:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во строк:");
            int n = int.Parse(Console.ReadLine());
            int[,] mas = randomMatrixInt(n, m);

            var setM = new HashSet<int>(); //Использую set для нахождения уникальных столбцов

            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] == 0) setM.Add(j); 

                    if (j != 0) 
                    {
                        if (mas[i, j] == mas[i, j - 1]) count++; //Определение одинаковых символов в строке
                    }
                    
                }
                if (count > maxim) 
                {
                    maxN = i + 1;
                    maxim = count;
                }
            }

            Console.WriteLine("Кол-во столбцов содержащих нулевой элемент: " + setM.Count);
            if (maxN == -1) Console.WriteLine("Такой строки нет");
            else Console.WriteLine("Строка с самой длинной серией одинаковых элементов: " + maxN);
            
        }
    }
}

