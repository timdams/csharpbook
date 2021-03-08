## Oefening: H5-boekhouder

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

## Oefening: H5-schaar-steen-papier

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

* Genereer een willekeurig getal tussen 1 en 3 om de computer te laten kiezen.
* Teken een flowchart!

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Maak een keuze:
1 voor schaar
2 voor steen
3 voor papier
> 2
De computer kiest steen!
Niemand wint deze ronde!
Jij hebt 0 punten, de computer heeft 0 punten.
Maak een keuze:
1 voor schaar
2 voor steen
3 voor papier
> 1
De computer kiest papier!
Jij wint deze ronde!
Jij hebt 1 punt, de computer heeft 0 punten.
Maak een keuze:
1 voor schaar
2 voor steen
3 voor papier
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
