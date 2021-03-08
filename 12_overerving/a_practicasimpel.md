# Labo-oefeningen

## Een bestaande klasse uitbreiden via overerving

### Leerdoelen
* overerving van bestaande klassen laten zien
* toegang tot properties en methodes demonstreren

### Functionele analyse
Maak een nieuwe klasse, `WorkingStudent`. Een werkstudent verschilt van een student omdat hij soms moet gaan werken en omdat hij een bepaald aantal werkuren per week moet presteren.

### Technische analyse
Deze klasse erft over van de klasse `Student` die je voor het eerst hebt gebruikt in hoofdstuk 8.

Bovenop alle eigenschappen / methoden van `Student` heeft `WorkingStudent`:

- een methode `HasWorkToday()` die willekeurig `true` of `false` teruggeeft. Er is geen methode `NextBool` in de klasse random, maar je kan een willekeurig getal tussen 0 en 1 genereren en de uitkomst vertalen in een boolean.
- een property `WorkHours` die een aantal gepresteerde uren bijhoudt (als `byte`). Deze staat waarden tussen 1 en 20 toe. Lagere of hogere waarden worden automatisch aangepast (naar 1 of 20 naargelang of de waarde lager of hoger is).
  - de defaultwaarde van deze property is 10

Voeg een statische methode `DemonstrateWorkingStudent()` toe aan je klasse voor deze les. Deze methode doet volgende zaken:

- ze maakt met de default constructor één gewone student aan (de properties mag je invullen zoals je zelf wil, maar vul ze wel in)
- ze maakt met de default constructor één werkstudent aan (de properties mag je invullen zoals je zelf wil, maar vul ze wel in)
- ze plaatst beide in een `List<Student>`
- ze doorloopt met een `foreach`-lus de lijst en toont via `Console.WriteLine` de naam van elke student
- je moet deze methode kunnen opstarten vanuit je keuzemenu voor dit onderwerp

## Klassen met aangepaste constructor maken

### Functionele analyse
We schrijven een applicatie die een lijst van af te handelen taken bijhoudt. Er zijn twee soorten taken: éénmalige taken en terugkerende taken. Elke taak heeft een beschrijving, maar terugkerende taken hebben ook een bepaalde hoeveelheid tijd waarna ze herhaald moeten worden.

### Technische analyse
- Maak een klasse `Task` met een property `Description` en een constructor die een waarde voor deze beschrijving verwacht (een `string`).
  - Wanneer deze constructor wordt opgeroepen, wordt volgende tekst getoond: "Taak <Description> is aangemaakt." Je vult hier zelf de beschrijving van de taak in.
- Maak een subklasse `RecurringTask` van `Task`. Deze heeft een constructor die twee zaken verwacht: een beschrijving (nog steeds een `string`) en een aantal dagen (een `byte`).
  - Wanneer deze constructor wordt opgeroepen, wordt de tekst voor een gewone taak getoond. Daaronder wordt getoond: "Deze taak moet om de <aantal dagen> dagen herhaald worden."
- Voeg een statische methode `DemonstrateTasks()` toe aan je klasse voor deze les. Deze methode maakt eerst een `ArrayList` van taken aan en herhaalt daarna volgende stappen tot de gebruiker aangeeft dat hij klaar is:
  - ze toont drie opties: een taak aanmaken, een terugkerende taak aanmaken of stoppen
  - indien de gebruiker vraagt een taak aan te maken, vraagt ze een beschrijving, maakt ze de taak en voegt ze deze toe aan de lijst
  - indien de gebruiker vraagt een terugkerende taak aan te maken, vraagt ze een beschrijving en een aantal dagen, maakt ze de terugkerende taak en voegt ze deze toe aan de lijst
  - indien de gebruiker wenst te stoppen, eindigt ze zonder resultaat
  - je moet deze methode kunnen opstarten vanuit je keuzemenu voor dit onderwerp

### Voorbeeldinteractie
```text
Wat wil je doen?
1. een taak maken
2. een terugkerende taak maken
3. stoppen
> 1
Beschrijving van de taak?
> TV ophangen
Taak TV ophangen is aangemaakt.
Wat wil je doen?
1. een taak maken
2. een terugkerende taak maken
3. stoppen
> 2
Beschrijving van de taak?
> Vuilzakken buiten zetten
Aantal dagen tussen herhaling?
> 7
Taak Vuilzakken buiten zetten is aangemaakt.
Deze taak moet om de 7 dagen herhaald worden.
Wat wil je doen?
1. een taak maken
2. een terugkerende taak maken
3. stoppen
> 3
```

## Oefening: H12-ziekenhuis

### Leerdoelen

* werken met methodes
* methodes overschrijfbaar maken
* code specifieker maken met behulp van subklassen

### Functionele analyse

Dit programma berekent de doktersrekening van een patiënt, op basis van een basisbedrag \(€50\) en een extra kost \(€20/uur\). In het geval van een verzekerde patiënt worden de kosten met 10% verlaagd.

### Technische analyse
- Schrijf twee klassen: `Patient` en `InsuredPatient`
- Beide hebben als properties een naam (een `string`) en een verblijfsduur (een `uint`)
- Beide hebben één constructor die de naam en verblijfsduur als parameter hebben
- Beide hebben een methode `ShowCost` die een boodschap op het scherm print die zegt hoe veel die patiënt moet betalen
  - Omdat de kost anders bepaald wordt voor een gewone patiënt dan voor een verzekerde patiënt, moet je deze methode **overschrijfbaar** maken in `Patient` en moet je ze **overschrijven** in `InsuredPatient`. De kost wordt getoond met twee cijfers na de komma.
- Voeg een statische methode `DemonstratePatients()` toe aan je klasse voor deze les. Deze methode maakt patiënten aan en roept hun methode `ShowCost` op, zodat onderstaande voorbeeldinteractie te zien is

#### voorbeeldinteractie

```text
Vincent, een gewone patiënt die 12 uur in het ziekenhuis gelegen heeft, betaalt €290.00.
Tim, een verzekerde patiënt die 12 uur in het ziekenhuis gelegen heeft, betaalt €261.00.
```

{% hint style="info" %}
Zie je geen €-symbool in je output? In het eerste semester hebben we gezien hoe je het gebruik van Unicode activeert.
{% endhint %}

#### Testscenario's

* Test ook uit met een verblijf van 1 uur.
* Test ook uit met een verblijf van 0 uur.
* Test ook uit met de patiënten beschreven in de voorbeeldinteractie.

## Oefening: dynamic dispatch

### Leerdoelen
* herbruik code ouderklasse
* virtual, override, base

### Functionele analyse
Onze rapporten van studenten missen belangrijke informatie. We willen te zien krijgen wie het statuut van werkstudent heeft.

### Technische analyse
Pas je klassen `Student` en `WorkingStudent` aan, zodat de bestaande methode `ShowOverview` een uitgebreider overzicht toont voor werkstudenten (voor gewone studenten blijft het ongewijzigd). Dit heeft dan de vorm:

```text
Joske Vermeulen, 21 jaar
Klas: EA2

Cijferrapport:
**********
Communicatie:             12
Programming Principles:   15
Web Technology:           13
Gemiddelde:               13.3
Statuut: werkstudent
Aantal werkuren per week: 10
```

De laatste twee regels komen **bovenop** de info die je eerder al toonde. Maak gebruik van `base` zodat je niet de volledige implementatie opnieuw hoeft te schrijven. Pas nu je methode `DemonstrateWorkingStudent` aan zodat niet de naam van elke student in de lijst wordt getoond, maar zodat zijn volledig rapport wordt getoond.
