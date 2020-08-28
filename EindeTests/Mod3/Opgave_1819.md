> **Opgelet** : In deze opgave komen geen arrays (H11) van objecten voor. Dit is echter ook leerstof en zal in de toekomst ZEKER WEL in de tussentijdse vaardigheidstoetsen voorkomen.

# Goal

Een goed mentale gezondheid – quality of life (Qal) - is even belangrijk als je fysieke gezondheid.
De firma "GetWeller" heeft je gevraagd om een prototype te maken van een QualityOfLife-diary app, waarin de gebruiker kan bijhouden hoe het met z’n mentale gezondheid is gesteld.

Je dient dit prototype in een C# console applicatie te maken zodat GetWeller kan zien of ze jouw firma willen inhuren om de volledige mobiele applicatie nadien te ontwikkelen.

Succes!

 
# Werking
De applicatie zal bestaan uit enkele fasen:

1. Eerst zal worden gevraagd van hoeveel dagen (DagboekEntry’s) de gebruiker een dagboek-input wilt schrijven.
2. Vervolgens wordt een samenvatting van het ingevoerde dagboek getoond
3. Finaal berekent een analyse-module hoe de Qal van de gebruiker is gebaseerd op het ingevoerde dagboek

# Klassen
De applicatie steunt op 2 belangrijke klassen:

* ``DagboekEntry``: deze bewaard telkens 1 dag van de gebruiker in het dagboek
* ``QalAnalyzer``: deze bevat een aantal hulpmethoden om de verzameling DagboekEntry’s te gebruiken.

**OPGELET 1:** niet alle zaken die je in de klasse zult zetten zal je mogelijk nodig hebben in de applicatie die je er rond gaat maken.

**OPGELET 2:** De hoofdmoot gebeurt in de QalAnalyzer methode ``CreateDiary``. Lees dus zeker eerst de hele opgave.  Indien je ``CreateDiary`` , en de andere methoden in ``QalAnalyzer``, niet in de klasse krijgt, raad ik je aan deze in je hoofdprogramma te plaatsen (voor minder punten weliswaar) zodat je voort kunt.

 
 
## Klasse DagboekEntry  (7 punten)

Een ``DagboekEntry`` stelt 1 dag voor die de gebruiker in z’n dagboek heeft gezet. Een DagboekEntry bestaat uit volgende zaken:

### Properties (40%)

* Autoproperty ``IsInspired`` (bool) die bijhoudt hoe geïnspireerd de gebruiker die dag was
* Property met private setter ``IsPrivate`` (bool) die aangeeft of deze entry als privé moet beschouwd worden
* Fullproperty ``Description`` (string) die een beschrijving bevat van hoe de gebruiker zich voelde die dag:
   * Bij Get zal enkel de description worden teruggegeven als IsPrivate niet true is. Indien het wel om een privé entry gaat dan wordt de tekst ***PRIVATE*** teruggegeven.
* Fullproperty ``Qal`` (int) deze kan enkel waarden tussen 0 en 100 krijgen. 
  *Indien de gebruiker een getal kleiner dan 0 instelt dan wordt de Qal op 0 ingesteld.
  *Indien de gebruiker een getal groter dan 100 instelt dan wordt de Qal op 100 gezet.

### Methoden (35%)

* MakePrivate: De enige manier om van buitenuit de IsPrivate van een DagboekEntry object aan te passen. De methode aanvaardt een bool die aangeeft of het object privaat moet gezet worden en geeft niets terug.
* ResetEntry: deze methode vereist geen parameters en geeft niets terug.
  * Zet ``IsInspired`` op false, de ``Qal`` op 50 en de ``description`` leeg
* ``ShowInfo``: deze methode vereist geen parameters en geeft niets terug.
  * Output het object naar het scherm als volgt (tekst tussen vierkante haakjes wordt vervangen door de effectieve waarden:

<!---{line-numbers:false}--->
```text
********
ENTRY:
[description]
Qal= [Qal]
*********
```

 **Opgelet**: indien het object privé is dan zal dus bij description de tekst ``***PRIVATE***`` verschijnen

### Constructors (25%)

De klasse kan op 2 manieren aangemaakt worden:

* Via een default constructor die de ResetEntry methode gebruikt 
* Via een overloaded constructor die de Qal, IsInspired, IsPrivate en Description als parameters aanvaardt


## QalAnalyzer (7 punten)

Deze klasse bevat enkel static methoden, namelijk:

* ``SummarizeDiary`` (15%): 
  * Aanvaardt een array (of lijst) van DagboekEntry’s . Geeft niets terug.
  * Zal alle ``ShowInfo``-methoden van iedere entry aanroepen zodat het volledige dagboek op het scherm komt
* ``AnalyseDiary`` (25%):
  * Aanvaardt een array (of lijst) van DagboekEntry’s. Geeft niets terug. 
  * Zal het gemiddelde IsInspired tonen wat de totale Qal is, rekeningen houdend met de privacy:
    * De totale Qal bevat de som van alle Qal’s in de DagboekEntry’s OP VOORWAARDE dat deze niét privé is (de privé Qals worden overgeslagen en niét meegerekend)
    * Het gemiddelde  IsInspired is de som van alle DagboekEntry’s waar de IsInspired true was, ongeacht of deze privé was of niet, gedeeld door het totaal aantal elementen in de array.
  * De methode toont vervolgens deze twee getalen (totale niet privé Qal, gemiddelde IsInspired)
* ``CreateDiary`` (60%) :
  * Aanvaardt geen parameters. Geeft een array (of lijst) van DagboekEntry’s terug.
  * Zal aan de gebruiker enkele vragen stellen en het ‘dagboek’ maken.
  * De werking van deze methode leggen we in volgende sectie uit.
  * Een dagboek is een array of lijst van DagboekEntry-objecten

### Werking CreateDiary-methode

#### Stap 0:

Er verschijnt een welkomstzin: Rise and shine. Gevolgd door de huidige tijd in uren en minuten:

<!---{line-numbers:false}--->
```text
Rise and shine
Het is nu 15:25
```

#### Stap 1:

Vraag aan de gebruiker hoeveel dagen de gebruiker wilt loggen. De gebruiker voert een getal in (geen foutcontrole vereist):

* Er zal een lijst of array van dagboek entries gevuld worden met het aantal dagen dat de gebruiker wilt invoeren.
* Deze lijst zal op het einde van de methode als resultaat terug gegeven worden

#### Stap 2a:

Je toont nu telkens aan de gebruiker om de hoeveelste dag het gaat (starten van 1 ) en welke dag dat ook effectief is. Als het programma wordt uitgevoerd op zondag, dan zal er dus verschijnen:

<!---{line-numbers:false}--->
```text
Dag 1: Maandag
[info uit stap 2b]
Dag 2: Dinsdag
[info uit stap 2b]
…
```

Opmerking: de dagen mogen in het Engels verschijnen als jouw OS in die taal werd ingesteld.

#### Stap 2b:

De gebruiker dient nu steeds in te geven hoe hij zich voelde (description), of hij geïnspireerd was (IsInspired), de Qal score die dag (Qal) en of het om een private entry gaat.
Deze informatie wordt steeds in een DagboekEntry geplaatst en aan de array toegevoegd.

**Deel uitvoer/invoer van de methode**

<!---{line-numbers:false}--->
```text
Rise and shine
Het is nu 15:25
Hoeveel dagen wil je loggen in je dagboek?
3 //userinput
Dag 1: Monday
Hoe was je dag?
Zeer goed //userinput
Voelde je je geïnspireerd?(y/n)
y //userinput
Welke score geef je deze dag?
60 //userinput
Is dit een private entry?(y/n)
n //userinput
Dag 2: Tuesday
Hoe was je dag?
…
```

## Hoofdprogramma (2 punt)

Het hoofdprogramma is zeer eenvoudig. Het gebruikt de ``QalAnalyzer`` methoden om volgende werking te hebben:

* Eerst wordt een dagboek aangemaakt met behulp van de ``CreateDiary`` methode.
* Dan wordt het dagboek meegegeven aan de ``SummarizeDiary`` methode.
* Vervolgens wordt het dagboek aan de ``AnalyseDiary`` methode

## CSV wegschrijven (4 punten)

Finaal wordt in het hoofdprogramma gevraagd of het huidige dagboek (de array/list) naar een csv bestand mag worden geschreven.

Indien de gebruiker ja antwoordt dan wordt gevraagd naar de naam die het bestand moet hebben.

Ieder DagboekEntry object wordt 1 lijn, met de verschillende properties met een ; gescheiden.
