# Enum

{% hint style="success" %}
[Kennisclip](https://youtu.be/k4aeNzfH31E)
{% endhint %}

## Enum datatypes

De datatypes die je al kent, kunnen veel of weinig waarden voorstellen. Met een string kan je bijvoorbeeld om het even welke tekst voorstellen, dus oneindig veel mogelijkheden. Met een byte kan je een getal tussen 0 en 255 voorstellen. Met de andere getaltypes kan je een getal in een ander bereik voorstellen. Soms matchen de waarden die je kan voorstellen niet met de mogelijkheden in het probleemdomein. Als je de mogelijkheden in het probleemdomein op voorhand kan vastleggen, is het vaak handig gebruik te maken van een **enumeratie** \(**enum**\). Een enumeratie is **een opsomming van alle mogelijke waarden** voor een variabele van een bepaald type.

## Een voorbeeld: weekdagen

Stel dat je een programma moet schrijven dat afhankelijk van de dag van de week iets anders moet doen. Zonder enums zou je dit kunnen schrijven op 2 zeer foutgevoelige manieren:

1. Met een `int` die een getal van 1 tot en met 7 kan bevatten
2. Met een `string` die de naam van de dag bevat

Beide hebben tekortkomingen, omdat ze niet goed genoeg overeenstemmen met de mogelijkheden in de werkelijkheid.

### Slechte oplossing 1: Met ints

De waarde van de dag staat in een variabele `int dagKeuze`. We bewaren er 1 in voor Maandag, 2 voor dinsdag, enzovoort.

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

* Wat als we per ongeluk `dagKeuze` een niet geldige waarde geven, zoals 9, 2000, -4, etc. ? We kunnen daar wel conditionele code voor voorzien, maar de compiler zal ons niet waarschuwen als we dat vergeten!
* De code is niet erg leesbaar. `dagKeuze==2`? Was dat nu maandag, dinsdag of woensdag \(want misschien beginnen we te tellen vanaf zondag, of misschien beginnen we te tellen vanaf 0\). Je kan wel afspraken maken binnen je team, maar het is altijd mogelijk een afspraak te vergeten.

### Slechte oplossing 2: Met strings

De waarde van de dag bewaren we nu in een variabele `string dagKeuze`. We bewaren de dagen als `"maandag"`, `"dinsdag"`, etc.

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

* De code is veel foutgevoeliger voor typfouten. Wanneer je `"Maandag"` i.p.v. `"maandag"` bewaart dan zal de `if` al niet werken. Iedere schrijffout of variant zal falen. 

## Enumeraties: het beste van beide werelden

Het keyword `enum` geeft aan dat we een nieuw datatype maken dat maar enkele mogelijke waarden kan hebben. Nadat we dit nieuwe type hebben gedefinieerd kunnen we variabelen van dit nieuwe type aanmaken.

In C\# zitten al veel `enum`-types ingebouwd. Denk maar aan `ConsoleColor`: wanneer je de kleur van het lettertype van de console wilt veranderen gebruiken we een enum-type. Er werd reeds gedefinieerd wat de toegelaten waarden zijn, bijvoorbeeld: `Console.ForegroundColor = ConsoleColor.Red;`

Achter de schermen worden waarden van een enum type nog steeds voorgesteld als getallen. Maar je gebruikt deze getallen niet rechtstreeks en dat verkleint de risico's.

### Zelf enum maken

Zelf een `enum` type gebruiken gebeurt in 2 stappen:

1. Het type en de mogelijke waarden definiëren
2. Variabele\(n\) van het nieuwe type aanmaken en gebruiken in je code

#### Stap 1: het type definiëren

We maken eerst een enum type aan. **Wij zullen dit doen in een aparte file met dezelfde naam als het nieuwe datatype.** Bijvoorbeeld:

```csharp
namespace Programmeren {
    enum Weekdagen {Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag}
}
```

Vanaf nu kan je variabelen van het type `Weekdagen` aanmaken. Merk op dat er **geen puntkomma** voorkomt. **De syntax is ongeveer dezelfde als die voor de definitie van een klasse.**

#### Stap 2: variabelen van het type aanmaken en gebruiken.

We kunnen nu variabelen van het type `Weekdagen` aanmaken. Bijvoorbeeld:

```csharp
Weekdagen dagKeuze;
Weekdagen andereKeuze;
```

En vervolgens kunnen we waarden aan deze variabelen toewijzen als volgt:

```csharp
dagKeuze = Weekdagen.Donderdag;
```

Kortom: we hebben variabelen zoals we gewoon zijn, het enige verschil is dat we nu beperkt zijn in de waarden die we kunnen toewijzen. Deze kunnen enkel de waarden zijn die in het type gedefinieerd werden. De code is nu ook een pak leesbaarder geworden.

### Waarden van een enum type inlezen

Eens je met enums aan het werken bent in je programma, kan je gerust zijn dat deze een geldige waarde bevatten. Er is alleen het probleem dat je soms een van de mogelijkheden moet krijgen van de gebruiker. Een waarde van een enum type rechtstreeks intypen gaat niet. Net zoals wanneer je een getal inleest, is er een omzetting nodig. Het verschil is dat we hier een dubbele omzetting doen: van tekst naar getal en dan van getal naar enum waarde.

Je kan dit als volgt doen:

```csharp
Weekdagen keuze;
Console.WriteLine("Welke dag is het vandaag?");
Console.WriteLine($"{(int) Weekdagen.Maandag}. {Weekdagen.Maandag}");
Console.WriteLine($"{(int) Weekdagen.Dinsdag}. {Weekdagen.Dinsdag}");
// enzovoort
keuze = (Weekdagen) Convert.ToInt32(Console.ReadLine());
```

Dit werkt en je hoeft de achterliggende getallen voor de waarden niet te kennen. Er zijn meer geavanceerde mogelijkheden, maar dit volstaat op dit punt.

## Nog enkele voorbeelden van enumeratietypes

De eerste kennismaking met enumeraties is wat bevreemdend: je kan plots je eigen datatypes aanmaken! Wanneer mag dat dan? Telkens je een variabele \(of meerdere\) nodig hebt waarvan je perfect op voorhand weet welke handvol mogelijke waarde ze mogen hebben.

#### Voorbeeld uit een video game

Er zijn slechts een handvol schermen waarop we ons kunnen bevinden en soms moet de code controleren op welk scherm we ons bevinden. Dan kan je dit doen:

```csharp
enum GameStates {Intro, Startmenu, Ingame, Gameover, Optionsscreen}
```

Nu kan je met een variabele van type `GameStates` bijhouden op welk scherm de gebruiker zich bevindt. Er zijn maar 5 mogelijkheden. Iets anders kan je aan die variabele niet toekennen.

#### Voorbeeld: rangen

In het Belgische leger bestaan er 23 militaire rangen. Om deze voor te stellen, kan je dit doen:

```csharp
enum Rangen {
Soldaat,
EersteSoldaat,
Korporaal,
KorporaalChef,
EersteKorporaalChef,
Sergeant,
EersteSergeant,
EersteSergeantChef,
EersteSergeantMajoor,
Adjudant,
AdjudantChef,
AdjudantMajoor,
Onderluitenant,
Luitenant,
Kapitein,
KapiteinCommandant,
Majoor,
LuitenantKolonel,
Kolonel,
BrigadeGeneraal,
GeneraalMajoor,
LuitenantGeneraal,
Generaal
}
```

Dit zijn de enige mogelijkheden. Je kan een variabele van type `Rangen` dus nooit de waarde `Maarschalk` geven, want die rang bestaat niet.

#### Voorbeeld: planeten in ons zonnestelsel

Schrijf je code die te maken heeft met ons zonnestelsel? Dan kan je dit gebruiken:

```csharp
enum Rangen {
Mercurius,
Venus,
Aarde,
Mars,
Jupiter,
Saturnus,
Uranus,
Neptunus
}
```

**Een enum is hier alleen geschikt als je je beperkt tot een vast stel planeten.** Je zou iets anders moeten gebruiken als je een onbegrensd aantal planeten wil toelaten, bijvoorbeeld als je het volledige heelal wil voorstellen.

