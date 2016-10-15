using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMaKtora
{
    class Program
    {
        static string slowo = "";
        static string[] array;

        static void Main(string[] args)
        {
            Console.Write("Podaj zdanie, czy cuś: ");
            slowo = readFromUser();
            Console.Write("Wymieszać tablicę: ");
            string rand = readFromUser();
            int randum;
            Int32.TryParse(rand, out randum);
            array = toArray(slowo);
            Console.WriteLine("Liczba słów: " + array.Count());
            Console.WriteLine("Tablica wygląda następująco");
            showArray(array,randum);
            Console.ReadKey();
        }

        private static void showArray(string[] array, int random = 0)
        {
            if (random == 1)
            {
                Random rnd = new Random();
                array = array.OrderBy(x => rnd.Next()).ToArray();
            }
            foreach (var item in array.Select((value, index) => new { value, index }))
            {
                Console.WriteLine(item.index + 1 + " | " + item.value);
            }
        }

        private static string[] toArray(string slowo)
        {
            array = slowo.Split();
            return array;
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
