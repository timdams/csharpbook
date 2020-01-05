# UML naar code

```csharp
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

```csharp
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

# Een eigen huis

## Main:

```csharp
Huis myHuis = new Huis();
myHuis.Kamers.Add(new Salon() { HeeftSchouw = true });
myHuis.Kamers.Add(new Gang() {Oppervlakte=20 });
myHuis.Kamers.Add(new BadKamer());
myHuis.Kamers.Add(new Kamer());

Console.WriteLine(myHuis.BerekenPrijs());
```

## Klasse

(In sommige hanteer ik de [EDM-schrijftstijl](B_appendix/6_exprbody.md) bij de override van properties.)

```csharp
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
