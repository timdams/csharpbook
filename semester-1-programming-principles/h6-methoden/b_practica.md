# Oefeningen

> Sommige oefeningen zijn van de vorm "Maak een methode die...". Het is steeds de bedoeling dat je de werking van je methode ook test door deze toe te voegen aan je keuzemenu en uit te proberen.

{% hint style="warning" %}
Vanaf hier documenteren we al onze methoden! Je voorziet:

* een samenvatting
* een omschrijving van elke parameter
* een omschrijving van de returnwaarde als die er is

Documenteer je methoden in het Nederlands.
{% endhint %}

## Oefening: H7-veel-kleintjes

### Leerdoelen

* methodes

### Functionele analyse

Schrijf in de klasse `HoofdstukZeven` een hele reeks methodes die je samen test:

1. Methode `Square` die het kwadraat van een ingevoerd getal berekent.
2. Methode `Radius` die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft.
3. Methodes `Circumference` en `Surface` \(in de formule gebruik je `Math.PI`\).
4. Methode `Largest` die het grootste van 2 getallen teruggeeft.
5. Methode `IsEven` die bepaalt of een getal even of oneven is \(geeft een `bool` terug die `true` is indien even\).
6. Methode `ShowOdd` die alle oneven getallen van 1 tot n **toont** waarbij n als parameter wordt meegegeven.

### Technische analyse

Voorzie een extra methode `DemonstreerKleintjes` die je uit je keuzemenu kan opstarten. Deze zorgt voor een voorbeeldinteractie zoals hieronder. De methoden hierboven geven in het algemeen hun resultaat via return, dus `DemonstreerKleintjes` moet dit nog afprinten op de console. Voor `ShowOdd` kan je nog geen resultaat teruggeven, maar je kan het wel afprinten.

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

{% hint style="warning" %}
Vergeet niet te documenteren.
{% endhint %}

## Oefening: H7-grootste-methode

### Leerdoelen

* methodes met invoer en uitvoer

### Functionele analyse

Schrijf een methode `Grootste` die drie `int`s aanvaardt en de grootste als resultaat teruggeeft. Schrijf ook een methode `VraagDrieEnToonGrootste` die geen parameters of returnwaarde heeft, maar de drie getallen vraagt en `Grootste` oproept met de drie ingevoerde getallen.

### Technische analyse

Aangezien het maar om 3 argumenten gaat, kan je dit oplossen met `if`s die het eerste en het tweede argument vergelijken, het eerste en het derde argument,... Test je methode door in je keuzemenu `VraagDrieEnToonGrootste` op te roepen.

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

{% hint style="warning" %}
Vergeet niet beide methoden te documenteren.
{% endhint %}

## Oefening: H7-film-default

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

Schrijf je methode met drie parameters, maar geef de duur en het genre een default waarde. Toon aan in je main dat de methode werkt met zowel 1, 2 als 3 parameters. Toon ook aan dat je met "named arguments" de methode kan aanroepen. Schrijf hiervoor een extra methode `DemonstreerFilm` die gewoon `FilmRuntime` een paar keer oproept en die je kan opstarten van uit je keuzemenu.

#### voorbeeldinteractie\(s\)

```text
The Matrix (120 minuten, Action)
Crouching Tiger, Hidden Dragon (90 minuten, Unknown)
```

{% hint style="warning" %}
Vergeet niet beide methoden te documenteren.
{% endhint %}

## Oefening: H7-rekenmachine

### Leerdoelen

* werken met verschillende methodes 

### Functionele analyse

### Rekenmachine

Maak de methoden `TelOp`, `TrekAf`, `VermenigVuldig` en `Deel`. 

Aan deze methoden worden twee doubles meegeven als parameter. Het returntype is de bewerking met die twee parameters. 

Maak een vijfde methode, `DemonstreerOperaties`, waarin je deze methoden test a.h.v. een keuze die gemaakt moet worden. 

### Technische analyse

Schrijf je vier operaties telkens met twee parameters. Schrijf `DemonstreerOperaties` zonder parameters en zonder return type en maak deze aanroepbaar uit het hoofdmenu.

#### voorbeeldinteractie\(s\)

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

{% hint style="warning" %}
Vergeet niet je methoden te documenteren!
{% endhint %}

## Oefening: H7-begroeten

### Leerdoelen

* overloading

### Functionele analyse

Schrijf drie manieren om gebruikers te begroeten. Naargelang hoe je de oproep schrijft, wordt de juiste methode uitgevoerd. Schrijf ook een methode om te demonstreren.

### Technische analyse

Noem je methode om te begroeten `Hallo`. Je kan deze oproepen zonder argumenten en dan wordt je naam gevraagd via de console. Je kan ze ook oproepen met één of twee argumenten. Je maakt ook een methode `DemonstreerHallo` en vraagt hierin om drie namen die je als argument kan gebruiken. De methode `Hallo` geeft ook aan hoe ze is opgeroepen.

#### Voorbeeldinteractie

```text
DemonstreerHallo heeft drie namen nodig!
> Misty
> Ash
> Brock
Hallo is opgeroepen zonder argument. Wat is je naam?
> Oak
Hallo, Oak!
Hallo is opgeroepen met één argument.
Hallo, Misty!
Hallo is opgeroepen met twee argumenten.
Hallo, Ash en Brock!
```

{% hint style="warning" %}
Documenteer al je methodes!
{% endhint %}

