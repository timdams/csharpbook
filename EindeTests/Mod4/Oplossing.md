## Stap 1

```java
    abstract class Vorm
    {
        public int X { get; set; }
        public int Y { get; set; }
        public abstract void TekenVorm();
        public virtual ConsoleColor Kleur { get; } = ConsoleColor.Red;

        public Vorm(int xin,int yin)
        {
            X = xin;
            Y = yin;
        }
    }
```

## Stap 2

```java
    class Lijn : Vorm
    {

        public Lijn(int xin, int yin, int lengtein) : base(xin, yin)
        {

            Lengte = lengtein;
        }
        public override void TekenVorm()
        {
            Console.ForegroundColor = this.Kleur;
            for (int i = 0; i < Lengte; i++)
            {
                
                    Console.SetCursorPosition(X+i , Y);
                    Console.Write("*");
                

            }
            Console.ResetColor();
        }

        public override ConsoleColor Kleur => ConsoleColor.Green;
        public int Lengte { get; set; }
        public int Breedte { get; set; }
    }

        class Rechthoek : Vorm
    {
        public Rechthoek(): base(1,1)
        {
            Breedte = 2;
            Lengte = 2;
        }
        public Rechthoek(int xin, int yin, int lengtein, int breedtein): base(xin,yin)
        {
            Breedte = breedtein;
            Lengte = lengtein;
        }
        public override void TekenVorm()
        {
            Console.ForegroundColor = this.Kleur;
            for (int i = 0; i < Lengte; i++)
            {
                for (int j = 0; j < Breedte; j++)
                {
                    Console.SetCursorPosition(X+i ,Y+ j);
                    Console.Write("*");
                }

            }
            Console.ResetColor();
        }

        public override ConsoleColor Kleur => ConsoleColor.Yellow;
        public int Lengte { get; set; }
        public int Breedte { get; set; }
    }
```

## Stap 3

```java
    class Vliegtuig:Vorm,IBeweegbaar
    {
        private Rechthoek r;
        private Lijn l1;
        private Lijn l2;
        public Vliegtuig(int xin,int yin):base(xin,yin)
        {
            r = new Rechthoek(xin + 3, yin, 2, 5);
            l1 = new Lijn(xin, yin + 2,3);
            l2 = new Lijn(xin + 5, yin + 2,3);
        }
        public override void TekenVorm()
        {
            r.TekenVorm();
            l1.TekenVorm();
            l2.TekenVorm();
        }
    }
```

## Stap 4

```java
    class Vloot:Vorm, IBeweegbaar
    {
        private List<Vliegtuig> vliegtuitenInVloot = new List<Vliegtuig>();
        public Vloot(int xin,int yin, int aantal): base(xin,yin)
        {
            for (int i = 0; i < aantal; i++)
            {
                vliegtuitenInVloot.Add(new Vliegtuig(xin, yin + 5 * i));
            }
        }
        public override void TekenVorm()
        {
            foreach (var item in vliegtuitenInVloot)
            {
                item.TekenVorm();
            }
        }
    }
```

## Stap 5

```java
    enum Richting { Links,Rechts,Boven,Beneden }
    interface IBeweegbaar
    {
        void Beweeg(Richting rkeuze);
    }
```

In vliegtuig:

```java
        public void Beweeg(Richting rkeuze)
        {
            switch (rkeuze)
            {
                case Richting.Links:
                    X--;
                    r.X--;
                    l1.X--;
                    l2.X--;
                    break;
                case Richting.Rechts:
                    X++;
                    r.X++;
                    l1.X++;
                    l2.X++;
                    break;
                case Richting.Boven:
                    Y--;
                    r.Y--;
                    l1.Y--;
                    l2.Y--;
                    break;
                case Richting.Beneden:
                    Y++;
                    r.Y++;
                    l1.Y++;
                    l2.Y++;
                    break;
                default:
                    break;
            }
        }
```

In vloot:

```java
        public void Beweeg(Richting rkeuze)
        {
            switch (rkeuze)
            {
                case Richting.Links:
                    X--;
                    break;
                case Richting.Rechts:
                    X++;
                    break;
                case Richting.Boven:
                    Y--;
                    break;
                case Richting.Beneden:
                    Y++;
                    break;
                default:
                    break;
            }

            foreach (var vliegtuig in vliegtuitenInVloot)
            {
                vliegtuig.Beweeg(rkeuze);
            }
        }
```

## Stap 6

```java
static void Main(string[] args)
        {
            List<Vorm> vormen = new List<Vorm>();
            bool stop = false;
            while (!stop)
            {
                //Alle vormen tekenen
                foreach (var vorm in vormen)
                {
                    vorm.TekenVorm();
                }
                //menu
                stop = VraagGebruiker(vormen);
                //clear
                Console.Clear();

            }

        }

        private static bool VraagGebruiker(List<Vorm> vormen)
        {
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("Maak keuze: 1.clear 2.add 3.exit 4.move");
            int keuze = Convert.ToInt32(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    vormen.Clear();
                    break;
                case 2:
                    AddVorm(vormen);
                    break;
                case 3:
                    return true; //stop
                    break;
                case 4:
                    BeweegVorm(vormen);
                    break;
                default:
                    Console.WriteLine("Onbekende keuze");
                    break;
            }

            return false;
        }

        private static void BeweegVorm(List<Vorm> vormen)
        {
            Console.WriteLine("Naar waar? 0.links 1.rechts 2.boven 3.beneden");
            Richting r = (Richting)(Convert.ToInt32(Console.ReadLine()));
            foreach (var vorm in vormen)
            {
                (vorm as IBeweegbaar)?.Beweeg(r);
            }
        }

        private static void AddVorm(List<Vorm> vormen)
        {
            Vorm toadd=null;
            Console.Write("Welke vorm? 1.lijn 2.rechthoek 3.vliegtuig 4.vloot");
            int keuze= (Convert.ToInt32(Console.ReadLine()));
            Console.Write("X?");
            int x = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("Y?");
            int y = (Convert.ToInt32(Console.ReadLine()));
            switch (keuze)
            {
                case 1:
                    Console.Write("Lengte?");
                    int lengte = (Convert.ToInt32(Console.ReadLine()));
                    toadd= new Lijn(x, y, lengte);
                    break;
                case 2:
                    Console.Write("Lengte?");
                    int lengtel = (Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Lengte?");
                    int breedtel = (Convert.ToInt32(Console.ReadLine()));
                    toadd = new Rechthoek(x, y, lengtel, breedtel);
                    break;
                case 3:
                    toadd = new Vliegtuig(x, y);
                    break;
                case 4:
                    Console.Write("Aantal vliegtuigen?");
                    int aantal = (Convert.ToInt32(Console.ReadLine()));
                    toadd = new Vloot(x, y,aantal);
                    break;
            }

            vormen.Add(toadd);
        }
```

## Stap 7
In vloot:
```java
        public void VergrootVloot()
        {
            Vliegtuig toadd = new Vliegtuig(X, Y + 5 * vliegtuitenInVloot.Count);
            vliegtuitenInVloot.Add(toadd);
        }
```

## Stap 8

In Vorm:
```java
    abstract class Vorm: IComparable
    {
        \\..
        public int CompareTo(object obj)
        {
            Vorm tocomp = obj as Vorm;
            if(tocomp!=null)
            {
                if (tocomp.X > this.X) return 1;
                else if (tocomp.X > this.X) return -1;
                else
                {
                    if (tocomp.Y > this.Y) return 1;
                    else if (tocomp.Y > this.Y) return -1;
                }           
            }
            return 0;
        }

        
        public override string ToString()
        {
            return $"{this.GetType().Name}, {X}, {Y}";
        }

```
