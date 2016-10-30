using System;
using System.Diagnostics;
using System.Threading;

namespace Bigosalke
{
    class Bigos
    {
        protected string _bigosUrl = "http://rafalkosik.com/wp-content/files/photos/091216_bigos_22.jpg";
        protected string _title = "Bigos";

        protected float _kapusta = 1.5F;
        protected float _kiszonaKapusta = 0;
        protected float _grzyby = 0.5F;
        protected float _suszoneGrzyby = 0;
        protected float _sliwki = 0.5F;
        protected float _suszoneSliwki = 0;

        protected int _cebule = 2;
        protected int _krojoneCebule = 0;
        protected int _lyzkiOleju = 2;
        protected int _petoKielbasy = 1;
        protected int _krojonePetoKielbasy = 0;
        protected int _wolowina = 250;
        protected int _krojonaWolowina = 0;
        protected int _boczek = 100;
        protected int _krojonyBoczek = 0;
        protected int _czerwoneWino = 250;
        protected int _lyzkiKoncentratu = 3;
        protected int _liscieLaurowe = 3;
        protected int _kminek = 1;
        protected int _majeranek = 1;

        protected bool _sol_i_pieprz = true;

        public Bigos()
        {
        }

        protected void zacznij()
        {
            Console.WriteLine(_title);
            Thread.Sleep(1000);
            writeLine("Na początek kisimy kapustę!", true);
            kiszenieKapusty();
            writeLine("Teraz suszymy grzyby oraz sliwki!!!", true);
            suszenieGrzybow();
            suszenieSliwek();
            if (_petoKielbasy>0 && _wolowina>0)
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
            pokazBigos(_bigosUrl);
        }

        private void cutWolowina()
        {
            _krojonaWolowina = _wolowina;
            loading("Krojenie wolowiny");
        }

        private void kiszenieKapusty()
        {
            _kiszonaKapusta = _kapusta;
            loading("Kiszenie kapusty");
        }

        private void suszenieGrzybow()
        {
            _suszoneGrzyby = _grzyby;
            loading("Suszenie grzybów");
        }

        private void suszenieSliwek()
        {
            _suszoneSliwki = _sliwki;
            loading("Suszenie śliwek");
        }

        private void cutKielbasa()
        {
            _krojonePetoKielbasy = _petoKielbasy;
            loading("Krojenie pęta kiełbasy");
        }

        private void cutCebula()
        {
            _krojoneCebule = _cebule;
            loading("Krojenie cebuli");
        }

        private void cutBoczek()
        {
            _krojonaWolowina = _wolowina;
            loading("Krojenie wołowiny");
        }

        private void addDoGarnka()
        {
            Console.WriteLine("+ Kiszona kapusta: " + _kiszonaKapusta + "kg");
            Console.WriteLine("+ Krojone pęto kiełbasy: " + _krojonePetoKielbasy + "kg");
            Console.WriteLine("+ Suszone grzyby: " + _suszoneGrzyby + " garści");
            Console.WriteLine("+ Suszone śliwki: " + _suszoneSliwki + " garści");
            Console.WriteLine("+ Krojone cebule: " + _krojoneCebule);
            Console.WriteLine("+ Olej: " + _lyzkiOleju + " łyżki");
            Console.WriteLine("+ Krojona Wołowina: " + _krojonyBoczek + "kg");
            Console.WriteLine("+ Czerwone Wino: " + _czerwoneWino + "ml");
            Console.WriteLine("+ Łyżki koncentratu: " + _lyzkiKoncentratu + " łyżki");
            Console.WriteLine("+ Liście laurowe: " + _liscieLaurowe);
            Console.WriteLine("+ kminek: " + _kminek);
            Console.WriteLine("+ Majeranek: " + _majeranek);
            if (_sol_i_pieprz)
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
