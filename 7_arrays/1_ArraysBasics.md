# Arrays

Arrays zijn een veelgebruikt principe in vele programmeertalen. Het grote voordeel van arrays is dat je een enkele variabele kunt hebben die een grote groep waarden voorstelt van eenzelfde type. Hierdoor wordt je code leesbaarder en eenvoudiger in onderhoud. Arrays zijn een zeer krachtig hulpmiddel, maar er zitten wel enkele venijnige addertjes onder het gras.

Op papier zijn arrays eenvoudig...helaas programmeren we niet (of zelden) op papier. In essentie is een array is niets meer dan **een verzameling variabelen van hetzelfde type** (bijvoorbeeld een verzameling ints, doubles of chars). Deze waarden kunnen benaderd worden via 1 enkele variabele, de array zelf. Door middel van een *index* kan ieder afzonderlijk element uit de array aangepast of uitgelezen worden.

Een nadeel van arrays is dat, eens we de lengte van een array hebben ingesteld, deze lengte niet meer kan veranderen. In het volgende boekdeel zullen we leren werken met lists en andere collections die dit nadeel niet meer hebben.

De nadelen zullen we echter met plezier erbij nemen wanneer we programma's beginnen schrijven die werken met véél data van dezelfde soort. Eenvoudigweg kan je stellen dat van zodra je 3 of meer variabelen heeft die dezelfde soort data bevatten, arrays altijd de oplossing zullen zijn.

## Nut van arrays

Stel dat je de dagelijkse neerslag wenst te bewaren om zo later de gemiddelde regen te berekenen. Dit kan je zonder arrays eenvoudig:

```java
int dag1 = 34;
int dag2 = 45;
int dag3 = 0;
int dag4 = 34;
int dag5 = 12;
int dag6 = 0;
int dag7 = 23;
```

Als  we je nu vragen om de gemiddelde neerslag te berekenen dan krijg je al een redelijk lang statement:

<!---{line-numbers:false}--->
```java
double gemiddelde= (dag1+dag2+dag3+dag4+dag5+dag6+dag7)/7.0;
```

Maar wat als je plots de neerslag van een heel jaar, 365 dagen, wenst te bewaren. Of een hele eeuw? Of een millennium?! Dat is niet werkbaar zonder een nieuw concept, dat van arrays, te introduceren. Van zodra je een bepaalde soort informatie hebt die je veelvuldig wenst te bewaren dan zijn arrays dus oplossing.


Voorgaande lijst van 7 aparte variabelen kunnen we eenvoudiger definiëren met 1 array (we bespreken de details verderop), genaamd ``regen``:

<!---{line-numbers:false}--->
```java
int[] regen  = {34, 45, 0, 34, 12, 0, 23}; 
```

<!--- {width:50%} --->
![Een schematische voorstelling van een lijst van aparte variabelen en het equivalent met een arrays](../assets/5_arrays/intro.png)

<!---{pagebreak} --->

Het gemiddelde berekenen kan dan als volgt:

<!---{line-numbers:false}--->
```java
double gemiddelde= (dag[0]+dag[1]+dag[2]+dag[3]+dag[4]+dag[5]+dag[6])/7.0;
```

Dat lijkt niet veel beter, integendeel, we zitten nu ook nog met een hoop vierkante haakjes (``[]``). 

De kracht van arrays komt nu: het getal tussen die vierkante haakjes (de index) kan je als een variabele beschouwen en dus ook dynamisch genereren in een loop. Volgende voorbeeld toont hoe we bijvoorbeeld een langere array van elementen met een for-loop overlopen om de som van alle elementen te berekenen:

```java
int[] regen  = {34, 45, 0, 34, 12, 0, 23, 7 , 20, 34 , 7 , 42}; //aanmaken array
double som=0;
for(int i=0; i<regen.Length;i++)
{
    som+=regen[i]; //element per element uit array optellen
}
double gemiddelde=som/regen.Length;
```



<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)

Sorry dat we weer even in het diepe water zijn gedoken. Het leek ons nuttig om even het totaalplaatje van arrays alvast uit de doeken te doen, zodat je snapt waarom er zo enthousiast over arrays wordt gedaan hier. 

A propos, kijk eens achterom! Schrik je van he. Je hebt al een aardige weg afgelegd als we vergelijken met de eerste keer toen ik je in het zwembad gooide. Herinner je je nog dat ik volgende code liet zien En je vervolgens moest gerust stellen?

```java
using System;
namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // enz.
```

Alles wordt kinderspel, als je maar lang genoeg met iets bezig bent. Zelfs de code die we net toonden met die arrays zou je niet meer zo erg mogen afschrikken als die eerste keer. Ok, er staan wat nieuwe termen tussen, maar al bij al zouden de grote lijnen van het algoritme en de werking ervan duidelijk moeten zijn.

Blijf dus maar hier lekker in het diep dobberen en ontdek verder waarom arrays zo'n krachtig concept zijn.
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->


## Arrays declareren
Een array creëren (declareren) kan op verschillende manieren.

### Manier 1
De eenvoudigste variant is deze waarbij je een array variabele aanmaakt, maar deze nog niet initialiseert (i.e. je maakt enkel een identifier in aan). De syntax is als volgt:

<!---{line-numbers:false}--->
```java
type[] arraynaam;
```
Type kan dus eender welk bestaand datatype zijn dat je reeds kent. De [] (*square brackets*) duiden aan dat het om een array gaat.

Voorbeelden van array declaraties kunnen dus bijvoorbeeld zijn:
```java
int[] verkoopCijfers;
double[] gewichtHuisdieren;
bool[] examenAntwoorden;
ConsoleColor[] mijnKleuren;
```

Op dit punt bestaan de arrays nog niet ect. **Hun lengte ligt nog niet vast.**


Stel dat je dus een array van strings wenst waarin je verschillende kleuren zal plaatsen dan schrijf je:

```java
string[] myColors;
```
Vervolgens kunnen we later waarden toekennen aan de array:

```java
string[] myColors;
myColors = {"red", "green", "yellow", "orange", "blue"};
```

Je array zal vanaf dit punt **een lengte van 5 hebben en kan niet meer groeien**.


### Manier 2
Indien je ogenblikkelijk waarden wilt toekennen (*initialiseren*) tijdens het aanmaken van de array zelf dan mag dit ook als volgt:

```java
string[] myColors = {"red", "green", "yellow", "orange", "blue"};
```

Ook hier zal dus vanaf dit punt je array een vaste lengte van 5 elementen hebben. 

Merk op dat deze manier dus enkel werkt indien je reeds weet welke waarden in de array moeten. In manier 1 kunnen we perfect een array aanmaken en pas veel later in programma ook effectief waarden toekennen (bijvoorbeeld door ze stuk per stuk door een gebruiker te laten invoeren).

### Manier 3
Nog een andere manier om arrays aan te maken is de volgende, waarbij je aangeeft hoe groot de array moet zijn, zonder reeds effectief waarden toe te kennen:

```java
string[] myColors;
myColors = new string[5];
```

Uiteraard kan dit ook in 1 stap:

```java
string[] myColors = new string[5];
```
We geven hier aan dat de array vanaf z'n prille bestaan 5 elementen kan bevatten.

{% hint style='tip' %}
Ook hier geldt dat de lengte vanaf dan vastligt en niet meer kan veranderen.
{% endhint %}


## Elementen van een array aanpassen en uitlezen
Van zodra er waarden in een array staan of moeten bijgeplaatst worden kan je deze benaderen met de zogenaamde **array accessor** notatie. Deze notatie is heel eenvoudigweg de volgende:

```java
myColors[2];  //element met index 2
```

We plaatsen de naam van de array, gevolgd door brackets waarbinnen een getal , 2 in dit voorbeeld, aangeeft het hoeveelste element we wensen te benaderen (lezen en/of schrijven). Deze nummering start vanaf 0.

{% hint style='tip' %}
**De index van een C#-array start steeds bij 0.** Indien je dus een array aanmaakt met lengte 5 dan heb je de indices 0 tot en met 4.

<!--- {width:45%} --->
![Lengte is 5, index laatste element is 4, eerste element is 0](../assets/5_arrays/arrays1.png)
{% endhint %}


<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
**Veelgemaakte fouten bij arrays gebeuren op de lengte en indexering ervan**

Het gebeurt vaak dat beginnende programmeurs verward geraken omtrent het aanmaken van een array aan de hand van de lengte en het indexeren erna. Maar niet getreurd, ik zal je hier extra tips geven.

De regels zijn duidelijk:
* Bij het maken van een array is de lengte van een array gelijk aan het aantal elementen dat er in aanwezig is. *Dus een array met 5 elementen heeft als lengte 5.*
* Bij het schrijven en lezen van individuele elementen uit de array (zie hierna) gebruiken we een indexering die start bij **0**. Bijgevolg is de index **4** van het laatste element in een array met **lengte 5**.

<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

### Lezen

We weten nu hoe we individuele waarden in een array kunnen benaderen. Ze gebruiken is dus exact hetzelfde zoals we in het verleden al met eender welke andere variabele hebben gedaan. Het enige verschil is dat de identifier dus vierkante haken met een index in bevat om aan te geven welke element we nodig hebben van de arrays.

Wanneer je dus het tweede element van een array wenst te gebruiken kan dit bijvoorbeeld als volgt:

```java
Console.WriteLine(myColors[1]);
```

of ook

```java
string kleurkeuze = myColors[1];
```

of zelfs

```java
if(myColors[1] == "pink")
```

Kortom, alles wat je al kon, kan ook met arrays. Je kan ze zelfs als parameters aan methoden meegeven of terugkrijgen (zie verder).

{% hint style='warning' %}
Een array proberen te tonen als volgt gaat niet:

<!---{line-numbers:false}--->
```java
Console.WriteLine(myColors);
```

De enige manier alle elementen van een arrays te tonen is door manueel ieder element individueel naar het scherm te sturen. Bijvoorbeeld:

```java
for(int i = 0 ; i<myColors.Length;i++)
{
    Console.Write($"{myColors[i]},");
}
```
{% endhint %}

<!---{pagebreak} --->

Stel dat we een array van getallen hebben, dan kunnen we dus bijvoorbeeld 2 waarden uit die array optellen en opslaan in een andere variabele als volgt:

```java
int[] numbers = {5, 10, 30, 45};
int som = numbers[0] + numbers[1];
```
De variabele som zal dan vervolgens de waarde 15 bevatten (5+10).


Stel dat we *alle* elementen uit de array ``numbers`` met 5 willen verhogen, we kunnen dan schrijven:

```java
int[] numbers = {5, 10, 30, 45};
numbers[0] += 5;
numbers[1] += 5;
numbers[2] += 5;
numbers[3] += 5;
```

Maar eigenlijk zijn we dan het voordeel van arrays niet aan het gebruiken. Met loops maken we bovenstaande oplossing beter zodat deze zal werken, ongeacht het aantal elementen in de array:

```java
int teller = 0;
while (teller < numbers.Length)
{
    numbers[teller] += 5;
    teller++
}
```

Of het equivalent met een for-loop:

```java
for(int teller = 0; teller < numbers.Length; teller++)
{
    numbers[teller] += 5;
}
```

{% hint style='tip' %}
Zoals je merkt zijn loops en arrays dikke vrienden.
{% endhint %}

<!---{pagebreak} --->

### Schrijven
Ook schrijven van waarden naar de array gebruikt dezelfde notatie. Enkel moet je dus deze keer de array accessor-notatie links van de toekenningsoperator plaatsen. Stel dat we bijvoorbeeld de waarde van het eerste element uit de myColors array willen veranderen van ``red`` naar ``indigo``, dan gebruiken we volgende notatie:

<!---{line-numbers:false}--->
```java
myColors[0] = "indigo";
```
Als we dus bij aanvang nog niet weten welke waarden de individuele elementen moeten hebben in een array, dan kunnen we deze eerst definiëren, en vervolgens individueel toekennen:

```java
string[] myColors;
myColors = new string[5];
// ...
myColors[0] = "red";
myColors[1] = "green";
myColors[2] = "yellow";
myColors[3] = "orange";
myColors[4] = "blue";
```

{% hint style='warning' %}
Een veel gestelde vraag wanneer een programmeur het nut van arrays nog niet 100% ziet is de volgende. Stel dat je deze code hebt;

```java
int dag1 = 34;
int dag2 = 45;
int dag3 = 0;
int dag4 = 34;
int dag5 = 12;
int dag6 = 0;
int dag7 = 23;
```

*"Kan ik die namen (dag1, dag2, etc.) met een loop genereren/bereiken zodat ik iets kan doen als volgt?"* **TOTAAL FOUTE CODE INCOMING**
```text
for(int i=1; i<=7; i++)
    dagi= ...
```

**Dat gaat niet!** Van zodra je van plan bent om variabele-namen "dynamisch" in je code te proberen aan te roepen moeten er tal van alarmbelletjes afgaan. De kans is dan héél groot dat je probleem beter met een array wordt opgelost dan met een boel variabelen met soortgelijke namen.
{% endhint %}

## De lengte van de array te weten komen

Soms kan het nodig zijn dat je in een later stadium van je programma de lengte van je array nodig hebt. De ``Length``-eigenschap van iedere array geeft dit weer. Volgend voorbeeld toen dit:

```java
string[] myColors = {"red", "green", "yellow", "orange", "blue"};
Console.WriteLine($"Length of array = {myColors.Length}" );
```
De ``Length``-eigenschap wordt vaak gebruikt in for/while loops waarmee je de hele array wenst te doorlopen. Door de ``Length``-eigenschap te gebruiken als grenscontrole verzekeren we er ons van dat we nooit buiten de grenzen van de array zullen lezen of schrijven:

```java
//Alle elementen van een array tonen
for (int i = 0; i < getallen.Length; i++)
{
    Console.WriteLine(getallen[i]);
}
```

{% hint style='warning' %}
Elementen benaderen buiten de range van een arrays geeft erg dikke errors. Het jammerlijke is , is dat VS dit soort subtiele 'out of range' bugs niet kan detecteren tijdens het compileren. Je zal ze pas ontdekken bij de uitvoer. Volgende code zal perfect gecompileerd worden, maar bij de uitvoer zal er op lijn 2 een error verschijnen en het programma zal stoppen:

```java
string[] myColors = { "red", "green", "yellow", "orange", "blue" };
Console.WriteLine(myColors[9]);
```

Dit zal resulteren in een *"Out of Range exception"* fout op lijn 2.

Hackers misbruiken dit soort fouten in code om toegang tot delen van het geheugen te krijgen waar ze eigenlijk niet mochten zijn. Dit zijn zogenaamde *buffer offerflow attacks*.

![Out of Range Exception](../assets/5_arrays/outrange.png)
{% endhint %}

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
Sorry dat ik je al weer lastig val. Maar ik wil je nog eens extra goed naar bovestaande fout (*exception*) laten kijken. Prent die fout, **System.IndexOutOfRangeException**, goed in je hoofd. 

Deze fout zegt exact wat er mis is: je probeert elementen in een arrays te benaderen die niet bestaan omdat je buiten het bereik (*range*) van de array bent gegaan. Het is hetzelfde als wanneer ik tegen m'n personeel zeg "ga jij de muur alvast metsen op de zesde verdieping" (``etage[5]``) terwijl we een flatgebouw met maar 3 verdiepingen hebben (``.Length`` is dus 3). 
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

## Volledig voorbeeldprogramma met arrays

Met al de voorgaande informatie is het nu mogelijk om vlot complexere programma's te schrijven die veel data moeten kunnen verwerken. Meestal gebruikt men een for-loop om een bepaalde operatie over de hele array toe te passen.

Het volgende programma zal een array van integers aanmaken die alle gehele getallen van 0 tot 99 bevat. Vervolgens zal ieder getal met 3 vermenigvuldigd worden. Finaal tonen we tonen we enkel die getallen die een veelvoud van 4 zijn na de bewerking.

```java
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