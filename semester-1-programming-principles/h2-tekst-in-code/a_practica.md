# Oefeningen

Al deze oefeningen maak je in een klasse `HoofdstukDrie`.

## Oefening: VariabelenHoofdletters

### Leerdoelen

* gebruik van variabelen om input en output via `Console.ReadLine` en `Console.WriteLine` op te slaan en terug te tonen

### Functionele analyse

Een applicatie vraagt je tekst in te voeren die dan daarna zal worden getoond met allemaal hoofdletters.

### Technische analyse

Noem de methode voor deze oefening `VariabelenHoofdletters`.

#### voorbeeldinteractie\(s\)

```text
Welke tekst moet ik omzetten?
> Hello World
HELLO WORLD
```

### Technische hulp

#### Programmaverloop

Lees de gebruikersinvoer van de console en sla deze op in een variabele.

Zet de inhoud van deze variabele om in hoofdletters. Je kan dit doen door `ToUpper()` toe te voegen aan een variabele van het type `string`. Bijvoorbeeld `myText.ToUpper()` in plaats van `myText`.

Uiteindelijk geef je dan deze variabele weer in de console.

#### Testscenario's

* Voer tekst in met spaties
* Voer tekst in van meer dan 100 karakters
* Voer tekst in van 1 karakter
* Voer geen tekst in

## Oefening: H3-string-interpolation

### Leerdoelen

* gebruik van string interpolation

### Functionele analyse

Oefening H2-maaltafels en H2-ruimte dienen we te herschrijven volgens de principes van string interpolation.

### Technische analyse

Noem de methode voor deze oefening `StringInterpolation`.

#### voorbeeldinteractie\(s\)

Zie oefening H2-maaltafels en H2-ruimte.

### Technische hulp

#### Programmaverloop

Pas string interpolatie mbv `$` \(manier 2\) toe.

#### Testscenario's

* Zie oefening H2-maaltafels en H2-ruimte.

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

## Oefening: H3-bereken-btw

### Leerdoelen

* gebruik van string interpolation

### Functionele analyse

Een programma vraagt een bedrag en vervolgens btw percentage in te geven waarna het bedrag incl. btw-percentage wordt weergegeven.

### Technische analyse

Noem de methode voor deze oefening `BerekenBtw`.

#### voorbeeldinteractie\(s\)

![](../../.gitbook/assets/image%20%2863%29.png)

### Technische hulp

#### Programmaverloop

Het bedrag dat wordt ingevoerd moet geconverteerd worden naar een int met `Convert.ToInt32`.

Rond tevens af tot 2 cijfers na de komma.

Pas string interpolatie mbv `$` \(manier 2\) toe.

#### Testscenario's

* Typ tekst in
* Geef een veel te groot bedrag in

## Oefening: H3-leetspeak

### Leerdoelen

* functionaliteit van strings leren kennen

### Functionele analyse

We willen tekst omvormen naar een ander formaat. Laat de gebruiker een lijn tekst ingeven en haal er alle tussenliggende spaties uit en vervang de a's door @

### Technische analyse

Gebruik Console.ReadLine om tekst in te lezen en hou bij in een variabele. Bereken uit deze variabele een waarde voor een variabele, die je ten slotte weergeeft via WriteLine. Noem je methode `LeetSpeak`.

#### Programmaverloop

```text
Geef je tekst in
> Oefening baart kunst!
Oefeningb@@rtkunst!
```

#### Testscenario's

* test met een zin zonder a's
* test met een zin met vijf a's of meer
* test met een lege string

## Oefening: H3-instructies

### Leerdoelen

* leren werken met stringinterpolatie
* leren werken met verbatim strings

### Functionele analyse

We willen met behulp van een programma instructies genereren voor de gebruiker. Meerbepaald wordt automatisch aangegeven in welke map de gebruiker bepaalde bestanden op een Windows systeem moet bijhouden.

{% hint style="warning" %}
Voor deze oefening is het verplicht gebruik te maken van een \(geïnterpoleerde\) verbatim string.
{% endhint %}

### Technische analyse

Op basis van de voornaam van de cursist en de naam van de cursus wordt de map gegeven die de cursist moet aanmaken \(eerste 3 letters voornaam, in hoofdletters met submap de naam van de cursus. Noem je methode `Instructies`.

#### Programmaverloop

```text
Wat is je naam?
> Vincent
Wat is de naam van de cursus?
> Programmeren
Maak een map als volgt: \VIN\Programmeren
```

## Oefening: H3-lotto

{% hint style="success" %}
[Kennisclip modeloplossing voor lotto en superlotto](https://youtu.be/9w37rObVAKU)
{% endhint %}

### Leerdoelen

* functionaliteit van strings
* stringinterpolatie
* escape sequenties

### Functionele analyse

De gebruiker voert zijn lottocijfers in. We willen deze op een overzichtelijke manier weergeven.

### Technische analyse

Laat de lottocijfers allemaal achter elkaar ingeven, gescheiden door komma's, zonder spaties. De gebruiker wordt verondersteld cijfers onder de 10 in te geven voorafgegaan door een nul. Gebruik de juiste methode om de cijfers uit te string te "knippen" en gebruik **tabs \(geen spaties!\)** om de uitvoer te scheiden. Noem je methode `Lotto`.

#### Voorbeeldinteractie

```text
Wat zijn je cijfers (tussen 01 en 45)?
> 05,08,13,18,27,44
Je cijfers zijn:
05    08    13
18    27    44
```

## Oefening: H3-superlotto

{% hint style="warning" %}
Dit is een moeilijke oefening, zeker met de middelen die we nu hebben. Maar ze kan opgelost worden. Doe je best!
{% endhint %}

Dit is een variatie op de vorige oefening. Schrijf nu een methode `SuperLotto`. Het enige verschil is dat de gebruiker getallen ook met één cijfer mag noteren.

```text
Wat zijn je cijfers (tussen 01 en 45)?
> 5,8,13,18,27,44
Je cijfers zijn:
05    08    13
18    27    44
```

### Technische hulp

* er zullen vijf komma's in de invoer staan
* bepaal eerst de positie van de eerste komma en hou bij in een variabele. Gebruik `IndexOf`.
* zet de tekst tot vlak voor die eerste komma om naar een getal en hou bij in een tweede variabele `eersteCijfer`
* bepaal dan de positie van de tweede komma
  * doe dit door de eerste komma te zoeken in de substring die begint net na de "echte" eerste komma
* bepaal het tweede cijfer door de tekst tussen de twee komma's in te lezen, om te zetten en bij te houden in een variabele `tweedeCijfer`
* werk op deze manier verder, tot je `zesdeCijfer` hebt
* pas ten slotte formattering toe in een geïnterpoleerde string om de output te tonen zodat er **wel** nullen voor de cijfers 1-9 verschijnen. Zoek in de cursus naar iets om getallen met een vast aantal cijfers te tonen.

{% hint style="success" %}
Klaar? Vergeet niet je oefeningen in Bitbucket \(m.b.v. git-commando's\) te zetten.
{% endhint %}

