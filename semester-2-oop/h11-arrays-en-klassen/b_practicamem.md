# Extra oefeningen

## Oefening 4: gemiddelde cijfers opvragen per vak

### Leerdoelen

* `foreach`
* combinatie controlestructuren

### Functionele analyse

Pas je oefening met CRUD-operaties op `Student` aan zodat we ook het gemiddelde per vak kunnen opvragen.

### Technische analyse

* Je werkt nog steeds met een `List<Student>`.
* Optie 5, 6 en 7 tonen nu het gemiddelde voor communicatie, programmeren of webtechnologie \(in die volgorde\).
* Optie 8 stopt het menu.

### Voorbeeldinteractie

Nadat er al drie studenten zijn aangemaakt, met 12, 17 en 19 op communicatie:

```text
Wat wil je doen?
> 5
Gemiddelde cijfer op communicatie: 16

Wat wil je doen?
```

## Oefening 5: hoger, lager

### Leerdoelen

* `List`

### Functionele analyse

Gebruik je eerdere code voor `PlayingCard` om een spelletje "hoger", "lager" toe te voegen.

### Technische analyse

* Eerst wordt `GenerateDeck` gebruikt om een lijst aan te maken en toe te kennen aan een variabele.
* Een willekeurig getal wordt gegenereerd tussen 0 en de maximale index van een element in de lijst.
* De kaart op deze indexpositie wordt toegekend aan een variabele van type `PlayingCard` met naam `previousCard`.
* Deze kaart wordt ook verwijderd uit de lijst.
* Volgende stappen herhalen zich zo lang alle kaarten niet zijn gespeeld:
  * De waarde van `previousCard` wordt getoond.
  * Een willekeurig getal wordt gegenereerd tussen 0 en de maximale index van een element in de lijst.
  * De kaart op deze indexpositie wordt toegekend aan een variabele van type `PlayingCard` met naam `currentCard`.
  * Deze kaart wordt ook verwijderd uit de lijst.
  * De gebruiker krijgt de vraag of de waarde van `currentCard` hoger, lager of gelijk aan de waarde van `previousCard` is.
  * `currentCard` vervang `previousCard`
* Het spel stopt als de gebruiker een fout maakt of als het spel kaarten op is.
* Noem de methode om het spel op te starten `HigherLower()`

### Voorbeeldinteractie

```text
Klaar om te spelen.
De vorige kaart had waarde 7.
Hoger (0), lager (1) of gelijk (2)?
> 0
De vorige kaart had waarde 11.
Hoger (0), lager (1) of gelijk (2)?
> 1
De vorige kaart had waarde 2.
Hoger (0), lager (1) of gelijk (2)?
> 2
Spel voorbij!
```

