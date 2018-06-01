# Klassen
## Methoden in klassen

### Nummers
Maak een eenvoudige klasse Nummers. Deze klasse bevat 2 getallen (type int). Er zijn 4 methoden:
* ``Som``: geeft som van beide getallen weer
* ``Verschil``: geeft verschil van beide getallen weer
* ``Product``: geeft product van beide getallen weer
* ``Quotient``: geeft deling van beide getallen door. Toon "Error" indien je zou moeten delen door 0. 

Toon in je main aan dat je code werkt.

Volgende code zou namelijk onderstaande output moeten geven:
```csharp
    Nummers paar1 = new Nummers();
    paar1.getal1 = 12;
    paar1.getal2 = 34;

    Console.WriteLine("Paar:" + paar1.getal1 + ", " + paar1.getal2);
    Console.WriteLine("Som = " + paar1.Som());
    Console.WriteLine("Verschil = " + paar1.Verschil());
    Console.WriteLine("Product = " + paar1.Product());
    Console.WriteLine("Quotient = " + paar1.Quotient());
```

Output:
```
Paar: 12, 34
Som = 46
Verschil = -22
Product = 408
Quotient = 0,352941176470588
```

### Figuren
Maak een eenvoudige klasse Rechthoek aan die een lengte en breedte als public fields heeft. 
Maak ook een klasse Driehoek die een basis en hoogte als fields heeft.

Beide klassen hebben een methode ``ToonOppervlakte`` die de oppervlakte van de figuur in kwestie op het scherm toont.

Toon de werking van het project aan door een aantal instanties van Driehoek en Rechthoek te maken, met verschillende groottes. Roep van iedere figuur de ToonOppervlakte-methode aan.

### Studentklasse
Maak ee nieuwe klasse ``Student`` toe
Deze klasse heeft 6 public fields:
* Naam (string)
* Leeftijd (int)
* Klas (maak dit van een ``enum``)
* PuntenCommunicatie (int)
* PuntenProgrammingPrinciples (int)
* PuntenWebTech (int)	 
Daar deze fields allemaal public zijn kunnen we deze dus rechtstreeks veranderen.

Voeg aan de klasse een methode ``BerekenTotaalCijfer`` toe. Wanneer deze methode wordt aangeroepen dan wordt het gemiddelde van de 3 punten  teruggegeven als double zodat dit op het scherm kan getoond worden.

Voeg aan de klasse  ook de methode ``GeefOverzicht`` toe. Deze methode zal een volledig "Rapport" van de student tonen (inclusief het gemiddelde m.b.v. de BerekenTotaalCijfer-methode).

Test je programma door enkele studenten aan te maken en in te stellen. Volgende main zou dan de bijhorende output moeten krijgen:
```csharp
    Student student1;
    student1.Klas = Klassen.EA2;
    student1.Leeftijd = 21;
    student1.Naam = "Joske Vermeulen";
    student1.PuntenCommunicatie = 12;
    student1.PuntenProgrammingPrinciples = 15;
    student1.PuntenWebTech = 13;

    student1.GeefOverzicht();
```
Output:
```csharp
Joske Vermeulen, 21 jaar
Klas: EA2

Cijferrapport:
**********
Communicatie:             12
Programming Principles:   15
Web Technology:           13
Gemiddelde:               13.3
```
#### Student Organizer

We gaan nu de Student-klasse gebruiken om een array van studenten te vullen.

Maak daarom een studenten-array aan die 5 studenten bevat :
```csharp
Student[] alleStudenten= new Student[5];
for(int i =0 ;  i<5;++)
    alleStudenten[i]= new Student();
```
Initialiseer alle fields van iedere student op een standaard-waarde (mbv een for-loop), bv:
 
Het programma start op en geeft de gebruiker een menu waaruit kan gekozen worden:

1. Student gegevens invoeren (eerstvolgende student wordt ingevuld)
Vervolgens moet de gebruiker kiezen welke student (nummer) moet ingevuld worden, van 1 tot 5. Vervolgens kan de gebruiker de gegevens 1 voor 1 invullen (oude gegevens worden zonder pardon overschreven).

 
2. Student gegevens tonen (alle studenten)
Wanneer de gebruiker voor 2 kiest dan wordt de GeefOverzicht-methode aangeroepen van iedere student zodat de 5 ‘rapportjes’ onder mekaar op het scherm 

Extra's:
Bouw extra functionaliteit naar keuze bij de StudentOrganizer, zoals: 
* Vragen aan de gebruiker of de oude gegevens overschreven mogen worden, indien deze reeds ingevuld zijn.
* Inbouwen van een eenvoudige zoekfunctie. Je kan bijvoorbeeld zoeken op naam (exacte invoer) of alle studenten tonen die in een bepaalde klas zitten of wiens punten onder/boven een bepaalde waarde zitten. Je kan dit als extra menuitem inbouwen, waarbij een nieuw menu verschijnt dat de gebruiker de verschillende zoekmogelijkheden voorstelt.
* Verwijderen van een student (waarbij alle gegevens worden gewist)
* Controle in alle methode inbouwen zodat ‘lege studenten’ worden genegeerd. Wanneer bijvoorbeeld menu item 2 wordt uitgevoerd (alle studenten tonen) dan worden enkel de ingevulde studenten getoond.

## Properties in klassen

### PizzaTime
Maak een klasse Pizza. Deze klasse heeft een aantal private fields:
* toppings (string): bevat beschrijving van wat er op ligt, bv. ananas, pepperoni, etc.
* diameter (integer): doorsnede van de pizza in cm
* price (double): prijs van de pizza in euro.
Zorg ervoor dat je met behulp van properties deze 3 velden kan uitlezen en aanpassen. Bouw controle in zodat de fields geen foute waarden kunnen gegeven worden (denk maar aan negatieve prijs en diameter, pizza zonder topping, etc.). Maak in je main een aantal pizza-instanties aan en toon de werking van de properties aan.

### Student Organizer Deluxe
Herschrijf de [Student-klasse](../6_klassen_en_objecten/A_practica.md#studentklasse) en zorg ervoor dat iedere public field private is. Vervolgens maak je bijhorende public properties aan die toegang tot deze private fields verzorgen. Controleer in de properties op illegale input zodat bijvoorbeeld geen  de punten enkel getallen tussen 0 en 20 mogen zijn.

Herschrijf de studentmanager zodat deze werkt met deze nieuwe klasse .

### BankManager

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
 
Voeg aan de Account-klasse een private field toe zijnde van het type accountState dat een enumeratie bevat. De account kan in volgende states zijn “Geldig”, “Geblokkeerd”). 
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

## Constructors en operator overloading in klassen

### APCenture-Job Agency
#### Deel 1: constructors
Maak een klasse ``Job``. Deze klasse heeft vier data fields:
* Description (string) bijvoorbeeld “ruiten wassen”
* Duration (int) , stelt tijd voor die nodig is om job uit te voeren
* RatePerHour (int), stelt kostprijs per uur voor van deze job
* TotalFee (int), stelt totale prijs voor zijnde  duration x rateperhour
Voorzie properties voor deze 4 velden, echter de TotalFee heeft geen ‘set’  daar deze een berekening van andere properties is. 
Telkens de Duration of RatePerHour wordt aangepast (set) wordt de TotalFee herberekend (je zal dus een private totalFee nodig hebben waar de public property TotalFee z’n waarde van krijgt).

Voorzie 2 constructors:
* Default constructor: stelt de description in op “onbekend” en zet duration en rateperhour in op 0.
* Overloaded constructor: waarbij je de 3 velden (behalve TotalFee) kan aanpassen tijdens de constructie van een Job-object

Toon de werking van je klasse aan door enkele objecten aan te maken met zowel de default als de overloaded constructor. Toon vervolgens dat TotalFee correct werkt.

#### Deel 2: Operator Overloading
Pas de klasse ‘Job’ aan zodat de + operator kan gebruikt worden om 2 job-objecten bij mekaar op te tellen.
Bv:
```csharp
Job epicDuoJob= jobOne+jobTwo;  //jobOne en jobTwo zijn ook van het type Job
```
De som van 2 job-objecten gaat als volgt te werk:
* Description: beide description worden na mekaar geplakt, waarbij het voegwoord ‘en’ tussen beide wordt gezet.
* Duration: som van beide durations
* RatePerHour: gemiddelde de ``rateperhour``van beide objecten
Toon in je main aan dat je nieuwe klasse werkt en dat je 2 jobs kan samenvoegen. Toon ook aan dat je vervolgens deze nieuwe samenvoeging op zijn beurt kan samenvoegen met een andere job (of zelfs met een andere samengevoegde job!).

### Breuk
Maak een klasse ‘Breuk’ dat dus een breuk zal voorstellen met een noemer en teller.

Voorzie properties voor noemer en teller, waarbij de noemer niet 0 mag zijn (zet deze op 1 indien de gebruiker dit toch probeert).

Voeg 2 constructors toe:

* Default constructor: de breuk wordt ingesteld op 0/1
* Overloaded constructor: zowel de noemer als teller worden als parameter meegegeven

Voorts:
1. Voeg een + operator toe die het mogelijk maakt om 2 breuken bij mekaar op te tellen. Wanneer de +operatie is toegepast wordt ook automatisch de Vereenvoudig-methode aangeroepen (zie verder) voor het resultaat wordt teruggegeven. Belangrijk: je dient aan operator overloading te doen. We willen dus dat je bijvoorbeeld kan schrijven Breuk breuksom= breuk1 + breuk2;
2. Voeg voorts een * operator toe die breuken vermenigvuldigen mogelijk maakt (ook hier wordt het resultaat vereenvoudigd teruggegeven).
3. Voeg een methode ‘AlsString’ toe die de breuk als string teruggeeft, waarbij de breuklijn als slash wordt voorgesteld.

 
Maak een array van 4 breuken in je main en laat de gebruiker deze alle 4 invullen. Toon vervolgens de som en vermenigvuldiging van deze 4 breuken als strings op het scherm.

Pro: Voeg een methode ‘Vereenvoudig’ toe. Deze zal de breuk vereenvoudigen indien mogelijk. Als dus de breuk op 2/4 staat dan wordt deze na het uitvoeren van deze methode 1/2.
