# Klassen objecten introductie

## RapportModule

Ontwerp een klasse ``Resultaat`` die je zal tonen wat je graad is gegeven een bepaald behaald percentage. Het enige dat je aan een ``Resultaat``-object moet kunnen geven is het behaalde percentage. Enkel het totaal behaalde % wordt bijgehouden via een auto-property. Via een methode PrintGraad kan de behaalde graad weergegeven worden. Dit zijn de mogelijkheden:

* < 50: niet geslaagd;
* tussen 50 en 68: voldoende;
* tussen 68 en 75: onderscheiding;
* tussen 75 en 85: grote onderscheiding;
* \> 85: grootste onderscheiding.


Test je klasse door enkele objecten in je main aan te maken en de verschillende properties waarden te geven en methoden aan te roepen.
Deze code zou moeten werken:

```java
Resultaat mijnpunten= new Resultaat();
mijnpunten.Percentage=65;
mijnpunten.PrintGraad();

```
## Nummers

Maak een klasse ``Nummers``. Deze klasse bevat 2 getallen (type int) die via een autoproperty kunnen aangepast worden. Er zijn 4 methoden:

* ``Som``: geeft de som van beide getallen terug
* ``Verschil``: geeft het verschil van beide getallen terug
* ``Product``: geeft het product van beide getallen terug
* ``Quotient``: geeft de deling van beide getallen terug. Toon "Error" indien je zou moeten delen door 0.

Toon in je main aan dat je code werkt.

Volgende code zou bijvoorbeeld onderstaande output moeten geven:

```java
    Nummers paar1 = new Nummers();
    paar1.Getal1 = 12;
    paar1.Getal2 = 34;

    Console.WriteLine("Paar:" + paar1.Getal1 + ", " + paar1.Getal2);
    Console.WriteLine("Som = " + paar1.Som());
    Console.WriteLine("Verschil = " + paar1.Verschil());
    Console.WriteLine("Product = " + paar1.Product());
    Console.WriteLine("Quotient = " + paar1.Quotient());
```

Output:

{line-numbers:false}
```text
Paar: 12, 34
Som = 46
Verschil = -22
Product = 408
Quotient = 0,352941176470588
```

## Studentklasse

Maak een nieuwe klasse ``Student``.


Deze klasse heeft 6 autoproperties:

* ``Naam`` (``string``)
* ``Leeftijd`` (``int``)
* ``Klas`` (maak dit van een ``enum``)
* ``PuntenCommunicatie`` (``int``)
* ``PuntenProgrammingPrinciples`` (``int``)
* ``PuntenWebTech`` (``int``)

Voeg aan de klasse een methode ``BerekenTotaalCijfer`` toe. Wanneer deze methode wordt aangeroepen dan wordt het gemiddelde van de 3 punten  teruggegeven als double zodat dit op het scherm kan getoond worden.

Voeg aan de klasse  ook de methode ``GeefOverzicht`` toe. Deze methode zal een volledig "Rapport" van de student tonen (inclusief het gemiddelde m.b.v. de BerekenTotaalCijfer-methode).

Test je programma door enkele studenten aan te maken en in te stellen. Volgende main zou dan de bijhorende output moeten krijgen:

```java
    Student student1= new Student();
    student1.Klas = Klassen.EA2;
    student1.Leeftijd = 21;
    student1.Naam = "Joske Vermeulen";
    student1.PuntenCommunicatie = 12;
    student1.PuntenProgrammingPrinciples = 15;
    student1.PuntenWebTech = 13;

    student1.GeefOverzicht();
```

Output:

{line-numbers:false}
```text
Joske Vermeulen, 21 jaar
Klas: EA2

Cijferrapport:
**********
Communicatie:             12
Programming Principles:   15
Web Technology:           13
Gemiddelde:               13.3
```

## PizzaTime
Maak een klasse Pizza. Deze klasse heeft een aantal private fields:

* ``toppings`` (``string``): bevat beschrijving van wat er op ligt, bv. ananas, peperoni, etc.
* ``diameter`` (``integer``): doorsnede van de pizza in cm.
* ``price`` (``double``): prijs van de pizza in euro.

Zorg ervoor dat je met behulp van full properties deze 3 velden kan uitlezen en aanpassen. Bouw controle in zodat de fields geen foute waarden kunnen gegeven worden (denk maar aan negatieve prijs en diameter, pizza zonder topping, etc.). Maak in je main een aantal pizza-instanties aan en toon de werking van de properties aan.

## Figuren

Maak een eenvoudige klasse ``Rechthoek`` aan die een lengte en breedte als private datafields heeft. Deze kunnen enkel via full properties ingesteld worden en nooit onder 1 gaan.

Maak ook een klasse ``Driehoek`` die een basis en hoogte als fields heeft.

Beide klassen hebben een methode ``ToonOppervlakte`` die de oppervlakte van de figuur in kwestie op het scherm toont.

Toon de werking van het project aan door een aantal instanties van ``Driehoek`` en ``Rechthoek`` te maken, met verschillende groottes. Roep van iedere figuur de ``ToonOppervlakte``-methode aan.

## Sports

### Sportspeler

Kies je favoriete sport of game. Maak een klasse aan die een speler uit deze sport kan voorstellen. Verzin een 4-tal private datavelden die deze spelers hebben, alsook 2 methoden die de speler moet kunnen uitvoeren. 

Voorzie een methode ``StelIn`` die je toelaat om de private datafields in te stellen:

Voorzie ook minstens 1 ``naam`` (``string``) dataveld.

Voorzie per data field ook telkens een full property. Waar nodig zorg je er voor dat er geen illegale waarden kunnen ingesteld worden (bv mutsnummer bij waterpolo gaat maar van 1 tot 13).

Bijvoorbeeld:

* klasse ``Waterpolospeler``
* datavelden:
  * ``spelerNaam``(``string``)
  * ``mutsnummer`` (``int``)
  * ``isDoelman`` (``bool``)
  * ``isReserve``(``bool``)
  * ``reeks`` (``string``, bv "Cadet")

Methoden: ``GooiBal``, ``Watertrappen``, ``StelIn``

De methode ``StelIn`` zou dan zou kunnen aangeroepen worden:

```java
speler1.StelIn("Tim", 5, false, true, "tweedeklas");
```

Wanneer de methoden worden aangeroepen zal er een tekst (mbv Console.WriteLine in de methode) op het scherm verschijnen die bv zegt ``Ik (Jos) gooi de bal``. Waarbij de naam van de speler in kwestie uit het Naam dataveld wordt gebruikt om mee getoond te worden.

Maak vervolgens een console-applicatie aan waarin je de werking van de klasse aantoont. Maar in de applicatie een aantal speler-objecten aan, vervolgens stel je hun properties in. Vervolgens roep je enkele methoden van de spelers aan en toon je via (Console.WriteLine) ook de properties van de individuele spelerobjecten.

Toon maw aan dat je:

* Een klasse kunt maken (in een aparte file!)
* Instanties (objecten) van deze klasse kunt maken
* Kunt werken met deze instanties (properties instellen én uitlezen, aanroepen van methoden)

{% hint style='tip' %}
### enums

Kan je in voorgaand voorbeeld het dataveld ``reeks`` vervangen door een dataveld reeks dat een enum als datatype heeft?
{% endhint %}



# Bibliotheek

Boeken in een bibliotheek mogen maximum 14 dagen uitgeleend worden. Schrijf een console-applicatie om de volgende gegevens te tonen door middel van een klasse ``BibBoek``:
* de naam van de ontlener, die werd ingelezen (autoproperty)
* de datum van vandaag (autoproperty met private set)
* de datum, dat het boek ten laatste terug moet ingeleverd worden (readonly property)



## BankManager

Ontwerp een klasse Account die minstens een ``naamveld``, ``balans`` en ``rekeningnummer`` bevat. Voorzie 3 methoden:

1. ``WithdrawFunds``: bepaalt bedrag wordt van de ``balans`` verwijderd
2. ``PayInFunds``: bepaalt bedrag (als parameter) wordt op de rekening gezet en aan ``balans`` toegevoegd
3. ``GetBalance``: het totale bedrag op de rekening wordt teruggegeven, m.a.w. ``balans`` wordt teruggegeven

Pas de ``WithdrawFunds`` methode aan zodat als returntype het bedrag (int) wordt teruggegeven. Indien het gevraagde bedrag meer dan de balans is dan geef je al het geld terug dat nog op de rekening staat en toon je in de console dat niet al het geld kon worden gegeven.

Maak 2 instanties van het type ``Account`` aan en toon aan dat je geld van de ene account aan de andere kunt geven, als volgt:

```java
BankAccount rekening1=new BankAccount();
BankAccount rekening2=new BankAccount();
```

Voeg aan de ``Account``-klasse een private field toe zijnde van het type ``accountState`` dat een enumeratie bevat. De account kan in volgende states zijn "Geldig", "Geblokkeerd"). 
Maak een bijhorende publieke Methode  waarmee je de account van state kunt veranderen. Deze methode (noem ze ChangeState) vereist één parameter van het type ``accountState`` natuurlijk.

Indien een persoon geld van of naar een Geblokkeerde rekening wil sturen dan zal er een error op het scherm verschijnen.

Test je klasse.

1. Nieuwe klant aanmaken (max 10) 
2. Status van bestaande klant tonen 
3. Geld op een bepaald account zetten 
4. Geld van een bepaald account afhalen
5. Geld tussen 2 accounts overschrijven

Voorzie extra functionaliteit naar keuze.

## OO Textbased game (PRO)

Bij de all-in-one projecten van dit semester vind je als eerst een tekstgebaseerde game ([hier](../A_DEEL2_AllInOne/2_OOTextGame.md)). Volg deze uitleg, maak het spel en voeg je eigen zotte ideeën toe.

# Persoon

Ontwerp en implementeer een klasse Persoon met 2 velden voornaam en achternaam. Voorzie hiervoor automatische properties. Voeg bovendien een property GeboorteDatum toe. De geboortedatum moet tussen 1/1/1990 en vandaag liggen. Indien dit niet de situatie is, wordt de huidige datum gebruikt. Definieer vervolgens een methode Leeftijd, die op grond van de geboortedatum en de systeemdatum de leeftijd van de persoon levert. Voorzie de nodige testcode.

# Dobbelstenen	

Ontwerp en implementeer een klasse PaarDobbelstenen, bestaande uit 2 dobbelstenen (elk met 6 oppervlakken). Creëer een klasse met een Main methode, waarin 1000 keer met een paar dobbelstenen wordt gegooid. Bereken hoeveel keer een dubbel zes voorkomt.
