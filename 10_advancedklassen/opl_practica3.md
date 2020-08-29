# Meetlab


```java
class Meetlat
{
    public Meetlat(int lengtestart)
    {

    }lengteInM=lengtestart;

    private double lengte;
    public double BeginLengte
    {
        set { lengte=value; }
    }

    private double lengteInM;

    public double LengteInCm
    {
        get{ return lengte*100;}
    }

    public double LengteInKm
    {
        get{ return lengte/1000;}
    }

    public double LengteInVoet
    {
        get{ return lengte*3.2808;}
    }
}
```

# Sport simulator

```java
class Waterpolospeler
{
    private string spelersNaam;

    public string SpelersNaam
    {
        get { return spelersNaam; }
        private set { spelersNaam = value; }
    }

    private int mutsNummer;

    public int MutsNummer
    {
        get { return mutsNummer; }
        private set
        {
            if (value > 0 && value < 14) //checken dat de waarde van de muts tussen de 0 en 14 is
            {
                mutsNummer = value; //als het zo is dan zal de waarde aan de muts worden gegeven
            }
        }
    }

    private bool isDoelman;

    public bool IsDoelman
    {
        get { return isDoelman; }
        private set { isDoelman = value; }
    }
    private bool isReserve;

    public bool IsReserve
    {
        get { return isReserve; }
        private set { isReserve = value; }
    }

    private string reeks;

    public string Reeks
    {
        get { return reeks; }
        private set { reeks = value; }
    }
    public void Stelin(string naamin, int nummerin, bool doelin, bool reservein, string reeksin)
    {
        SpelersNaam = naamin;
        MutsNummer = nummerin;
        IsDoelman = doelin;
        IsReserve = reservein;
        Reeks = reeksin;
    }
    public void Gooibal()
    {
        Console.WriteLine($"Ik ({this.SpelersNaam}) gooi de bal");
    }

    public void Watertrappen()
    {
        Console.WriteLine($"nummer {this.MutsNummer} is aan het watertrappelen");
    }
    public void Tooninfo()
    {
        Console.WriteLine($@"
Naam: {SpelersNaam}
Mutsnummer: {MutsNummer}
Is doelman: {IsDoelman}
Is reserve: {IsReserve}
Reeks: {Reeks}

");



    }

    public static void SimuleerSpeler(Waterpolospeler testspeler)
    {
        for (int i = 0; i < 3; i++)
        {
            testspeler.Watertrappen();
        }
        for (int i = 0; i < 3; i++)
        {
            testspeler.Gooibal();
        }
    }

    public static void SimuleerWedstrijd(Waterpolospeler speler1, Waterpolospeler speler2)
    {
        Random rgen = new Random();
        if (rgen.Next(0, 10) < 5)
        {
            Console.WriteLine($"de winnaar is: {speler1.SpelersNaam}");
        }
        else
        {
            Console.WriteLine($"de winnaar is: {speler2.SpelersNaam}");
        }
    }
    public static Waterpolospeler BesteSpeler(Waterpolospeler speler1, Waterpolospeler speler2)
    {
        Random rgen = new Random();
        if (rgen.Next(0, 10) < 5)
        {
            return speler1;
        }
        else
        {
            return speler2;
        }
    }
}
```

# Pokemon met deel 2

We laten de reeds bestaande properties en methoden niet meer zien in deze oplossing:
```java

class Pokemon
{
    //reeds bestaande properties en methoden
    public void VerhoogLevel()
    {
        if(NoLevelingAllowed)
        {
            Console.WriteLine("Levelingo of Pokemons not allowed. Change NoLevelingAllowed to false to reenable leveling");
        }
        else
        {
            TimesLeveled++;
            Level++;
        }
    }
    //Nieuw deel

    //Default constructor
    public Pokemon()
    {
        HP_Base=10;
        Attack_Base=10;
        Defense_Base=10;
        SpecialAttack_Base = 10;
        SpecialDefense_Base = 10;
        Speed_Base=10;
  
    }
    //Overloaded constructor
    public Pokemon(int hp, int att, int def, int spec_att, int spec_def, int speed)
    {
        HP_Base=hp;
        Attack_Base=att;
        Defense_Base=def;
        SpecialAttack_Base = spec_att;
        SpecialDefense_Base = spec_def;
        Speed_Base=speed;  
    }

    //static deel
    public static int TimesLeveled{get; private set}  
    public static int TimesBattled{get; private set}
    public static int TimesBattleDraw{get; private set}
    public static int TimesRandomGenerated{get; private set}
    public static bool NoLevelingAllowed{get; private set}

    public static void Info()
    {
        Console.WriteLine($"Aantal keer geleveled:{TimesLeveled}");
        Console.WriteLine($"Aantal keer gevochten:{TimesBattled}");
        Console.WriteLine($"Waarvan {TimesBattleDraw} keren gelijke stand");
        Console.WriteLine($"Er werden {TimesRandomGenerated} random pokemons aangemaakt"); 
    }

    private static Random ran=new Random();
    public static Pokemon GeneratorPokemon ()
    {
        TimesRandomGenerated++;
        Pokemon temp= new Pokemon();
        temp.HP_base= ran.Next(1,100);
        temp.Attack_base=ran.Next(1,100);
        return temp;
    }
    public static int Battle(Pokemon poke1, Pokemon poke2)
    { 
        TimesBattled++;
        if(poke1 ==null && poke2 == null)
            return 0;
        if(poke1==null)
            return 2;
        if(poke2==null)
            return 1;

        if(poke1.Average > poke2.Average)
            return 1;
        else if (poke2.Average< poke2.Average)
            return 2;

        TimesBattleDraw++;
        return 0;
    }
}
```

# Digitale kluis

```java
class DigitaleKluis
{
    private int code=0x0000;

    public DigitaleKluis(int startcode)
    {
        Code=startcode;
    }

    private bool canShowCode;
    public bool CanShowCode
    {
        get
        {
            return canShowCode;
        }
        set
        {
            canShowCode=value;
        }
    }

    public int CodeLevel
    {
        get
        {
            return (Code/1000);
        }
    }

    public int Code
    {
        get
        {
            if(CanShowCode)
                return code;
            else
                return -666;
        }

        private set
        {
            code=value;
        }
    }

    private int aantalpogingen;
    public bool TryCode(int testcode)
    {
        if(testcode==-666)
        {
            Console.WriteLine("Cheater!");
            return false;
        }
        else if(testcode==Code)
        {
            Console.WriteLine($"Deze code is geldig. Aantalpogingen = {aantalpogingen}");
            return true;
        }
        Console.WriteLine("Dat is geen geldige code");
        aantalpogingen++;
        return false;
        }
    }
}
```
