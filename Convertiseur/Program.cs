using System.Text.RegularExpressions;

namespace Convertiseur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();
            p.run();
        }


        public double saisi()
        {
            Console.WriteLine("Veuillez taper un nombre représentant des degrés");

            var a = Console.ReadLine();
            double d;
            while (!double.TryParse(a, out d))
            {
                Console.WriteLine("YO big ta pas compris dumbass");
                a = Console.ReadLine();
            }
            return d;
        }

        public double convK(double c)
        {
            return c + 273.15;
        }

        public double convF(double c)
        {
            return (c * (9 / 5)) + 32;
        }

        public bool whichOne()
        {
            Console.WriteLine("Tu veux le convertir en kelvin ou en Fahrenheit ?");
            string ans = Console.ReadLine();
            ans = ans.ToLower();
            Regex a = new Regex("[kelvin]");
            MatchCollection matchCollection = a.Matches(ans);
            return matchCollection.Count > 4;
        }


        public void run()
        {
            double a = saisi();
            double ans;
            string fin;
            if (whichOne())
            {
                ans = convK(a);
                fin = "kelvin";
            }
            else
            {
                ans = convF(a);
                fin = "fahreneith";
            }

            Console.WriteLine($"{ans} degrée {fin} genre dude");
        }
    }
}