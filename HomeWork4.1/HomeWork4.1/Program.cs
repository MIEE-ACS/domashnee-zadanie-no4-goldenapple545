using System;

namespace HomeWork4._1
{
    class Program
    {
        static int[] randomMasInt(int n) //Функция заполнения массива рандомными числами в диапозоне [-10, 10]
        {
            Random rnd = new Random();
            int[] mas = new int[n];

            Console.WriteLine("Массив: ");
            for (int i = 0; i < n; i++) {
                mas[i] = rnd.Next(-10, 10);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine(" ");

            return mas;
        }


        static void Main(string[] args)
        {
            long prod = 1;
            bool flag = false;
            long sum = 0;

            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            int[] mas = randomMasInt(n); //Заполнение массива случайными числами

            for (int i = 0; i < n; i++) {
                if (mas[i] == 0 && flag == true) flag = false;
                if (mas[i] == 0 && sum == 0) flag = true;

                if (i % 2 == 0) prod *= mas[i];
                if (flag == true) sum += mas[i];
            }
            Console.WriteLine("Произведение равно: " + prod); //Вывод произведения элементов массива с четными номерами
            if (prod == 0) Console.WriteLine("Один из элементов с четным номером равен 0"); //Пояснение для пользователя
            Console.WriteLine("Сумма равна: " + sum); //Вывод суммы элементов

            Array.Sort(mas); //Сортировка
            Array.Reverse(mas); //Порядок по убыванию
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }

        }
    }
}

