using System;
using System.Diagnostics;
using System.Threading;

namespace Bigosalke
{
    class Bigos
    {
        private float kapusta = 1.5F;
        private float kiszonaKapusta = 0;
        private float grzyby = 0.5F;
        private float suszoneGrzyby = 0;
        private float sliwki = 0.5F;
        private float suszoneSliwki = 0;

        private int cebule = 2;
        private int krojoneCebule = 0;
        private int lyzkiOleju = 2;
        private int petoKielbasy = 1;
        private int krojonePetoKielbasy = 0;
        private int wolowina = 250;
        private int krojonaWolowina = 0;
        private int boczek = 100;
        private int krojonyBoczek = 0;
        private int czerwoneWino = 250;
        private int lyzkiKoncentratu = 3;
        private int liscieLaurowe = 3;
        private int kminek = 1;
        private int majeranek = 1;

        private bool sol_i_pieprz = true;

        public Bigos()
        {
            Console.WriteLine("BIGOS");
            Thread.Sleep(1000);
            writeLine("Na początek kisimy kapustę!",true);
            kiszenieKapusty();
            writeLine("Teraz suszymy grzyby oraz sliwki!!!", true);
            suszenieGrzybow();
            suszenieSliwek();
            writeLine("Teraz czas pociac kielbasę, cebulę, wolowinę!", true);
            cutKielbasa();
            cutCebula();
            cutWolowina();
            writeLine("Teraz czas na dodanie wszystkiego!", true);
            addDoGarnka();
            writeLine("Więc skoro już wszystko jest w garze to gotujemy! <3", true);
            loading("GOTOWANIE");
            writeLine("Odstaw na kilka dni. Niech dojrzeje <3", true);
            loading("ODSTAWIENIE");
            writeLine("Gotowe! Smacznego bigosu!", true);
            pokazBigos();
        }

        private void kiszenieKapusty()
        {
            kiszonaKapusta = kapusta;
            loading("Kiszenie kapusty");
        }

        private void suszenieGrzybow()
        {
            suszoneGrzyby = grzyby;
            loading("Suszenie grzybów");
        }

        private void suszenieSliwek()
        {
            suszoneSliwki = sliwki;
            loading("Suszenie śliwek");
        }

        private void cutKielbasa()
        {
            krojonePetoKielbasy = petoKielbasy;
            loading("Krojenie pęta kiełbasy");
        }

        private void cutCebula()
        {
            krojoneCebule = cebule;
            loading("Krojenie cebuli");
        }

        private void cutWolowina()
        {
            krojonaWolowina = wolowina;
            loading("Krojenie wołowiny");
        }

        private void addDoGarnka()
        {
            Console.WriteLine("+ Kiszona kapusta: " + kiszonaKapusta + "kg");
            Console.WriteLine("+ Krojone pęto kiełbasy: " + krojonePetoKielbasy + "kg");
            Console.WriteLine("+ Suszone grzyby: " + suszoneGrzyby + " garści");
            Console.WriteLine("+ Suszone śliwki: " + suszoneSliwki + " garści");
            Console.WriteLine("+ Krojone cebule: " + krojoneCebule);
            Console.WriteLine("+ Olej: " + lyzkiOleju + " łyżki");
            Console.WriteLine("+ Krojona Wołowina: " + krojonyBoczek + "kg");
            Console.WriteLine("+ Czerwone Wino: " + czerwoneWino + "ml");
            Console.WriteLine("+ Łyżki koncentratu: " + lyzkiKoncentratu + " łyżki");
            Console.WriteLine("+ Liście laurowe: " + liscieLaurowe);
            Console.WriteLine("+ kminek: " + kminek);
            Console.WriteLine("+ Majeranek: " + majeranek);
            if (sol_i_pieprz)
            {
                Console.WriteLine("+ Sól i pieprz");
            }
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
            //Console.ReadKey();
        }

        private void pokazBigos()
        {
            Console.ReadKey();
            Process.Start("http://rafalkosik.com/wp-content/files/photos/091216_bigos_22.jpg");
        }

        private void writeLine(string v, bool clear = false)
        {
            //Console.ReadKey();
            if (clear)
            {
                Console.Clear();
            }
            Console.WriteLine(v);
        }
    }
}
