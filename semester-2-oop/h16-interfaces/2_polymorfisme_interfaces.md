# Polymorfisme en interfaces

## Polymorfisme, interfaces en is/as

De eigenschappen van polymorfisme en interfaces combineren kan zeer krachtige tot zeer krachtige code resulteren wanneer we de `is` en `as` keywords gebruiken. We tonen dit in een voorbeeld.

### Vloekende mensen: Opstart

De idee is de volgende: mensen kunnen spreken. Leraren, Studenten, Politieker, en ja zelfs Advocaten zijn mensen. Echter, enkel Politiekers en Advocaten hebben ook de interface IVloeker die hen toelaat eens goed te vloeken. Brave leerkrachten en studenten doen dat niet. We willen een programma dat lijsten van mensen bevat waarbij we de vloekers kunnen doen vloeken zonder complexe code te moeten schrijven.

We hebben volgende klasse-structuur: ![](../../.gitbook/assets/polyinterface.png)

Als basis klasse `Mens` hebben we dan:

```csharp
public class Mens
{
    public void Spreek()
    {
        Console.WriteLine("Hoi!");
    }
}
```

Voorts definiëren we de interface:

```csharp
interface IVloeker
{
    void Vloek();
}
```

We kunnen nu de nodige child-klassen maken. 1. De niet vloekers: `Leraar` en `Student` 2. De vloekers: `Advocaat` en `Politieker`

```csharp
class Leraar:Mens {} //moet niets speciaal doen

class Student:Mens{} //ook studenten doen niets speciaal

class Politieker: Mens, IVloeker
{
    public void Vloek()
    {
        Console.WriteLine("Godvermiljaardedeju, zei de politieker");
    }
}

class Advocaat: Mens, IVloeker
{
    public void Vloek()
    {
        Console.WriteLine("SHIIIIT, zei de advocaat");
    }
}
```

### Vloekende mensen: Het probleem

We maken een array van mensen aan:

```csharp
Mens[] mensjes = new Mens[4];
mensjes[0]= new Leraar();
mensjes[1]= new Politieker();
mensjes[2]= new Student();
mensjes[3]= new Advocaat();

for(int i =0; i<mensjes.Length; i++)
{
    //NOW WHAT?
}
```

**Het probleem:** hoe kan ik in de array van mensen \(bestaande uit een mix van studenten, leraren, advocaten en politiekers\) **enkel de vloekende mensen laten vloeken?**

### Oplossing 1 - Vloekende mensen: `is` to the rescue

De eerste oplossing is door gebruik te maken van het `is` keyword. We zullen de lijst doorlopen en steeds aan het huidige object vragen of dit object de `IVloeker` interface bezit, als volgt:

```csharp
for(int i =0; i<mensjes.Length; i++)
{
    if(mensjes[i] is IVloeker)
    {
        //NOW WHAT ?
    }
    else
    {
        mensjes[i].Spreek();
    }
}
```

Vervolgens kunnen we binnen deze if het huidige object tijdelijk omzetten \([casten](../../semester-1-programming-principles/h3-werken-met-data/4_converteren_casting.md)\) naar een IVloeker object en laten vloeken:

```csharp
if(mensjes[i] is IVloeker)
{
    IVloeker tijdelijk= (IVloeker)mensjes[i];
    tijdelijk.Vloek();
}
```

### Oplossing 2 - Vloekende mensen: `as` to the rescue

Het `as` keyword kan ook een toffe oplossing geven. Hierbij zullen we het object proberen omzetten via `as` naar een IVloeker. Als dit lukt \(het object is verschillend van `null`\) dan kunnen we het object laten vloeken:

```csharp
for(int i =0; i<mensjes.Length; i++)
{
    IVloeker tijdelijk = mensjes[i] as IVloeker;
    if(tijdelijk !=null)
    {
        tijdelijk.Vloek();
    }
    else
    {
        mensjes[i].Spreek();
    }
}
```

## Why should I care

![](../../.gitbook/assets/care.jpg)

In de echte C\# wereld houdt men van interfaces. Het is veel beter om 'tegen interfaces' te programmeren dan tegen klassen. Het maakt je code veel beter qua onderhoud en complexiteit.

Met `is` en `as` kan je snel objecten van eender welk type bevragen:

* _"Heb jij interface x?"_ m.b.v `is`  \(bv.  `if(object is ISomething`\)\)
* _"Wordt jij eens even interface x!"_ m.b.v. `as` \(bv. object as ISomething\)

