using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace Permutation
{
    class Permutation
    {
        static void Main(string[] args)
        {
            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();

            string[] firstTab = Console.ReadLine().Split(' ');
            string[] secondTab = Console.ReadLine().Split(' ');

            for (int i = 0; i < firstTab.Length; i++)
            {
                firstList.Add((firstTab[i]));
                secondList.Add((secondTab[i]));
            }
            
            firstList.Sort();
            secondList.Sort();

            string tmp1 = "";
            string tmp2 = "";

            for (int i = 0; i < firstList.Count; i++)
            {
                tmp1 += firstList[i];
                tmp2 += secondList[i];
            }

            if (tmp1.Equals(tmp2))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}