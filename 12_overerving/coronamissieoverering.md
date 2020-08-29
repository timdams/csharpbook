> Tijd om ons Vaccin te verbeteren. Het huidige Vaccin vindt de killcode enkel door steeds willekeurige getallen te testen. Dat is een beetje hetzelfde als geblinddoekt op een olifant jagen. We gaan nieuwe vaccins ontwikkelen die een betere strategie hanteren.

# Nieuwe vaccins en virussen

1. Zorg ervoor dat de methode ``TryKillCode`` virtual wordt gemaakt in de Vaccin klasse.
2. Maak een klasse SlimVaccin dat overerft van Vaccin. Deze klasse implementeert TryKillCode op een andere manier via ``override``:
   1. Het Vaccin zal eerst alle veelvouden van 10 (0,10, 20, etc.) testen. Vervolgens 11,21,31,...en dan 12,22, etc.

# Nieuw virus

1. Zorg ervoor dat de methode ``TryVaccin`` virtual wordt gemaakt in de Virus klasse.
2. Maak een klasse DomVirus dat overerft van Virus. Deze klasse voert nog steeds TryVaccin uit zonder aanpassingen. Echter, 50% van de tijd zal de aanroep van TryVaccin resulteren in het verhogen (ipv verlagen) van de ``DoomCountdown`` teller.

# Test vaccin en nieuwe virus

Voer terug Fase 1 uit maar deze keer doe je dit op het nieuwe DomVirus en gebruik je SlimVaccins.

Kan je nu sneller het vaccin vinden? 

# Vaccinatiecentra verspreiden



## Dictionary 
We gaan de centra over de 7 continenten verspreiden. Maar we gaan hiervoor een nieuw concept gebruiken, een zogenaamde ``Dictionary`` dit is hetzelfde als een ``List`` maar in plaats van een index heeft ieder element een key van een type dat je zelf bepaalt. [Lees even dit na.](../11_arraysvanklassen/dict.md)

Maak de Dictionary als volgt:

```java
Dictionary<string,VaccinatieCentrum> centraDB = new Dictionary<string,VaccinatieCentrum>();
```

``string`` geeft hier aan dat we als key een string gebruiken, en dat de elementen in de dictionary allemaal Vaccinatiecentra zijn.

Voeg centra aan de dicht als volgt toe.Dit centrum geven we als key frankrijk:

```java
centraDB.Add("frankrijk", new VaccinatieCentrum());
```

Volgende code toont bijvoorbeeld hoe je een vaccin nu aan het centrum met key frankrijk verkrijgt

```java
Vaccin vac= centraDB["frankrijk"].GeefVaccin();
```

## Uitvoeren

Maak een programma dat aan de "operator" vraagt in welke landen een centrum moet geplaatst worden. Zoek op hoe je in een dictionary kan controleren of er reeds een element met die key bestaat (want anders overschrijf je bestaande centrum). Toon aan gebruiker dat bouw van nieuw centrum gelukt is, of waarschuw hem als dit land reeds centrum heeft.

De operator kan uit het menu ook kiezen om een overzicht van alle centra te krijgen. Volgende code toont hoe dit kan:

```java
Console.WriteLine("Centra in volgende landen:")
foreach (VaccinatieCentrum item in centraDV)
{
    Console.WriteLine(item.Key);
}
```

Kan je hier een programma rond bouwen waarbij de operator ook kan kiezen welk land/centrum Vaccins moet genereren?