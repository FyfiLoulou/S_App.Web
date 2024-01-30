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

    }
}