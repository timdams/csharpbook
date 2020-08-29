# Oplossingen 

# Figures with interfaces

```java
class Rechthoek: IComparable
{
    //Alle vorige zaken
    //...

    public int CompareTo(object obj)
    {
        Rechthoek temp = (Rechthoek)obj;
        if (temp.Breedte * temp.Lengte > Breedte * Lengte)
            return -1;
        else if (temp.Breedte * temp.Lengte < Breedte * Lengte)
            return 1;
        return 0;
    }
}
```

# Carbon footprint

```java

List<object> vervuilers = new List<object>();
vervuilers.Add(new Plant());
vervuilers.Add(new Huis() { Volume = 200 });
vervuilers.Add(new Fabriek() { Werknemers = 10 });
vervuilers.Add(new Auto() { Merk = AutoMerk.Audi });
vervuilers.Add(new Plant());
vervuilers.Add(new Huis() { Volume = 100 });
vervuilers.Add(new Fabriek() { Werknemers = 25 });
vervuilers.Add(new Auto() { Merk = AutoMerk.Volvo });

int som = 0;
int max = -1;
int maxindex = -1;
for (int i = 0; i < vervuilers.Count; i++)
{

    var vuileI = vervuilers[i] as ICarbonFootPrint;
    if (vuileI != null)
    {
        int print = vuileI.BerekenFootPrint();
        Console.WriteLine($"{vervuilers[i].GetType()}:{print}");
        som += print;
        if (print > max)
        {
            max = print;
            maxindex = i;
        }
    }
}
Console.WriteLine($"Gemiddelde footprint is {som/vervuilers.Count}");
if(maxindex>-1)
    Console.WriteLine($"{vervuilers[maxindex]} op positie {maxindex} heeft grootste footprint {max}");
```


```java
class Huis : ICarbonFootPrint
{
    public int Volume { get; set; }
    private double footprintfactor = 1;
    public int BerekenFootPrint()
    {
        return (int)(Volume * 10 * footprintfactor);
    }

    public void VerlaagFootprint()
    {
        if (footprintfactor > 1)
            footprintfactor -= 0.1;
    }
}

class Fabriek : ICarbonFootPrint
{
    public int Werknemers { get; set; }
    private int factor = 100;
    public int BerekenFootPrint()
    {
        return Werknemers * factor;
    }

    public void VerlaagFootprint()
    {
        if (factor > 5)
            factor--;
    }
}

enum AutoMerk { BMW, Volvo, Audi }
class Auto : ICarbonFootPrint
{
    public AutoMerk Merk { get; set; }
    private int factor = 1;
    public int BerekenFootPrint()
    {
        switch (Merk)
        {
            case AutoMerk.BMW:
                return 10 + factor;
                break;
            case AutoMerk.Volvo:
                return 12 + factor;
                break;
            case AutoMerk.Audi:
                return 14 + factor;
                break;
            default:
                break;
        }
        return 0;
    }

    public void VerlaagFootprint()
    {
        if (factor > 0)
            factor--;
    }
}
class Plant
{ }

interface ICarbonFootPrint
{
    int BerekenFootPrint();
    void VerlaagFootprint();
}
```