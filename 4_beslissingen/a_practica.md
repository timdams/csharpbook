### Beslissingen

#### BMI met if

Pas je BMI-programma uit het vorige hoofdstuk aan zodat je programma feedback geeft aan de gebruiker naargelang het berekende BMI.

De kleur tussen haakjes geeft aan in welke kleur je deze tekst zet:

* Onder de 18,5 (rood): ondergewicht.
* Tussen de 18,5 en de 24,9 (groen): normaal gewicht. 
* Tussen de 25 en de 29,9 (donkergeel): overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.
* Tussen de 30 en de 39,9 (rood): Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.
* Boven de 40 (magenta): ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).

#### BankRekening controle
Schrijf een programma om het vroegere nationale bankrekeningnummer te controleren off het al of niet een geldig nummer is (dus niet het IBAN nummer). 

Het bankrekeningnummer wordt ingelezen als 3 gehele getallen van 3, 7 en 2.

{% hint style='tip' %}
Een bankrekeningnummer is geldig als de rest van de deling van het getal, dat bestaat uit de eerste 10 cijfers, door 97, gelijk is aan het getal bestaande uit de laatste 2 cijfers.
{% endhint %}

#### Schoenverkoper
a) Maak een oefening die aan de gebruiker vraagt hoeveel paar schoenen hij wenst te kopen. Ieder paar schoenen kost steeds 20 euro. Indien de gebruiker 10 paar of meer koopt kosten de eerste 9 paar nog steeds 20 euro, de overige kosten echter maar 10 euro. Toon aan de gebruiker de totale prijs.

Voorbeeld:  
* 8 schoenen kost 8x20 = 160 euro
* 12 schoenen kost 9x20 + 3x10 = 210 euro

b) Voeg nu toe dat het programma eerst aan de kassier vraagt tot hoeveel schoenen de korting niet geldt. 

Voorbeeld:
* De kassiester voert 6 in. Dan kosten 8 schoenen: 6x20 + 2x10 = 140 euro.

#### Ohm-berekenaar
Vraag aan de gebruiker wat hij wenst te berekenen: spanning, weerstand of stroomsterkte. Vraag vervolgens de 2 andere waarden (als dus de gebruiker "Spanning" kiest vraag je aan de gebruiker de stroomsterkte en de weerstand) en bereken m.b.v. de wet van Ohm de gewenste waarde.

#### Kleurcode weerstand naar ohm
Vraag aan de gebruiker om de ringkleuren van de eerste 3 ringen in te voeren als tekst (bv ``groen``). Toon vervolgens de de waarde van deze weerstand.
Als dus de gebruiker na elkaar invoert:

```
rood
paars
rood
```
Dan zal het programma tonen:

``Deze weerstand heeft een waarde van  2700 Ohm``

Los deze oefening op met een ``switch``statement.


#### Orakeltje van Delphi, part deux
We gaan het Orakeltje verbeteren. Voor het orakel je vertelt hoe lang je te leven hebt zal het eerste vragen of je een vrouw (``v``) of een man (``m``) bent. Dan vraagt ze je leeftijd.
Mannen leven maximum tot hun 120 jaar. Vrouwen echter tot 150 jaar. Laat het orakel een duur voorspellen die kan. Als een vrouw van 50 de vraag stelt dan zal het orakel dus een getal tussen 5 en 100 (``150-50``) genereren. Een man van 35 zal tussen de 5 en 85 (``120-35``) jaren langer kunnen leven. 

#### Casino
Genereer  een random getal van 1 t.e.m. 6 maar toon dit niet aan de gebruiker. Vraag aan de gebruiker welk getal hij denkt dat de computer heeft "geworpen". Indien de gebruiker juist raadt verschijnt er "proficiat" op het scherm. Anders: "you lose".

##### Casino 3
Vul de voorgaande oefening aan, maar laat de gebruiker 3x na mekaar raden. Enkel als hij juist raadt mag hij nog eens raden. Als hij ook de derde juist raadt wint hij. In alle andere gevallen niet.

#### Schaakstuk

Schrijf een applicatie om het volgende te verwezenlijken: De bedoeling is om 3 stukken willekeurig te kiezen van een schaakspel. 
Maak maximaal gebruik van enumeratie-types. Op het scherm moet dus willekeurig een opsomming van 3 stukken (als woorden) verschijnen. De uitvoer kan dus bijvoorbeeld zijn: 

<!---{line-numbers:false}--->
```text
wit paard
zwarte loper
witte pion
```

#### Quiz
Maak een quiz. Maak gebruik van het ``switch``-statement om de input van de gebruiker (a, b, c of d) te verwerken en bij iedere vraag aan te geven of dit juist of fout is. Voorzie 3 multiple choice vragen. Houdt bij hoe vaak de speler juist antwoordde en geef op het einde de eindscore (Juist is +2, fout is -1).

 Zoek op hoe je de kleur van de letters en de achtergrond in een console-applicatie kunt aanpassen en pas dit toe op je quiz om deze er iets boeiender uit te laten zien. Toon iedere vraag op een nieuw scherm.

#### Schrikkeljaar
De gebruiker voert een jaartal in en jouw programma toont of het wel of geen schrikkeljaar is. Een schrikkeljaar is deelbaar door 4, behalve als het ook deelbaar is door 100, tenzij het wél deelbaar is door 400.
Bijvoorbeeld: 
* 1997: geen schrikkeljaar
* 1996: wél schrikkeljaar
* 1900: geen schrikkeljaar
* 2000: wél schrikkeljaar

<!---NOBOOKSTART--->
#### GuntherD Stemwijzer
Kan jij volgende ludieke stemwijzer van GuntherD in een eenvoudig programma gieten dat door een reeks j/n vragen aan de gebruiker uiteindelijk zijn "stemprofiel" toont?

![Bron Stubru](../assets/2_beslissingen/stemwijzer.png)
<!---NOBOOKEND--->

#### Enum seizoenen
Maak een ``enum`` die de seizoenen van het jaar bevat. Vraag aan de gebruiker om een maandnummer in te voeren. Gebruik vervolgens een switch om te bepalen in welk seizoen deze maand (grotendeels) ligt. Wijs deze enum toe aan een variabele in de switch.
Vervolgens gebruik je een if om, gebaseerd op deze enum-variabele, te tonen of het om een koud seizoen (winter en herfst) of een warm seizoen (zomer en lente) gaat.

#### Enum bij BMI

Maak een e``num die de verschillende soorten gewichten voorstelt (Obees, Zwaarlijvig, NormaalGewicht, etc.) Pas de bestaande "BMI met if" oefening aan zodat je deze enum gebruikt om je code leesbaarder te maken. 

#### Kleurcode weerstand naar ohm, met enum
Open de "Kleurcode weerstand naar ohm" die je eerder in dit hoofdstuk hebt gemaakt. Gebruik ``enum`` om de weerstandskleuren voor te stellen zodat je veel leesbaardere code krijgt.

<!---{pagebreak}--->