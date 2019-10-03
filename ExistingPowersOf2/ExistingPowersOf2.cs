using System;
using System.Collections.Generic;

namespace ExistingPowersOf2
{
    class ExistingPowersOf2
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> binaryNumbers = new List<string>();
            List<string> trimNumbers = new List<string>();
            List<int> score = new List<int>();
            int counter = 0;
            int indexGreatestpowerTwo = 0;
            
            numbers.Add(3);
            numbers.Add(1);
            numbers.Add(2);
            
            numbers.Sort();
            numbers.Reverse();

            foreach (int var in numbers)
            {
                binaryNumbers.Add(Convert.ToString(var,2));
            }

            foreach (string var in binaryNumbers)
            {
                trimNumbers.Add(var.Trim('0'));
            }

            foreach (string var in trimNumbers)
            {
                if (var.Equals("1"))
                {
                    indexGreatestpowerTwo = counter;
                    int greatestPowerTwo = numbers[indexGreatestpowerTwo];

                    while (greatestPowerTwo != 0)
                    {
                        score.Add(greatestPowerTwo);
                        greatestPowerTwo = greatestPowerTwo / 2;
                    }


                    score.Reverse();
                    foreach (int var1 in score)
                    {
                        if (var1 != numbers[indexGreatestpowerTwo])
                        {
                            Console.Write(var1 + ", ");
                        }
                        else
                        {
                            Console.WriteLine(var1);
                        }
                    }

                    break;
                }
                counter++;
            }

            if (score.Count == 0)
            {
                Console.WriteLine("NA");
            }

        }
        
        
    }
}