# Oefeningen

## Oefening 1: prijzen met `foreach` \(h11-prijzen\)

### Leerdoelen

* `foreach`
* combinatie controlestructuren

### Functionele analyse

We willen enkele gegevens \(prijzen\) inlezen van de gebruiker en slechts sommige van deze prijzen tonen.

### Technische analyse

* Werk onderstaande opdracht uit in een statische methode `AskForPrices`.
* Maak eerst een array die tot 20 prijzen \(type `double`\) kan bewaren.
* Vraag aan de gebruiker om 20 prijzen in te voeren en bewaar elke prijs in de array.
* Doorloop vervolgens **m.b.v. een `foreach`-lus** de volledige array.
  * Toon enkel de elementen op het scherm wiens prijs hoger of gelijk is aan €5.00.
* Toon op het einde van het programma het gemiddelde van alle prijzen \(dus inclusief de lagere prijzen\).
* Toon alles afgerond tot twee cijfers na de komma.

#### Voorbeeldinteractie

```text
Gelieve 20 prijzen in te geven.
> 1
> 1
> 1
> 21
> 1
> 1
> 1
> 1
> 1
> 17
> 1
> 1
> 1
> 14
> 1
> 1
> 1
> 1
> 1
> 1
21.00
17.00
14.00
Het gemiddelde bedrag is 3.00.
```

## Oefening 2: speelkaarten \(h11-speelkaarten\)

### Leerdoelen

* `foreach` genest
* `List`

### Functionele analyse

We willen een kaartenspel programmeren. Om dat te doen, moeten we zeker een lijst kaarten kunnen aanmaken en ook kaarten te kunnen trekken.

### Technische analyse

* Maak een klasse `PlayingCard`.
  * Een kaart heeft 2 eigenschappen \(properties\)
    * een getal van 1 tot en met 13 \(boer=11, koningin= 12, heer= 13\):
    * een kleur, de zogenaamde "suite". Deze stel je voor via een enumtype `Suites` en kan als waarden `Clubs` \(klaveren\), `Hearts` \(harten\), `Spades` \(schoppen\) of `Diamonds` \(ruiten\) zijn.
* Schrijf een statische methode `GenerateDeck` die een boek kaarten teruggeeft.
  * Schrijf om dit te bereiken twee `foreach` loops die de 52 kaarten van een standaard pak in een `List<PlayingCard>` plaatsen.
    * Doe dit door één lus in een andere te nesten.
* Schrijf ook een statische methode `ShowShuffledDeck(List<PlayingCard> cards)` die telkens een willekeurige kaart uit de deck trekt en deze aan de gebruiker toont. De kaart wordt na het tonen dus uit de lijst verwijderd.
  * Doe dit door in iedere stap een willekeurige, geldige index in de lijst met kaarten te berekenen en die kaart uit de lijst te halen.

### Voorbeeldinteractie

```text
9 Hearts
4 Clubs
... (er volgen nog 50 willekeurige combinaties)
Alle kaarten zijn getoond.
```

## Oefening 3: organiseren van studenten \(h11-organizer\)

### Functionele analyse

We gaan nu de `Student`-klasse uit een hoofdstuk 8 gebruiken om een `List<Student>` van studenten aan te maken. Daarna zullen we een menu tonen om gegevens over studenten in te voeren \(student toevoegen, student aanpassen, gegevens over student tonen, student verwijderen\). Op de werkvloer worden deze mogelijkheden "CRUD"-operaties genoemd \(create, read, update, delete\).

### Technische analyse

* Maak eerst \(in de klasse `Student`\) een statische methode `ExecuteStudentMenu()` zonder return type. Deze zal, zolang de gebruiker niet aangeeft dat hij wil stoppen, een menu tonen waarin we gegevens kunnen bekijken of wijzigen.
* Het menu toont steeds volgende opties:
  1. gegevens van de studenten tonen
  2. een nieuwe student toevoegen
  3. gegevens van een bepaalde student aanpassen
  4. een student uit het systeem verwijderen
  5. stoppen
* Je mag voorlopig veronderstellen dat de gebruiker geldige indexposities en gegevens invoert.

#### mogelijkheid 1: gegevens van de studenten tonen

Deze keuze toont, via de methode `ShowOverview()` en een `foreach`-lus, de gegevens van elke student in de lijst. Elk rapport wordt gevolgd door een lege regel. Het is niet erg als er op het einde één regel te veel is.

**Voorbeeldinteractie**

Nadat er al twee studenten zijn aangemaakt:

```text
Wat wil je doen?
> 1
Joske Vermeulen, 21 jaar
Klas: EA2

Cijferrapport:
**********
Communicatie:             12
Programming Principles:   15
Web Technology:           13
Gemiddelde:               13.3

Mieke Vermeulen, 22 jaar
Klas: EB1

Cijferrapport:
**********
Communicatie:             10
Programming Principles:   16
Web Technology:           16
Gemiddelde:               13.3

Wat wil je doen?
```

#### mogelijkheid 2: een nieuwe student toevoegen

Deze keuze voegt een nieuwe student toe.

**Voorbeeldinteractie**

Bij nul studenten:

```text
Wat wil je doen?
> 1
Wat wil je doen?
> 2
Wat wil je doen?
> 1
Onbekend Onbekend, 18 jaar
Klas: EA1

Cijferrapport:
**********
Communicatie:             10
Programming Principles:   10
Web Technology:           10
Gemiddelde:               10.0

Wat wil je doen?
```

#### mogelijkheid 3: een student aanpassen

Deze keuze staat toe de naam, leeftijd, klasgroep of een van de drie cijfers van de student aan te passen.

**Voorbeeldinteractie**

Vlak na het aanmaken van een eerste student:

```text
Wat wil je doen?
> 3
Wat is de indexpositie van de student die je wil aanpassen?
> 0
Wat wil je aanpassen?
1. Naam
2. Leeftijd
3. Klasgroep
4. Cijfer communicatie
5. Cijfer programmeren
6. Cijfer webtechnologie
> 4
Wat is de nieuwe waarde?
> 13
Wat wil je doen?
> 1
Onbekend Onbekend, 18 jaar
Klas: EA1

Cijferrapport:
**********
Communicatie:             13
Programming Principles:   10
Web Technology:           10
Gemiddelde:               11.0

Wat wil je doen?
```

#### mogelijkheid 4: een student verwijderen

**Voorbeeldinteractie**

Nadat er al twee studenten zijn aangemaakt:

```text
Wat wil je doen?
> 4
Wat is de indexpositie van de te verwijderen student?
> 0
Wat wil je doen?
> 1
Mieke Vermeulen, 22 jaar
Klas: EB1

Cijferrapport:
**********
Communicatie:             10
Programming Principles:   16
Web Technology:           16
Gemiddelde:               13.3

Wat wil je doen?
```

