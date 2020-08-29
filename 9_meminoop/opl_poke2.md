# Meetlat

```java
class Meetlat
{
    private double lengte;
    public double BeginLengte
    {
        set { lengte=value; }
    }

    public double LengteInM
    {
        get{ return lengte;}
    }

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

# Pokemontester

```java
Pokemon aPoke= new Pokemon();
Console.WriteLine("Geef hp:");
aPoke.HP_Base= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Geef attack:");
aPoke.Attack_base= Convert.ToInt32(Console.ReadLine());

//enz

aPoke.ShowInfo();

Console.WriteLine("Tot welke level wilt u leveren?");
int levels= Convert.ToInt32(Console.ReadLine());
for(int i=0;i<levels;i++)
{
    aPoke.VerhoogLevel();
}
Console.WriteLine($"Na {levels} keer het level te verhogen:");
aPoke.ShowInfo();
```

# Pokemon generator

```java
private static Random ran=new Random();
public static Pokemon GeneratorPokemon ()
{
    Pokemon temp= new Pokemon();
    temp.HP_base= ran.Next(1,100);
    temp.Attack_base=ran.Next(1,100);
    return temp;
}
```

Aanroep:

```java
Pokemon myNewPokemon= GeneratorPokemon();
Pokemon myOtherPokemon= GeneratorPokemon();
```

# Pokemon-battle

```java
public static int Battle(Pokemon poke1, Pokemon poke2)
{
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

    return 0;
}
```