namespace P_App.Web
{
    internal class formatif1lol
    {
        //Convertisseur (Celcius, Kelvin et Fahrenheit)


        // 0C -> 273,15K 
        public void CAK(double celcius)
        {
            double kelvin = celcius + 273,15;

            Console.WriteLine(celcius + "°C = " + kelvin + " Kelvin");
        }

        // C -> F = (0°C × 9/5) + 32 = 32°F
        public void CAF(double celcius)
        {
            double fahrenheit = ( celcius * (9/5)) + 32;

            Console.WriteLine(celcius + "°C = " + fahrenheit + "°F");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("test hot dog");
            Celcius c = new Celcius();

            CAK(0);
            CAF(0);
        }
    }
}