using System;
using System.Diagnostics;
using System.Threading;

namespace Bigosalke
{
    class Bigos
    {
        protected string bigosUrl = "http://rafalkosik.com/wp-content/files/photos/091216_bigos_22.jpg";
        protected string title = "Bigos";

        protected float kapusta = 1.5F;
        protected float kiszonaKapusta = 0;
        protected float grzyby = 0.5F;
        protected float suszoneGrzyby = 0;
        protected float sliwki = 0.5F;
        protected float suszoneSliwki = 0;

        protected int cebule = 2;
        protected int krojoneCebule = 0;
        protected int lyzkiOleju = 2;
        protected int petoKielbasy = 1;
        protected int krojonePetoKielbasy = 0;
        protected int wolowina = 250;
        protected int krojonaWolowina = 0;
        protected int boczek = 100;
        protected int krojonyBoczek = 0;
        protected int czerwoneWino = 250;
        protected int lyzkiKoncentratu = 3;
        protected int liscieLaurowe = 3;
        protected int kminek = 1;
        protected int majeranek = 1;

        protected bool sol_i_pieprz = true;

        public Bigos()
        {
        }

        protected void zacznij()
        {
            Console.WriteLine(title);
            Thread.Sleep(1000);
            writeLine("Na początek kisimy kapustę!", true);
            kiszenieKapusty();
            writeLine("Teraz suszymy grzyby oraz sliwki!!!", true);
            suszenieGrzybow();
            suszenieSliwek();
            if (petoKielbasy>0 && wolowina>0)
            {
                writeLine("Teraz czas pociac kielbasę, cebulę, wolowinę i boczek!", true);
                cutKielbasa();
                cutBoczek();
                cutWolowina();
            } else
            {
                writeLine("Teraz czas pociac cebulę!", true);
            }
            cutCebula();
            writeLine("Teraz czas na dodanie wszystkiego!", true);
            addDoGarnka();
            writeLine("Więc skoro już wszystko jest w garze to gotujemy! <3", true);
            loading("GOTOWANIE");
            writeLine("Odstaw na kilka dni. Niech dojrzeje <3", true);
            loading("ODSTAWIENIE");
            writeLine("Gotowe! Smacznego bigosu!", false);
            pokazBigos(bigosUrl);
        }

        private void cutWolowina()
        {
            krojonaWolowina = wolowina;
            loading("Krojenie wolowiny");
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

        private void cutBoczek()
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

        private void pokazBigos(string url)
        {
            Console.ReadKey();
            Process.Start(url);
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
