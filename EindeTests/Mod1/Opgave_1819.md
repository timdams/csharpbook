# Opgave vaardigheidsproef 1819, module 1 - Intergalactic pizzaphone bestel-module
## Introductie
IPP – Intergalactic PizzaPhone -  is de populairste pizza-delivery service van het heelal. Ze hebben jouw hulp ingeschakeld om een nieuwe bestel-module te maken. Jouw module moet ervoor zorgen dat de telefoonoperators veel sneller de bestellingen kunnen invoeren en doorgeven aan de keuken.  
> yIghoSDo' chenmoHwI'!  (Klingon voor: Veel succes maker!)

## Opgave
De opgave bestaat uit twee delen:
* Deel 1- Bestelmodule (15 punten)
    De bestelmodule uit een aantal onderdelen (Alle prijzen worden uitgedrukt in Intergalactic Credits (IC))
    * Bevraging: er wordt aan de klant een aantal vragen gesteld (bv type pizza, etc)
    * Visualisatie: de bestelling wordt getoond op het scherm
    * Berekening: de totaalprijs wordt berekend
    * Ticket: de totaalprijs wordt getoond

* Deel 2 – Uitbreidingen (5 punten)
    Deze zullen achteraan de opgave uitgelegd worden. Het is aangeraden om eerst deel 1 af te werken voor je aan de uitbreidingen begint.

    De uitbreidingen zijn:
    * Een random kortingsmodule
    * Een benzine berekenaar  
 

## Deel 1- Bestelmodule
### Bevraging (5 punten)
Een reeks vragen zal gesteld worden waarbij de gebruiker (operator) z’n keuze invoert en naar de volgende vraag gaat.

#### Pizzabodem?

De pizzabodem kan bestaat uit:
* Cheesy crust  	(kost 5 IC)
* Martian meal 	(kost 2.8 IC)
* Pegasus lime	(kost 12.4 IC)

Indien "Martian meal" wordt besteld moet de operator ook vertellen dat dit niet geschikt is voor kinderen onder de 54 jaar. De operator zal daarom nu de leeftijd vragen en enkel verder gaan indien deze groter of gelijk is aan 54. Indien jonger stopt programma en verschijnt er “ERROR” in rode letters op het scherm.

#### Topping?

De gebruiker kan kiezen uit 2 soorten toppings, hij mag ook verkiezen om zonder topping verder te gaan. De kost van een topping kan afhankelijk zijn van de gekozen pizzabodem:
* Endrali pies	
    * kost 10 IC voor cheesy crust,
	* kost 15 IC voor Martian meal en Pegasus Lime
* Italian Cheese	
	* kost 5.5 IC op alle bodems
* Geen		
    * geen kost

#### Chefs extra?

Indien de klant voor geen topping kiest dan kan deze voor 1 IC de chef’s extra (een dikke fluim) aan z’n pizza toevoegen.

#### Afstand tot aarde in lichtjaar?
* Als finale vraag dient de gebruiker door te geven hoe ver het afleveradres is in lichtjaren. Dit zal steeds een geheel getal tussen 1 en 100 moeten zijn. 
* Indien de gebruiker een getal buiten deze grenzen ingeeft dan sluit het programma door in rode letters “ERROR” op het scherm te zetten

 
### Visualisatie (4punten)

De pizzabestelling wordt gevisualiseerd als volgt:
* Een letter verschijnt in een bepaalde kleur afhankelijk van de bodem, namelijk:
    * Gele C voor cheesy crust
	* Rode M voor martian meal
	* Groene P voor pegasus lime
* Na de bodemletter verschijnt een O in de kleur van de topping. 
	* Blauw voor endrali pies
	* Geel voor italian cheese
	* Indien gebruiker geen topping koos maar wel de chef’s extra verschijnt in de plaats een Witte E
	* Indien de gebruiker geen topping koos en ook geen chef’s extra dan verschijnt er geen O maar een gele Z


Voorbeelden:

![](../../assets/2_beslissingen/vaardig1819.jpg)

### Prijsberekening (3 punten)
De prijsberekening van de pizza gebruikt de prijzen hierboven vermeld en is gewoon de optelsom van de aparte delen.

Na de pizza-prijs berekening wordt berekend hoeveel de transportkosten zullen zijn. Deze zijn gebaseerd op de afstand tot de aarde in lichtjaren als volgt:

Transportkosten:
* Afstand kleiner dan 10 :  25 IC
* Afstand groter of gelijk aan 10: $\sqrt(s/p)+p$   (met p gelijk aan de pizzaprijs en s de afstand)
    * De transportprijs wordt naar beneden afgerond tot het eerste gehele getal.
* Indien de chef’s extra werd gekozen dan zal er een 10% korting op de totale transportkosten gegeven worden

### Ticket (3 punten)
**Gebruik string interpolatie voor dit deel.**
Een ticket wordt getoond dat de volledige bestelling in tekst toont met erachter, via tab, steeds de prijs. Onderaan volgt de totaalprijs. 
Voorbeeld van een ticket:

<!---{line-numbers:false}--->
```text
Martian meal			2.8 IC
Italian Cheese			5.5 IC
- 	-	-	-	-	-	-	-	-
Totaal pizza			8.3 IC

Afstand		                12 Lichtjaren
Transportkosten:		9  IC
- 	-	-	-	-	-	-	-	-
TOTAAL				17.3 IC
```
 
## Deel 2- Uitbreidingen
### Random korting- module  (2 punt)

De standaard korting voor de chef’s extra op de transportkosten is 10%. In deze uitbreiding zou het bedrijf graag hebben dat een willekeurige korting wordt toegekend. Deze zal steeds een willekeurige bedrag tussen 0 en 50% korting zijn.

### Benzine module (3 punten)

Deze module zal berekenen hoeveel tonnen benzine er nodig zijn om de pizza bij de klant te krijgen. Er is 1 ton benzine nodig per 5 lichtjaar. Indien de klant dus 12 lichtjaren ver woont dan zijn 3 tonnen nodig, waarbij de derde ton maar voor 2/5 (40%) zal opgebruikt worden.

De module zal dus steeds het geheel aantal tonnen benzine tonen , gevolgd door hoeveel % van de laatste ton nodig zal zijn (indien deze volledig opgebruikt zal worden dan toon je 100% uiteraard; bv wanneer de klant op 10 lichtjaar woont)

De benzine module toont deze informatie onderaan het ticket:

<!---{line-numbers:false}--->
```text
Martian meal			2.8 IC
Italian Cheese			5.5 IC
- 	-	-	-	-	-	-
Totaal pizza			8.3 IC

Afstand	                	12 Lichtjaren
Transportkosten:		9  IC
- 	-	-	-	-	-	-
TOTAAL				17.3 IC
*********************************
Informatie voor de piloot:
Benzine tonnen in te laden	2
Benzine over in laatste ton:	20%
```
