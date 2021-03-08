# Static

## Static

Je hebt het keyword `static` al een paar keer zien staan voor methoden het vorige semester. En dit semester werd er dan weer nadrukkelijk verteld géén `static` voor methoden te plaatsen. Wat is het nu?

Een `static` onderdeel van een klasse hoort **bij de klasse zelf** en **niet bij specifieke instanties** van die klasse. Je hoeft dus geen instanties aan te maken om gebruik te maken van dit onderdeel.

`static` kan op 2 manieren gebruikt worden:

1. Bij _variabelen_ om een gedeelde variabele aan te maken, over de objecten van die klasse heen.
2. Bij _methoden_ om zogenaamde methoden-bibliotheken of hulpmethoden aan te maken.

### Variabelen en het static keyword

Zonder het keyword heeft ieder object z'n eigen variabelen en aanpassingen binnen het object aan die variabelen heeft geen invloed op andere objecten. We tonen eerst de werking zoals we gewend zijn en vervolgens hoe `static` werkt.

#### Variabelen ZONDER static

Gegeven volgende klasse:

```csharp
class Mens
{
    private int leeftijd=1;
    public void Jarig()
    {
        leeftijd++;
    }

    public void ToonLeeftijd()
    {
        Console.WriteLine(leeftijd);
    }
}
```

Als we dit doen:

```csharp
Mens m1= new Mens();
Mens m2= new Mens();

m1.Jarig();
m1.Jarig();

m2.Jarig();

m1.ToonLeeftijd();
m2.ToonLeeftijd();
```

Dan zien we volgende uitvoer:

```text
3
2
```

Ieder object houdt de stand van z'n eigen variabelen bij. Ze kunne mekaars interne \(zowel publieke als private\) staat niet veranderen.

#### Variabelen MET static

We maken de variabele `private int leeftijd` static als volgt: `private static int leeftijd=1;`.

We krijgen dan:

```csharp
class Mens
{
    private static int leeftijd=1;
    public void Jarig()
    {
        leeftijd++;
    }

    public void ToonLeeftijd()
    {
        Console.WriteLine(leeftijd);
    }
}
```

**We hebben nu gezegd dat ALLE objecten de variabele leeftijd delen. Er wordt van deze variabele dus maar een "instantie" in het geheugen gemaakt.**

Voeren we nu terug volgende code uit:

```csharp
Mens m1= new Mens();
Mens m2= new Mens();

m1.Jarig();
m1.Jarig();

m2.Jarig();

m1.ToonLeeftijd();
m2.ToonLeeftijd();
```

Dan wordt de uitvoer:

```text
4
4
```

Static laat je dus toe om informatie over de objecten heen te delen. **Gebruik static niet te pas en te onpas: vaak druist het in tegen de concepten van OO en wordt het vooral misbruikt** Ga je dit vaak nodig hebben? Niet zo vaak. Het volgende concept wel.

### Methoden met static

Heb je er al bij stil gestaan waarom je dit kan doen:

```text
Math.Pow(3,2);
```

Zonder dat we objecten moeten aanmaken in de trend van:

```csharp
Math myMath= new Math(); //dit mag niet!
myMath.Pow(3,2)
```

De reden dat je de math-bibliotheken kan aanroepen rechtsreeks **op de klasse** en niet op objecten van die klasse is omdat de methoden in die klasse als `static` gedefineerd staan.

### Voorbeeld van static methoden

Stel dat we enkele veelgebruikte methoden willen groeperen en deze gebruiken zonder telkens een object te moeten aanmaken dan doen we dit als volgt:

```csharp
class EpicLibray
{
    static public void ToonInfo()
    {
        Console.WriteLine("Ik ben ik");
    }

    static public int TelOp(int a, int b)
    {
        return a+b;
    }
}
```

We kunnen deze methoden nu als volgt aanroepen:

```csharp
EpicLibrary.ToonInfo();

int opgeteld= EpicLibrary.TelOp(3,5);
```

Mooi toch.

### Nog een voorbeeld

In het volgende voorbeeld gebruiken we een `static` variabele om bij te houden hoeveel objecten \(via de constructor\) er van de klasse reeds zijn aangemaakt:

```csharp
class Fiets
{
    private static int aantalFietsen = 0;
    public Fiets()
    {
        aantalFietsen++;
        Console.WriteLine($"Er zijn nu {aantalFietsen} gemaakt");
    }

    public static void VerminderFiets()
    {
        aantalFietsen--;
    }
}
```

Merk op dat we de methoden `VerminderFiets` enkel via de klasse kunnen aanroepen:

```csharp
Fiets.VerminderFiets();
```

#### `private static`?

Merk op dat, in bovenstaand voorbeeld, `aantalFietsen` `private` is en dat er geen publieke property aanwezig is, terwijl een constructor **wel** bij een instantie hoort. Herinner je ook dat `private` onderdelen van een klasse alleen toegankelijk zijn vanuit code binnenin die klasse. De code voor objecten van een bepaalde klasse staat ook binnenin die klasse, dus `private static` onderdelen van een klasse **zijn toegankelijk voor de objecten van die klasse**!

## Static vs non-static

Van zodra je een methode hebt die `static` is dan zal deze methode enkel andere ```static`` methoden en variabelen kunnen aanspreken. Dat is logisch: een static methode heeft geen toegang tot de gewone niet-statische variabelen van een individueel object, want welk object zou hij dan moeten aanpassen?

Volgende code zal dus een error geven:

```csharp
class Mens
{
    private int gewicht=50;

    private static void VerminderGewicht()
    {
        gewicht--;
    }
}
```

De error die verschijnt **An object reference is required for the non-static field, method, or property 'Program.Fiets.gewicht'** zal bij de lijn `gewicht--` staan.

Een eenvoudige regel is te onthouden dat van zodra je in een static omgeving \(meestal een methode\) bent je niet meer naar de niet-static delen van je code zal geraken.

## Static en main

Dit verklaart ook waarom je bij console applicaties in Program.cs steeds alle methoden `static` moet maken. Een console-applicatie is als volgt beschreven wanneer je het aanmaakt:

```csharp
public class Program
{
        public static void Main()
        {

        }
}
```

Zoals je ziet is de `Main` methode als `static` gedefinieerd. Willen we dus vanuit deze methode andere methoden aanroepen dan moeten deze als `static` aangeduid zijn.

Uiteraard kan je wel niet-static zaken gebruiken en daarom kan je dus gewone objecten etc. in je static methoden aanmaken.

