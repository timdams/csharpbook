# Oefeningen

**Sla de oefeningen van dit hoofdstuk op in een klasse `HoofdstukVijf`, behalve de oefeningen rond apdotcom.**

## H5: Uitbreiding BMIBerekenaar

### Leerdoelen

* conditionele boodschappen

### Functionele analyse

Deze opgave bouwt verder op [BMIBerekenaar](https://apwt.gitbook.io/cursus-pro-oo/semester-1-programming-principles/h3-werken-met-data/a_practica#h-4-bmi-berekenaar). Meerbepaald moet je de gebruiker niet alleen zijn of haar BMI tonen, maar moet je ook een gekleurde boodschap tonen die laat weten of de BMI goed zit of niet.

Voor een BMI strikt lager dan 18,5 toon je de boodschap "ondergewicht" in rode tekst. Voor een BMI vanaf 18,5 maar strikt lager dan 25, toon je de boodschap "normaal gewicht" in groene tekst. Voor een hogere BMI, maar strikt lager dan 30, toon je in gele tekst "overgewicht". Voor een hogere BMI, maar strikt lager dan 40, toon je "zwaarlijvig" in rode tekst. Voor een hogere BMI toon je "ernstige obesitas" in magenta.

### Technische analyse

Kopieer de methode `HoofdstukVier.BMIBerekenaar()` naar de klasse `HoofdstukVijf` en werk er daar aan verder.

Via `if` en `else` \(en dus ook `else if`\) kan je gevallen onderscheiden. Om de tekst te kleuren, gebruik je `ConsoleColor.Red`, `ConsoleColor.Green`, `ConsoleColor.Yellow` en `ConsoleColor.Magenta`.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Hoeveel weeg je in kg?
> 69.0
Hoe groot ben je in m?
> 1.78
Je BMI bedraagt 21.78.
normaal gewicht
```

{% hint style="info" %}
De tekst _normaal gewicht_ zou hierboven in het groen moeten verschijnen maar Gitbook staat dit niet meteen toe.
{% endhint %}

## H5: Schoenverkoper

### Leerdoelen

* conditionele berekeningen

### Functionele analyse

Maak een programma dat aan de gebruiker vraagt hoeveel paar schoenen hij wenst te kopen. Ieder paar schoenen kost normaal 20 euro. Indien de gebruiker 10 paar of meer koopt, kost elk paar maar 10 euro. Toon aan de gebruiker de totale prijs.

**Uitbreiding:** Breid in een tweede stap je programma uit zodat gevraagd wordt vanaf welk aantal schoenen de prijs daalt naar 10 euro.

### Technische analyse

Zet de oplossing van deze oefening in een methode genaamd `Schoenverkoper`.

Hou variabelen bij voor de prijs, de gereduceerde prijs en het aantal paar dat nodig is om korting te krijgen.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Hoeveel paar schoenen wil je kopen?
> 3
Je moet 60 euro betalen.
```

```text
Hoeveel paar schoenen wil je kopen?
> 12
Je moet 120 euro betalen.
```

**Uitbreiding**

```text
Vanaf welk aantal geldt de korting?
> 7
Hoeveel paar schoenen wil je kopen?
> 8
Je moet 80 euro betalen.
```

## H5: Wet van Ohm

### Leerdoelen

* conditionele berekeningen

{% hint style="info" %}
De Wet van Ohm houdt in dat een elektrische stroom \(voorgesteld als `I`\) gelijk is aan een spanningsverschil \(`U`\) gedeeld door een weerstand \(`R`\), dus I = U / R.
{% endhint %}

### Functionele analyse

Vraag aan de gebruiker wat hij wenst te berekenen: Spanning, Weerstand of Stroomsterkte. Vraag vervolgens de twee andere waarden.  
Als dus de gebruiker "Spanning" kiest, vraag je aan de gebruiker de waarden van de stroomsterkte en de weerstand.  
Bereken m.b.v. de Wet van Ohm de gewenste waarde en toon aan de gebruiker.

### Technische analyse

Maak in de klasse `HoofdstukVijf` een nieuwe methode genaamd `WetVanOhm`.

Denk eraan dat de gegeven formule wiskundig gedefinieerd is. In C♯ zal je rekening moeten houden met het feit dat deze drie maten uitgedrukt kunnen worden in kommagetallen.

Je mag hier gewoon strings gebruiken om na te gaan welke maat de gebruiker heeft ingetypt. Je mag veronderstellen dat de getallen uitgedrukt zijn in de gewoonlijke eenheden \(volt, ampère, ohm\) zodat je ze gewoon kan invullen in de formule.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Wat wil je berekenen? spanning, weerstand of stroomsterkte?
> spanning
Wat is de weerstand?
> 30
Wat is de stroomsterkte?
> 5
De spanning bedraagt 150.
```

```text
Wat wil je berekenen? spanning, weerstand of stroomsterkte?
> weerstand
Wat is de spanning?
> 220
Wat is de stroomsterkte?
> 10
De weerstand bedraagt 22.
```

```text
Wat wil je berekenen? spanning, weerstand of stroomsterkte?
> stroomsterkte
Wat is de spanning?
> 30
Wat is de weerstand?
> 20
De stroomsterkte bedraagt 1.5.
```

## H5: Schrikkeljaar

### Leerdoelen

* conditionele berekeningen
* geneste condities

### Functionele analyse

De gebruiker voert een jaartal in en jouw programma toont of het wel of geen schrikkeljaar is. Een schrikkeljaar is deelbaar door 4, behalve als het ook deelbaar is door 100, tenzij het wél deelbaar is door 400.

### Technische analyse

Zet de oplossing in een methode genaamd `Schrikkeljaar`.

* gebruik de modulo-operator \(`%`\) om deelbaarheid door 4 na te gaan
* gebruik een constructie met geneste `if`s \(en `else`s\) om alle gevallen af te handelen

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
> 1997
geen schrikkeljaar
```

```text
> 1996
schrikkeljaar
```

```text
> 1900
geen schrikkeljaar
```

```text
> 2000
schrikkeljaar
```

## H5: SimpeleRekenmachine

### Leerdoelen 

* Conditionele functionaliteit 

### Functionele analyse 

In deze oefening bouw je een simpele rekenmachine, die twee getallen kan optellen, aftrekken, vermenigvuldigen of delen.   
De gebruiker voert de te bewerken getallen in en kiest dan de berekening.  

### Technische analyse 

Gebruik een variabele om de gekozen bewerking in op te slaan en if-statements om te variëren tussen bewerkingen. 

Noem je methode voor deze oefening `SimpeleRekenmachine` 

### UI 

Console-applicatie 

### Voorbeeldinteractie 

```text
Geef een eerste getal in: 
> 5 
Geef een tweede getal in: 
>  6 
Welke berekening wil je maken? (+,-,*,/) 
> * 
De uitkomst is: 30 
```

## Keuzemenu's maken

### Leerdoelen: 

* Conditionele functionaliteit 

###  Functionele analyse: 

In deze oefening voorzie je elke klasse die je tot hiertoe in dit project gemaakt hebt van een keuzemenu, zodat de gebruiker bij het uitvoeren van je programma eerst kan kiezen uit de hoofdstukken \(= klassen\) en dan uit de oefeningen \(=methodes\) binnen het gekozen hoofdstuk.

### Technische analyse 

* Maak in je klasse `Program` een methode`Hoofdmenu`. Deze methode laat de gebruiker kiezen uit één van de hoofdstukken. Na de keuze wordt het scherm leeggemaakt en dan wordt de methode `Keuzemenu` van de juiste klasse opgeroepen.
* Maak in elke klasse uit de vorige labo’s een methode `Keuzemenu.` Deze methode laat de gebruiker kiezen uit de verschillende methodes binnen die klasse. Na de keuze wordt het scherm weer leeggemaakt en wordt de gekozen methode opgestart.
* In `Program.Main` start je nu de methode `Hoofdmenu`.

### UI

Console applicatie 

### Voorbeeldinteractie

```text
Kies uit volgende klassen door een cijfer te tikken:
    1 - HoofdstukEen
    2 – HoofdstukTwee
    3 – HoofdstukDrie
    4 – HoofdstukVier
    5 – HoofdstukVijf
> 5

```

\(scherm wordt leeggemaakt\)

```text
Kies uit volgende methodes door een cijfer te tikken:
    1 – BMIBerekenaar
    2 – Pythagoras
    3 – Cirkels
    4 – Orakeltje
> 2
```

\(scherm wordt leeggemaakt, Pythagoras wordt opgestart en uitgevoerd\)

```text
Geef de lengte van de eerste rechthoekszijde: 
> 4
Geef de lengte van de tweede rechthoekszijde:
> 3
De lengte van de schuine zijde is 5
```

## APDotCom

### Leerdoelen

* Een bestaande applicatie uitbreiden
* Conditionele logica integreren

### Functionele analyse

Het programma werkt op dezelfde manier als [H4 apdotcom \(deel 2\)](https://apwt.gitbook.io/cursus-pro-oo/semester-1-programming-principles/h3-werken-met-data/a_practica#oefening-apdotcom-deel-2), met volgende aanpassingen:

* De gebruiker kan nu op voorhand kiezen of de willekeurige prijsstijgingen van 'Vraag en aanbod' worden toegepast of niet.
* Een prijsstijging wordt weergegeven in rode tekst, een prijsdaling in groene tekst
* Als er een korting van meer dan 30% wordt ingevoerd, toont het programma de boodschap _Waarschuwing: het ingevoerde percentage is hoog!_

### Technische analyse

In de klasse `APDotCom` maak je een kopie van de methode `BestelMetVraagEnAanbod`, die je `BestelConditioneel` noemt.

Om _enkel_ de prijsstijgingen en -dalingen te kunnen kleuren, ga je gebruik moeten maken van `ConsoleColor.Red`, `ConsoleColor.Green` en `Console.ResetColor()`.

### Voorbeeldinteractie

```text
Basisprijs van een boek?
> 12.00
Basisprijs van een CD?
> 9.95
Basisprijs van een servies?
> 75
Basisprijs van een springkasteel?
> 150
Aantal boeken?
> 4
Aantal CD's?
> 2
Aantal serviezen?
> 1
Aantal springkastelen?
> 1
Percentage korting?
> 40
Waarschuwing: het ingevoerde percentage is hoog!

Worden prijsstijgingen en -dalingen toegepast? (J/N)
> J

Uw kasticket
------------
vraag en aanbod boeken: 20%
vraag en aanbod CD's: -18%
vraag en aanbod serviezen: 10%
vraag en aanbod springkastelen: 48%
boek x 4: 57.60
CD x 2 : 16.32
servies x 1: 82.50
springkasteel x 1: 222
KORTING: 40%
TOTAAL VOOR KORTING: 378.42
TOTAAL: 227.05
```

{% hint style="info" %}
De getallen _20%, 10% en 48%_ zouden hierboven in het rood moeten verschijnen en _-18%_ in het groen \(lijnen 26-29\), maar Gitbook staat dit niet meteen toe.
{% endhint %}

Of zonder 'vraag en aanbod':

```text
Basisprijs van een boek?
> 12.00
Basisprijs van een CD?
> 9.95
Basisprijs van een servies?
> 75
Basisprijs van een springkasteel?
> 150
Aantal boeken?
> 4
Aantal CD's?
> 2
Aantal serviezen?
> 1
Aantal springkastelen?
> 1
Percentage korting?
> 40
Waarschuwing: het ingevoerde percentage is hoog!

Worden prijsstijgingen en -dalingen toegepast? (J/N)
> N

Uw kasticket
------------
boek x 4: 48.00
CD x 2 : 19.90
servies x 1: 75.00
springkasteel x 1: 150.00
KORTING: 40%
TOTAAL VOOR KORTING: 292.90
TOTAAL: 175.74
```

