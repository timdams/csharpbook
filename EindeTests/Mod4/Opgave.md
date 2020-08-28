{% hint style='tip' %}
Volgende opgave kwam uit de vaardigheidsproef module 4 van dit vak juni 2019.
{% endhint %}

# Hammertje Tik
Maak een digitale console-versie van het klassieke kinderspel hamertje Tik
 
In dit spel heeft het kind een hele hoop kleurige blokjes ter beschikking waarmee hij op een kurken bord eender welke ‘tekening’ kan maken door de blokjes in de kurk met een nagel te kloppen.
# Opbouw project
Het project bestaat uit enkele delen.
* Klassen  	- Deel 1 (11 punten) : maken van de nodige klassen die Vormen voorstellen
* Menu		- Deel 2 (5 punten): maken van een menu die toelaat dat de gebruiker verschillende vormen op het scherm kan manipuleren
* PRO 		-Deel 3 (4 punten): een iets pittigere pro-gedeelte voor zij die nog tijd hebben


# DEEL 1  (11 PUNTEN)
We gaan volgende klasse-structuur in de volgende stappen maken:

![](/assets/Aallinone/mod4class.png)


## Stap 1: 	/2PUNTEN
Maak een abstracte klasse Vorm die z’n locatie (via x,y coördinaten als autoprops) op het scherm kan bijhouden alsook een abstracte methode  ``TekenVorm``.
Voeg voorts een virtual property Kleur toe van het type ``ConsoleColor``. Deze property is read-only en geeft ConsoleColor.Red terug.

De klasse ``Vorm`` heeft een overloaded constructor die steeds de x,y coördinaten verwacht als parameters vervolgens instelt in de bijhorende autoprops.

De Vorm heeft géén default constructor.

De locatie van de vormen die we hierna zullen definiëren is steeds het punt linksboven indien we een rechthoek omheen de vorm zouden tekenen. Het voorbeeld hier toont deze plek bij het vliegtuig van stap 3: 

![linkerbovenhoek is de oorsprong](/assets/Aallinone/vliegtuigcoord.png)

 
## Stap 2:	/2punten
Maak twee klassen die allebei een Vorm zijn:
* ``Rechthoek``
* ``Lijn``

Zorg ervoor dat beide vormen via TekenVorm zichzelf op het scherm kunnen tonen in hun eigen kleur.

**Lijn:**
* Heeft een Lengte autoproperty
* Heeft 1 overloaded constructor die x,y en lengte vraagt
* Heeft als kleur ``ConsoleColor.Green``
* Een lijn bestaat uit een reeks sterretjes (*)  horizontaal naast elkaar, gelijk aan de lengte die je via de constructor van bij de start kunt meegeven. Bijvoorbeeld bij lengte 3:

<!---{line-numbers:false}--->
```text
	* * *
```

**Rechthoek:**

* Heeft een Lengte en Breedte autoproperty
* Heeft 2 constructors:
  * 1 overloaded die x,y, lengte en breedte vraagt
  * default die standaard een rechthoek op locatie 1,1 zet met lengte en breedte 2
* Heeft als kleur ``ConsoleColor.Yellow``
* Een rechthoek verwacht een lengte en breedte bij het aanmaken en kan zichzelf ook tekenen. Als je lengte 4 en breedte 2 ingaf zou deze er als volgt uitzien:

<!---{line-numbers:false}--->
```text
 	* * 
	* * 
	* * 
	* *
```

## Stap 3:	/3punten
Maak een klasse Vliegtuig dat ook een Vorm is. Een vliegtuig bestaat (compositie!) uit 1 Rechthoek en 2 Lijn-objecten en ziet er altijd hetzelfde uit, namelijk
* Een rechthoek van 2 bij 5
* Links en rechts van deze rechthoek een lijn van 3 breed, telkens in de helft van de lengte van deze rechthoek 
* Enkel de locatie op het scherm kan anders zijn per vliegtuig, hun afmetingen echter niet.

<!---{line-numbers:false}--->
```text
	   * * 
	   * * 
     * * * * * * * * 
	   * * 
	   * *
```

Een Vliegtuig heeft een constructor die de x,y locatie vraagt (zie tekening vorige pagina i.v.m. coördinaten) en zal in de constructor de 3 vormen (2 lijnen en 1 rechthoek) aanmaken.

Merk op dat dus dat het lichaam (de Rechthoek) geel zal zijn, en de twee vleugels groen (van de lijnen).

## Stap 4:	/2punten
Maak een klasse Vloot dat ook een Vorm is. Een vloot bestaat uit 1 of meerdere vliegtuigen. Je kan via de constructor instellen hoeveel vliegtuigen er moeten zijn in 1 Vloot, alsook de x,y coördinaten (linksboven).De nodige vliegtuigen worden in de constructor aangemaakt en in een lijst bijgehouden in het Vloot-object zelf.

Houdt via een lijst in de klasse de vliegtuigen bij. Een vloot vliegtuigen dat getekend wordt tekent gewoon alle vliegtuigen onder mekaar.

Een vloot van 3 vliegtuigen zal er als volgt uitzien op het scherm:

<!---{line-numbers:false}--->
```text
        * * 
        * *
  * * * * * * * * 
        * * 
        * *
        * * 
        * *
  * * * * * * * * 
        * * 
        * *
        * * 
        * *
  * * * * * * * * 
        * * 
        * *
```

Merk op dat de vliegtuigen hun originele kleuren behouden uit de vorige stap.
 
##	Stap 5:	/2 punten
Maak een interface ``IBeweegbaar``, bestaande uit 1 methode ``Beweeg``. Deze geeft niets terug en heeft 1 parameter van het type ``Richting``.

``Richting`` is een enum-type dat 4 mogelijke waarden heeft: Links, Rechts, Boven, Beneden.

Pas de interface toe op Vliegtuig en Vloot. Deze methode zal de Locatie van het object 1 plekje opschuiven in de richting die in de parameter werd meegegeven. Als dus vervolgens het object opnieuw wordt getekend zal het object 1 plek naar rechts opgeschoven zijn.

Vormen verplaatsen is gewoon een kwestie van de X,Y coördinaten aan te passen. Meer is niet nodig.

  
# Deel 2		(5 PUNTEN)

##	Stap 6	/5punten

Maak nu een hammertje tik programma: een console-programma dat de gebruiker steeds volgende vragen stelt en vervolgens de gevraagde vormen toevoegt aan het scherm. Op de duur zal de gebruiker grote, complexe tekeningen kunnen maken door meerdere vormen en types te combineren. 
Iedere vorm die wordt toegevoegd zal in een lijst worden bijgehouden.

Een loop zal steeds volgende stappen uitvoeren tot de gebruiker het programma afsluit. 
1. Alle vormen die reeds zijn toegevoegd in de lijst op het scherm tekenen via TekenVorm
2. Aan gebruiker vragen wat er moet gebeuren
3. Beeld leegmaken


De vragen die gesteld kunnen 
1. *Lijst  leegmaken* => alle vormen verdwijnen en de gebruiker kan terug opnieuw beginnen
2. *Vorm toevoegen* => zal de gewenste vorm toevoegen aan een lijst nadat volgende 2 of 3 extra zaken aan de gebruiker werden gevraagd:
   1. *Welke vorm?* (rechthoek, lijn, vliegtuig, vloot)
   2. *Locatie* (x,y) op het scherm
   3. Vormafhankelijke informatie? (bv aantal vliegtuigen)
3. *Afsluiten* => programma sluit af
4. *Verplaats object naar…*: gevolgd door de vraag in welke richting moet verplaatst worden. Wanneer de gebruiker deze optie zullen alle objecten die de IBeweegbaar hebben 1 plekje in de ingegeven richting verschoven worden


# DEEL 3	(4 PUNTEN)

##	STAP 7:	/2 punten

Voeg een nieuw menu-item toe namelijk *Vergroot vloot*. Wanneer de gebruiker deze optie kiest zullen alle Vloot-objecten in de lijst 1 extra vliegtuig bijkrijgen. Je zal hiervoor een extra methode ``VergrootVloot`` aan de Vloot-klasse moeten toevoegen.

## STAP 8: 	/2 punten

Voeg een nieuw menu-item ``Sorteer`` toe, indien de gebruiker dit kiest dan worden alle Vormen gesorteerd op hun x-locatie, hoe kleiner x, hoe eerder in de lijst. Bij gelijke x wordt gekeken naar de y-locatie waar degene met de laagste y voor die met hogere komt.

Vervolgens worden de objecten met een loop op het scherm beschreven als volgt:
VormType, x, y

Dus bijvoorbeeld:

<!---{line-numbers:false}--->
```text
Rechthoek, 3, 5
Rechthoek, 3,6
Vliegtuig, 5,2
```