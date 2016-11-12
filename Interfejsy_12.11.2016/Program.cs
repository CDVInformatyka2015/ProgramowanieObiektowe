using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy_12._11._2016
{
    class Program
    {
        static void Main(string[] args)
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
