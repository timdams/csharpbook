# Figures with interfaces
Gebruik je [Rechthoek-klasse](/6_klassen_en_objecten/A_practica.md#figuren) die je eerder  hebt aangemaakt. Maak een List aan waarin je een 10 rechthoek-objecten plaatsen, allen met een verschillende grootte. Zorg ervoor dat je nu je rechthoeken met de Sort()-methode kan sorteren op oppervlakte.

Toon de werking aan in een klein voorbeeld programma. 

## Game
**Zie onderaan pagina voor minimale klasse-hiërarchie en interfaces.**

Maak een spel dat als volgt werkt:
* De speler dient met zijn pion de overkant van het veld te bereiken.
* Het veld bestaat uit 20 bij 20 vakjes. Op ieder vakje kan maximum één mapelement staan: 
  * De speler zelf
  * Een monster
*	Een rots
*	Een speler kan niet door rotsen of monsters wandelen. 
*	Een speler kan in zijn beurt telkens één vakje bewegen OF naar rechts schieten:
  *	Indien geschoten wordt dan zal het mapelement op het vakje rechts van de speler vernietigd worden (rots of monster)
*	Monsters kunnen ook bewegen. In de beurt van de monsters beweegt ieder monster in een willekeurige richting indien er geen rotsen of spelers LINKS van het monster staan.
  *	Indien er WEL een rots of speler LINKS van het monster staat dan schiet het monster en vernietigd het de speler of rots.
*	Enkel RockDestroyer monsters kunnen schieten.
De setup van het spel bestaat uit volgende stappen:
1. Maak een 20 bij 20 array aan en plaats bepaalde hoeveelheid monsters en rotsen op de kaart, behalve op kolom 0.
2. Plaats de speler op de plek 0,10 in de array (midden van kolom 0)
3. Doorloop de volgende stappen tot er winnaar is

Iedere beurt van het spel bestaat uit volgende stappen:
1. Vraag speler om input (bewegen in 1 van de 4 richtingen OF schieten)
2. Voer actie van speler uit
3. Kijk of speler overkant van kaart heeft bereikt, zo ja: gewonnen!
4. Beweeg ieder monster op de kaart in een willekeurige richting
5. Beweeg iedere RockDestroyer OF laat RockDestroyer schieten
 

Stel de speler voor door een X, een rots door O , een monster door M een RockDestroyer door D.



## Extra’s:
Voorgaande beschrijving is een ‘minimale’ beschrijving. Voorzie extra functionaliteit naar believen zoals:
* Speler heeft levens
* Monsters hebben levens
* Andere soort monsters (bv slimmere)
* Meerdere levels met telkens andere/meer monsters bijvoorbeeld
* Meerdere spelers
* Verder schieten, of schieten in andere richtingen.

## Klasse-schema
![](/assets/9_interfaces/practgame.png)

``Location`` is van het type ``Point`` (compositie). ``Point`` is een zelfgemaakte mini klasse die er als volgt uit (minimaal uitziet): 
```csharp
class Point
{
  public int X{get;set;}
  public int Y{get;set;}
}
```

En dus in je abstracte klasse MapElement zal iets krijgen in de trend van: ``public Point Location {get;set;} = new Point();``

## Enkele screenshots

![](/assets/9_interfaces/practgame2.png)
![](/assets/9_interfaces/practgame3.png)


