# Oefening 1: klasse `Pokemon` (h9-pokeattack)

## Leerdoelen

* herhalen aanmaken klassen
* herhalen aanmaken instantiemethoden
* herhalen aanmaken full properties

## Functionele analyse

We willen een bootleg Pokémon spel maken. We starten met een klasse om Pokémon voor te stellen.

### Technische analyse

Schrijf een klasse `Pokemon` met volgende onderdelen:
- een full property `MaxHP`
  - deze stelt een getal voor dat altijd minstens 20 en maximum 1000 bedraagt
  - als je een lagere of hogere waarde probeert in te stellen, wordt de dichtstbijzijnde waarde ingesteld
- een full property `HP`
  - deze stelt een getal voor dat altijd groter dan of gelijk aan 0 is; verder kan de waarde ook nooit groter gemaakt worden dan `MaxHP`; elke poging om het getal kleiner dan 0 te maken, maakt het gelijk aan 0 en elke poging om boven `MaxHP` te gaan, maakt het gelijk aan `MaxHP`.
- een autoproperty `PokeSpecies` om aan te geven over welk soort Pokémon het gaat; maak hiervoor een enum `PokeSpecies` met waarden `Bulbasaur`, `Charmander`, `Squirtle`, `Pikachu`
- een autoproperty `PokeType` om aan te geven wat het element van de Pokémon is; maak hiervoor een enum `PokeTypes` met waarden `Grass`, `Fire`, `Water`, `Electric`
- een methode `Attack()`: deze zorgt ervoor dat de naam van het soort Pokémon in hoofdletters en in kleur wordt geprint. Je kan de methode `ToString()` van een enum gebruiken. De kleur die je gebruikt is als volgt:
  - groen voor type `Grass`
  - rood voor type `Fire`
  - blauw voor `Water`
  - geel voor `Electric`

Schrijf dan een statische `MakePokemon`-methode in de klasse `Pokemon` die één `Pokemon` van elke soort maakt (je mag de soort en het type invullen na het aanmaken van de objecten) en elk van deze `Pokemon` één keer hun methode `Attack` laat uitvoeren. Elke `Pokemon` start bovendien met 20 hit points als huidige waarde en als maximumwaarde.

### Voorbeeldinteractie
```text
BULBASAUR!
CHARMANDER!
SQUIRTLE!
PIKACHU!
```
(In groen, rood, blauw en geel.)

# Oefening 2 (h9-consciouspokemon)

## Leerdoelen

* arrays van objecten
* `null`

## Functionele analyse
In een gevecht begin je met je eerste Pokémon die nog bij bewustzijn is. Bewusteloze Pokémon kunnen immers niet vechten. Schrijf een statische methode om de eerste bewuste Pokémon te vinden.

## Technische analyse
Schrijf een **statische** methode `FirstConsciousPokemon` met één parameter: een array van `Pokemon`. Deze methode loopt met een `for`-lus door de array en geeft als antwoord de eerste `Pokemon` terug met minstens 1 HP. Je moet zorgen dat de methode aanvaard wordt door de compiler, ook als er geen enkele bewuste Pokémon in de rij is bijgehouden.

Schrijf ook een statische methode `TestConsciousPokemon()` die een array van dezelfde vier Pokémon als hierboven maakt, waarbij Bulbasaur en Charmander 0 HP hebben en Squirtle 2 HP. Toon wat gebeurt als de eerste wakkere Pokémon aanvaalt. Dit is de methode die je vanuit je keuzemenu zal oproepen.

### Voorbeeldinteractie
```text
SQUIRTLE!
```

# Oefening 3 (h9-consciouspokemon-improved)

## Leerdoelen

* arrays van objecten
* `null`

## Functionele analyse
Je moet ook het geval afhandelen waarbij al je Pokémon KO zijn.

## Technische analyse
Breid je methode `TestConsciousPokemon` uit zodat ze niet crasht wanneer al je Pokémon KO zijn. Doe dit in een nieuwe versie, `TestConsciousPokemonSafe`.

### Voorbeeldinteractie
```text
Al je Pokémon zijn KO! Haast je naar het Pokémon center.
```

# Oefening 4: value en reference (h9-pokevalueref)

## Leerdoelen
* call by value vs. call by reference

## Functionele analyse
Een beginnend programmeur bij Game Freak heeft volgende statische methode geschreven in je klasse:

```
public static void RestoreHP(int oldHP, int newHP) {
    oldHP = newHP;
}
```

Hij gaat ervan uit dat dit werkt:

```
public static void DemoRestoreHP() {
// aanmaken van array bewusteloze Pokemon van 4 soorten zoals eerder: zelf doen
for(int i = 0; i < pokemon.Length; i++) {
    Pokemon.RestoreHP(pokemon[i].HP,pokemon[i].MaxHP);
    }
}
for(int i = 0; i < pokemon.Length; i++) {
    Console.WriteLine(pokemon[i].HP)
    }
}
```

Maar dit klopt niet. Los zijn bug op.

## Technische analyse
Je moet `RestoreHP` anders schrijven en ook het gebruik ervan aanpassen. Je mag de parameters van `RestoreHP` volledig aanpassen en ook de eerste `for`-lus veranderen. De tweede `for`-lus en het aanmaken van de array van `Pokemon` moeten exact gebeuren zoals ze geschreven zijn.

Roep `DemoRestoreHP()` op uit je keuzemenu.

### Voorbeeldinteractie
```text
20
20
20
20
```

# Oefening 5: uitkomst gevecht (h9-fight)

## Leerdoelen
* gebruik van `Random`
* `null` guard
* call by reference

## Functionele analyse
Hoe wreed het ook is, Pokémon zijn bestemd om tegen elkaar te vechten. Schrijf een simulatie van een gevecht met een willekeurig element.

## Technische analyse
Schrijf eerst een enumeratie `FightOutcome` met drie mogelijkheden: `WIN`, `LOSS` en `UNDECIDED` ("onbeslist").

Schrijf dan een **statische** methode `FightOutcome` in de klasse `Pokemon`. Deze heeft drie parameters, twee `Pokemon`-objecten en één `Random`-object.

`FightOutcome()` werkt als volgt:
- Een van de twee Pokémon mag eerst aan de beurt; welke van de twee wordt willekeurig beslist met behulp van het `Random`-object.
- Wanneer een Pokémon aan de beurt is, voert hij zijn `Attack()` methode uit.
- Hierna verlaagt de HP van de andere Pokémon met een getal tussen 0 en 20.
- Hierna is de andere van de twee Pokémon aan de beurt, maar alleen als hij nog bij bewustzijn is.
- De match is voorbij wanneer één van de twee Pokémon 0 HP heeft bereikt. Dan wordt het resultaat teruggegeven:
  - `WIN` als de eerste Pokémon die je als parameter hebt meegegeven nog bij bewustzijn is.
  - `LOSS` als de tweede nog bij bewustzijn is.

Handel ook situaties af waarbij minstens één van de twee Pokémon `null` is of al KO is bij het begin van de match. Dan wint de andere vanzelf, tenzij ze allebei ontbreken of KO zijn. Dan is de uitkomst `UNDECIDED`.

Schrijf ten slotte een methode `DemoFightOutcome()` die twee Pokémon naar keuze aanmaakt, hen tegen elkaar laat vechten tot er een resultaat is en dat resultaat dan op het scherm toont.

Test je methode met alle combinaties:

- twee gezonde Pokémon
- één bewusteloos
- twee bewusteloos
- één `null`
- twee `null`
- één bewusteloos en één `null`

## Afronden
Ga na dat al je code van de eerste oefeningen nog werkt nadat je de laatste hebt afgerond en plaats alles op Bitbucket.
