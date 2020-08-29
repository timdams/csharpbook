# Bugs in vaardigheidsproef 1819

We bespreken en tonen hier kort de meest voorkomende fouten in de vaardigheidsproef 1819. Ook lezers van dit boek in verdere jaren zullen hier veel uit kunnen leren!

# Random perikelen

## Random te veel

Ongeacht hoeveel willekeurige getallen je nodig hebt in een stuk code, je hebt nooit meer dan 1 ``Random`` number generator nodig, volgende code is er dus 1 te veel:

```java
Random rekengetal1 = new Random();
Random rekengetal2 = new Random();
```

## Random te veel oplossen?

Voorgaande fout zal dus twee generators maken die mooi synchroon dezelfde getallen genereren, wat we waarschijnlijk niet wensen. De oplossing is er maar 1 gebruiken...of volgende originele, maar niet erg goede manier:

```java
Random get1 = new Random();
Thread.Sleep(250); //250ms wachten voor de volgende random te generen. Anders altijd hetzelfde getal.
Random get2 = new Random();
```

Een bewuste vertraging in je code inbouwen is nooit erg goed, zeker niet voor je eindgebruiker die zo nuttige tijd van hun leven verslijten met het wachten tot je programma terug werkt...

# Beslissingen

## == vs =

Nooit in een if een enkele ``=`` gebruiken, je hebt er altijd twee nodig wanneer je een test op gelijkheid wenst te doen:

```java
if(getal=4)
```

## Dubbele code

Àls je bij twee checks identieke code moet schrijven dan heb je een verkeerde voorwaarde geschreven:

```java
if (raad < juist)
{
    pogingen++;
    Console.WriteLine($""Neen, dat is het niet. Probeer opnieuw (aantal pogingen is {pogingen})"");
    Console.WriteLine($""Welk getal is het (aantal pogingen is { pogingen})"");
}
else if(raad > juist)
{
    pogingen++;
    Console.WriteLine($""Neen, dat is het niet. Probeer opnieuw (aantal pogingen is {pogingen})"");
    Console.WriteLine($""Welk getal is het (aantal pogingen is { pogingen})"");
}
```

Je kan dit reduceren tot 1 ``if(raad!=juist)`` en dus niet je code moet kopiëren.

## Onnodige check

Soms heb je een tweede of derde else if check niet meer nodig als die reeds alle voorwaarden bevat die nog overblijven:

```java
if (geld <0)
{
    Console.WriteLine(""bankroet..... dasss no good"");
}
else if (geld == 0)
{
    Console.WriteLine(""you are right where you started"");
}
else if (geld > 0) 
{
    Console.WriteLine($""je hebt {geld} verdient"");
}
```

Je kan dus even goed dit schrijven:
```java
if (geld <0)
{
    Console.WriteLine(""bankroet..... dasss no good"");
}
else if (geld == 0)
{
    Console.WriteLine(""you are right where you started"");
}
else 
{
    Console.WriteLine($""je hebt {geld} verdient"");
}
```

Stel dat je derde else if niet klopte dan bestond er dus een kans dat bepaalde code nooit werd uitgevoerd.

# Methoden

## Methoden naar void zette

In de opgave moesten enkele methoden geschreven worden die een bepaald iets teruggaven. Deze methoden zullen dus nooit ``void`` als returntype hebben, ook al is dat het enige soort methode waar je momenteel zo te zien mee kunt werken. **Zorg dat je methoden beheerst en zaken UIT de methode kunt krijgen door middel van ``return``**

## Methoden aanpassen

Wanneer je methoden in de opgave krijgt volgende bepaalde specificaties qua returntype en parameters, dan moet er altijd een alarmbelletje afgaan wanneer je deze specificaties moet aanpassen om je code werkende te krijgen. Vermoedelijk ben je dan de methoden niet juist aan het gebruiken en klopt er iets niet.

## Na return gebeurt er niets

Code schrijven na een ``return`` is code schrijven die NOOIT zal uitgevoerd, en heeft dus 0 komma 0 nut:

```java
return getal;
Console.WriteLine("Klaar");
```

## Return het gewoon

Wanneer je iets wil return...return het dan. Je hoeft er niet eerst een variabele voor aan te maken:

```java
scherm = false;
return scherm;

```

Dit kan je dus beter schrijven als:

```java
return false;
```

Dit kwam in de buurt, maar is dus even nutteloos:

```java
return scherm = true;
```

## Waarom parameter vragen

Als je in je methode-definitie een parameter vraagt dan is het onbeleefd (en nutteloos) om deze direct bij de start van de methode van waarde te veranderen. Waarom heb je ze dan gevraagd? Of begrijp je misschien nog niet goed hoe parameters bij methoden werken?

```java
static int ShowEnding(int input_geld)
{

    input_geld = 0;
```

# Loops

## Loops en arrays hebben een nut

Loops en array zijne r voor je om dit soort code nooit te moeten schrijven:

```java
int maal1 = 1;
int maal2 = 2;
int maal3 = 3;
int maal4 = 4;
int maal5 = 5;
int maal6 = 6;
int maal7 = 7;
int maal8 = 8;
int maal9 = 9;
int maal10 = 10;
```

## Echt waar ze hebben een nut

```java
bool[] RandomBool = new bool[10];
Random Random = new Random();
bool RandomBoolke0 = Convert.ToBoolean(Random.Next()); //NEEE
bool RandomBoolke1 = Convert.ToBoolean(Random.Next());
bool RandomBoolke2 = Convert.ToBoolean(Random.Next());
bool RandomBoolke3 = Convert.ToBoolean(Random.Next());
bool RandomBoolke4 = Convert.ToBoolean(Random.Next());
bool RandomBoolke5 = Convert.ToBoolean(Random.Next());
bool RandomBoolke6 = Convert.ToBoolean(Random.Next());
bool RandomBoolke7 = Convert.ToBoolean(Random.Next());
bool RandomBoolke8 = Convert.ToBoolean(Random.Next());
bool RandomBoolke9 = Convert.ToBoolean(Random.Next());



RandomBool[0] = RandomBoolke0;
RandomBool[1] = RandomBoolke1;
RandomBool[2] = RandomBoolke2;
RandomBool[3] = RandomBoolke3;
RandomBool[4] = RandomBoolke4;
RandomBool[5] = RandomBoolke5;
RandomBool[6] = RandomBoolke6;
RandomBool[7] = RandomBoolke7;
RandomBool[8] = RandomBoolke8;
RandomBool[9] = RandomBoolke9;
```