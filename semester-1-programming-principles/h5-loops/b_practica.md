# Oefeningen deel 3

## Oefening: H6-boekhouder

### Leerdoelen

* een taak herhaaldelijk uitvoeren met een lus

### Functionele analyse

Maak een 'boekhoud-programma': de gebruiker kan continu positieve en negatieve getallen invoeren. Dit programma houdt volgende zaken bij:

* de totale balans
* de som van de positieve getallen
* de som van de negatieve getallen
* het gemiddelde

### Technische analyse

Voor de eerste drie zaken kom je toe met een variabele. Voor de laatste is dit lastiger, omdat elk nieuw getal een kleiner effect heeft om het gemiddelde dan het vorige. Je houdt beter een teller bij met het aantal ingevoerde getallen. Dan is het gemiddelde de totale balans gedeeld door het aantal ingevoerde getallen.

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Geef een getal
> 7
De balans is 7
De som van de positieve getallen is 7
De som van de negatieve getallen is 0
Het gemiddelde is 7
Geef een getal
> -3
De balans is 4
De som van de positieve getallen is 7
De som van de negatieve getallen is -3
Het gemiddelde is 2
Geef een getal
> 11
De balans is 15
De som van de positieve getallen is 18
De som van de negatieve getallen is -3
Het gemiddelde is 5
```

\(Dit programma kan blijven verder lopen zo lang je wil.\)

## Oefening: H6-schaar-steen-papier

### Leerdoelen

* een taak herhaaldelijk uitvoeren met een lus

### Functionele analyse

Maak een applicatie waarbij de gebruiker steen-schaar-papier met de computer kan spelen. De gebruiker kiest telkens steen, schaar of papier en drukt op enter. Vervolgens kiest de computer willekeurig steen, schaar of papier.

Vervolgens krijgt de winnaar 1 punt:

* Steen wint van schaar, verliest van papier
* Papier wint van steen, verliest van schaar
* Schaar wint van papier, verliest van steen
* Indien beide hetzelfde hebben wint niemand een punt.

De eerste \(pc of gebruiker\) die 10 punten haalt wint.

### Technische analyse

* Maak een [enum](../h4-beslissingen/enum.md) met elementen `Schaar`, `Steen` en `Papier`
* Teken een flowchart!
* Gebruik [de instructies over hoe je een enum waarde kan inlezen](../h4-beslissingen/enum.md#waarden-van-een-enum-type-inlezen)
* Noem je methode `SchaarSteenPapier`.
* Je krijgt een flowchart om te helpen.

{% file src="../../.gitbook/assets/flowchartbladsteenschaar.pdf" caption="flowchart schaar steen papier" %}

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Maak een keuze:
1. Schaar
2. Steen
3. Papier
> 2
De computer kiest steen!
Niemand wint deze ronde!
Jij hebt 0 punten, de computer heeft 0 punten.
Maak een keuze:
1. Schaar
2. Steen
3. Papier
> 1
De computer kiest papier!
Jij wint deze ronde!
Jij hebt 1 punt, de computer heeft 0 punten.
Maak een keuze:
1. Schaar
2. Steen
3. Papier
> 1
De computer kiest steen!
De computer wint deze ronde!
Jij hebt 1 punt, de computer heeft 1 punt.
```

\(Helemaal op het einde\)

```text
Jij hebt 10 punten, de computer heeft 8 punten.
Jij bent gewonnen!
```

of

```text
Jij hebt 8 punten, de computer heeft 10 punten.
De computer is gewonnen!
```

## APDotCom

### Leerdoelen

* Een bestaande applicatie uitbreiden
* Loop toevoegen om meerdere bestellingen aan te maken

### Functionele analyse

Het programma werkt op dezelfde manier als [H5 apdotcom](https://apwt.gitbook.io/cursus-pro-oo/semester-1-programming-principles/h4-beslissingen/a_practica#apdotcom), met volgende aanpassingen:

* De gebruiker krijgt na het verkrijgen van een kasticket de vraag om nog een bestelling aan te maken
* Exact dezelfde logica wordt doorlopen als voorheen wanneer de gebruiker J ingeeft
* De bevraging stopt wanneer de gebruiker N ingeeft

### Technische analyse

TIP: de code van de bestelling moet minstens 1x uitgevoerd worden, vermijd dubbele code. Noem je methode `BestelMeerdere`.

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

Wil je nog een bestelling plaatsen? (J/N)
> J

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

Wil je nog een bestelling plaatsen? (J/N)
> N
```

