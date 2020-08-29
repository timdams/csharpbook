# Deel 1: Pokemon manager

Kan je alle kennis van dit semester gebruiken om een volwaardige Pokémon-gerelateerde manager te maken? Beeld je in dat je een programma schrijft dat toelaat dat gebruikers kunnen bijhouden welke Pokémons ze reeds hebben. Je array is een soort verzamelmap waarin je alle Pokémons kan plaatsen die je vindt.
De gebruiker krijgt een menu waarin hij kan kiezen om:

* Een nieuwe Pokémon toevoegen aan je map. Hiervoor toon je een lijst van geldige Pokémon. De gebruiker kiest welke nummer hij wenst toe te voegen, en die wordt dan aan de map toegevoegd.
* Oplijsten welke Pokémons er reeds in de map zitten
* Specifieke verzamelde Pokémon uit verwijderen
* Statistieken van een specifieke verzamelde Pokémon te tonen
* Specifieke verzamelde Pokémon van level te verhogen

# Deel 2: Manager klasse

Plaat alle logica uit deel 1 in een nieuwe ``PokeManager``klasse. Plaats je array met Pokémon als static array in deze klasse. Deze klasse zal quasi enkel ``static`` methoden hebben, zoals:
* ``ToonMenu``
* ``DeletePokemon(int index)``
* ``AddPokemon(Pokemon toadd)``
* ``ShowCollection()``
* ``ShowStats(int index)``
* ``Levelup(int index, int amountLevel)``

De idee van deze klasse is dat er in je hoofdprogramma zeer weinig code nog steeds, maar die wel zeer duidelijk is. Iets in trend van:

```java
while(true)
{
    PokeManager.ToonMenu();
    Console.WriteLine("Wat wil je doen?");
    //Toon mogelijkheden
    switch(keuze)
    {
        case 1:
            PokeManager.ShowCollection();
            break;
        //etc
    }
}
```

# (PRO) Deel 3: CSV bestanden verwerken

Zorg ervoor dat je:

* Bij het toevoegen van nieuwe Pokémon toon je alle mogelijke Pokémons door deze uit een csv-bestand uit te lezen (``allpoke.csv``), inclusief hun basis stats
* Je verzamelmap naar een een csv-bestand schrijven en uitlezen (``mypoke.csv``). Je hoeft hiervoor enkel het id en huidige level weg te schrijven. Nadien kan je met dit id de Pokémon opzoeken in de totaallijst van alle bestaande Pokémons(``allpoke.csv``))