using System;

namespace FindingPrimes
{
    class FindingPrimes
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < T; i++)
            {
                String[] tmpTab = Console.ReadLine().Split(' ');
                int a = int.Parse(tmpTab[0]);
                int b = int.Parse(tmpTab[1]);

                for (int j = a; j <= b; j++)
                {
                    if (isFirst(j))
                    {
                        counter++;
                    }
                }
                
                Console.WriteLine(counter);
                counter = 0;
            }
        }

        public static Boolean isFirst(int a)
        {
            if (a == 1)
            {
                return false;
            }

            for (int i = 2; i < (a/2) + 1; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}