using System;
using System.Collections;

namespace Interfejsy_12._11._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            //runBigos();
            dawajBigos();
            Console.ReadKey();
        }

        private static void dawajBigos()
        {
            ArrayList lista = new ArrayList();
            bool status = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Każdy składnik zatwierdzasz Enterem, jeśli chcesz zakończyć dodawanie składników - wpisz 'koniec'");
                Console.Write("Jaki składnik: ");
                string skladnik = Console.ReadLine();
                if (skladnik == "koniec")
                {
                    status = false;
                    break;
                }
                lista.Add(skladnik);
            } while (status);

            IEnumerator e = lista.GetEnumerator();
            Console.Clear();
            Console.WriteLine("A oto i lista składników!");
            while (e.MoveNext())
            {
                Console.WriteLine(">" + e.Current);
            }
        }

        private static void runBigos()
        {
            Bigos bigos = new Bigos(true);
            Console.Clear();
            bigos.gotuj();
            Console.Clear();
            bigos.dodajSkladniki();
            Console.Clear();
            bigos.gotuj();
            Console.Clear();
            if (bigos.czyUgotowano())
            {
                Console.WriteLine("GOTOWY BIGOSIK!");
            }
            else
            {
                Console.WriteLine("Niestety! Bigos nie jest gotowy!");
            }
        }
    }
}
