# Klassen objecten introductie

## Alledaags

Zoek een foto naar keuze (nieuws, privé, etc) waarop meer dan één element opstaat (dus geen pasfoto of foto van blauwe lucht zonder wolken). Tracht de nodige klassen te verzinnen en verzin minstens 1 auto-property en 1 methode per klasse.  Maak in een console-applicatie vervolgens objecten van deze klassen aan en test ze. Voeg de foto aan je solution-folder toe.

Bijvoorbeeld: een foto van een betoging. Je zou minstens 3 klassen kunnen verzinnen (gebouw, politie, betoger). Van ieder van deze klassen maak je dan objecten aan zoals je ze op de foto ziet (uiteraard gaan we geen 30 betoger-instanties maken, enkele zijn genoeg, als voorbeeld).

## RapportModule

Ontwerp een klasse Resultaat die je zal tonen wat je graad is gegeven een bepaald behaald percentage. Het enige dat je aan een Resultaat-object moet kunnen geven is het behaalde percentage. Enkel het totaal behaalde % wordt bijgehouden via een auto-property. Via een methode PrintGraad kan de behaalde graad worden weergegeven. Dit zijn de mogelijkheden:

* < 50: niet geslaagd;
* tussen 50 en 68: voldoende;
* tussen 68 en 75: onderscheiding;
* tussen 75 en 85: grote onderscheiding;
* \> 85: grootste onderscheiding.


Test je klasse door enkele objecten in je main aan te maken en de verschillende properties waarden te geven en methoden aan te roepen.

## Nummers

Maak een eenvoudige klasse Nummers. Deze klasse bevat 2 getallen (type int) die via een autoproperty kunnen aangepast worden. Er zijn 4 methoden:

* ``Som``: geeft som van beide getallen weer
* ``Verschil``: geeft verschil van beide getallen weer
* ``Product``: geeft product van beide getallen weer
* ``Quotient``: geeft deling van beide getallen weer. Toon "Error" indien je zou moeten delen door 0.

Toon in je main aan dat je code werkt.

Volgende code zou namelijk onderstaande output moeten geven:

```csharp
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

```text
Paar: 12, 34
Som = 46
Verschil = -22
Product = 408
Quotient = 0,352941176470588
```

## Figuren

Maak een eenvoudige klasse Rechthoek aan die een lengte en breedte als private datafields heeft. Deze kunnen enkel via full properties ingesteld worden en nooit onder 1 gaan.

Maak ook een klasse Driehoek die een basis en hoogte als fields heeft.

Beide klassen hebben een methode ``ToonOppervlakte`` die de oppervlakte van de figuur in kwestie op het scherm toont.

Toon de werking van het project aan door een aantal instanties van Driehoek en Rechthoek te maken, met verschillende groottes. Roep van iedere figuur de ToonOppervlakte-methode aan.

## PizzaTime
Maak een klasse Pizza. Deze klasse heeft een aantal private fields:

* toppings (string): bevat beschrijving van wat er op ligt, bv. ananas, pepperoni, etc.
* diameter (integer): doorsnede van de pizza in cm.
* price (double): prijs van de pizza in euro.

Zorg ervoor dat je met behulp van properties deze 3 velden kan uitlezen en aanpassen. Bouw controle in zodat de fields geen foute waarden kunnen gegeven worden (denk maar aan negatieve prijs en diameter, pizza zonder topping, etc.). Maak in je main een aantal pizza-instanties aan en toon de werking van de properties aan.

## Studentklasse

Maak een nieuwe klasse ``Student``.
Deze klasse heeft 6 properties:

* Naam (string)
* Leeftijd (int)
* Klas (maak dit van een ``enum``)
* PuntenCommunicatie (int)
* PuntenProgrammingPrinciples (int)
* PuntenWebTech (int)

Voeg aan de klasse een methode ``BerekenTotaalCijfer`` toe. Wanneer deze methode wordt aangeroepen dan wordt het gemiddelde van de 3 punten  teruggegeven als double zodat dit op het scherm kan getoond worden.

Voeg aan de klasse  ook de methode ``GeefOverzicht`` toe. Deze methode zal een volledig "Rapport" van de student tonen (inclusief het gemiddelde m.b.v. de BerekenTotaalCijfer-methode).

Test je programma door enkele studenten aan te maken en in te stellen. Volgende main zou dan de bijhorende output moeten krijgen:

```csharp
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

## Sports

### Sportspeler

Kies je favoriete sport of game (voor zij die enkel pc/console-sporten ). Maak een klasse aan die een speler uit deze sport kan voorstellen. Verzin een 4-tal private datavelden die deze spelers hebben, alsook 2 methoden die de speler moet kunnen uitvoeren. 

Voorzie een methode ``StelIn`` die je toelaat om de private datafields in te stellen:

Voorzie ook minstens 1 "Naam" (string) dataveld.

Voorzie per data field ook telkens een full property. Waar nodig zorg je er voor dat er geen illegale waarden kunnen ingesteld worden (bv mutsnummer bij waterpolo gaat maar van 1 tot 13).

Bijvoorbeeld:

* klasse Waterpolospeler
* datavelden:
  * spelerNaam(string)
  * mutsnummer (int)
  * isDoelman (bool)
  * isReserve(bool)
  * reeks (string, bv "Cadet")

Methoden: GooiBal, Watertrappen, StelIn

De methode ``StelIn`` zou dan zou kunnen aangeroepen worden:

```csharp
speler1.StelIn("Tim", 5, false, true, "tweedeklas");
```

Wanneer de methoden worden aangeroepen zal er een tekst (mbv Console.WriteLine in de methode) op het scherm verschijnen die bv zegt ``Ik (Jos) gooi de bal``. Waarbij de naam van de speler in kwestie uit het Naam dataveld wordt gebruikt om mee getoond te worden.

Maak vervolgens een console-applicatie aan waarin je de werking van de klasse aantoont. Maar in de applicatie een aantal speler-objecten aan, vervolgens stel je hun properties in. Vervolgens roep je enkele methoden van de spelers aan en toon je via (Console.WriteLine) ook de properties van de individuele spelerobjecten.

Toon maw aan dat je:

* Een klasse kunt maken (in een aparte file!)
* Instanties (objecten) van deze klasse kunt maken
* Kunt werken met deze instanties (properties instellen én uitlezen, aanroepen van methoden)

### Sport simulator

Schrijf een methode genaamd:
``static void SimuleerSpeler(Waterpolospeler testspeler)``

(vervang Waterpolospeler door de klasse die je zelf hebt gemaakt)

De SimuleerSpeler-methode zal beide methoden van je klasse telkens 3x aanroepen m.b.v. een for-loop in de methode (dus in mijn geval 3x GooiBal en 3xWatertrappen)

Test je methode door 2 objecten aan te maken en telkens mee te geven als parameter.

### Pro enums

Kan je in voorgaand voorbeeld het dataveld ``reeks`` vervangen door een dataveld reeks dat een enum als datatype heeft?


## BankManager

Ontwerp een klasse Account die minstens een Naamveld, bedrag en rekeningnummer bevat. Voorzie 3 methoden:

1. WithdrawFunds: bepaald bedrag wordt van rekening verwijderd
2. PayInFunds: bepaald bedrag (als parameter) wordt op de rekening gezet
3. GetBalance: het totale bedrag op de rekening wordt teruggegeven

Pas de WithdrawFunds methode aan zodat als returntype het bedrag (int) wordt teruggegeven. Indien het gevraagde bedrag meer dan de balance is dan geef je al het geld terug dat nog op de rekening staat en toon je in de console dat niet al het geld kon worden gegeven.

Maak 2 instanties van het type Account aan en toon aan dat je geld van de ene account aan de andere kunt geven, als volgt:

```csharp
BankAccount rekening1=new BankAccount();
BankAccount rekening2=new BankAccount();
```

Voeg aan de Account-klasse een private field toe zijnde van het type accountState dat een enumeratie bevat. De account kan in volgende states zijn "Geldig", "Geblokkeerd"). 
Maak een bijhorende publieke Methode  waarmee je de account van state kunt veranderen. Deze methode (noem ze ChangeState) vereist één parameter van het type accountState natuurlijk.

Indien een persoon geld van of naar een Geblokkeerde rekening wil sturen dan zal er een error op het scherm verschijnen.
Maak een array aan van 10 klanten. Wanneer je met klassen werkt moet je bij de initialisatie van de array ook ieder element afzonderlijk initialiseren, als volgt:

```csharp
BankAccount[] lijst = new BankAccount[10];
//Init
for(int i=O; i<lijst.Length;i++)
{ 
 lijst[i]= new BankAccount();
}
```

Schrijf nu een BankManager systeem. Voorzie  een console- menu waarbij de gebruiker volgende zaken kan doen:

1. Nieuwe klant aanmaken (max 10) 
2. Status van bestaande klant tonen 
3. Geld op  bepaalde account zetten 
4. Geld van bepaalde account afhalen 
5. Geld tussen 2 accounts overschrijven.
6. Een totaaloverzicht van alle accounts tonen (Allerlei statistieken zoals de totale som op alle rekeningen samen, rijkste account, etc worden in een tabel getoond)

Voorzie extra functionaliteit naar keuze.