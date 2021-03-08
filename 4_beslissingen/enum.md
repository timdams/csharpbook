# Enum datatypes
{% hint style='tip' %}
Delen van dit hoofdstuk komen uit Visual C# 2012 -  De basis (Sander Gerz)
{% endhint %}

{% hint style='warning' %}
Dit is nog zo'n onderschat hoofdstuk. Enums zijn wat raar in het begin, maar van zodra je er mee weg bent zal je niet meer zonder kunnen!
{% endhint %}


# De bestaansreden voor enums
Stel dat je een programma moet schrijven dat afhankelijk van de dag van de week iets anders moet doen. In een wereld zonder enums (enumeraties) zou je dit kunnen schrijven op 2 zeer foutgevoelige manieren:
1. Met een ``int`` die een getal van 1 tot en met 7 kan bevatten 
2. Met een ``string`` die de naam van de dag bevat

## Slechte oplossing 1: Met ints
De waarde van de dag staat in een variabele ``int dagKeuze``. We bewaren er 1 in voor Maandag, 2 voor dinsdag, enzovoort.
```csharp
if(dagKeuze==1)
{
    Console.WriteLine("We doen de maandag dingen");
}
else 
if (dagKeuze==2)
{
    Console.WritLine("We doen de dinsdag dingen");
}
else 
if //enz..
```

Deze oplossing heeft 2 grote nadelen:
* Wat als we per ongeluk ``dagKeuze`` een niet geldige waarde geven, zoals 9, 2000, -4, etc. ? 
* De code is niet erg leesbaar. ``dagKeuze==2``? Was dat nu dinsdag of woensdag (want misschien was maandag 0 i.p.v. 1).

## Slechte oplossing 2: Met strings
De waarde van de dag bewaren we nu in een variabele ``string dagKeuze``. We bewaren de dagen als ``"maandag"``, ``"dinsdag"``, etc.
```csharp
if(dagKeuze=="maandag")
{
    Console.WriteLine("We doen de maandag dingen");
}
else 
if (dagKeuze=="dinsdag")
{
    Console.WritLine("We doen de dinsdag dingen");
}
else 
if //enz..
```

De code wordt nu wel leesbaarder dan met 1, maar toch is ook hier 1 groot nadeel:
* De code is veel foutgevoeliger voor typfouten. Wanneer je ``"Maandag"`` i.p.v. ``"maandag"`` bewaard dan zal de if al niet werken. Iedere schrijffout of variant zal falen. 

# Enumeraties: het beste van beide wereld.
Enumeraties (**enum**) zijn een C# syntax die bovenstaand probleem oplost en het beste van beide samenvoegt: **leesbaardere code** en visual studio kan je helpen met **minder foutgevoelige foute schrijven**.

 Het keyword ``enum`` geeft aan dat we een nieuw type maken dat maar enkele mogelijke waarden kan hebben. Nadat we dit nieuwe type hebben gedefiniëerd kunnen we variabele van dit nieuwe type aanmaken. De variabele die we dan later maken zal van dit type zijn en enkel de opgegeven waarden mogen bevatten. Ook zal IntelliSense van Visual Studio je de mogelijke waarden helpen invullen.

In C# zitten al veel Enum-types ingebouwd. Denk maar aan ``ConsoleColor``: wanneer je de kleur van het lettertype van de console wilt veranderen gebruiken we een enum-type. Er werd reeds gedefinieerd wat de toegelaten waarden zijn, bijvoorbeeld: ``Console.ForegroundColor = ConsoleColor.Red;`` 

## Zelf enum maken
Zelf een ``enum`` type maken gebeurt in 2 stappen:
1. Het type en de mogelijke waarden definiëren
2. Variabele(n) van het nieuwe type aanmaken en gebruiken in je code

### Stap 1: het type definiëren
We maken eerst een enum type aan. In je console-applicaties moet dit binnen ``class Program`` gebeuren, maar niét binnen de (``main``) methoden:
```csharp
enum Weekdagen {Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag}
```

Vanaf nu kan je variabelen van het type ``Weekdagen`` aanmaken.

Merk op dat er **geen puntkomma** achteraan komt.

#### Locatie enum definitie
Let er op dat je je ``enum`` op de juiste locatie in je code schrijft:
```csharp
public class Program
{
    enum Weekdagen {Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag}
    
    public static void Main(string[] args)
    {

    }
}
```


**Dit is fout:**
```csharp
public class Program
{
    public static void Main(string[] args)
    {
        enum Weekdagen {Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag}   
    }
}
```

### Stap 2: variabelen van het type aanmaken en gebruiken.
We kunnen nu variabelen van het type ``Weekdagen`` aanmaken. Bijvoorbeeld:
```csharp
Weekdagen dagKeuze;
Weekdagen andereKeuze;
```

En vervolgens kunnen we waarden aan deze variabelen toewijzen als volgt
```csharp
dagKeuze = Weekdagen.Donderdag;
```

Kortom: we hebben variabelen zoals we gewoon zijn, het enige verschil is dat we nu beperkt zijn in de waarden die we kunnen toewijzen. Deze kunnen enkel de waarden zijn die in het type gedefiniëerd werden. De code is nu ook een pak leesbaarder geworden.

## Enums en beslissingen werken graag samen
Ook de beslissingsstructuren worden leesbaarder:
```csharp
if(dagKeuze == Weekdagen.Woensdag)
```
of een switch:
```csharp
switch(dagKeuze)
{
    case Weekdagen.Maandag:
        Console.WriteLine("It's monday!");
        break;
    case Weekdagen.Dinsdag:
     //etc.
}
```

## Conversie
Intern worden de enum-variabelen als ints bewaard. In het geval van de ``Weekdagen`` zal maandag de waarde 0 krijgen, dinsdag 1, etc.

Volgende conversies met behulp van [casting](../3_data/4_converteren_casting.md) zijn dan ook perfect toegelaten:
```csharp
int keuze = 3;

Weekdagen dagKeuze = (Weekdagen)keuze;

//dagKeuze zal de waarde Weekdagen.Donderdag hebben
```
Wil je dus bijvoorbeeld 1 dag bijtellen dan kan je schrijven:
```csharp
Weekdagen dagKeuze= Weekdagen.Dinsdag;
int extradag= (int)dagKeuze + 1;
Weekdagen nieuweDag= (Weekdagen)extradag;
//extraDag heeft de waarde Weekdagen.Woensdag
```

## Andere interne waarde
Standaard worden de waarden dus genummerd intern beginnende bij 0, enz. Je kan dit ook manueel veranderen door bij het maken van de ``enum`` expliciet aan te geven wat de interne waarde moet zijn, als volgt:

```csharp
enum WeekDagen {Maandag=1, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag}
```
De dagen zullen nu vanaf 1 genummerd worden, dus ``WeekDagen.Woensdag`` zal de waarde 3 hebben.

We kunnen ook nog meer informatie meegeven, bijvoorbeeld:
```csharp
enum WeekDagen {Maandag=1, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag=50, Zondag=60}
```

In dit geval zullen Maandag tot Vrijdag intern als 1 tot en met 5 bewaard worden, Zaterdag als 50, en Zondag als 60.

# Why should I care?
![](../assets/care.jpg)

Je kan perfect leven zonder ``enum``. Vele programmeurs voor je hebben dit bewezen. Echter, van zodra ze ``enum``ontdekten (en begrepen) zijn nog maar weinig programmeurs ervan af gestapt. 

De eerste kennismaking met enumeraties is wat bevreemdend: je kan plots je eigen datatypes aanmaken?! Van zodra je ze in de vingers hebt zal je ontdekken dat je veel leesbaardere code kunt schrijven én dat Visual Studio je kan helpen met het opsporen van bugs. 

Wanneer gebruik je ``enum``? Telkens je een variabele (of meerdere) nodig hebt waarvan je perfect op voorhand weet welke handvol mogelijke waarde ze mogen hebben. Ze worden bijvoorbeeld vaak gebruikt in **finite state machines**. Bij game development willen we bijhouden in welke staat het programma zich bevindt: ``intro``, ``startmenu``, ``ingame``, ``gameover``, ``optionsscreen``, etc.
Dit is een typisch ``enum`` verhaal. We definiëren hiervoor het volgende type:
```csharp
enum gamestate {intro, startmenu, ingame, gameover, optionsscreen}
```
En vervolgens kunnen we dan met een eenvoudige switch in ons hoofdprogramma snel de relevante code uitvoeren:

```csharp
//Bij opstart:
gamestate playerGameState= gamestate.intro;

//later:
switch(playerGameState)
{
    case gamestate.intro:
        //show fancy movie
        break;
    case gamestate.startmenu:
        //show start menu
        break;
    //etc...
```

# Kennisclip
![](../assets/infoclip.png)
* [Enums gebruiken](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=9273e56b-1bfa-4393-a14a-aaed00bd4eaf)
