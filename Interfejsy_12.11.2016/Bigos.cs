using System;
using System.Threading;

namespace Interfejsy_12._11._2016
{
    class Bigos : IGotowanie
    {
        protected bool skladniki = false;
        protected bool dodanoSkladniki = false;
        protected bool ugotowano = false;

        public Bigos(bool skladniki)
        {
            this.skladniki = skladniki;
        }

        private void loading(string v)
        {
            Console.WriteLine("=================================");
            Console.WriteLine(v);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("█");
                Thread.Sleep(100);
            }
            Console.WriteLine("\nGOTOWE!");

            Thread.Sleep(1000);
        }

        public void dodajSkladniki()
        {
            if (this.skladniki)
            {
                this.loading("Dodawanie składników");
                this.dodanoSkladniki = true;
                Console.WriteLine("Dodano składniki!");
            }
            else
            {
                Console.WriteLine("Nie ma czym gotować!");
            }
            Console.ReadKey();
        }

        public void gotuj()
        {
            if (this.skladniki && this.dodanoSkladniki)
            {
                this.loading("Trwa gotowanie!");
                this.ugotowano = true;
                Console.WriteLine("Ugotowano pomyślnie!");
            }
            else
            {
                Console.WriteLine("Nie dodałeś składników!");
            }
            Console.ReadKey();
        }

        public bool czyUgotowano()
        {
            if (this.dodanoSkladniki == true && this.ugotowano == true)
            {
                return true;
            }

            return false;
        }
    }
}
