# Arrays

Arrays zijn een veelgebruikt principe in vele programmeertalen. Het grote voordeel van arrays is dat je een enkele variabele kunt hebben die een grote groep waarden voorstelt van eenzelfde type. Hierdoor wordt je code leesbaarder en eenvoudiger in onderhoud. Arrays zijn een zeer krachtig hulpmiddel, maar er zitten wel enkele venijnige addertjes onder het gras.

Een array is niet meer dan een verzameling waarden van hetzelfde type (bijvoorbeeld een verzameling ints, doubles of chars). Deze waarden kunnen benaderd worden via 1 enkele variabele, de array zelf. Door middel van een *index* kan ieder afzonderlijk element uit de array aangepast of uitgelezen worden.

Een nadeel van arrays is dat, eens we de lengte van een array hebben ingesteld, deze lengte niet meer kan veranderen. Later zullen we leren werken met lists en andere collections die dit nadeel niet meer hebben (zie [hier](../17_gencols/8_Collections.md)).

## Nut van arrays

Stel dat je de dagelijkse neerslag wenst te bewaren. Dit kan je zonder arrays eenvoudig:

```csharp
int dag1= 34;
int dag2= 45;
int dag3= 0;
int dag4= 34;
int dag5= 12;
int dag6= 0;
int dag7= 23;
```

Maar wat als je plots de neerslag van een heel jaar, 365 dagen, wenst te bewaren. Of een hele eeuw? Van zodra je een bepaalde soort data hebt die je veelvuldig wenst te bewaren dan zijn arrays de oplossing.

## Bron

Grote delen van dit hoofdstuk zijn vertaald uit het handboek C# 4.0 Essentials.

# Array Basics

## Arrays declareren
Een array creëren (declareren) kan op verschillende manieren. Hoewel manier 1 de meest gebruikelijke is, zal deze voor de beginnende programmeur nog wat abstract lijken vanwege het gebruik van het ``new`` keyword. Manier 2 is de eenvoudigste en snelste manier, maar deze is wel minder flexibel.

### Manier 1
De eenvoudigste variant is deze waarbij je een array variabele aanmaakt, maar deze nog niet initialiseert (i.e. je maakt enkel een identifier in aan). De syntax is als volgt:

```csharp
type[] arraynaam;
```
Type kan dus eender welk type zijn dat je reeds kent. De [ ] (*square brackets*) duiden aan dat het om een array gaat.

Voorbeelden van array declaraties kunnen dus bijvoorbeeld zijn:
```csharp
    int[] verkoopCijfers;
    double[] gewichtHuisdieren;
    bool[] examenAntwoorden;
```
Stel dat je dus een array van strings wenst waarin je verschillende kleuren zal plaatsen dan schrijf je:
```csharp
string[] myColors;
```
Vervolgens kunnen we later waarden toekennen aan de array, hiervoor gebruiken we het ``new`` sleutelwoord.

```csharp
string[] myColors;
myColors = new string[] {"red", "green", "yellow", "orange", "blue"};
```
Je array zal vanaf dit punt een lengte van 5 hebben en kan niet meer groeien.

### Manier 2
Indien je direct waarden wilt toekennen (initialiseren) tijdens het aanmaken van de array zelf dan mag dit ook als volgt:

```csharp
string[] myColors = {"red", "green", "yellow", "orange", "blue"};
```
Ook hier zal dus vanaf dit punt je array een vaste lengte van 5 elementen hebben. Merk op dat deze manier dus enkel werkt indien je reeds weet welke waarden in de array moeten. In manier 1 kunnen we perfect een array aanmaken en pas veel later in programma ook effectief waarden toekennen (bijvoorbeeld door ze stuk per stuk door een gebruiker te laten invoeren).

### Manier 3
Nog een andere manier om arrays aan te maken is de volgende, waarbij je aangeeft hoe groot de array moet zijn, zonder reeds effectief waarden toe te kennen:

```csharp
string[] myColors;
myColors = new string[5];
```

### Samengevat

De 3 manieren om arrays te declareren zijn dus:

```csharp
//Manier 1
string[] myColors;
myColors = new string[] {"red", "green", "yellow", "orange", "blue"};
//Manier 2
string[] myColors = {"red", "green", "yellow", "orange", "blue"};
//Manier 3
string[] myColors;
myColors = new string[5];
```



## Elementen van een array aanpassen en uitlezen
Van zodra er waarden in een array staan of moeten bijgeplaatst worden dan kan je deze benaderen met de zogenaamde *array accessor* notatie Deze notatie is heel eenvoudigweg de volgende:

```csharp
myColors[i];
```
We plaatsen de naam van de array, gevolgd door brackets waarbinnen een getal *i* aangeeft het hoeveelste element we wensen te benaderen (lezen en/of schrijven).

**De index van een C#-array start steeds bij 0. Indien je dus een array aanmaakt met lengte 10 dan heb je de indices 0 tot en met 9.**

![](../assets/5_arrays/arrays1.png)

### Veelgemaakte fouten: Lengte en indexering van arrays
Het gebeurt vaak dat beginnende programmeurs verward geraken omtrent het aanmaken van een array aan de hand van de lengte en het indexeren.

De regels zijn duidelijk:
* Bij het maken van een array is de lengte van een array gelijk aan het aantal elementen dat er in aanwezig is. Dus een array met 5 elementen heeft als lengte 5.
* Bij het schrijven en lezen van individuele elementen uit de array (zie hierna) gebruiken we een indexering die start bij 0. Bijgevolg is de index **4** van het laatste elemente in een array met **lengte 5**.

## Schrijven
Ook schrijven van waarden naar de array gebruikt dezelfde notatie. Enkel moet je dus deze keer de array accessor-notatie links van de toekenningsoperator plaatsen. Stel dat we bijvoorbeeld de waarde van het eerste element uit de myColors array willen veranderen van red naar indigo, dan gebruiken we volgende notatie:

```csharp
myColors[0] = "indigo";
```
Als we dus bij aanvang nog niet weten welke waarden de individuele elementen moeten hebben in een array, dan kunnen we deze eerst definiëren, en vervolgens individueel toekennen:

```csharp
string[] myColors;
myColors = new string[5];
// ...
myColors[0] = "red";
myColors[1] = "green";
myColors[2] = "yellow";
myColors[3] = "orange";
myColors[4] = "blue";
```
## Uitlezen
Stel dat we een array aanmaken (eerste lijn) dan kunnen we dus bijvoorbeeld het getal ``90`` op het scherm tonen als volgt:

```csharp
int[] scores = {100, 90, 55, 0, 34};
int kopie = scores[1];
Console.WriteLine(kopie);
```
of nog korter:

```csharp
int[] scores = {100, 90, 55, 0, 34};
Console.WriteLine(scores[1]);
```

Stel dat we een array van getallen hebben, dan kunnen we dus bijvoorbeeld 2 waarden uit die array optellen en opslaan in een andere variabele als volgt:

```csharp
int[] numbers = {5, 10, 30, 45};
int som = numbers[0] + numbers[1];
```
De variabele som zal dan vervolgens de waarde 15 bevatten (5+10).


Stel dat we alle elementen uit de array ``numbers`` met 5 willen verhogen, we kunnen dan schrijven:

```csharp
int[] numbers = {5, 10, 30, 45};
numbers[0] += 5;
numbers[1] += 5;
numbers[2] += 5;
numbers[3] += 5;
```

Nog beter is het natuurlijk deze code (die 4 keer quasi dezelfde statement bevat) te vereenvoudigen tot:
```csharp
int[] numbers = {5, 10, 30, 45};
int teller = 0;
while (teller < 4)
{
    numbers[teller] += 5;
    teller++
}
```

Of het equivalent met een for-loop:
```csharp
int[] numbers = {5, 10, 30, 45};
for(int teller = 0; teller < 4; teller++)
{
    numbers[teller] += 5;
}
```

## De lengte van de array te weten komen
Soms kan het nodig zijn dat je in een later stadium van je programma de lengte van je array nodig hebt. De ``Length`` eigenschap van iedere array geeft dit weer. Volgend voorbeeld toen dit:
```csharp
string[] myColors = {"red", "green", "yellow", "orange", "blue"};
Console.WriteLine("Length of array = {0}", myColors.Length);
```
De variabele myColors.Length is een special element, van het type int, die iedere array met zich meedraagt (zie volgende semester). Je kan dus deze lengte ook toekennen aan een variabele:

```csharp
int arrayLength = myColors.Length;
```
De Length-property wordt vaak gebruikt in for/while loops waarmee je de hele array wenst te doorlopen. Door de Length-property te gebruiken als grenscontrole verzekeren we er ons van dat we nooit buiten de grenzen van de array zullen lezen of schrijven:

```csharp
//Alle elementen van een array tonen
for (int i = 0; i < getallen.Length; i++)
{
    Console.WriteLine(getallen[i]);
}
```
## Volledig voorbeeldprogramma met arrays
Met al de voorgaande informatie is het nu mogelijk om heel eenvoudig complexere programma's te schrijven die veel data moeten kunnen verwerken. Meestal gebruikt men een for-element om een bepaalde operatie over de hele array toe te passen.

Het volgende programma zal een array van integers aanmaken die alle gehele getallen van 0 tot 99 bevat. Vervolgens zal ieder getal met 3 vermenigvuldigd worden. Finaal tonen we tonen we enkel die getallen die een veelvoud van 4 zijn na de bewerking.

```csharp
//Array aanmaken
int[] getallen = new int[100];
 
//Array vullen
for (int i = 0; i < getallen.Length; i++)
{
    getallen[i] = i;
}
 
//Alle elementen met 3 vermenigvuldigen
for (int i = 0; i < getallen.Length; i++)
{
    getallen[i] = getallen[i] * 3;
}
 
//Enkel veelvouden van 4 op het scherm tonen
for (int i = 0; i < getallen.Length; i++)
{
    if(getallen[i] % 4 == 0)
        Console.WriteLine(getallen[i]);
}
```

# Geheugengebruik bij arrays

[Zie volgend filmpje op 31 minuten.](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=17ce5c87-2b6a-46ea-b7b1-a87e00a7e4e5)

# Arrays kopiëren

Arrays worden 'by reference' gebruikt in C#. Het gevolg hiervan is dat volgende code niet zal doen wat je wenst (``ploegen``, ``nieuwePloegen`` zijn twee arrays van bijvoorbeeld een ``string[]``).
```csharp
nieuwePloegen = ploegen;
```
Deze code zal perfect werken. Wat er er echter is gebeurd is dat we de referentie naar ``ploegen`` ook in ``nieuwePloegen`` hebben geplaatst. Bijgevolg verwijzen beide variabelen naar dezelfde array, namelijk die waar ``ploegen`` al naar verwees. We hebben een soort alias gemaakt en kunnen nu op twee manieren de array benaderen.
Als je dus  schrijft:
```csharp
nieuwePloegen[4] = "Beerschot";
```
Dan is dat hetzelfde als schrijven:
```csharp
ploegen[4] = "Beerschot";
```

En waar staan de ploegen in de nieuwePloegen array? *Die bestaat niet meer!*

Wil je dus arrays kopieren dan kan dat niet op deze manier: **je moet manueel ieder element van de ene naar de andere array kopiëren** als volgt:
```csharp
for(int i = 0; i < ploegen.Length; i++)
{
    nieuwePloegen[i] = ploegen[i];
}
```

**Opgelet: wanneer je met arrays van objecten (zie [later](../11_arraysvanklassen/7_arraysvanobj.md)) werkt dan zal bovenstaande mogelijk niet het gewenste resultaten geven daar we nu de individuele referenties van een object kopieren!**

