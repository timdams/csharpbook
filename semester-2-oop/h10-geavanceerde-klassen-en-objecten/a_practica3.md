# Oefeningen

## Pokémons makkelijk aanmaken \(h10-pokeconstructie\)

### Leerdoelen

* gebruik van expliciete constructoren

### Functionele analyse

Zorg ervoor dat elke Pokémon bij constructie zijn eigenschappen krijgt.

### Technische analyse

* Voorzie je klasse Pokémon \(uit hoofdstuk 9\) van een constructor zonder parameters. Dit om bestaande code intact te houden.
* Voorzie je klasse Pokémon \(uit hoofdstuk 9\) van een constructor met vier parameters, één per property. Pas je methode `MakePokemon` van hoofdstuk 9 aan zodat gebruik wordt gemaakt van deze constructor in plaats van de constructor zonder argumenten.

### Voorbeeldinteractie

\(Hier is geen verschil met hoe dit er in hoofdstuk 9 uitzag.\)

## Pokémons nog makkelijker aanmaken \(h10-chaining\)

### Leerdoelen

* gebruik van expliciete constructoren
* herbruik van bestaande constructor

### Functionele analyse

Wanneer we een willekeurige Pokémon aanmaken, start deze normaal met de helft van zijn maximale hit points. We willen onszelf het werk besparen van dit elke keer uit te typen, dus we voorzien een extra constructor.

### Technische analyse

Maak een nieuwe constructor met **drie** argumenten in plaats van vier. Het argument voor HP valt weg. Deze nieuwe constructor maakt eerst gebruik van de bestaande constructor met vier argumenten. Daarna past hij in zijn body de hoeveelheid HP aan naar de helft van het maximum. Bij het gebruik van de meer algemene constructor maakt het niet uit welke waarde je meegeeft voor de huidige hit points. Test je constructor uit met een \(statische\) demomethode `ConstructPokemonChained()`. Deze maakt met deze nieuwe constructor een nieuwe Pokémon \(naar keuze\) aan met een maximale hoeveelheid HP naar keuze en toont de uitkomst.

### Voorbeeldinteractie

```text
De nieuwe Squirtle heeft maximum 40 HP en heeft momenteel 20 HP.
```

## Globale statistieken bijhouden \(h10-pokebattlecount\)

### Leerdoelen

* verschil tussen klasse en object

### Functionele analyse

We willen bijhouden hoe vaak elk element al gebruikt is voor een aanval. Voeg code toe die bijhoudt hoe vaak een Pokémon van type `Grass` al heeft aangevallen, hoe vaak een Pokémon van type `Fire` al heeft aangevallen, etc. Voeg ook een statische methode, `DemonstrateCounter()` aan die vijf willekeurige Pokémon aanmaakt en elke Pokémon tussen de 5 en de 10 keer laat aanvallen.

### Technische analyse

Bij een aanval van een Pokémon met een bepaald type, gaat er een teller omhoog. Er is één teller per `PokéType`.

### Voorbeeldinteractie

```text
BULBASAUR!
BULBASAUR!
BULBASAUR!
BULBASAUR!
BULBASAUR!
SQUIRTLE!
SQUIRTLE!
SQUIRTLE!
SQUIRTLE!
SQUIRTLE!
PIKACHU!
PIKACHU!
PIKACHU!
PIKACHU!
PIKACHU!
CHARMANDER!
CHARMANDER!
CHARMANDER!
CHARMANDER!
CHARMANDER!
CHARMANDER!
BULBASAUR!
BULBASAUR!
BULBASAUR!
BULBASAUR!
BULBASAUR!
BULBASAUR!
BULBASAUR!
Aantal aanvallen van Pokémon met type `Grass`: 12
Aantal aanvallen van Pokémon met type `Fire`: 6
Aantal aanvallen van Pokémon met type `Electric`: 4
Aantal aanvallen van Pokémon met type `Water`: 5
```

\(Merk op: er zijn twee Bulbasaurs in het spel, maar alle aanvallen van graspokémon zijn samen geteld.\)

## Gemeenschappelijke kenmerken \(h10-tombola\)

### Leerdoelen

* goed gebruik van `Random`
* `static`
* `constructoren`

### Functionele analyse

We schrijven een digitale tombola. Iedere keer een lotje wordt aangemaakt, wordt er een willekeurig getal aan toegekend.

### Technische analyse

Maak een klasse, `Ticket`. Deze is voorzien van één autoproperty: `Prize`. Dit is een `byte`. Bij aanmaak van een `Ticket` wordt deze property ingesteld op een waarde tussen 1 en 100. Schrijf je code zodat dezelfde `Random` gebruikt wordt voor alle tickets. Je kan dus geen `Random` aanmaken iedere keer je een `Ticket` aanmaakt! Maak ook een methode `Raffle` \(d.w.z. "tombola"\) om te demonstreren dat dit werkt. Deze methode maakt een rij met 10 lotjes aan en print de waarde van elk lotje in de rij. Het is niet erg dat twee lotjes dezelfde waarde kunnen krijgen.

### Voorbeeldinteractie

```text
Waarde van het lotje: 77
Waarde van het lotje: 8
Waarde van het lotje: 12
Waarde van het lotje: 14
Waarde van het lotje: 51
Waarde van het lotje: 97
Waarde van het lotje: 20
Waarde van het lotje: 15
Waarde van het lotje: 32
Waarde van het lotje: 68
```

## CSV

Schrijf een statische klasse `CSVDemo` met een statische methode `Run()`. Deze downloadt automatisch [dit bestand](http://samplecsvs.s3.amazonaws.com/SalesJan2009.csv) en print de info in de eerste drie kolommen op het scherm. Tussen elke kolom verschijnt een tab.

