# Generic classes en constraints

## Klassen en generics

Niets houdt ons nu tegen om generieke klassen te maken. We kunnen bijvoorbeeld volgende klasse maken die we kunnen gebruiken met eender welk type om de meetwaarde van een meting in op te slaan:

```csharp
public class Meting<T>
{
    private T waarde;
    //constructor
    public Meting(T waardein)
    {
        waarde = waardein;
    }
    //Public property
    public T Waarde { get { return waarde; } set { waarde = value ;} }
    public override string ToString()
    {
        return "Deze meting heeft als waarde:"+ waarde.ToString();
    }
}
```

Een voorbeeldgebruik van dit nieuwe type kan zijn:

```csharp
    Meting<int> m1 = new Meting<int>(44);
    Console.WriteLine(m1);

    Meting<string> m2 = new Meting<string>("slechte meting");
    Console.WriteLine(m2);
```

Of we zouden zelfs een extra klasse kunnen aanmaken genaamd Student

```csharp
public class Student
{
    public string Naam;
    public Student(string n){Naam= n;} //Constructor
    public override string  ToString()
    {
        return Naam;
    }
}
```

En dan als volgt een nieuwe meting met daarin een student aanmaken. Let goed op de constructor-aanroep van zowel Meting als Student!

```csharp
Meting<Student> m3= new Meting<Student>(new Student("Tim Dams"));
Console.WriteLine(m3);
```

De uitvoer van dit programma zou dan zijn: ![](../../.gitbook/assets/generics1.png)

## Meerdere types in generics

Zoals reeds eerder vermeld is de T aanduiding enkel maar een afspraak. Je kan echter zoveel T-parameters meegeven als je wenst. Stel dat je bijvoorbeeld een klasse wenst te maken waarbij 2 verschillende types kunnen gebruikt worden. De klassedefinitie zou er dan als volgt uit zien:

```csharp
class DataBewaarder<Type1, Type2>
{
    private Type1 waarde1;
    private Type2 waarde2;
    //Constructor
    public DataBewaarder(Type1 w1, Type2 w2)
    {
        waarde1 = w1;
        waarde2 = w2;
    }
    public override string ToString()
    {
        return "Waarde1: " + waarde1 + "\nWaarde2: " + waarde2;
    }
}
```

Het gebruik ervan:

```csharp
DataBewaarder<int, string> d1 = new DataBewaarder<int, string>(4, "Ok");
```

Met als uitvoer: ![](../../.gitbook/assets/generics2.png)

## Constraints

We willen vaak voorkomen dat bepaalde types wel of niet gebruikt kunnen worden in je zelfgemaakte generieke klasse. Stel bijvoorbeeld dat je een klasse schrijft waarbij je de CompareTo\(\) methode wenst te gebruiken. Dit gaat enkel indien het type in kwestie de IComparable interface implementeert. We kunnen als constraint \("beperking"\) dan opgeven dat de volgende klasse enkel kan gebruikt worden door klassen die ook effectief die interface implementeren \(en dus de CompareTo\(\)-methoden hebben\). Het geel deel geeft de constraint aan. We zeggen dus letterlijk \("waar T overerft van IComparable"\):

```csharp
public class Wijziging<T> where T : IComparable
{
    public T vorigewaarde;
    public T huidigewaarde;
    public Wijziging(T vorig, T huidig)
    {
        vorigewaarde = vorig;
        huidigewaarde = huidig;
    }

    public bool IsGestegen()
    {
        if (huidigewaarde.CompareTo(vorigewaarde) > 0)
            return true;
        else return false;
    }
}
```

Volgende gebruik van deze klasse zou dan True op het scherm tonen:

```csharp
Wijziging<double> w = new Wijziging<double>(3.4, 3.65);
Console.WriteLine(w.IsGestegen());
```

### Mogelijke constraints

Verschillende zaken kunnen als constraint optreden. Naast de verplichting dat een bepaalde interface moet worden geïmplementeerd kunnen ook volgende constraints gelden\([meer info](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters)\):

* Enkel value types
* Enkel klassen
* Moet default constructor hebben
* Moet overerven van een bepaalde klasse

## Why should I care?

![](../../.gitbook/assets/care.jpg)

Goh, eerlijk is eerlijk: in je prille programmeursbestaan zal je niet heel vaak de nood zien om je eigen generieke klasse te schrijven. Laat staan dat je ook nog eens allerlei constraints gaat definiëren.

