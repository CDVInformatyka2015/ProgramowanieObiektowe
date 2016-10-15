using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /*
     * Program pobiera od użytkownika liczbę, a następnie rysuje kwadrat z gwiazdek. Awesome!
     */
    class Program
    {
        private const string ZNAK = "* ";

        static void Main(string[] args)
        {
            Console.Title = "Konsola 15-10-2016";
            Console.Write("Wpisz ilość gwiazdek: ");
            int liczbaGwiazdek = readFromUser();
            Console.Clear();
            printStars(liczbaGwiazdek);
            Console.ReadKey();
        }

        public static int readFromUser()
        {
            string text;
            int result;

            try
            {
                text = Console.ReadLine();
                Int32.TryParse(text, out result);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return 0;
        }

        private static void printStars(int stars)
        {
            Random r = new Random();
            for (int i = 1; i <= stars; i++)
            {
                for (int j = 1; j <= stars; j++)
                {
                    Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                    Console.Write(ZNAK);
                }
                Console.Write("\n");
            }
        }
    }
}
