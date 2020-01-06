# Deel 2 Geavanceerde methode concepten

## Film Default
Maak een methode FilmRuntime() die 3 parameters accepteert:

1. Een string die de naam van de film bevat
2. Een integer die duur in minuten van de film bevat
3. Een enum-type die het genre van de film bevat (Drama, Actie, etc.)

Indien de duur van de film niet wordt meegeven wordt een standaard  lengte van 90 minuten ingesteld. Indien het genre niet wordt meegeven dan wordt deze default op Onbekend ingesteld.

De methode geeft niets terug maar toont eenvoudigweg de film op het scherm, gevolgd door z’n duur en genre in volgende formaat.

```text
The Matrix (120minuten, Actie)
```

Toon aan in je main dat de methode werkt met zowel 1, 2 als 3 parameters. Toon ook aan dat je met ‘named arguments’ de methode kan aanroepen.

## Opwarmers met geavanceerde methoden
Zorg ervoor dat de opwarmers uit Deel 0 oefeningen hiervoor steeds minstens 1 optionele parameter hebben. Roep deze methoden aan via named parameters.

## Oude oefeningen leesbaarder maken
Kan je code uit vorige hoofdstukken herbruiken door deze in handige methoden te plaatsen zodat je code leesbaarder én bruikbaarder wordt?

## Einde deel 1 test  herschrijven
Bekijk terug jouw (of mijn) oplossing van de vaardigheidsproef of de [deel 1 eindetest](../EindeTests/Mod1/Opgave.md) in deze cursus. 

Kan je deze code leesbaarder maken door methoden (en loops) toe te voegen?

## Verhaalgenerator
Bekijk het all-one-project ["De verhaal generator"](../A_DEEL1_AllInOne/3_verhaalgenerator.md): kan jij dit project afwerken zoals onderaan de opgave wordt voorgesteld?

## Muziek en methoden

Muziek maken
(Wikipedia) [http://nl.wikipedia.org/wiki/Toonhoogte] leert ons dat de grondtonen do-re-mi-fa-sol-la-si-do de frequenties : 264-297-330-352-396-440-495-528 hz behelsen (excuses indien dit *jargon* niet klopt. Ik ken even veel van muziek als van metsen).

De `Console.Beep()` methode laat ons toe om tonen te genereren op een bepaalde frequentie (in Hz) en van een bepaalde duur (in milliseconden, i.e. 1/1000 van een seconde). 

We kunnen dus de computer de toonladder afspelen, elke noot 1 seconde lang, als volgt:

```csharp
Console.Beep(264, 1000);
Console.Beep(297, 1000);
Console.Beep(330, 1000);
Console.Beep(352, 1000);
Console.Beep(396, 1000);
Console.Beep(440, 1000);
Console.Beep(495, 1000);
Console.Beep(528, 1000);
```

## Opgave 1
Zorg ervoor dat je bovenstaande als volgt kunt aanroepen:

```csharp
Do();
Re();
Mi();
Fa();
Sol()
La();
Si();
Do2();
```

Iedere methode zal dus de correcte toon afspelen gedurende 1s (je mag dit ook sneller instellen naar keuze).

## Opgave 2

Iedere ‘noot-methode’ zal ook steeds op het scherm tonen welke noot wordt afgespeeld (doe dit als eerste in de methode)
De uitvoer van opgave één wordt dan:

```text
Do
Re
Mi
Fa
Sol
La
Si
Do
```
 
Extra: plaats ieder noot in een andere tekstkleur (m.b.v. ``Console.ForeGroundColor``)

## Opgave 3

Door een de frequentie van een toon te vermenigvuldigen of te delen met veelvouden van 2 krijg je de tonen op andere octaven.
Pas de ‘noot-methoden’ aan zodat 2 parameters kunnen meegeven worden:
1. De lengte in milliseconden dat de toon moet aangehouden worden
2. De octaaf van de toon: 1 = basis octaaf die we al hadden, 2= 2e octaaf (dus frequentie x2) 3= 3e octaaf (frequentie x 3) etc.

Als je dus de 2e octaaf wil spelen, iedere toon om de 500ms moet je deze als volgt kunnen aanroepen:

```csharp
Do(500,2);
Re(500,2);
Mi(500,2);
Fa(500,2);
Sol(500,2)
La(500,2);
Si(500,2);
Do2(500,2);
```

## Opgave 4

Maak minstens 2 methoden naar keuze: iedere methode zal een liedje beginnen spelen dat je zelf hebt gemaakt (bv. een bestaand kinderliedje).
Hier bijvoorbeeld het begin van "You are my sunshine":

```csharp
Re();
Sol();
La();
Si();
Si();
Si();
La();
Si();
Sol();
Sol();


Sol();
La();
Si();
Do1();
Mi();
Mi();
Re();
Do1();
Si();
```

De methoden als naam ``SpeelX`` met ``X`` de titel van het liedje, bijvoorbeeld ``SpeelYouAreMySunshine``.

> Extra: De Lyrics verschijnen op de juiste momenten op het scherm (dus vlak voor het afspelen van de bijhorende noot).

## Opgave 5

Bij het opstarten van het programma krijg je een menu te zien waaruit de gebruiker een liedje kan kiezen dat gespeeld moet worden. Vervolgens wordt dit liedje gespeeld en nadien wordt de vraag terug gesteld (oneindige loop).
 

## Opgave 6

Wanneer een liedje werd afgespeeld dan dient de methode terug te geven (als double) hoe lang het liedje heeft geduurd. Het hoofdmenu toont dit aan het einde van het afspelen.
 
Je kan de duur van een methode heel eenvoudig meten als volgt, gebruikmakende van de ``StopWatch``:

```csharp
            //Start
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            //Voer te meten code uit

            //Stop
            stopwatch.Stop();
            double totaletijd = stopwatch.Elapsed.TotalSeconds;
```
``totaleTijd`` zal de totaal verstreken tijd in seconden bevatten.

## Opgave 7 
Toon je muzikale skills en zorg voor uitbreidingen naar keuze (meer songs, complexere songs, meer kleurtjes, stoerdere timings, zotte functionaliteit, animaties, etc. The sky is the limit!).

