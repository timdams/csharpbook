## Enum
<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
Helm op alsjeblieft! ``enum`` is een erg onderschat concept bij beginnende programmeurs. Enums zijn wat raar in het begin, maar van zodra je er mee weg bent zal je niet meer zonder kunnen en zal je code zoveel eleganter en stoerder worden. Zet je helm dus op en begin er aan!
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

### De bestaansreden voor enums
Stel dat je een programma moet schrijven dat afhankelijk van de dag van de week iets anders moet doen. In een wereld zonder enums (**enumeraties**, letterlijk *opsommingen*) zou je dit kunnen schrijven op 2 zeer foutgevoelige manieren:
1. Met een ``int`` die een getal van 1 tot en met 7 kan bevatten, afhankelijk van de dag (bv. 1 voor maandag, enz.)
2. Met een ``string`` die de naam van de dag bevat (bv. ``woensdag``)

#### Slechte oplossing 1: Met ``int``
De waarde van de dag staat in een variabele ``int dagKeuze``. We bewaren er 1 in voor Maandag, 2 voor dinsdag, enzovoort. Vervolgens kunnen we dan schrijven: 

```java
if(dagKeuze==1)
{
    Console.WriteLine("We doen de maandag dingen");
}
else 
if (dagKeuze==2)
{
    Console.WriteLine("We doen de dinsdag dingen");
}
else 
if //enz.
```

Deze oplossing heeft 2 grote nadelen:
* Wat als we per ongeluk ``dagKeuze`` een niet geldige waarde geven, zoals 9, 2000 of  -4 ?
* De code is niet erg leesbaar. Wat was ``dagKeuze==2`` nu weer? Was ``2`` nu dinsdag of woensdag (want misschien was maandag 0 i.p.v. 1) ?

#### Slechte oplossing 2: Met strings

Laten we tweede manier eens bekijken: de waarde van de dag bewaren we in een variabele ``string dagKeuze``. We bewaren de dagen als ``"maandag"``, ``"dinsdag"``, etc.

```java
if(dagKeuze=="maandag")
{
    Console.WriteLine("We doen de maandag dingen");
}
else 
if (dagKeuze=="dinsdag")
{
    Console.WriteLine("We doen de dinsdag dingen");
}
else 
if //enz.
```

De code wordt nu wel leesbaarder, maar toch is ook hier 1 groot nadeel:
* De code is veel foutgevoeliger voor typfouten. Wanneer je ``"Maandag"`` i.p.v. ``"maandag"`` bewaard dan zal de if al niet werken. Iedere schrijffout of variant zal falen. 

### Enumeraties: het beste van beide wereld.
Enumeraties (**enum**) zijn een C# syntax dat bovenstaand probleem oplost en het beste van beide slechte oplossingen samenvoegt : 
1. **leesbaardere code**.
2. Minder foutgevoelige code, en dus minder potentiële bugs.
3. VS kan je helpen met met sneller de nodige code te schrijven.

Het keyword ``enum`` geeft aan dat we een nieuw datatype maken dat maar enkele mogelijke waarden kan hebben. Nadat we dit nieuwe datatype hebben gedefiniëerd kunnen we variabele van dit nieuwe datatype aanmaken. Deze variabele zal enkel waarden mogen bevatten die in het datatype werden gedefinieerd. Ook zal IntelliSense van Visual Studio je de mogelijke waarden helpen invullen.

{% hint style='tip' %}
In C# zitten al veel Enum-types ingebouwd. Denk maar aan ``ConsoleColor``: wanneer je de kleur van het lettertype van de console wilt veranderen gebruiken we een enum-type. Er werd reeds gedefinieerd wat de toegelaten waarden zijn, bijvoorbeeld: ``Console.ForegroundColor = ConsoleColor.Red;`` 
{% endhint %}

### Zelf enum maken
Zelf een ``enum`` type maken gebeurt in 2 stappen:
1. Het nieuwe datatype en de mogelijke waarden definiëren.
2. Variabele(n) van het nieuwe type aanmaken en gebruiken in je code.

#### Stap 1: het nieuwe datatype definiëren
We maken eerst een enum type aan. **In je console-applicaties moet dit binnen ``class Program`` gebeuren, maar niét binnen de (``main``) methoden**:
```java
enum Weekdagen{Maandag,Dinsdag,Woensdag,Donderdag,Vrijdag,Zaterdag,Zondag};
```

Als volgt dus:

```java
enum Weekdagen{Maandag,Dinsdag,Woensdag,Donderdag,Vrijdag,Zaterdag,Zondag};

static void Main(string[] args)
{
    Console.WriteLine("Hello enum");
}
```
We hebben nu letterlijk een nieuwe datatype aangemaakt, genaamd ``Weekdagen``. Net zoals ``int``, ``double`` etc. kan je nu ook variabelen van het type ``Weekdagen`` aanmaken. Hoe cool is dat?!


#### Stap 2: variabelen van het nieuwe datatype aanmaken en gebruiken

We kunnen nu variabelen van het type ``Weekdagen`` aanmaken. Bijvoorbeeld:
```java
Weekdagen dagKeuze;
Weekdagen andereKeuze;
```

En vervolgens kunnen we waarden aan deze variabelen toewijzen als volgt:

```java
dagKeuze = Weekdagen.Donderdag;
```

Kortom: we hebben variabelen zoals we gewoon zijn, het enige verschil is dat we nu beperkt zijn in de waarden die we kunnen toewijzen. Deze kunnen enkel de waarden krijgen die in het type gedefiniëerd werden. De code is nu ook een pak leesbaarder geworden.

<!---{pagebreak} --->

### Enums en beslissingen werken graag samen
Ook de beslissingsstructuren worden leesbaarder:
```java
if(dagKeuze == Weekdagen.Woensdag)
```
of een switch:
```java
switch(dagKeuze)
{
    case Weekdagen.Maandag:
        Console.WriteLine("It's monday!");
        break;
    case Weekdagen.Dinsdag:
     //etc.
}
```

{% hint style='tip' %}
Visual Studio houdt van enums (ik ook) en zal je helpen bij het schrijven van een ``switch`` indien je test-variabele een enum-type bevat. 
Hoe?

* Schrijf ``switch`` en druk op 2 maal op tab. Normaal verschijnt er nu een "prefab" switch structuur met een test-waarde genaamd ``switch_on`` die een gele achtergrond heeft
* Overschrijf ``switch_on`` met de variabele die je wilt testen (bv ``dagKeuze``)
* Klik nu met de muis eender waar binnen de accolades van de ``switch``
* Profit!
{% endhint %}

<!---{pagebreak} --->

### Conversie van en naar enum variabelen
Intern worden de enum-variabelen als ints bewaard. In het geval van de ``Weekdagen`` zal maandag standaard de waarde 0 krijgen, dinsdag 1, etc.

Volgende conversies met behulp van **casting** zijn dan ook perfect toegelaten:

```java
int keuze = 3;

Weekdagen dagKeuze = (Weekdagen)keuze;

//dagKeuze zal de waarde Weekdagen.Donderdag hebben
```

Wil je dus bijvoorbeeld 1 dag bijtellen dan kan je schrijven:

```java
Weekdagen dagKeuze= Weekdagen.Dinsdag;
int extradag= (int)dagKeuze + 1;
Weekdagen nieuweDag= (Weekdagen)extradag;
//extraDag heeft de waarde Weekdagen.Woensdag
```

Let er wel op dat je geen extra dag op Zondag probeert bij te tellen. Dat zal niet werken.

### Andere interne waarde toekennen

Standaard worden de enum waarden intern dus genummerd beginnende bij 0. Je kan dit ook manueel veranderen door bij het maken van de ``enum`` expliciet aan te geven wat de interne waarde moet zijn, als volgt:

```java
enum WeekDagen 
    {Maandag=1, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag}
```
De dagen zullen nu vanaf 1 genummerd worden, dus ``WeekDagen.Woensdag`` zal de waarde 3 hebben.

We kunnen ook nog meer informatie meegeven, bijvoorbeeld:
```java
enum WeekDagen 
    {Maandag=1, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag=50, Zondag=60}
```

In dit geval zullen Maandag tot Vrijdag intern als 1 tot en met 5 bewaard worden, Zaterdag als 50, en Zondag als 60.

{% hint style='tip' %}

### Gebruikersinvoer naar enum

Heel vaak zal je een programma schrijven waarbij de gebruiker een keuze moet maken uit een menu of iets dergelijks. Dit menu kan je voorstellen met een enum. Het probleem is vervolgens vragen wat de keuze van de gebruiker is en deze dan verwerken. Je zou dit kunnen doen met behulp van een reeks if-testen (``if(userinput=="demo")`` ), of je zou het feit kunnen gebruiken dat we nu ``enum`` kennen. 

Volgende code toont hoe je dit kunt doen:

```java
enum Menu {Demo=1, Start, Einde}
static void Main(string[] args)
{
    Console.WriteLine("Wat wil je doen?");
    Console.WriteLine("1. Demo");
    Console.WriteLine("2. Start");
    Console.WriteLine("3. Einde");
    int userkeuze = Convert.ToInt32(Console.ReadLine());

    Menu keuze = (Menu)userkeuze;

    switch (keuze)
    {
        //...
```
{% endhint %}

<!---{pagebreak} --->

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)

Ah, de tijden zonder ``enum``. Ik weet nog hoe we onze grotten beschilderden zonder ons druk te moeten maken in enumeraties. Om maar te zeggen: je kan perfect leven zonder ``enum``. Vele programmeurs voor je hebben dit bewezen. Echter, van zodra ze ``enum`` ontdekten (en begrepen) zijn nog maar weinig programmeurs er terug van afgestapt. 

De eerste kennismaking met enumeraties is wat bevreemdend: je kan plots je eigen datatypes aanmaken?! Van zodra je ze in de vingers hebt zal je ontdekken dat je veel leesbaardere code kunt schrijven én dat Visual Studio je kan helpen met het opsporen van bugs. 

Wanneer gebruik je ``enum``? Telkens je een variabele (of meerdere) nodig hebt waarvan je perfect op voorhand weet welke (handvol) mogelijke waarden ze mogen hebben. Ze worden bijvoorbeeld vaak gebruikt in **finite state machines**. 

Bij game development willen we bijhouden in welke staat het programma zich bevindt: ``intro``, ``startmenu``, ``ingame``, ``gameover``, ``optionsscreen``, etc.

Dit is een typisch ``enum`` verhaal. We definiëren hiervoor het volgende type:

```java
enum gamestate {intro, startmenu, ingame, gameover, optionsscreen}
```
En vervolgens kunnen we dan met een eenvoudige switch in ons hoofdprogramma snel de relevante code uitvoeren:

```java
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

Een ander typisch voorbeeld is schaken. We maken een enum om de speelstukken voor te stellen (``Pion, Koning, Toren`` etc.) en kunnen hen dan laten bewegen en vechten in uiterst leesbare code:

```java
if(spelstuk== Schaakstuk.Paard)
```


<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)
* [Enums gebruiken](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=9273e56b-1bfa-4393-a14a-aaed00bd4eaf)
<!---NOBOOKEND--->
