namespace MiniCalcul
{
    internal class Program
    {

        public enum Operateurs
        {
            additionner = '+',
            soustraire = '-',
            multiplier = '*',
            diviser = '/'
        };

        public double addition(double a, double b)
        {       
            return a + b;
        }

        public double soustraction(double a, double b)
        {
            return a - b;
        }

        public double multiplication(double a, double b)
        {
            return a * b;
        }

        public double division(double a, double b)
        {
            return a / b;
        }

        /*
        private Operateurs saisirOp(String message)     
        {

            

            return (Operateurs)message;
        }
        */


        static void Main(string[] args)
        {
            Console.WriteLine("=================================MiniCalcul=================================");

            while (true)
            {
                Console.WriteLine("Veuillez choisir un opérateur parmis les suivants\nAddition (+)\nSoustraction (-)\nMultiplication (*)\nDivision (/)");
                String op = Console.ReadLine();
                Console.WriteLine("Veuillez écrire votre premier nombre");
                double a = Console.Read();
                Console.WriteLine("Veuillez écrire votre deuxième nombre");
                double b = Console.Read();
                Console.WriteLine(a + " " + op + " " + b + " = " + "résultat ici");


                Console.WriteLine("============================================================================");
            }

        }
    }
}