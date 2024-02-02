using System.Text.RegularExpressions;

namespace Convertiseur
{
    internal class Program
    {
        //Convertisseur (Celcius, Kelvin et Fahrenheit)


        // 0C -> 273,15K = 0°C + 273,15
        public String CAK(double c)
        {
            double kelvin = c + 273.15;
            String message = c + "°C = " + kelvin + " Kelvin";

            return message;
        }

        
        public String CAF(double c)
        {
            // 0C -> 32F = (0°C × 9/5) + 32
            double fahrenheit = (c * (9 / 5)) + 32;
            String message = c + "°C = " + fahrenheit + "°F";
            
            return message;
        }

        static void Main(string[] args)
        {
            Program celcius = new Program();



            Console.WriteLine(celcius.CAK(1));
            Console.WriteLine(celcius.CAF(2));
            


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