# Introductie
![Kaart uitleg](../../assets/title.png) 
Het spel Magic The Gathering is een populair kaart/verzamel spel. We gaan een vereenvoudigde versie maken die ons zal toelaten om te ontdekken of we een bepaald wezen kunnen maken (*casten*) gegeven een bepaalde hoeveelheid land-kaarten.

Er zijn 2 soorten kaarten:

* CreatureKaarten: deze wezens kan je enkel maken als je genoeg land hebt om de CastingCost te bepalen in mana (van een bepaalde kleur).
* LandKaarten: ieder land produceert 1 mana van een specifieke type (kleur).

Wil je dus een wezen produceren dat 4 water(blauwe) mana vereist dan zal je 4 Islands nodig hebben (daar een Island 1 blauwe mana genereert)


# Opdracht

Deze opgave bestaat uit 3 grote delen:
1. CreateKaart klasse maken
2. LandKaart klasse maken
3. Casting tester applicatie maken

# CreatureKaart klasse

Een kaart met een wezen wordt gedefinieerd door volgende zaken (enkel de zwarte pijlen gaan we gebruiken):

![Kaart uitleg](../../assets/kaartuitleg.jpg) 

## Eigenschappen
* **CreatureName**: naam van het wezen
    * We stellen deze voor in de klasse als een ``string``, readonly property 


* *"De casting cost"*: hoeveelheid mana die nodig is. In bovenstaande voorbeeld heb je 2 blauwe en 4 "kleurloze' mana nodig (kleurloos= gebruiker mag eender welke kleur kiezen).
    * In onze klasse stellen we de casting cost voor door 3 aparte readonly properties met namen:
        1. ``ColoredTypeNeeded``: is van het ``ManaType`` type (enum), readonly property (zie verder, bij Enum landen). Deze stelt de "hoofdkleur" van de kaart voort (Blauw in bovenstaand geval)
        2. ``AmoundColoredTypeNeeded``: type ``int`` om aan te geven hoeveel mana er nodig is van het ``ColoredTypeNeeded`` type (2 in bovenstaand geval).
        3. ``AmountUncoloredTypeNeeded``: ook een ``int`` om aan te geven hoeveel kleurloze mana er nodig is. (4 in bovenstaand geval)
    * OOP al goed in de vingers? Bekijk dan zeker de extra opgave voor dit stukje achteraan dit document.
* **SpecialAbilities**:
    We stellen deze voor in de klasse als een ``string``, readonly property.
* **FlavourText**:
    * We stellen deze voor in de klasse als een ``string``, readonly property 
* *"Attack/Defense"*:
    * We stellen deze in de klasse voor als twee readonly ``int`` properties met private setters genaamd ``Attack`` en ``Defense``.
        * Beide properties kunnen nooit lager dan 0 zijn (0 is wel toegelaten)

## Constructor

Een ``CreatureKaart`` object kan enkel via een **overloaded constructor** aangemaakt waarbij alle voorgaande eigenschappen moeten worden meegegeven.

## Methoden

* **``ChangeAttack``**: deze methode aanvaardt 1 ``bool`` en geeft niets terug. Als deze ``true`` is dan zal bij aanroep van de methode de ``Attack`` property met 1 verhoogd worden. Wanneer de ``bool`` ``false`` is zal de ``Attack`` property met 1 verlaagd worden.

* **``Toonkaart``**: deze methode aanvaardt geen parameters en geeft niets terug. Aanroepen ervan zal een samenvatting van de kaart op het scherm tonen. 

<!---{line-numbers:false}--->
```text
*******************************************************
Mahamoti Djinn (4 kleurloos, 2 Water mana)
*******************************************************
"Of royal blood among the spirits [etcetc]"
-------------------------------------------------------
    Abilities: Flying
    Attack: 5
    Defense: 6
-------------------------------------------------------
```

Bij attack en defense toon je de HUIDIGE waarden. 
# LandKaart klasse

Er zijn 5 soorten land. Ieder land genereert 1 mana van de kleur die op de kaart staat. 
![Kaart uitleg](../../assets/mana.jpg) 

## Eigenschappen
Een landkaart wordt door 2 zaken gedefinieerd:

* Naam van het land (readonly property, ``string``) (bv Island, Forest, Plains, etc.)
* Type mana dat het land genereert
    * Stel deze voor in de klasse als een readonly property van het type ``ManaType`` (zie hieronder)

###  Enum landen (ManaType)

Er zijn 5 mana "kleuren". Deze stel je voor in een enum type genaamd ``ManaType``. De kleuren zijn:
* Water
* Bos
* Zon
* Vuur
* Dood 

## Constructor

Een ``LandKaart`` object kan enkel via een **overloaded constructor** aangemaakt waarbij alle voorgaande eigenschappen moeten worden meegeven.

## Methoden

* Toonkaart: deze methode aanvaardt geen parameters en geeft niets terug. Aanroepen ervan zal een samenvatting van de kaart op het scherm tonen. 

<!---{line-numbers:false}--->
```text
*******************************************************
Island (Water mana)
*******************************************************
```
# Maak 3 creature objecten aan

Maak 3 CreatureObjecten aan in je main:

1. Namelijk ten eerste de Mahamori Djinn van hierboven.
    * ``ColoredTypeNeeded``: ManaType.Water, ``AmountColoredTypeNeeded``: 2 en ``AmoundUncoloredTypeNeeded``:4
2. Alsook een "KinderCatch" (merk ok dat deze kaart geen ``SpecialAbilities`` heeft en je deze property dus als een lege tekst mag voorstellen (``""``)). Deze kaart heeft dus 3 bos-mana en 3 kleurloze mana nodig.
![Kaart uitleg](../../assets/card2.jpg) 
    * ``ColoredTypeNeeded``: ManaType.Bos, ``AmountColoredTypeNeeded``: 3 en ``AmoundUncoloredTypeNeeded``:3
3. Als derde deze schattige "Mountain Goat" die als ``SpecialAbility`` "Mountainwalk heeft".
![Kaart uitleg](../../assets/card3.jpg)
    * ``ColoredTypeNeeded``: ManaType.Vuur, ``AmountColoredTypeNeeded``: 1 en ``AmoundUncoloredTypeNeeded``:0
# Casting tester

We maken nu een applicatie die uit drie stappen bestaat:

1. Een deck met landkaarten aanmaken gebaseerd op de invoer van de gebruiker
2. Vragen welk creature de gebruiker wenst te maken
3. Controleren of het gevraagde wezen kan gemaakt worden met de aanwezige landkaarten

# Stap 1: Landen maken
De gebruiker wordt gevraagd hoeveel landen hij per manatype heeft.

<!---{line-numbers:false}--->
```text 
Aantal Water? 
4   <-ingevoerd door gebruiker
Aantal Bos? 
2   <-ingevoerd door gebruiker
Aantal Zon? 
3   <-ingevoerd door gebruiker

etc.
``` 
Maak een ``List<LandKaart>`` lijst aan waarin je het juiste aantal ``LandKaart``-objecten plaatst. Dus in voorgaande voorbeelden zullen er 4 Water landkaarten vooraan staan, gevolgd door 2 Bos, etc.

# Stap 2: Creature vraag

De gebruiker wordt gevraagd welk dier hij wilt maken. Hierbij worden de 3 eerder aangemaakt creature objecten (de djinn, de geit en de kindercatch) getoond d.m.v. ``ToonKaart`` methode van ieder object.

De gebruiker kan dan 1, 2 of 3 als invoer geven (foute invoer niet controleren)

# Stap 3: Controle

> De applicatie zal nu bekijken of je het gekozen dier kan maken. Hierbij zal de ``List<LandKaart>`` bekeken worden of dat er genoeg landen van het juiste type voor het gegeven dier aanwezig zijn.

## CastTest methode
Deze controle gebeurt via een **``static``** methode die je in de ``LandKaart`` klasse plaatst. Deze methode heeft ``CastTest`` als naam. 

De methode aanvaardt 2 parameters:
* Een ``List<LandKaart>`` object dat de deck met landkaarten voorstelt
* Een ``CreatureKaart`` object dat het dier voorstelt dat je wilt maken

De methode geeft een ``bool`` terug om aan te geven of het dier wel of niet gemaakt kan worden. 

## Methode in stap 3 gebruiken
Gebruik de ``CastTest`` methode om te controleren ofhet gevraagde dier kan gemaakt worden. Geef daarvoor als parameters de in stap 1 gemaakt LandKaarten-lijst mee alsook het in stap 2 gekozen dier-object.

Het resultaat van deze methode zal vervolgens gebruikt worden om een zinnetje op het scherm te tonen:

``Dier kan gemaakt worden`` (indien bool ``true`` was)

of

``Dier kan niet gemaakt worden``  (indien bool ``false`` was)

# Extra opgave voor de OOPros

Vervang de 3 casting cost gerelateerde properties door een 1 property van het type ``CastingCost`` dat je in een aparte klasse ``CastingCost`` aanmaakt. 

Deze klasse heeft 3 eigenschappen : ``ColoredTypeNeeded``, ``AmountColoredTypeNeeded`` en ``AmoundUncoloredTypeNeeded``.

Je kan objecten van deze klasse enkel aanmaken m.b.v. een constructor die 3 parameters vereist om de 3 voorgaande eigenschappen in te stellen.