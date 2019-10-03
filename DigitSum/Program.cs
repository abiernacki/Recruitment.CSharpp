using System;
using System.Collections.Generic;

namespace DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] helpTab = Console.ReadLine().Split(' ');
            int index = GetIndex(N, helpTab);
            Console.WriteLine(index);
        }

        public static int GetIndex(int n, string[] helpTab)
        {
            string[] numbers = new string[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = helpTab[i];
            }
            
            List<string> separatedNumbers = SeparatedNumbers(numbers);

            int[] tmpTab = new int[10];
            int index = 0;
            int max = 0;
            int tmp = 0;

            foreach (string number in separatedNumbers)
            {
                string[] digits = number.Split(' ');
                int sum = 0;
                foreach (string digit in digits)
                {
                    for (int i = 0; i < tmpTab.Length; i++)
                    {
                        if (digit.Contains(Convert.ToString(i)))
                        {
                            sum += i;
                        }
                    }
                }

                if (sum > max)
                {
                    max = sum;
                    index = tmp;
                }

                tmp++;
            }

            return index;
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