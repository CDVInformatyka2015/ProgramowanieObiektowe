using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa_15_10_2016
{
    class Program
    {
        private static int szanseCounter = 11;
        private static string haslo;
        private static string[] hasloArray;
        private static string[] hasloEncoded;

        static void Main(string[] args)
        {
            start();
            Console.ReadKey();
        }

        private static void start()
        {
            Console.Clear();
            Console.Write("Podaj hasło: ");
            haslo = readFromUser();
            hasloArray = splitHaslo(haslo);
            hasloEncoded = encodeHaslo(hasloArray);
            writeInfo();
        }

        private static void writeInfo(bool status = false)
        {
            Console.Clear();
            if (status)
            {
                Console.WriteLine("Trafiłeś!");
            } else
            {
                szanseCounter--;
                if (szanseCounter < 1)
                {
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Masz jeszcze " + szanseCounter + " prób!");
            foreach (var item in hasloEncoded)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            newChar();
        }

        private static void newChar()
        {
            Console.WriteLine("Podaj kolejny znak!");
            string znak = readFromUser();
            checkTrue(znak);
        }

        private static void checkTrue(string znak)
        {
            bool yay = false;
            for (int i = 0; i < hasloArray.Length; i++)
            {
                if (znak == hasloArray[i])
                {
                    hasloEncoded[i] = hasloArray[i];
                    yay = true;
                }
            }
            writeInfo(yay);
        }

        private static string[] encodeHaslo(string[] hasloArray)
        {
            string[] enc = new string[hasloArray.Count()];
            Array.Copy(hasloArray, enc, hasloArray.Count());
            for (int i = 0; i < hasloArray.Count(); i++)
            {
                enc[i] = "_";
            }
            return enc;
        }

        private static string[] splitHaslo(string haslo)
        {
            return haslo.ToCharArray().Select(c => c.ToString()).ToArray();
        }

        private static string readFromUser()
        {
            string text;
            try
            {
                text = Console.ReadLine();
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return "";
        }
    }
}
