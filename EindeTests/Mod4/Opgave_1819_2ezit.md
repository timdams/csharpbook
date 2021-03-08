{% hint style='tip' %}
Volgende opgave was de vaardigheidsproefopdracht voor het 2e zit examen van dit vak (OOP) in augustus 2019
{% endhint %}

We maken een eenvoudige veiling-simulator. Hierbij kunnen spelers bieden op getoonde schilderijen en deze kopen indien ze wensen. Het spel wordt gespeeld door 2 spelers, waarbij 1 speler de gebruiker is, de andere wordt door de computer bestuurd.

# Deel 1: Klassen
## Klasse 1: schilderij (3p)

Maak een klasse ``Schilderij``.

Deze heeft 2 minstens methoden
* TekenSchilderij: de methode zal een willekeurig schilderij op het scherm tekenen in linkerbovenhoek. Een schilderij is steeds 10 bij 10 groot en bestaat uit een willekeurige hoeveelheid gele, rode en groene vlakken. Enkele voorbeelden:
  ![](schilder.jpg)        
* Opgelet: ieder object tekent een ander schilderij. Als op hetzelfde object 2x na mekaar TekenSchilderij wordt aangeroepen dan zal uiteraard 2x hetzelfde schilderij getekend worden.
De klasse houdt intern bij uit hoeveel rode, hoeveel gele, en hoeveel rode vlakken het schilderij bestaat.

* ``KrijgData``: deze methode geeft terug uit hoeveel rode vlakken de schilderij bestond.

## Klasse  2: WaardeBepaler (2p)
Maak een klasse ``WaardeBepaler``. Deze bestaat uit 1 static methode genaamd ``BerekenWaarde``. Deze methode aanvaardt 1 int als parameter. Het geeft een double terug als resultaat.

De methode zal de waarde van het schilderij bepalen gebaseerd op het aantal rode vlakken. De waarde van een schilderij is het aantal rode vlakken maal 1000 en daar vervolgens de vierkantswortel van.

Een schilderij met 50 rode vlakken heeft dus een waarde van  €223,6   (vierkantswortel van 1000*50)


Dit getal tot 1 cijfer na de komma wordt door de methode teruggegeven.

## Klasse 3: Koper (4p)
Een koper heeft bij de start steeds een budget van 1500 euro. 

Het budget kan enkel als readonly property van buitenaf uitgelezen worden. De setter is private.

Een koper heeft een lijst  van schilderijen (leeg bij de start) waarin ieder gekocht schilderij komt.

Een koper heeft een constructor die een interne waarde ogenblikkelijk op 1500 zet
* Een methode “Koop”: deze methode aanvaardt 1 parameter van het type schilderij en geeft een bool terug.
  * Eerst wordt de waarde van het meegegeven schilderij berekend mbv van de WaardeBepaler klasse. 
  * Vervolgens: Indien de koper genoeg budget heeft dan zal de waarde van het schilderij van het budget gehaald worden (via de private setter) en wordt het schilderij aan de lijst van gekochte schilderijen van de koper toegevoegd.
     * Vervolgens geeft de methode ‘true’ terug.
  * Indien de koper niet genoeg budget heeft wordt false teruggeven.


Een koper heeft een methode ``TotaleWinst``: deze methode geeft de totale waarde van alle schilderijen samen in zijn lijst  terug als een int.

# Deel 2: Veiling (4p)

Schrijf een programma dat voorgaande klasse gebruikt als volgt:
* 1 speler-object wordt door de gebruiker bedient. 1 door de computer.
* Er verschijnt telkens een schilderij, met daaronder de waarde ervan.
* Er wordt aan de gebruiker gevraagd of hij/zij dit wenst te kopen. Indien ja, en dit kan, dan wordt het schilderij aan zijn lijst toegevoegd en z’n budget verlaagt.
* Indien neen dan zal de computer het schilderij kopen indien deze nog genoeg budget heeft.
* Vervolgens komt het volgende schilderij.
* Het ‘spel’ stopt wanneer beide speler het huidige schilderij niet kunnen of willen kopen.
* De “TotaleWinst” van iedere speler wordt vergeleken. De speler wiens TotaleWinst + overgebleven Budget het hoogst is wint.
  * Voorbeeld: speler 1 heeft TotaleWinst 300 en Budget over 300, dus 600
  * Speler 2  (de computer) heeft TotaleWinst 400 en Budget 100, dus 500. Speler 1, de gebruiker, wint de veiling
* Het spel toont wie heeft gewonnen en sluit dan af.

# Deel 3: Picassos (2p)

* Maak een klasse Picasso. Deze klasse is een Schilderij, maar bestaat uit een 15 bij 15 groot schilderij (in plaats van 10 bij 10) en zal dus meestal meer waard zijn.

* Zorg ervoor dat er op de veiling ongeveer 30% van de tijd een Picasso verschijnt die de spelers kunnen kopen. De overige werking blijft dezelfde.

# Deel 4: Koper++ (4p)

* De klasse Koper heeft een extra methode “SorteerBezit”. Wanneer deze wordt aangeroepen dan worden de schilderijen in zijn bezit gesorteerd op basis van hun waarde. De hoogste waarde komt vooraan en zo verder.


* De klasse Koper heeft een extra methode “KrijgSchilderij”: deze methode aanvaardt 1 parameter van het type Koper. Wanneer de methode wordt aangeroepen op een koper en een andere koper wordt als parameter meegegeven, dan krijgt de koper die de methode aanroept het eerste schilderij uit de lijst van de meegegeven koper. Het schilderij verdwijnt vervolgens uit de lijst van deze koper.


* Voeg aan achteraan het spel code toe die aantoont dat deze twee methoden werken.
