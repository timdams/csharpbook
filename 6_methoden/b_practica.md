### Methoden

{% hint style='tip' %}
Ook dit hoofdstuk bevat meer oefeningen dan je lief zijn. Zoek zelf de oefeningen uit die je aanspreken en focus je op het leren werken met methoden en deze te integreren in een grotere applicatie.

Tip van een lector: meestal als een boek veel oefeningen van een bepaald onderwerp bevat is de kans bestaande dat dit onderwerp misschien wel eens belangrijk kan zijn ;)
{% endhint %}

{% hint style='warning' %}
Opgelet: wanneer je een oefening maakt die invoer van de gebruiker vereist, gelieve die invoer dan BUITEN de methode te vragen (dus meestal in de ``Main`` methode). 
**Op die manier zorg je er voor dat je je methoden kunt herbruiken.**
{% endhint %}

{% hint style='tip' %}
Sommige oefeningen zijn van de vorm "Maak een methode die...". Het is steeds de bedoeling dat je de werking van je methode ook test in je main door deze aan te roepen.
{% endhint %}

#### Opwarmers
Een extra grote hoop oefeningen om je methoden te drillen ([originele bron](https://codeforwin.org/2016/03/functions-programming-exercises-and-solutions-in-c.html)). De oefeningen zijn ongeveer gerangschikt naar moeilijkheid.

Iedere oefening verwacht dat je steeds een methode schrijft en de werking ervan aantoont:

* Methode ``Kwadraat`` die het kwadraat van een ingevoerd getal berekend ( het getal geef je mee als paramater).
* Methode ``BerekenStraal`` die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft (de diameter geef je mee als parameter).
* Idem voor omtrek en oppervlakte.
* Methode die het grootste van 2 getallen teruggeeft (beide getallen geef je mee als parameter).
* Methode ``IsEven`` die bepaalt of een getal even of oneven is (geeft een ``bool`` terug die ``true`` is indien even).
* Methode ``IsArmstrong`` die bepaalt of een getal een Armstrong getal is.
* Methode ``ToonOEvenNummers`` die alle oneven getallen van 1 tot n toont waarbij n als parameter wordt meegegeven.
* Methode ``ToonArmstrongNummers`` die alle Armstrong nummers tot n toont.


#### Basic
Maak een methode die jezelf voorstelt op het scherm in de vorm van "Ik ben Tim Dams, ik ben 18 jaar oud en woon in de Lambrisseringsstraat 666".
Deze informatie mag hardcoded in je methode staan. Bedoeling is dat je de methode kan aanroepen als volgt:

```java
MyIntro();
```

{% hint style='tip' %}
Deze methode toont enkel zaken op het scherm en heeft dus als returntype ``void``.
{% endhint %}

##### Basic 2

Zorg er voor dat je nu je naam, leeftijd en adres via parameters kan meegeven en dus de methode als volgt kunt aanhouden:

```java
MyIntro("Jos", 34, "Trammezantlei 21");
```

#### Grootste methode
Schrijf een methode die 3 ints aanvaardt en vervolgens de grootste van de 3 parameters als resultaat terug geeft.

#### Rekenmachine
Maak minimaal de methoden genaamd ``TelOp``, ``TrekAf``, ``VermenigVuldig`` en ``Deel``. Je kan aan deze methoden steeds twee doubles meegeven en het resultaat dat terugkomt is uiteraard de bewerking van die twee parameters.

Maak een eenvoudig programmatje waarin je die methoden test. Kan je een eenvoudige rekenmachine maken (inclusief geheugen)? Voeg extra methoden naar keuze toe (denk aan macht, sinus, cosinus, modulo, etc.).

#### Paswoord generator methode
Maak een paswoord generator die paswoorden van bepaalde lengte genereert en bestaat uit willekeurige letters, hoofdletters en cijfers. Plaats deze code in een methode die 1 parameter aanvaardt namelijk de lengte van het paswoord dat gemaakt moet worden. De methode geeft het gegenereerde paswoord terug als resultaat. (tip gebruik een random number generator(s) om getallen te genereren die je ook kan casten naar chars dankzij de Unicode waarde van chars).