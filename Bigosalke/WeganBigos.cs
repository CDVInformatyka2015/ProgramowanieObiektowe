using System;
using System.Threading;

namespace Bigosalke
{
    class WeganBigos:Bigos
    {
        public WeganBigos()
        {
            this.title = "Wegański bigos!";
            this.bigosUrl = "http://blonve.pl/wp-content/uploads/2015/08/IMG_1242.jpg";
            this.petoKielbasy = 0;
            this.wolowina = 0;
            this.boczek = 0;
            this.zacznij();
        }
    }
}