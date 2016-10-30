using System;
using System.Threading;

namespace Bigosalke
{
    class WeganBigos:Bigos
    {
        protected string _zwierzeta = "Zwierzęta hodowane na mięso (a także na mleko i jaja) spędzają swoje życie w warunkach o wiele gorszych od tych, które sobie wyobrażamy. Zielone pastwiska i idylliczne wiejskie scenki to przeszłość. Większość zwierząt hodowanych na mięso żyje na przemysłowych fermach; ściśnięte w brudnych, pozbawionych okien barakach, metalowych klatkach, kojcach porodowych i innych systemach ograniczających ruch. Te zwierzęta nigdy nie będą ryć w prawdziwej ziemi, nie założą rodzin, nie zbudują gniazd – nie zrobią nic, co jest dla nich naturalne. Nie będą nawet miały okazji oddychać świeżym, czystym powietrzem czy poczuć słońca na skórze – aż do dnia, kiedy zostaną załadowane na ciężarówki i przewiezione do rzeźni. Zobaczcie spot przygotowany przez organizację Mercy of Animals. Zwierzęta żyjące na przemysłowych fermach nie są prawnie chronione przed okrucieństwem, które w przypadku psów i kotów byłoby przestępstwem. Są więc, zgodnie z prawem, poddawane okaleczaniu, manipulacjom genetycznym, zaniedbywane, faszerowane antybiotykami; hodowane tak intensywnie, że ich organizmy nie wytrzymują i często cierpią na bóle i złamania. Na końcu czeka okrutna rzeź. Ta różnica w traktowaniu zwierząt domowych i hodowlanych nie oznacza, że zwierzęta hodowlane są w jakimkolwiek stopniu mniej inteligentne czy zdolne do odczuwania bólu, co psy i koty, których cenimy sobie jako kompanów. Systemy wielkoprzemysłowego chowu wypracowane przez współczesne rolnictwo koncentrują się na zmaksymalizowaniu zysków przy jednoczesnej minimalizacji kosztów. Krowy, cielęta, świnie, kury, indyki, kaczki, gęsi i inne zwierzęta więzione są w małych klatkach, w zatłoczonych barakach, lub w brudnych tuczarniach. Nierzadko ich przestrzeń życiowa jest tak mała, że nie mogą się nawet obrócić czy wygodnie położyć. Pozbawione są możliwości nieograniczonego ruchu aby ich organizmy jak najwięcej energii przeznaczały na rozrost ciała, produkcję jaj czy mleka – wszystko przeznaczone do konsumpcji przez człowieka. Wielkie korporacje, które zarządzają większością ferm przemysłowych, ograniczają tą przestrzeń życiową w celach zwiększenia zysku chociaż wiedzą, że wiele zwierząt choruje i nawet umiera z tego powodu. Bardzo łatwo obejść można wprowadzony w Polsce zakaz karmienia zwierząt antybiotykami w celu przyśpieszenia ich wzrostu. Antybiotyki i inne leki są niezbędne, aby zwierzęta przeżyły w tak strasznych warunkach. Zwierzęta zostały również genetycznie zmodyfikowane, aby szybciej przybierały na masie lub aby produkowały więcej mleka i jaj, niż w warunkach naturalnych. Wiele zwierząt doznaje urazów kończyn z powodu swojej zbyt dużej wagi i umiera centymetry od wody i jedzenia. Cierpienie, jakiego doznają wszystkie zwierzęta na przemysłowych fermach jest takie samo. Jednak różne gatunki zwierząt cierpią z różnych powodów: \n\n>Kury zabijane dla mięsa są hodowane tak intensywnie, że ich serca, płuca i kończyny nie wytrzymują.\n>Kury znoszące jaja (kury nioski) żyją po sześć lub siedem w jednej klatce wielkości dużej szuflady. Klatki te ustawiane są rząd na rzędzie i w jednym przeraźliwie brudnym baraku żyć może nawet kilka tysięcy ptaków.\n>Krowy i byki hodowane na mięso są kastrowane a ich rogi – przycinane.\n>Krowy mleczne żyją w ciągłym cyklu ciąża–poród–laktacja po to, aby mogły wyprodukować nienaturalne wielką ilość mleka. Tuż po porodzie odbiera się im dzieci, które trafiają na bardzo okrutne fermy cieląt. Wszystko dla możliwości picia krowiego mleka.\n>Ciężarne świnie są przetrzymywane w kojcach tak małych, że nie mogą się obrócić ani wygodnie położyć.\n>Ryby hodowane na fermach spędzają całe życie w ciasnocie i brudzie. Wiele z nich cierpi z powodu infekcji pasożytów, chorób i wyniszczających urazów. Warunki na niektórych fermach są tak straszne, że nawet 40% ryb umiera zanim hodowcy zabiją je i zapakują.\n>Indykom obcina się dzioby, oczywiście bez znieczulenia. Wiele z nich cierpi z powodu niewydolności serca lub osłabiającego bólu nóg, które nie wytrzymują ciężaru przerośniętego ciała.\n\nprzez kilkadziesiąt godzin, niezależnie od pogody – do rzeźni. Zwierzęta, które przeżyją tą koszmarną podróż, skończą życie z poderżniętym gardłem, nierzadko w stanie pełnej przytomności. Wiele z nich jest również przytomnych gdy zanurzane są we wrzącą wodę w celu ułatwienia usunięcia piór czy sierści lub gdy ich ciała są pozbawiane skóry lub rozkrajane. Sprzeciw się okrucieństwu wobec zwierząt. Więcej o chowie przemysłowym przeczytaj tutaj Ściągnij (tutaj) również raport dotyczący długodystansowych transportów zwierząt. O prawach zwierząt przeczytasz na stronie Zeszytów Praw Zwierząt.";
        public WeganBigos()
        {
            _title = "Wegański bigos!";
            _bigosUrl = "http://blonve.pl/wp-content/uploads/2015/08/IMG_1242.jpg";
            _petoKielbasy = 0;
            _wolowina = 0;
            _boczek = 0;
            opowiedzJakToLepiejBycWeganemMimoZeLubiszMieso();
            zacznij();
        }

        private void opowiedzJakToLepiejBycWeganemMimoZeLubiszMieso()
        {
            foreach (var item in _zwierzeta)
            {
                Console.Write(item);
                Thread.Sleep(1);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}