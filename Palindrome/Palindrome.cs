using System;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            string[] letters =
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
                "m", "n", "o", "p", "r", "s", "t", "u", "w", "x", "y", "z"
            };


            string word = Console.ReadLine();
            word = word.ToLower();
            string word2 = "";
            char[] charTab = word.ToCharArray();


            var isNoPalindrome = IsNoPalindrome(charTab, word2, letters);

            if (isNoPalindrome)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }

        private static bool IsNoPalindrome(char[] charTab, string word2, string[] letters)
        {
            for (int i = 0; i < charTab.Length; i++)
            {
                word2 += charTab[i] + " ";
            }

            string[] wordTab = word2.Split(' ');
            string onlyLetters = "";

            for (int i = 0; i < wordTab.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (wordTab[i].Contains(letters[j]))
                    {
                        onlyLetters += wordTab[i];
                    }
                }
            }

            int length = onlyLetters.Length;
            int lastLetter = length - 1;
            Boolean isNoPalindrome = false;

            for (int i = 0; i < length; i++)
            {
                if (onlyLetters[i] != onlyLetters[lastLetter])
                {
                    isNoPalindrome = true;
                    break;
                }

                lastLetter--;
            }

            return isNoPalindrome;
        }
    }
}