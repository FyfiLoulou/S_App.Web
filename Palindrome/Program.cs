using Microsoft.Win32.SafeHandles;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();
            p.isPalindrome(p.saisi());
        }


        public bool isPalindrome(string mot)
        {
            bool isPalindrome = true;
            for (int i = 0; i < mot.Length; i++)
            {
                if (!(mot[i] == mot[mot.Length - i - 1]))
                {
                    isPalindrome = false;
                    Console.WriteLine($"{mot} n'est pas un palindrome");
                    break;
                }
            }

            if (isPalindrome)
            {
                affichage(mot);
            }

            return isPalindrome;
        }

        public void affichage(string palindrome)
        {
            string p = "";
            foreach (char l in palindrome)
            {
                Console.WriteLine(p += l);
            }
        }

        public string saisi()
        {
            Console.WriteLine("Donne moi un mot genre tse que c'est un palindrome genre");
            string a = Console.ReadLine();
            return a;
        }
    }
}