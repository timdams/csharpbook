# Casting, conversie en parsing: data omzetten
Wanneer je de waarde van een variabele wil toekennen aan een variabele van een ander type mag dit niet zo maar. Je kan geen appelen in peren veranderen zonder magie: in het geval van C# zal je moeten converteren of casten.
Parsing is iets anders: deze zal je enkel nodig hebben om data door de computer te 'interpreteren' , vooral nuttig als je bijvoorbeeld tekst naar getallen wilt omzetten. 

## Casting

Hierbij dien je aan de compiler te zeggen: *"Volgende variabele die van het type x is, moet aan deze variabele van het type y toegekend worden. Ik besef dat hierbij data verloren kan gaan, maar zet de variabele toch maar om naar het nieuwe type"*.

Stel dat temperatuurGisteren en temperatuurVandaag van het type int zijn, maar dat we nu de gemiddelde temperatuur willen weten. De formule voor gemiddelde temperatuur over 2 dagen is:

```csharp
int temperatuurGemiddeld = (temperatuurGisteren + temperatuurVandaag)/2;
```
Test dit eens met de waarden 20 en 25. Wat zou je verwachten als resultaat? Inderdaad: 22,5 (omdat 20+25)/2 = 22.5) *Nochtans krijg je 22 op scherm te zien en zal de variabele temperatuurGemiddeld ook effectief de waarde 22 bewaren en niet 22.5.*

Het probleem is dat het gemiddelde van 2 getallen niet noodzakelijk een geheel getal is. **Omdat de expressie enkel integers bevat (temperatuurGisteren en temperatuurVandaag) zal ook het resultaat een integer zijn.** In dit geval wordt alles na de komma gewoon *weggegooid*, vandaar de uitkomst. **Dit is narrowing.**

Hoe krijgen we de correctere uitslag te zien? Door temperatuurGemiddeld als kommagetal te declareren (bijvoorbeeld door het type double):

```csharp
double temperatuurGemiddeld = (temperatuurGisteren + temperatuurVandaag)/2;
```

Als we dit testen zal nog steeds de waarde 22 aan temperatuurGemiddeld toegewezen worden. Inderdaad. De expressie rechts bevat enkel integers en de computer zal dus ook de berekening en het resultaat als integer beschouwen. We moeten dus ook de rechterkant van de toekenning als double beschouwen. *We doen dit door middel van **casting** zoals eerder vermeld*, als volgt:

```csharp
double temperatuurGemiddeld = ((double)temperatuurGisteren + (double)temperatuurVandaag)/2;
```
Nu zal temperatuurGemiddeld wel de waarde 22.5 bevatten.

## Wat is casting
Casting heb je nodig om een variabele van een bepaald type voor een ander type te laten doorgaan? Stel dat je een complexe berekening hebt waar je werkt met verschillende types (bijvoorbeeld int, double en float). Door te casten voorkom je dat je vreemde resultaten krijgt. Je gaat namelijk bepaalde types even als andere types gebruiken.

Het is belangrijk in te zien dat het casten van een variabele naar een ander type enkel een gevolg heeft TIJDENS het uitwerken van de expressie waarbinnen je werkt. De variabele in het geheugen zal voor eeuwig en altijd van het type zijn waarin het origineel gedeclareerd werd.

## Casting voorbeelden
### Narrowing
Casting doe je wanneer je een variabele wil toekennen aan een andere variabele van een ander type dat daar eigenlijk niet inpast. Bekijk eens volgende voorbeeld:

```csharp
double var1;
int var2;
 
var1 = 20.4;
var2 = var1;
```
Dit zal niet gaan. Je probeert namelijk een waarde van het type double in een variabele van het type int te steken. Dat gaat enkel als je informatie weggooit. Je moet aan *narrowing* doen. Dit gaat enkel als je expliciet aan de compiler zegt: het is goed, je mag informatie weggooien, ik begrijp dat en zal er rekening mee houden. Dit proces van narrowing noemen we casting.

En je lost dit op door voor de variabele die TIJDELIJK dienst moet doen als een ander type, het nieuwe type, tussen ronde haakjes, te typen, als volgt:

```csharp
double var1;
int var2;
 
var1 = 20.4;
var2 = (int)var1;
```
Het resultaat in var2 zal 20 zijn (alles na de komma wordt bij casting van een double naar een int weggegooid).

### Widening
Casting is echter dus niet nodig als je aan *widening* doet (een kleiner type in een groter type steken), als volgt:

```csharp
int var1;
double var2;
 
var1 = 20;
var2 = var1;
```

Deze code zal zonder problemen gaan. Var2 zal de waarde 20.0 bevatten. De inhoud van var1 wordt *verbreed* naar een double, eenvoudigweg door er een kommagetal van te maken. Er gaat **geen** inhoud verloren echter.

## Conversie
Casting is de 'oldschool' manier van data omzetten die vooral zeer nuttig is daar deze ook werkt in andere C#-related programmeertalen zoals C, C++ en Java. 

Echter, .NET heeft ook enkele ingebouwde conversie-methoden die je kunnen helpen om data van het ene type naar het andere te brengen. Al deze methoden zitten binnen de **Convert**-bibliotheek.

Het gebruik hiervan is zeer eenvoudig.Enkele voorbeelden:

```csharp
int getal = Convert.ToInt32(3.2); //double to int
double anderGetal = Convert.ToDouble(5); //int to double
bool isWaar = Convert.ToBoolean(1); //int to bool
int userAge = Convert.ToInt32("19"); //string to int
```

De convert-klasse bevat tal van conversiemogelijkheden. Opgelet: de convert zal zelf zo goed mogelijk de data omzetten en dus indien nodig widening of narrowing toepassen. Zeker bij het omzetten van een string naar een ander type kijk je best steeds de documentatie na om te weten wat er intern juist zal gebeuren.

Je kan [alle conversie-mogelijkheden hier bekijken](https://msdn.microsoft.com/en-us/library/system.convert.aspx)

## Parsing
Ieder ingebouwd type heeft ook een .Parse() methode die je kan aanroepen om strings om te zetten naar het gewenste type. Parsing zal je echter minder vaak nodig hebben. Gebruik deze enkel wanneer
1. Je een string hebt waarvan je weet dat deze altijd van een specifiek type zal zijn, bv een int, dan kan je ``Int32.Parse()`` gebruiken 
2. Je input van de gebruiker vraagt (bv via Console.ReadLine) en niet 100% zeker bent dat deze een getal zal bevatten, gebruik dan ``Int32.TryParse()`` [info](https://msdn.microsoft.com/en-us/library/f02979c7.aspx)

Er zij nog subtiele verschillen die we hier niet behandelen ([zie](https://stackoverflow.com/questions/199470/whats-the-main-difference-between-int-parse-and-convert-toint32))