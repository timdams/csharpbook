Onderstaande oplossing is niet 100% conform de opgave. Deze oplossing werd gemaakt in het hoorcollege en hier en daar werd er afgeweken van de opgave.

# Program.cs

```java
List<Mens> mensen = new List<Mens>();

for (int i = 0; i < 100000; i++)
{
    mensen.Add(new Mens(Geslacht.Vrouw));
}
for (int i = 0; i < 100000; i++)
{
    mensen.Add(new Mens(Geslacht.Man));
}

Mens.Simuleer(mensen, 10);
```

# Mens.cs

```java
using System;
using System.Collections.Generic;
using System.Text;

namespace gen
{
    enum Geslacht { Man, Vrouw }
    enum OogKleur { Blauw, Bruin, Groen, Rood, Geel }

    class Mens
    {
        static Random r = new Random();
        //Default constructor
        public Mens()
        {
            Generatie = 0;
            if (r.Next(0, 2) == 0)
                Geslacht = Geslacht.Vrouw;
            else Geslacht = Geslacht.Man;

            OogKleur = (OogKleur)r.Next(0, 4);

            int percentlengte = r.Next(0, 100);
            if (percentlengte < 5)
                MaxLengte = r.Next(40, 151);
            else if (percentlengte >= 95)
                MaxLengte = r.Next(210, 241);
            else
                MaxLengte = r.Next(151, 210);
        }

        //Overloaded constructor
        public Mens(OogKleur oogin, Geslacht geslin, int maxLengtein, int genin)
        {
            OogKleur = oogin;
            Geslacht = geslin;
            MaxLengte = maxLengtein;
            Generatie = genin;
        }

        public Mens(Geslacht geslin) : this()
        {
            Geslacht = geslin;
        }

        //Properties

        public int Generatie { get; private set; }
        public Geslacht Geslacht { get; private set; }
        public OogKleur OogKleur { get; private set; }
        private int maxLengte;


        public int MaxLengte
        {
            get { return maxLengte; }
            private set { if (value >= 30) maxLengte = value; }
        }

        public void ToonMens()
        {
            switch (OogKleur)
            {
                case OogKleur.Blauw:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case OogKleur.Bruin:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case OogKleur.Groen:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case OogKleur.Rood:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case OogKleur.Geel:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{MaxLengte / 100.0: 0.00} m, {Geslacht} ({Generatie})");

            Console.ResetColor();
        }

        public Mens Plantvoort(Mens man)
        {
            if (Geslacht == Geslacht.Vrouw && man.Geslacht == Geslacht.Man)// && this.Generatie == man.Generatie)
            {
                int lengteind = (man.MaxLengte + this.MaxLengte) / 2;
                OogKleur oogkind = this.OogKleur;
                if (r.Next(0, 2) == 0) oogkind = man.OogKleur;

                if (r.Next(0, 5) == 0) oogkind = OogKleur.Geel;

                Geslacht g = Geslacht.Man;
                if (r.Next(0, 2) == 0) g = Geslacht.Vrouw;

                return new Mens(oogkind, g, lengteind, Generatie + 1);

            }
            else return null;
        }

        public static void Simuleer(List<Mens> testlijst, int gentest = 5)
        {
            for (int i = 0; i < gentest; i++)
            {
                List<Mens> deKribbe = new List<Mens>();
                foreach (var mens in testlijst)
                {
                    int partner = r.Next(0, testlijst.Count);
                    Mens babynew = mens.Plantvoort(testlijst[partner]);
                    if (babynew != null)
                        deKribbe.Add(babynew);
                }
                //statistieken verkrijgen
                
                testlijst.AddRange(deKribbe);


            }
            GenereerStatistieken(testlijst, gentest);
            //foreach (var mens in testlijst)
            //{
            //    mens.ToonMens();
            //}
        }

        private static void GenereerStatistieken(List<Mens> deKribbe, int aantalgens)
        {
            for (int i = 0; i < aantalgens; i++)
            {
                int aantalVrouwen = 0;
                double gemiddeldeLengte = 0.0;
                int aantalinGen = 0;
                int aantalGeel = 0;
                foreach (var mens in deKribbe)
                {

                    if (mens.Generatie == i)
                    {
                        if (mens.OogKleur == OogKleur.Geel) aantalGeel++;
                        if (mens.Geslacht == Geslacht.Vrouw) aantalVrouwen++;

                        gemiddeldeLengte += mens.MaxLengte;
                        aantalinGen++;
                    }
                }

                gemiddeldeLengte = gemiddeldeLengte /aantalinGen;

                Console.WriteLine($"Generatie {i}");
                Console.WriteLine($"\tGemiddelde lengte= {gemiddeldeLengte}");
                Console.WriteLine($"\tAantal vrouwen: {aantalVrouwen}/{aantalinGen}");
                if(aantalinGen!=0)
                    Console.WriteLine($"\tMensen met gele ogen:{aantalGeel} ({((double)aantalGeel/aantalinGen)*100:0.0}%)");
            }


           
        }
    }
}
```