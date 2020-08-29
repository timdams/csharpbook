# UML naar code

```java
class Head {}
class Hand {}
class Leg{}

class Person
{
    private Head theHead =new Head();
    private Hand leftHand = new Hand();
    private Leg leftLeg = new Leg();
}
```

```java
class Wheel{}
class Crankshaft{}
class Piston{}

class Engine
{
    private Crankshaft theCrank=new Crankshaft();
    private List<Piston> pistons = new List<Piston>(); //todo: piston objecten inplaatsen, zie voorbeeld Car-constructor
}

class Car
{
    public Car() 
    {
        for(int i=0;i<4;i++)
            wheels.Add(new Wheel());
    }

    private List<Wheel> wheels=new List<Wheel>();

    private Engine mainEngine = new Engine();
}

class Propeller
{

}

class Boat 
{
    private Engine mainEngine = new Engine();
    private  List<Propeller> propellers = new List<Propeller>(); //todo: propeller objecten inplaatsen, zie voorbeeld Car-constructor
}
```

# Politiek

```java
static void Main(string[] args)
{
    President ikke = new President() { Naam = "Tim" };
    List<Minister> mins = new List<Minister>();
    mins.Add(new Minister() { Naam="Bruno"});
    mins.Add(new Minister() { Naam = "Freya" });
    mins.Add(new Minister() { Naam = "Peter" });
    mins.Add(new Minister() { Naam = "Ann" });

    Land mijnLand = new Land();
    mijnLand.MaakRegering(ikke, mins);
    mijnLand.MaakRegering(ikke, mins); //Moet error geven
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Weer een jaar verder");
        mijnLand.JaarVerder();
    }
}
```

```java
class Land
{
    private President President;
    private Minister EersteMinister;
    private List<Minister> Ministers = new List<Minister>(4);

    public void MaakRegering(President presin, List<Minister> minin)
    {
        if(President==null)
        {
            President = presin;
            EersteMinister = minin[0];
            if(minin.Count>=2)
            for (int i = 1  ; i < minin.Count; i++)
            {
                    Ministers.Add(minin[i]);
            }
        }

        else
        {
            Console.WriteLine("Gaat niet. Dit land heeft al een regering");
        }
    }

    public void JaarVerder()
    {
        if (President != null)
        {
            President.JaarVerder();
            if(President.Teller<=0)
            {
                Console.WriteLine("Regering is gedaan");
                President = null;
                EersteMinister = null;
                Ministers.Clear();
            }
        }
    }

}

class Minister
{
    public string Naam { get; set; }
}

class President: Minister
{
    public int Teller { get; private set; } = 4;
    public void JaarVerder()
    {
        Teller--;
    }
}
```

# Moederbord

De output van onderstaande code zal zijn:

<!---{line-numbers:false}--->
```text
Je hebt nog geen agp kaart
Je hebt nog 2 vrij ramsloten
Er zijn geen andere componenten aanwezig
```

```java
Moederbord Z390E_GAMING = new Moederbord(3);
Z390E_GAMING.CPUSlot = new CPU("IntelCorei9_9900K",4);
Z390E_GAMING.Ramslots.Add(new RamMemory("Corsair", 8));
Z390E_GAMING.TestMoederbord();
```

```java
class Moederbord
{
    public Moederbord(int aantalRamsloten)
    {
        Ramslots = new List<RamMemory>(aantalRamsloten);
    }
    public AGPKaart AGPSlot { get; set; } = null;
    public CPU CPUSlot { get; set; } = null;
    public List<PCComponent> AndereComponenten { get; set; } = new List<PCComponent>();

    public List<RamMemory> Ramslots { get; set; }

    public void TestMoederbord()
    {
        if(AGPSlot==null)
            Console.WriteLine("Je hebt nog geen agp kaart");
        if(CPUSlot==null)
            Console.WriteLine("Je hebt nog geen cpu");
        if(Ramslots.Capacity!= Ramslots.Count)
        {
            Console.WriteLine($"Je hebt nog {Ramslots.Capacity-Ramslots.Count} vrij ramsloten");
        }
        if(AndereComponenten.Count==0)
            Console.WriteLine("Er zijn geen andere componenten aanwezig");
    }

}

class PCComponent
{
    public string Merk { get; set; }
    public PCComponent(string merk) { Merk = merk; }
}

class RamMemory : PCComponent
{
    public int GeheugenGrootte { get; set; }
    public RamMemory(string merk, int aantalGB) : base(merk)
    {
        GeheugenGrootte = aantalGB;
    }
}

class AGPKaart : PCComponent
{
    public AGPKaart(string merk) : base(merk)
    { }
}

class CPU : PCComponent
{
    public int KlokSnelheidInGhz { get; set; }
    public CPU(string merk, int snelheid) : base(merk)
    {
        KlokSnelheidInGhz = snelheid;
    }
}

```

# Een eigen huis

## Main:

```java
Huis myHuis = new Huis();
myHuis.Kamers.Add(new Salon() { HeeftSchouw = true });
myHuis.Kamers.Add(new Gang() {Oppervlakte=20 });
myHuis.Kamers.Add(new BadKamer());
myHuis.Kamers.Add(new Kamer());

Console.WriteLine(myHuis.BerekenPrijs());
```

## Klasse

(In sommige hanteer ik de [EDM-schrijftstijl](B_appendix/6_exprbody.md) bij de override van properties.)

```java
class Huis
    {
        public List<Kamer> Kamers { get; set; } = new List<Kamer>();
        public int BerekenPrijs()
        {
            int totaal = 0;
            foreach (var kamer in Kamers)
            {
                totaal += kamer.Prijs;

            }
            return totaal;
        }
    }

    class Kamer
    {
        public int Oppervlakte { get; set; }
        public string Naam { get; set; }
        public virtual int Prijs
        {
            get
            {
                return 400;
            }
        }

    }

    class BadKamer : Kamer
    {
        public override int Prijs => 500;
    }

    class Salon : Kamer
    {
        public bool HeeftSchouw { get; set; }
        public override int Prijs
        {
            get
            {
                if (HeeftSchouw) return 300;
                return 500;
            }
        }
    }
    class Gang : Kamer
    {
        public override int Prijs => 10 * Oppervlakte;
    }
```
