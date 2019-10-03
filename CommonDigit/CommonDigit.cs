using System;
using System.Collections.Generic;

namespace CommonDigit
{
    class CommonDigit
    {
        static void Main(string[] args)
        {
            int[] tmpTab = new int[10];
            int N = 0;

            do
            {
                N = int.Parse(Console.ReadLine());
            } while (N < 2 || N > 20);


            string[] helpTab = Console.ReadLine().Split(' ');
            string[] numbers = new string[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = helpTab[i];
            }

            List<string> separatedNumbers = SeparatedNumbers(numbers);

            foreach (string number in separatedNumbers)
            {
                string[] digits = number.Split(' ');
                foreach (string digit in digits)
                {
                    for (int i = 0; i < tmpTab.Length; i++)
                    {
                        if (digit.Contains(Convert.ToString(i)))
                        {
                            tmpTab[i]++;
                        }
                    }
                }
            }

            int score = 0;
            int max = 0;

            for (int i = 0; i < tmpTab.Length; i++)
            {
                if (tmpTab[i] >= max)
                {
                    max = tmpTab[i];
                    score = i;
                }
            }
            
            Console.WriteLine(score);
        }
        
        private static List<string> SeparatedNumbers(string[] tab)
        {
            List<string> stringList = new List<string>();
            char[] tmpTab;
            String separateNumbers = "";

            for (int i = 0; i < tab.Length; i++)
            {
                tmpTab = tab[i].ToCharArray();

                for (int j = 0; j < tmpTab.Length; j++)
                {
                    separateNumbers += tmpTab[j] + " ";
                }

                stringList.Add(separateNumbers);
                separateNumbers = "";
            }

            return stringList;
        }
        
    }
}