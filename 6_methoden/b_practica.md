# Oefeningen

> Sommige oefeningen zijn van de vorm "Maak een methode die...". Het is steeds de bedoeling dat je de werking van je methode ook test in je `Main` door deze aan te roepen.

## Oefening: H6-veel-kleintjes

### Leerdoelen

* methodes

### Functionele analyse

Schrijf een hele reeks methodes die je samen test:

1. Methode `Square` die het kwadraat van een ingevoerd getal berekent.
2. Methode `Radius` die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft.
3. Methodes `Circumference` en `Surface` \(in de formule gebruik je `Math.PI`\).
4. Methode `Largest` die het grootste van 2 getallen teruggeeft.
5. Methode `IsEven` die bepaalt of een getal even of oneven is \(geeft een `bool` terug die `true` is indien even\).
6. Methode `ShowOdd` die alle oneven getallen van 1 tot n **toont** waarbij n als parameter wordt meegegeven.

### Technische analyse

Schrijf een voorbeeldprogramma dat in de `Main`-methode elke methode kort demonstreert. Toon alle getallen tot op twee cijfers na de komma. Voor `ShowOddNumbers` kan je nog geen resultaat teruggeven, maar je kan het wel afprinten.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Wat moet ik kwadrateren?
> 2
4
Wat is de diameter?
> 6
3
Wat is de diameter?
> 2
De omtrek is 6.28
De oppervlakte is 3.14
Welke twee getallen wil je vergelijken?
> 3
> 9
9 is het grootste getal
Geef een getal en ik zeg of het even is:
> 4
Het getal is even.
Geef een getal en ik zoek de oneven getallen:
> 7
1
3
5
7
```

## Oefening: H6-voorstellen

### Leerdoelen

* methodes

### Functionele analyse

Maak een methode die jezelf voorstelt op het scherm in de vorm van "Ik ben Tim Dams, ik ben 18 jaar oud en woon in de Lambrisseringsstraat 666".

### Technische analyse

Je persoonlijke informatie mag hardcoded in je methode staan. Bedoeling is dat je de methode kan aanroepen als volgt:

```csharp
MyIntro();
```

Deze methode voert een taak uit, maar geeft geen antwoord dat je verder zou kunnen gebruiken. Het return type is dan ook `void`.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Ik ben Tim Dams, ik ben 18 jaar oud en woon in de Lambrisseringsstraat 666
```

## Oefening: H6-voorstellen-plus

### Leerdoelen

* methodes-met-parameters

### Functionele analyse

Maak een flexibelere versie van H6-voorstellen, die je persoonlijke gegevens als argumenten meekrijgt.

### Technische analyse

Je persoonlijke informatie wordt meegegeven via drie parameters: één voor de naam, één voor de leeftijd, één voor de straat. Je moet de methode dus zo kunnen oproepen:

```csharp
MyIntro("Tim Dams", 18, "Lambrisseringsstraat 666");
```

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Ik ben Tim Dams, ik ben 18 jaar oud en woon in de Lambrisseringsstraat 666
```

## Oefening: H6-grootste-methode

### Leerdoelen

* methodes

### Functionele analyse

Schrijf een methode die drie `int`s aanvaardt en de grootste als resultaat teruggeeft.

### Technische analyse

Aangezien het maar om 3 argumenten gaat, kan je dit oplossen met `if`s die het eerste en het tweede argument vergelijken, het eerste en het derde argument,... Test je methode uit in een voorbeeldprogrammaatje.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Geef 3 ints.
> 7
> 10
> 4
Het grootste getal is 10.
```

## Oefening: H6-paswoord-generator

### Leerdoelen

* methodes

### Functionele analyse

Maak een paswoord generator die paswoorden van bepaalde lengte genereert en bestaat uit willekeurige letters, hoofdletters en cijfers. Plaats deze code in een methode met 1 parameter, namelijk de lengte van het paswoord dat gemaakt moet worden. De methode geeft het gegenereerde paswoord terug als resultaat.

### Technische analyse

Maak gebruik van `Random` en een `for`-lus. Een `Random` genereert normaal alleen getallen, maar via casting kan je die getallen omzetten in `char`s. Raadpleeg een Unicode tabel voor de juiste getallen _of_ \(iets sneller\) cast eerst `'a'` en `'z'` naar getallen en gebruik die om te bepalen welke willekeurige resultaten je mag genereren. Demonstreer je methode met een kort programma.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Hoe veel karakters moet je wachtwoord bevatten?
> 8
dIh8ez10
```

## Oefening: H6-film-default

### Leerdoelen

* methodes met default argumenten

### Functionele analyse

Maak een methode `FilmRuntime` met 3 parameters:

1. Een string die de naam van de film bevat
2. Een integer die duur in minuten van de film bevat
3. Een enum-type `FilmGenre` die het genre van de film bevat. Deze enum heeft de mogelijke waarden `Drama`, `Action`, `Comedy` en `Uncategorized`.

Deze methode toont dan een samenvatting van de film **op het scherm**, gevolgd door zijn duur en genre in volgend formaat:

```text
The Matrix (120 minuten, Action)
```

Indien de duur niet gespecifieerd wordt, wordt gezegd dat hij 90 minuten duurt. Indien het genre niet wordt meegegeven, wordt "Uncategorized" vermeld op het scherm.

### Technische analyse

Schrijf je methode met drie parameters, maar geef de duur en het genre een default waarde. Toon aan in je main dat de methode werkt met zowel 1, 2 als 3 parameters. Toon ook aan dat je met "named arguments" de methode kan aanroepen.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
The Matrix (120 minuten, Action)
Crouching Tiger, Hidden Dragon (90 minuten, Unknown)
```

## Oefening: H6-rekenmachine

### Leerdoelen

* werken met verschillende methodes 

### Functionele analyse

### Rekenmachine

Maak de methoden `TelOp`, `TrekAf`, `VermenigVuldig` en `Deel`. 

Aan deze methoden worden twee doubles meegeven als parameter. Het returntype is de bewerking met die twee parameters. 

Maak een eenvoudig programma'tje waarin je deze methoden test a.h.v. een keuze die gemaakt moet worden. 

```text
Maak een keuze uit
1. Optellen
2. Aftrekken
3. Vermenigvuldingen
4. Delen
Geef het overeenstemmende nummer als keuze in: 1

Geef het eerste nummer in: 2
Geef het tweede nummer in: 3

Resultaat: (2 + 3) = 5
```

### Technische analyse

Schrijf je vier methoden, telkens met twee parameters. 

Roep één van deze vier methoden aan a.h.v. een switch constructie binnen uw main.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
TelOp(number1, number2)
```

