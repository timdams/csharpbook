```java

static void Main(string[] args)
        {
            //Fase 1:
            double budget = Fase1();

            //Fase 2
            bool[] gekocht = new bool[10];
            double[] prijzen = new double[10];
            int Gekocht = Fase2(budget, gekocht, prijzen);
            //Fase 3
            Fase3(gekocht, prijzen, Gekocht);
        }

        private static void Fase3(bool[] gekocht, double[] prijzen, int Gekocht)
        {
            for (int j = 0; j < Gekocht; j++)
            {
                Console.Write($"Huis met prijs {prijzen[j]} euro heb je ");
                if (gekocht[j] == false)
                    Console.Write("niet ");
                Console.WriteLine("gekocht");
            }

            double gem = BerekenGemiddelde(prijzen, gekocht);
            Console.WriteLine($"Je spendeerde gemiddelde {gem} euro aan een huis");
        }

        private static int Fase2( double budget, bool[] gekocht, double[] prijzen)
        {
            int Gekocht = 0;
            Random r = new Random();
            while (budget > 0 && Gekocht < 20)
            {
                Console.WriteLine("*****");
                int kost = HuisPrijs();
                prijzen[Gekocht] = kost;
                Console.WriteLine($"Je budget is nu {budget}");
                Console.WriteLine("-----------------");
                Console.WriteLine($"Wil je dit huis kopen? Het kost {kost} euro. [j/n]");

                string keuze = Console.ReadLine();
                if (keuze == "j")
                {
                    budget -= kost;
                    gekocht[Gekocht] = true;
                }
                Gekocht++;
            }

            return Gekocht;
        }

        private static double Fase1()
        {
            Console.WriteLine("Geef moeilijkheidsgraad in (een getal van 1 tot en met 9)");
            int moei = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Krijg de trainee een startbonus? [j/n]");
            bool bonus = false;
            if (Console.ReadLine() == "j") bonus = true;


            double budget = BudgetGenerator(false, 5);
            Console.WriteLine($"Je startbudget is {budget}");
            return budget;
        }

        private static double BerekenGemiddelde(double[] prijzen, bool[] gekocht)
        {
            double som = 0;
            double aantal = 0;
            for (int i = 0; i < prijzen.Length; i++)
            {
                if (gekocht[i] == true)
                {
                    aantal++;
                    som += prijzen[i];
                }
            }
            return som / aantal;
        }

        private static int HuisPrijs()
        {
            int prijs = 1000;
            Random r = new Random();
            int aantalkamers = r.Next(1, 4);
            prijs = prijs + aantalkamers * 120;
            bool heeftterras = false;
            if (r.Next(1, 4) == 1)
            {
                heeftterras = true;
                prijs += 450;


            }
            if (!heeftterras)
                Console.WriteLine($"Huis met {aantalkamers} slaapkamers en geen terras: {prijs} euro");
            else
                Console.WriteLine($"Huis met {aantalkamers} slaapkamers en met terras: {prijs} euro");
            return prijs;
        }

        static double BudgetGenerator(bool bonus, int moeilijkheidsgraad = 5)
        {
            double budget = 5000;
            if (bonus == true)
            {
                budget += 2500;
            }
    
                budget -= (moeilijkheidsgraad* 100);

            return budget;

        }

```