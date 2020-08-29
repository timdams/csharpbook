```java
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1819_PPVaardigMod2_1ekans
{
    class Program
    {
        static void Main(string[] args)
        {

            if (SetupCasino("tim", 20, 80))
            {
                int keuze = 0;
                int geld = 0;
                while (keuze != -1)
                {
                    Console.Clear();
                    Console.WriteLine($"Je hebt {geld} euro.");
                    keuze = ToonMenu();
                    Console.Clear();
                    switch (keuze)
                    {
                        case 1:
                            geld += RaadHetGetal();
                            break;
                        case 2:
                            geld += RekenenMaar();
                            break;
                        case 3:
                            geld += ArrayGame();
                            break;
                        default:
                            ShowEnding(geld);
                            break;

                    }
                    Console.WriteLine("Druk toets om verder te gaan");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("Ongeldige hoogte en/of breedte");
            }
        }

        private static int ArrayGame(int lengte=10)
        {
            bool[] guess = new bool[lengte];
            Random r = new Random();
            for (int i = 0; i < guess.Length; i++)
            {
                if (r.Next(0, 2) == 0)
                    guess[i] = true;
                else guess[i] = false;
            }

            Console.WriteLine("Hoe lang kan jij de sequentie raden?Geef 0 (false) of 1 (true) in.");
            int curr = 0;
            bool correct = true;
            do
            {
                Console.WriteLine("Komt er juist of fout? (1 of 0)");
                int c = Convert.ToInt32(Console.ReadLine());
                if ((guess[curr] == true && c == 1) || guess[curr] == false && c == 0)
                {
                    Console.WriteLine("Goed zo!");
                    curr++;
                }
                else
                    correct = false;
            } while (curr < guess.Length && correct == true);

            Console.WriteLine($"Je behaalde een sequentie van {curr} juiste gokken. Dat is {curr*5} euro waard.");

            Console.WriteLine("De correcte sequentie was:");
            for (int i = 0; i < guess.Length; i++)
            {
                Console.Write(guess[i] + ",");
            }
            Console.WriteLine();
            return curr*5;
        }



        private static int RekenenMaar()
        {
            int winst = 0;
            Console.WriteLine("Je krijgt nu 5 reken oefeningen. Per juiste krijg je 5 euro. Per foute verlies je 5 euro.");
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int a = r.Next(1, 10);
                int b = r.Next(1, 10);
                Console.WriteLine($"Hoeveel is {a}x{b}?");
                int uit = Convert.ToInt32(Console.ReadLine());
                if (uit == a * b)
                {
                    Console.WriteLine("Mooi zo! Je winst verhoogt.");
                    winst += 5;
                }
                else
                {
                    Console.WriteLine("Dat is fout. Je winst verlaagt");
                    winst -= 5;
                }


            }
            Console.WriteLine($"Je totale winst dit spel is {winst}");
            return winst;

        }

        private static int RaadHetGetal()
        {
            Console.WriteLine("Welkom bij raad het getal!");
            Console.WriteLine("Je moet een getal van 1 tot 10 raden. Hoe veel keer denk je nodig te hebben?");
            int grens = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hier gaan we dan.");
            Random r = new Random();
            int getaltezoeken = r.Next(1, 11);
            int guess = -1;
            int tries = 0;
            while (guess != getaltezoeken)
            {
                Console.WriteLine($"Welk getal is het (aantalpogingen is {tries}.)?");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess != getaltezoeken)
                    Console.WriteLine("Neen, dat is het niet. Probeer opnieuw");
                tries++;
            }
            Console.WriteLine("Jeuj. Je hebt het geraden!");
            //Berekening
            if (tries == grens)
            {
                Console.WriteLine("Wow. Je wist hoe vaak je ging raden.Je verdient 50 euro!");
                return 10;
            }

            int dif = Math.Abs(tries - grens);
            if (dif < 3)
            {
                Console.WriteLine("Je zat er minder dan 3 af van het aantal keer dat je ging raden.Je verdient 5 euro.");
                return 5;
            }
            Console.WriteLine("Je zat er  3 of meer keer af van het aantal keer dat je ging raden.Je verliest 5 euro.");
            return -5;
        }

        private static void ShowEnding(int geld)
        {
            if (geld < 0)
                Console.WriteLine("Bankroet...Niet goed hoor!");
            if (geld == 0)
                Console.WriteLine("Geen geld verloren, geen geld verdiend.");
            if (geld > 0)
                Console.WriteLine($"Je hebt {geld} euro verdient");
        }

        private static int ToonMenu()
        {

            int keuze = 0;

            do
            {
                Console.WriteLine("Geef keuze");
                Console.WriteLine("\t1. Raad het getal");
                Console.WriteLine("\t2. Rekenen maar");
                Console.WriteLine("\t3. Raad de sequentie");
                Console.WriteLine("*****");
                Console.WriteLine("-1 is stoppen");
                keuze = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (keuze != 1 && keuze != 2 && keuze != -1 && keuze !=3);

            return keuze;
        }

        private static bool SetupCasino(string name, int hoogte=60, int breedte=60)
        {
            if (hoogte < 1 || breedte < 1)
            {
                return false;
            }

            Console.WindowWidth = breedte;
            Console.WindowHeight = hoogte;

            for (int i = 0; i < breedte; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
                Console.SetCursorPosition(i, 2);
                Console.Write("*");
            }

            Console.SetCursorPosition(1, 1);
            Console.Write($"Welkom bij Casino AP {name}");

            Console.SetCursorPosition(1, 3);
            Console.WriteLine("Druk op toets om voort te gaan");
            Console.ReadKey();
            Console.Clear();
            return true;
        }
    }
}

```