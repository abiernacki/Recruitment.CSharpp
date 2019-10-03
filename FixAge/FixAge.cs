using System;

namespace FixAge
{
    class FixAge
    {
        static void Main(string[] args)
        {
            int[] tab = {5, 15, 25, 78, 59, 45};

            Fixage(tab);
        }

        public static void Fixage(int[] tab)
        {
            int[] tmpTab = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] >= 18 && tab[i] <= 60)
                {
                    tmpTab[i] = tab[i];
                }
            }

            int counter = 0;
            for (int i = 0; i < tmpTab.Length; i++)
            {
                if (tmpTab[i] != 0)
                {
                    if(i < (tmpTab.Length-1)) {
                        Console.Write(tmpTab[i] + ", ");
                    } else {
                        Console.Write(tmpTab[i]);
                    }
                    counter++;
                }
            }
            
            if (counter == 0)
            {
                Console.WriteLine("NA");
            }
        }
    }
}