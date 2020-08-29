# Code met uitleg
![](../assets/infoclip.png)

[De oplossing wordt hier stap voor stap besproken](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=736abb9f-5971-4920-a031-abad00ca02bc)

# Code
## Main

```java
            List<Gebouw> enclave = new List<Gebouw>();
            enclave.Add(new Hospitaal("Sint Vincentius", 4, 5));
            enclave.Add(new Woonst("Tims shack", 1, 1));
            enclave.Add(new Generator("batteryshed 1", 1, 2));

            foreach (var gebouw in enclave)
            {
                gebouw.PrintGebouw();
            }

            Console.SetCursorPosition(1, 20);
```

## Gebouw
```java
abstract class Gebouw
{
    public Gebouw(string naamin, int xin, int yin)
    {
        Naam = naamin;
        X = xin;
        Y = yin;
    }
    public string Naam { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public abstract void PrintGebouw();

    public override string ToString()
    {
        return $"{Naam} (locatie: {X},{Y})";
    }
}
```

## Flat
```java
class Flat : Woonst
{
    public Flat(int xin, int yin) : base("Flat",xin, yin)
    {
    }
    public override string ToString()
    {
        return base.ToString()+ " Voor veel mensen";
    }

    public override void PrintGebouw()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write("W");
    }
}
```

## Hospitaal
```java
class Hospitaal : Gebouw
{
    public Hospitaal(string naamin, int xin, int yin) : base(naamin, xin, yin)
    {
    }
    public override string ToString()
    {
        return base.ToString() + "Hier genezen de mensen.";
    }

    public override void PrintGebouw()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write("H");
    }
}
```

## Generator
```java
class Generator : Gebouw
{
    private string v;
    private int xin;
    private int yin;

    public Generator( int xin, int yin) : base("Generator", xin, yin)
    {
    }

    public Generator(string v, int xin, int yin): base(v,xin,yin)
    {

    }
    public override string ToString()
    {
        return base.ToString() + "Dit gebouw maakt elektriciteit.";
    }
    public override void PrintGebouw()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write("g");
    }
}
```

## WaterkrachtCentrale
```java
class WaterkrachtCentrale: Generator
{
    public WaterkrachtCentrale(int xin, int yin): base("WaterkrachtCentrale",xin,yin)
    { }
    public override string ToString()
    {
        return base.ToString() + "Met behulp van water";
    }

    public override void PrintGebouw()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write("G");
    }
}
```