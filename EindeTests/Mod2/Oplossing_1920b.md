
```java
using System;

namespace examenjanuarie
{
    class Program
    {
        enum Alarmtype { Geen, Test, Echt}
        static void Main(string[] args)
        {
            int teller = 0;
            bool klaar = false;
            char volgendjaar;
            Alarmtype[] jaarlog = new Alarmtype[52];
            double[] jaarlogbook = { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 };
            int gebouwnummer, kans;
            bool testalarm;
            //while zal 10 keer maximum doorlopen
            while (!klaar)
            {
                Console.WriteLine("log jaar" + (teller + 1));



                // weekloop
                for (int i = 1; i < 53; i++)
                {
                    switch (i)
                    {
                        case 1:
                        case 11:
                        case 21:
                        case 31:
                        case 41:
                        case 51:
                            //aanroepen test alarm
                            testalarm = true;
                            Console.WriteLine("test alarm week " + i);
                            TestAlarm();
                            jaarlog[i - 1] = Alarmtype.Test;
                            break;
                        default:
                            //aanroepen start alarm
                            testalarm = false;
                            gebouwnummer = gen.Next(0, 3);
                            kans = gen.Next(0, 4);

                            if (kans == 0)
                            {
                                jaarlog[i - 1] = Alarmtype.Echt;
                                StartAlarmGebouw(gebouwnummer, testalarm);
                            }
                            else
                            {
                                jaarlog[i - 1] = Alarmtype.Geen;
                            }

                            break;
                    }


                }

                ToonLogBook(jaarlog);
                jaarlogbook[teller] = BerekenSommen(jaarlog);
                //vragen voor een volgend jaar
                Console.WriteLine("moet er nog een jaar gestart worden?");
                volgendjaar = Convert.ToChar(Console.ReadLine());
                //checken op alles en volgend jaar
                teller++;
                if (volgendjaar == 'n' || teller == 10)
                {
                    klaar = true;
                }




            }
            Console.WriteLine("Verslag:");
            for (int i = 0; i < teller; i++)
            {

                if (jaarlogbook[i] < 10.00)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"Jaar {i + 1}: {jaarlogbook[i]}%");
                Console.ResetColor();
            }




        }
        static double BerekenSommen(Alarmtype[] logbook)
        {
            double teller = 0;
            for (int i = 0; i < logbook.Length; i++)
            {
                if (logbook[i] == Alarmtype.Echt)
                {
                    teller++;
                }
            }



            double uitkomst = (teller / 52) * 100;
            uitkomst = Math.Round(uitkomst, 2);
            Console.WriteLine($"jaargemiddelde = {uitkomst}%");
            return uitkomst;
        }


        static void ToonLogBook(Alarmtype[] logbook)
        {
            int teller = 0;
            for (int i = 0; i < logbook.Length; i++)
            {
                teller++;
                if (logbook[i] == Alarmtype.Test)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (logbook[i] == Alarmtype.Echt)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                if (teller == 10)
                {
                    teller = 1;
                }
                Console.Write(teller);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        static void TestAlarm()
        {
            int gebouwkans = gen.Next(0, 11);
            int nummer;
            if (gebouwkans < 2)
            {
                nummer = 1;
            }
            else if (gebouwkans < 5)
            {
                nummer = 2;
            }
            else
            {
                nummer = 3;
            }
            StartAlarmGebouw(nummer, true);

        }
        static void StartAlarmGebouw(int nummer, bool testalarm)
        {
            if (testalarm)
            {
                Console.WriteLine($"Gebouw {nummer} geevacueerd tgv alarm (dit was een test).");
            }
            else
            {
                Console.WriteLine($"Gebouw {nummer} geevacueerd tgv alarm (ECHT ALARM).");
            }
        }
        static Random gen = new Random();
    }
}
```