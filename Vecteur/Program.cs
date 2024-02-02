using System.Collections;

namespace Vecteur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ArrayList b = initialisation();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
            trierArray(b);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------");
            
        }

        private static ArrayList initialisation()
        {
            ArrayList list = new ArrayList();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(33, 127));
            }
            affichage(list);

            return list;
        }

        private static void trierArray(ArrayList list)
        {
            ArrayList a = new ArrayList();
            foreach (int i in list)
            {
                a.Add(i);
            }
            a.Sort();
            affichage(a);
        }


        private static void affichage(ArrayList list)
        {
            foreach (int i in list)
            {
                Console.Write($"{i}, "); 
            }
            Console.WriteLine();
        }


    }
}