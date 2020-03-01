# Meetlat constructor

Vul de ``Meetlat`` klasse uit het vorige hoofdstuk aan met een constructor. De constructor laat toe om de lengte in meter als parameter mee te geven. De ``LengteInMeter`` write-only property vervang je door een private datafield ``double lengteInMeter``.

# Sport simulator
Haal je Sport klasse van hoofdstuk 8 (oefeningen) boven en voeg volgende statische methode er aan toe (vervang het soort speler door de naam van jouw klasse. Mijn klasse noemde ``Waterpolospeler``)

Schrijf een methode genaamd:
``static void SimuleerSpeler(Waterpolospeler testspeler)``

(vervang dus Waterpolospeler door de klasse die je zelf hebt gemaakt)

De SimuleerSpeler-methode zal beide methoden van je klasse telkens 3x aanroepen m.b.v. een for-loop in de methode (dus in mijn geval 3x GooiBal en 3xWatertrappen)

Test je methode door 2 objecten aan te maken en telkens mee te geven als parameter.

Maak een tweede methode 
``static void SimuleerWedstrijd(Waterpolospeler speler1, Waterpolospeler speler2)``

Bij aanroep van de methode verschijnt er op het scherm wie van beide speler zou winnen als ze zouden spelen. Gebruik een random uitkomst om te bepalen over speler 1 of 2 wint. Toon op het scherm "Speler 1 wint." Gevolg door de aanroep van iedere methode van die speler.

Maak een derde methode
``static Waterpolospeler BesteSpeler(Waterpolospeler speler1, Waterpolospeler speler2)``

Deze methode gaat ook random bepalen welke speler de beste is. Vervolgens geef je deze speler terug als resultaat. In de main roep je vervolgens iedere methode van dit object aan.

# Digitale kluis

Maak een klasse ``DigitaleKluis`` die we gaan gebruiken om een kluis voor te stellen.

De klasse heeft volgende elementen:

* Een private variabele die de toegangscode van de kluis bewaard als geheel getal (naam: ``code``) 
* Een overloaded constructor die als parameter een geheel getal toelaat. Dit getal zal worden toegewezen aan de private variabele code.
* Een full property ``CanShowCode`` die kan ingesteld worden op true or false, om aan te geven of de code van buitenuit kan gezien worden.
* Een read-only property ``CodeLevel`` van type int. Deze property zal het level van de code teruggeven. Het level is eenvoudigweg de code gedeeld door 1000 als geheel getal (dus indien de code 500 is zal 0 worden teruggegeven, indien de code 2000 is wordt 2 teruggegeven, etc.) 
* Een fullproperty ``Code`` met private set. De get van deze property zal -666 teruggeven, tenzij CanShowcode op true staat, in dit geval zal de effectieve code worden terug gegeven. 
* Een methode ``TryCode`` die een geheel getal als parameter aanvaardt. De methode geeft een true terug indien de code correct was, anders false. Deze methode kan gebruikt worden om extern een code te testen , indien deze overeenkomt met de bewaarde code dan zal gemeld worden dat de code geldig is en wordt ook getoond hoeveel keer de gebruiker geprobeerd heeft. Indien de gebruiker -666 meegaf dan meldt de methode dat de gebruiker een cheater is . Indien de gebruiker een foute code meegaf dan meldt de methode dat dit een foute code was en wordt het aantal pogingen met 1 verhoogd.  
* Een private variabele ``aantalpogingen`` om bij te houden hoe vaak de gebruiker geprobeerd heeft de code te vinden.

Maak enkele Digitale Kluis objecten aan in je main en test of je bovenstaande klasse correct is geïmplementeerd.

# Pokémons deel 2

## Constructors

Pas de kennis van constructors toe op je Pokémon-project uit het vorige hoofdstuk. Zorg ervoor dat je Pokémons op 3 manieren kunt aanmaken als volgt:

* Via een default constructor: alle base stats worden daarbij op 10 standaard ingesteld via de constructor
* Via een overloaded constructor die de gebruiker toelaat om de 6 base stats als parameters mee te geven (bv ``new Pokemon(45,42,50,65,34,67)``)
* Via object initializer syntax waarbij je eender welke stat kunt instellen.

## Static methoden

* Verhuis de methoden (``GeneratorPokemon`` en ``Battle``) die je maakte in deel 3 van de Pokémon-opdracht in vorige hoofdstuk naar de klasse ``Pokemon`` zelf en test of deze nog steeds werkt. (Is dit een logischere plek?)
* Voeg enkele static properties met private set toe om bij te houden:
    * Hoe vaak een Pokémon z'n level werd verhoogd (dus telkens bij aanroep van ``VerhoogLevel``)
    * Hoe veel Battles er al zijn geweest (verhoogt telkens ``Battle`` wordt uitgevoerd)
    * Hoe vaak een battle resulteerde in gelijkstand (verhoogd bij gelijkstand in  ``Battle``)
    * Hoe veel random Pokémons werden aangemaakt (verhoogt telkens ``GeneratorPokemon`` wordt aangeroepen)
* Maak een static methode ``Info`` die deze properties als een soort samenvatting naar het scherm stuurt
* Maak een static property ``NoLevelingAllowed`` aan van het type bool. Deze kan van buiten de klasse aangepast worden. Indien deze bool op ``true`` staat kunnen Pokémons hun level niet verhoogd worden. Wanneer in dit geval ``VerhoogLevel`` wordt aangeroepen zal er een foutboodschap op het scherm komen.

Toon in je hoofdprogramma aan dat je kunt werken met deze static methoden en properties.

# Werken met string en csv

Opgelet! Er is geen aparte oefening waar wordt gewerkt rond string en het verwerken van csv-bestanden. Zorg dat je dit beheerst door bijvoorbeeld zelf een oefening uit te werken waarin je een csv-bestand verwerkt!