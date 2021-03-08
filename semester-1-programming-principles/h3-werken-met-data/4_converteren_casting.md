# Casting, conversie en parsing

Wanneer je de waarde van een variabele wil toekennen aan een variabele van een ander type mag dit niet zomaar. Volgende code zal bijvoorbeeld een dikke error geven:

```csharp
int age = 4.3;
```

Je kan geen appelen in peren veranderen zonder magie: in het geval van C\# zal je moeten **converteren of casten**.

Dit kan op 3 manieren:

* Via casting: de \(klassieke\) manier die ook werkt in veel andere programmeertalen.
* Via de Convert bibliotheek van .NET. Deze staat omzettingen toe die handig zijn, maar niet op het niveau van de taal zijn vastgelegd.
* Via _parsing_ die we enkel terloops bespreken, maar die niet bij de leerstof van deze cursus hoort. Parsing betekent dat je tekst met een bepaalde vorm omzet naar data en werkt dus alleen op strings.

## Casting

Het is uiteraard onmogelijk om een kommagetal aan een geheel getal toe te wijzen zonder dat er informatie verloren zal gaan. Toch willen we dit soms doen. **Van zodra we een variabele van het ene type willen toekennen aan een variabele van een ander type en er dataverlies zal plaatsvinden dan moeten we aan casting doen.**

Hierbij dien je aan de compiler te zeggen: _"Volgende variabele die van het type x is, moet aan deze variabele van het type y toegekend worden. **Ik besef dat hierbij data verloren kan gaan, maar zet de variabele toch maar om naar het nieuwe type, ik draag alle verantwoordelijkheid voor het verlies.**"_.

### Wat is casting

Casting heb je nodig om een variabele van een bepaald type voor een ander type te laten doorgaan. Stel dat je een complexe berekening hebt waar je werkt met verschillende types \(bijvoorbeeld int, double en float\). Door te casten voorkom je dat je vreemde resultaten krijgt. Je gaat namelijk bepaalde types even als andere types gebruiken.

Het is belangrijk in te zien dat het casten van een variabele naar een ander type enkel een gevolg heeft TIJDENS het uitwerken van de expressie waarbinnen je werkt. De variabele in het geheugen zal voor eeuwig en altijd het type zijn waarin het origineel gedeclareerd werd.

> **Je dient voornamelijk aan casting te doen wanneer je aan** _**narrowing**_ **doet: een datatype omzetten naar een ander datatype dat een verlies aan data met zich zal meebrengen.**

Casting duid je aan door voor de variabele of literal het datatype tussen haakjes te plaatsen naar wat het omgezet moet worden:

```csharp
int mijngetal = (int)3.5;
```

of

```csharp
double kommagetal = 13.8;
int kommaNietWelkom = (int)kommagetal;
```

### Narrowing

Casting doe je dus wanneer je een variabele wilt toekennen aan een andere variabele van een ander type dat daar eigenlijk niet inpast. We moeten dan aan **narrowing** doen, letterlijk het versmallen van de data.

Bekijk eens het volgende voorbeeld:

```csharp
double var1;
int var2;

var1 = 20.4;
var2 = var1;
```

Dit zal niet gaan. Je probeert namelijk een waarde van het type double in een variabele van het type int te steken. Dat gaat enkel als je informatie weggooit. Je moet aan _narrowing_ doen.

Dit gaat enkel als je expliciet aan de compiler zegt: het is goed, je mag informatie weggooien, ik begrijp dat en zal er rekening mee houden. Dit proces van narrowing noemen we casting.

En je lost dit op door voor de variabele die tijdelijk dienst moet doen als een ander type, het nieuwe type, tussen ronde haakjes te typen, als volgt:

```csharp
double var1;
int var2;

var1 = 20.4;
var2 = (int)var1;
```

Het resultaat in `var2` zal `20` zijn \(alles na de komma wordt bij casting van een double naar een int weggegooid\).

> Merk op dat `var1` nooit van datatype is veranderd; enkel de inhoud ervan \(`20.4`\) werd eruit gehaald, omgezet \("gecast"\) naar `20` en dan aan `var2` toegewezen dat enkel `int` aanvaardt.

### Narowing in de praktijk

Stel dat temperatuurGisteren en temperatuurVandaag van het type int zijn, maar dat we nu de gemiddelde temperatuur willen weten. De formule voor gemiddelde temperatuur over 2 dagen is:

```csharp
int temperatuurGemiddeld = (temperatuurGisteren + temperatuurVandaag)/2;
```

Test dit eens met de waarden 20 en 25. Wat zou je verwachten als resultaat? Inderdaad: 22,5 \(omdat \(20+25\)/2 = 22.5\) _Nochtans krijg je 22 op scherm te zien en zal de variabele temperatuurGemiddeld ook effectief de waarde 22 bewaren en niet 22.5._

Het probleem is dat het gemiddelde van 2 getallen niet noodzakelijk een geheel getal is. **Omdat de expressie enkel integers bevat \(temperatuurGisteren, temperatuurVandaag en 2\) zal ook het resultaat een integer zijn.** In dit geval wordt alles na de komma gewoon _weggegooid_, vandaar de uitkomst.

Hoe krijgen we de correctere uitslag te zien? Door temperatuurGemiddeld als kommagetal te declareren \(bijvoorbeeld door het type double\):

```csharp
double temperatuurGemiddeld = (temperatuurGisteren + temperatuurVandaag)/2;
```

Als we dit testen zal nog steeds de waarde 22 aan temperatuurGemiddeld toegewezen worden. De expressie rechts bevat enkel integers en de computer zal dus ook de berekening en het resultaat als integer beschouwen \([lees hier hoe dit nu weer zat](../h1-variabelen-en-datatypes/2_expressies.md)\). We moeten dus ook de rechterkant van de toekenning als double beschouwen. _We doen dit, zoals eerder vermeld, door middel van **casting**_, als volgt:

```csharp
double temperatuurGemiddeld = ((double)temperatuurGisteren + (double)temperatuurVandaag)/2;
```

Nu zal temperatuurGemiddeld wel de waarde 22.5 bevatten.

### Widening

Casting is echter niet nodig als je aan **widening** doet \(een kleiner type in een groter type steken\), als volgt:

```csharp
int var1;
double var2;

var1 = 20;
var2 = var1;
```

Deze code zal zonder problemen gaan. `var2` zal de waarde `20.0` bevatten. De inhoud van `var1` wordt _verbreed_ naar een `double`, eenvoudigweg door er een kommagetal van te maken. Er gaat **geen** inhoud verloren echter. Je hoeft dus niet expliciet de casting-notatie zoals `(double)var1` te doen, de computer ziet zelf dat hij de inhoud van `var1` zonder dataverlies kan toekennen aan `var2`.

## Conversie

Casting is een in de taal ingebakken manier van data omzetten, die vooral zeer nuttig is daar deze ook werkt in andere C\#-related programmeertalen zoals C, C++ en Java.

Echter, .NET heeft ook ingebouwde conversie-methoden die je kunnen helpen om data van het ene type naar het andere te brengen. Het nadeel is dat ze iets meer typwerk \(en dus meer code\) verwachten dan bij casting. Al deze methoden zitten binnen de **Convert**-bibliotheek van .NET.

Het gebruik hiervan is zeer eenvoudig. Enkele voorbeelden:

```csharp
int getal= Convert.ToInt32(3.2); //double to int
double anderGetal= Convert.ToDouble(5); //int to double
bool isWaar= Convert.ToBoolean(1); //int to bool
int userAge= Convert.ToInt32("19"); //string to int
int ageOther= Convert.ToInt32(anderGetal); //double to int
```

Je plaatst tussen de ronde haakjes de variabele of literal die je wenst te converteren naar een ander type. Merk op dat naar een `int` converteren met `.ToInt32()` moet gebeuren. Om naar een `short` te converteren is dit met behulp van `.ToInt16()`.

> `Convert.ToBoolean` verdient extra aandacht: Wanneer je een getal, eender welk, aan deze methode meegeeft zal deze altijd naar `True` geconverteerd worden. Enkel indien je `0`, \(`int`\) of `0.0` ingeeft, dan krijg je `False`. In quasi alle andere gevallen krijg je altijd `True`.

Opgelet: de convert zal zelf zo goed mogelijk de data omzetten en dus indien nodig widening of narrowing toepassen. Zeker bij het omzetten van een string naar een ander type kijk je best steeds de documentatie na om te weten wat er intern juist zal gebeuren.

Je kan [alle conversie-mogelijkheden hier bekijken](https://msdn.microsoft.com/en-us/library/system.convert.aspx).

## Ter info: Parsing

> Voorlopig zullen we parsing niet nodig hebben. Voor de volledigheid plaatsen we deze informatie hier echter.

Naast conversie en casting bestaat er ook nog parsing.

Parsing is anders dan conversie en casting. Parsing zal je enkel nodig hebben dit jaar om tekst naar getallen om te zetten.

Ieder ingebouwd type heeft een .Parse\(\) methode die je kan aanroepen om strings om te zetten naar het gewenste type. Parsing zal je echter minder vaak nodig hebben. Gebruik deze enkel wanneer

1. Je een string hebt waarvan je weet dat deze altijd van een specifiek type zal zijn, bv een int, dan kan je `Int32.Parse()` gebruiken.
2. Je input van de gebruiker vraagt \(bv via Console.ReadLine\) en niet 100% zeker bent dat deze een getal zal bevatten, gebruik dan `Int32.TryParse()`. \([info](https://msdn.microsoft.com/en-us/library/f02979c7.aspx)\)

Er zijn nog subtiele verschillen die we hier niet behandelen \([zie](https://stackoverflow.com/questions/199470/whats-the-main-difference-between-int-parse-and-convert-toint32)\).

Voorbeeld van parsing:

```csharp
int numVal = Int32.Parse("-105");
Console.WriteLine(numVal);
```

