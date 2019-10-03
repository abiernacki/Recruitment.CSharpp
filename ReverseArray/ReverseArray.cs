using System;

namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] tab = Console.ReadLine().Split(' ');

            for (int i = (N - 1); i >= 0; i--)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }
    }
}