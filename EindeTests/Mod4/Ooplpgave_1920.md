## Opgave 1

### Main

```java
static Random r = new Random();
static void Main(string[] args)
{
    School s = new School();
    var WerkStudenten = new List<Leerling>();

    for (int i = 0; i < 15; i++)
    {
        s.GeefGeld(r.Next(15, 30));
        if(s.MaakLeerling())
        {
            if(r.Next(0,100)>=60)
            { 
                Leerling toadd = s.GeefLeerling();
                    if (toadd != null)
                        WerkStudenten.Add(toadd);
            }
        }
        Console.WriteLine(s);
    }

    foreach (var werkstudent in WerkStudenten)
    {
        Console.WriteLine(werkstudent.Naam);
    }
}
```

### School

```java
class School
{
    private int geldHoeveelheid;

    public int GeldHoeveelheid
    {
        get { return geldHoeveelheid; }
        set
        {
            if (value <= 15)
                geldHoeveelheid = 15;
            else geldHoeveelheid = value;
        }
    }

    public bool IsBijnaLeeg
    {
        get
        {
            if (GeldHoeveelheid >= 15)
                return true;
            else return false;
        }

    }

    public List<Leerling> Leerlingen { get; set; } = new List<Leerling>(15);

    public void GeefGeld(double geld)
    {
        GeldHoeveelheid += (int)geld;
    }

    public bool MaakLeerling()
    {
        if (geldHoeveelheid>=40 && Leerlingen.Count<16 ) 
        {
            
            geldHoeveelheid -= 15;
            Leerlingen.Add(new Leerling());
            return true;
        }
        return false;
    }

    public Leerling GeefLeerling()
    {
        if(Leerlingen.Count>=2)
        {
            Leerling toreturn = Leerlingen[0];
            Leerlingen.RemoveAt(0);
            return toreturn;

        }
        return null;
    }

    public override string ToString()
    {
        return $"{GeldHoeveelheid},{IsBijnaLeeg},{Leerlingen.Count}";
        //Mag je iets sexier maken
    }
}
```

## Opgave 2

### Klassen
```java
interface IRampGebiedResponder
{
    void Vertrek();
}

abstract class ReddingsWerker
{
    public ReddingsWerker(int Risicograadin)
    {
        RisicoGraad = Risicograadin;
    }
    public int RisicoGraad { get; set; } = 6;
    public virtual string RapportStatus()
    {
        return $"{RisicoGraad}";
    }
}

class Politie : ReddingsWerker
{
    public Politie(int risicograadin) : base(risicograadin)
    {

    }
}
class Brandweer : ReddingsWerker
{
    public Brandweer(int risicograadin) : base(risicograadin)
    {

    }
}
class SpecialeBrandweer : Brandweer, IRampGebiedResponder
{
    public SpecialeBrandweer() : base(15)
    {

    }
    public void Vertrek()
    {
        throw new NotImplementedException();
    }
    public override string RapportStatus()
    {
        return base.RapportStatus() + "Ik ben beter.";
    }
}
```

### Main
```java
List<ReddingsWerker> begin = new List<ReddingsWerker>()
{
    new Politie(6),new Brandweer(6), new SpecialeBrandweer()
};


var dict = new Dictionary<int, ReddingsWerker>();

int key = 0;
foreach (var element in begin)
{

    do
    {
        key = r.Next(100, 2000);
    } while (dict.ContainsKey(key));
    dict.Add(key, element);
    Console.WriteLine($"{element} heeft key {key}");
}

Console.WriteLine("Geef getal?");
int keytoview = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(dict[keytoview].RapportStatus());
int gemall = 0;
int gemallexcl = 0;
int countnotiramp = 0;
foreach (var item in dict.Values)
{
    gemall += item.RisicoGraad;
    if (!(item is IRampGebiedResponder))
    {
        gemallexcl += item.RisicoGraad;
        countnotiramp++;
    }
}


Console.WriteLine($"Gemiddelde is {gemall / dict.Count}");
Console.WriteLine($"Gemiddelde excl IRampgebiedResponse is {gemallexcl / countnotiramp}");
```