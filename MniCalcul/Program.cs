using System.Text.RegularExpressions;

namespace MniCalcul
{
    internal class Program
    {

        enum operateurs
        {
            addition = 1, soustraction = 2, multiplication = 3, division = 4
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.run();
        }

        public void run()
        {
            intro();
            saisi();
        }

        public void intro()
        {
            Console.WriteLine("Calculatrice!");
            Console.WriteLine("Tu peux faire une addition(1), une soustraction(2), une multiplication(3) ou une division(4)");
            Console.WriteLine("Qu'est-ce que tu veux faire ?");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Soustraction");
            Console.WriteLine("3. Multiplicatiion");
            Console.WriteLine("4. Division");
        }

        public int saisi()
        {
            string? a = Console.ReadLine();
            int b;
            while (!int.TryParse(a, out b))
            {
                Console.WriteLine("Retry");
                a = Console.ReadLine();
            }
            return validation(b);
        }

        public int validation(int a)
        {
            if (0 < a && a < 5)
            {
                return a;
            }
            else return -1;
        }





    }
}