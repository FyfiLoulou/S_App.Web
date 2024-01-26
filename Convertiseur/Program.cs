namespace Convertiseur
{
    internal class Program
    {
        //Convertisseur (Celcius, Kelvin et Fahrenheit)


        // 0C -> 273,15K 
        public String CAK(double c)
        {
            double kelvin = c + 273.15;
            String message = c + "°C = " + kelvin + " Kelvin";

            return message;
        }

        // C -> F = (0°C × 9/5) + 32 = 32°F
        public String CAF(double c)
        {
            double fahrenheit = (c * (9 / 5)) + 32;
            String message = c + "°C = " + fahrenheit + "°F";
            
            return message;
        }
        static void Main(string[] args)
        {
            Program celcius = new Program();

            Console.WriteLine(celcius.CAK(0.0));
            Console.WriteLine(celcius.CAF(0.0));
            

        }

    }
}