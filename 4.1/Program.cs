using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //20
            Console.WriteLine("N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            Random rnd = new Random();
            int K = 0;
            Console.WriteLine("mas");
            for (int i = 0; i < N; i++)
            {
                mas[i] = rnd.Next(-10, 11);
                Console.Write(mas[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("mas2");
            for (int i = 0; i < N - 1; i++)
            {
                if (mas[i] < mas[i + 1])
                {
                    Console.Write(mas[i] + "\t");
                    K = K + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Кол-во элементов: " + K);
        }
    }
}
