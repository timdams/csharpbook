# Introductie/Context

Oh jeetje, de wereld draait nu helemaal door. Jouw firma werd zonet gevraagd om een online casino te ontwerpen met als doelgroep babies. Voor ze je de effectieve site laten maken willen ze eerst een simulatie zien in console. Aan jou de eer om deze om deze dubieuze opdracht tot een goed einde te brengen.

# Algemeen

De speler wordt telkens gevraagd welk van de 3 spellen hij wenst te spelen. Hij kan ten allen tijde stoppen en krijgt dan te zien hoeveel het verlies of de winst is.

De applicatie is modulair opgebouwd door middel van methoden.

Opgelet, bekijk zeker de puntenverdeling om te bepalen wat je eerst doet:
Je kan deze opgave in willekeurige volgorde oplossen, daar alle delen modulair en onafhankelijk van mekaar zijn:

* Opstarten casino: 3 punten
* Spel Raadhetgetal: 4 punten
* Spel Rekenenmaar: 3 punten
* Spel ArrayGame: 5 punten
* Afsluiten casino: 1 punt

# Opstarten casino (3 punten)

## Methode SetupCasino

Maak een methode SetupCasino:

* Returntype bool
* Parameters:
  * Naam (tekst)
  * Lengte scherm (geheel getal) [optioneel, standaard= 80]
  * Breedte scherm [optioneel, standaard= 60]
* Werking
  * De methode geeft false terug indien de lengte of breedte kleiner is dan 1
  * Anders geeft de methode true terug en doet het volgende:
    * Het stelt het console scherm in (Width en Height) op de hoogte die via de parameters werd gegeven
    * Het vult de hele bovenste lijn van het scherm met sterretjes
    * Op de tweede lijn komt de begroeting Welkom bij Casino AP [X]
      * [X] vervang je door de Naam die als parameter werd meegegeven
    * Het vult de derde lijn van de console ook met sterretjes
* Voorbeeld output:

<!---{line-numbers:false}--->
```text
*******************************************************
Welkom bij Casino AP tim
*******************************************************
```

### Gebruik SetupCasino

Roep de methode aan vanuit de main met een naam, lengte en breedte naar keuze.
Enkel indien de methode true geeft zal het programma verder gaan, anders sluit het programma zich hier af.

# Methode CasinoLoop (0 punten)
Maak een methode Casinoloop die niets teruggeeft en geen parameters nodig heeft.

Indien de CasinoSetup is gelukt dan zal deze loop gestart worden.

Deze loop heeft volgende code:

```java
   int keuze = 0;
   int geld = 0;
   while (keuze != -1)
   {
       Console.Clear();
       Console.WriteLine($"Je hebt {geld} euro.");
       keuze = ToonMenu();
       Console.Clear();
       switch (keuze)
       {
           case 1:
               geld += RaadHetGetal();
               break;
           case 2:
               geld += RekenenMaar();
               break;
           case 3:
               geld += ArrayGame();
               break;
           default:
               ShowEnding(geld);
			 keuze=-1;
               break;

       }
       Console.WriteLine("Druk toets om verder te gaan");
       Console.ReadKey();
   }

```

**De methoden in het vet zal je nu zelf moeten schrijven zoals beschreven in de volgende secties.**

# ToonMenu()  (0 punten)

Bevat volgende code:
```java
int keuze = 0;

do
{
    Console.WriteLine("Geef keuze");
    Console.WriteLine("\t1. Raad het getal");
    Console.WriteLine("\t2. Rekenen maar");
    Console.WriteLine("\t3. Raad de sequentie");
    Console.WriteLine("*****");
    Console.WriteLine("-1 is stoppen");
    keuze = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
} while (keuze != 1 && keuze != 2 && keuze != -1 && keuze !=3);

return keuze;
```

# Spel Methoden (RaadHetGetal, RekenenMaar en ArrayGame)

Deze 3 methoden bevatten telkens 1 spel. Als het spel gedaan is geeft de methode telkens terug hoeveel winst (of negatieve winst) de speler heeft gemaakt.

## RaadHetGetal (4 punten)

### Beschrijving spel
De speler moet raden welk getal tussen 0 en 10 de computer in gedachte heeft.  Voor hij dit doet moet hij eerst ingeven hoe vaak hij denkt te moeten raden.

### De winst die de methode teruggeeft is als volgt:

* Indien de gebruiker exact wist hoevaak hij moest raden voor hij het getal zou vinden, dan krijgt hij **+50**.
* Indien het aantal keer raden maximum 2 verwijderd is van hoe vaak hij dacht nodig te hebben, dan krijgt hij **+5**. 
  * Stel dat hij aan de start 5 ingaf als aantal pogingen, dan zal hij 5 euro krijgen indien hij het uiteindelijk effectief in 3,4,6  of 7 pogingen het heeft geraden (en uiteraard 50 indien hij het in 5 keer raadde)
* In alle andere gevallen is de winst **-5**.

### Voorbeeld spelverloop 

<!---{line-numbers:false}--->
```text
Welkom bij raad het getal!
Je moet een getal van 1 tot 10 raden. Hoe veel keer denk je nodig te hebben?
4   <= ingevoerd door gebruiker
Hier gaan we dan.
Welk getal is het (aantalpogingen is 0)?
1   <= ingevoerd door gebruiker
Neen, dat is het niet. Probeer opnieuw
Welk getal is het (aantalpogingen is 1)?
2   <= ingevoerd door gebruiker
Neen, dat is het niet. Probeer opnieuw
Welk getal is het (aantalpogingen is 2)?
3   <= ingevoerd door gebruiker
Jeuj. Je hebt het geraden!
Je zat er minder dan 3 af van het aantal keer dat je ging raden. Je verdient 5 euro.
```

## RekenenMaar (3 punten)

### Beschrijving spel

De speler krijgt 5 vermenigvuldigen voorgeschoteld die hij moet uitrekenen. Deze zijn steeds tussen 1 x 1 en 10 x 10 .

### De winst die de methode teruggeeft is als volgt

* Per juiste: +5
* Per foute: -5

### Voorbeeld spelverloop 

<!---{line-numbers:false}--->
```text
Je krijgt nu 5 reken oefeningen. Per juiste krijg je 5 euro. Per foute verlies je 5 euro.
Hoeveel is 4x9?
36  <= ingevoerd door gebruiker
Mooi zo! Je winst verhoogt.
Hoeveel is 6x4?
20  <= ingevoerd door gebruiker
Dat is fout. Je winst verlaagt
Hoeveel is 7x7?
49  <= ingevoerd door gebruiker
Mooi zo! Je winst verhoogt.
Hoeveel is 8x1?
8   <= ingevoerd door gebruiker
Mooi zo! Je winst verhoogt.
Hoeveel is 9x1?
10  <= ingevoerd door gebruiker
Dat is fout. Je winst verlaagt
Je totale winst dit spel is 5
Druk toets om verder te gaan
```

## ArrayGame (5 punten)

### Beschrijving spel
Bij de start van deze methode wordt een array van bool, met lengte 10, gevuld met willekeurige true en false waarden.

De gebruiker moet proberen zo ver mogelijk door de array te geraken door te raden of de volgende waarde in de array true of false is. Van zodra de speler fout gokt stopt dit spel.

Hoe verder de speler geraakt, hoe meer winst (er kan geen verlies gemaakt worden).
Er wordt op het einde ook getoond wat de volledige sequentie was

### De winst die de methode teruggeeft is als volgt:
 
* Alle 10 juist:** +100 winst**
* In alle andere gevallen: +(5* het aantal juist geraden)

### Voorbeeld spelverloop 

Hoe lang kan jij de sequentie raden?Geef 0 (false) of 1 (true) in.
Komt er juist of fout? (1 of 0)
1   <= ingevoerd door gebruiker
Goed zo!
Komt er juist of fout? (1 of 0)
1   <= ingevoerd door gebruiker
Goed zo!
Komt er juist of fout? (1 of 0)
0   <= ingevoerd door gebruiker
Fout
Je behaalde een sequentie van 2 juiste gokken. Dat is 10 euro waard.
De correcte sequentie was:
True,True,True,True,True,True,True,False,True,False,
```