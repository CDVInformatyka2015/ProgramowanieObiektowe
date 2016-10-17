using System;
using System.Linq;

namespace PracaDomowa_15_10_2016
{
    class Program
    {
        private static int _szanseCounter = 11;
        private static string _haslo;
        private static string[] _hasloArray;
        private static string[] _hasloEncoded;

        static void Main(string[] args)
        {
            start();
            Console.ReadKey();
        }

        private static void start()
        {
            Console.Clear();
            Console.Write("Podaj hasło: ");
            _haslo = readFromUser();
            _hasloArray = splitHaslo(_haslo);
            _hasloEncoded = encodeHaslo(_hasloArray);
            writeInfo();
        }

        private static void writeInfo(bool status = false)
        {
            Console.Clear();
            if (Enumerable.SequenceEqual(_hasloArray, _hasloEncoded))
            {
                Console.WriteLine("Gratulacje! Hasło to: " + _haslo);
                Console.WriteLine("Wyłącz program, by zakończyć grę lub naciśnij dowolny klawisz");
                renderWisielec(_szanseCounter);
                Console.ReadKey();
                start();
            }
            if (status)
            {
                Console.WriteLine("Trafiłeś!");
            } else
            {
                _szanseCounter--;
                if (_szanseCounter < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Przegrałeś!");
                    Console.WriteLine("Wyłącz program, by zakończyć grę lub naciśnij dowolny klawisz");
                    renderWisielec(0);
                    Console.ReadKey();
                    start();
                }
            }
            Console.WriteLine("Masz jeszcze " + _szanseCounter + " prób!");
            foreach (var item in _hasloEncoded)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            renderWisielec(_szanseCounter);
            newChar();
        }

        private static void renderWisielec(int v)
        {
            switch (v)
            {
                case 0: Console.WriteLine(" _______\n |     |\n |     O\n |    /|\\\n |    / \\\n/|\\"); break;
                case 1: Console.WriteLine(" _______\n |     |\n |     O\n |    /|\\\n |    /\n/|\\"); break;
                case 2: Console.WriteLine(" _______\n |     |\n |     O\n |    /|\\\n |\n/|\\"); break;
                case 3: Console.WriteLine(" _______\n |     |\n |     O\n |    /|\n |\n/|\\"); break;
                case 4: Console.WriteLine(" _______\n |     |\n |     O\n |     |\n |\n/|\\"); break;
                case 5: Console.WriteLine(" _______\n |     |\n |     O\n |\n |\n/|\\"); break;
                case 6: Console.WriteLine(" _______\n |     |\n |\n |\n |\n/|\\"); break;
                case 7: Console.WriteLine(" _______\n |\n |\n |\n |\n/|\\"); break;
                case 8: Console.WriteLine("\n |\n |\n |\n |\n/|\\"); break;
                case 9: Console.WriteLine("\n\n\n\n\n/|\\"); break;
                case 10: Console.WriteLine("\n\n\n\n\n"); break;
                    //default: Console.WriteLine("Czysto");
            }
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
            for (int i = 0; i < _hasloArray.Length; i++)
            {
                if (znak == _hasloArray[i])
                {
                    _hasloEncoded[i] = _hasloArray[i];
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
