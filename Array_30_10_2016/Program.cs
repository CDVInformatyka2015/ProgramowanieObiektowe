using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_30_10_2016
{
    class Program
    {
        private static string[] _tablica = new string[1];

        static void Main(string[] args)
        {
            int i = 0;
            string key;
            do
            {
                Console.Clear();
                Console.Write("Podaj znak: ");
                key = Console.ReadLine();

                if (key == "0")
                {
                    break;
                }

                //string[] temp = new string[i+1];
                _tablica = saveTable(_tablica);
                _tablica[i] = key;
                i++;
            } while (true);
            readTable(_tablica);
            Console.ReadKey();
        }

        private static string[] saveTable(string[] temp)
        {
            string[] wroc = new string[temp.LongLength+1];
            foreach (var item in temp.Select((value, index) => new { value, index }))
            {
                wroc[item.index] = item.value;
            }
            return wroc;
        }

        private static void writeProblem(string v)
        {
            Console.WriteLine("\n===\n" + v + "\n===\n");
            Console.ReadKey();
        }

        private static void readTable(string[] _tablica)
        {
            Console.Clear();
            foreach (var item in _tablica)
            {
                Console.WriteLine(item);
            }
        }
    }
}
