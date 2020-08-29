### Herhalingen, herhalingen, herhalingen

<!---NOBOOKSTART--->
{% hint style='tip' %}
Vanaf dit hoofdstuk zul je véél meer oefeningen voorgeschoteld krijgen dan je kan afwerken in 1 labo tijd (I dare you ;) ). Selecteer zelf de oefeningen die je wenst te doen en sla die over waarvan je overtuigd bent ze al te kunnen. 
{% endhint %}
<!---NOBOOKEND--->

{% hint style='tip' %}
De oefeningen zijn, in de mate van het mogelijke, gerangschikt op relatieve moeilijkheidsgraad
{% endhint %}

{% hint style='tip' %}
Indien niet expliciet vermeld mag je kiezen met wat voor loop (``for``, ``while``, ``do while``) je het probleem zal oplossen. Denk echter steeds goed na wat voor loop de beste keuze is. Indien je van te voren weet hoevaak de loop moet uitgevoerd worden, dan is een ``for`` de beste keuze. Weet je dat niet dan kies je voor ``while`` of `` do while`` (weet je nog het verschil tussen beiden?)
{% endhint %}

#### De opwarmers
<!---NOBOOKSTART--->
##### Opwarmers van opwarmers
Bekijk maak de oefeningen 8 tot en met 13 van hoofdstuk 4 in volgende [pdf](../assets/docs/oefenvragen2010.pdf) 

{% hint style='tip' %}
Dit document staat ook in de lijst onderaan bij de [nuttige extra's](../_intro/nuttigeextras.md).
{% endhint %}
<!---NOBOOKEND--->

1. Lees een willekeurig aantal getallen in met als afsluitwaarde 0. Bereken de som en druk die af.
2. Lees een willekeurig aantal getallen in met als afsluitwaarde 0. Druk het aantal strikt positieve en het aantal strikt negatieve getallen af.
3. Lees een willekeurig aantal getallen in met als afsluitwaarde -32768. Bepaal het aantal strikt positieve getallen, het aantal strikt negatieve getallen en het aantal getallen gelijk aan nul. Druk deze aantallen af.
4. Lees een willekeurig aantal getallen in met als afsluitwaarde 0. Bereken het product en druk dit af.
5. Lees een getal in en druk de som van zijn cijfers af.
6. Lees een willekeurig aantal positieve getallen in en bereken het (afgekapt) gemiddelde ervan. De afsluitwaarde is een willekeurig negatief getal.
7. Lees een willekeurig aantal getallen in met afsluitwaarde -32768. Druk het kleinste getal af en het aantal keer dat het voorkomt.
8. Een reeks in stijgende volgorde gesorteerde getallen wordt ingelezen. De invoer moet stoppen indien er een fout in de sorteervolgorde voorkomt.
9. Een reeks getallen wordt ingelezen. De invoer moet stoppen indien er twee maal achter elkaar een nul wordt ingelezen. Het gemiddelde van de reeks getallen wordt afgedrukt. De laatste twee nullen tellen uiteraard niet mee voor de bepaling van het gemiddelde.
10. Bepaal de som van de kwadraten van de even natuurlijke getallen tussen 50 en 100 (inbegrepen). De som wordt afgedrukt.
11. Een reeks van 100 getallen wordt ingelezen. Van de positieve getallen moet er afgedrukt worden hoeveel deelbaar waren door 2, hoeveel deelbaar waren door 3 en hoeveel door 6.
12. Druk de som af van de eerste 30 termen van de volgende reeksen:
 * 6 + 12 + 18 + 24 + 30 + ...
 * 4 + 12 + 20 + 28 + 36 + ...
 * 1 + 2 + 4 + 8 + 16 + ...
 * 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...
 * 1 + 1/3 + 1/5 + 1/7 + 1/9 + ...
 * 1/2 + 1/3 + 1/5 + 1/9 + 1/17 + ...
13. Druk de som af van de eerste 20 termen van de volgende reeksen:
 * 4 + 8 + 12 + 16 + 20 + ...
 * 4 + 10 + 16 + 22 + 28 + ...
 * 1 + 3 + 9 + 27 + 81 + ...
 * 1/2 + 1/4 + 1/6 + 1/8 + 1/10 + ...
 * 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...
 * 1 + 1/3 + 1/7 + 1/15 + 1/31 + ...


#### Tafels van vermenigvuldigen
Gebruik de kracht van loops om pijlsnel alle tafels van 1 tot en met 10 van vermenigvuldigen op het scherm te tonen (dus van 1x1 tot 10x10 en alles daartussen).

#### RNA Transscriptie

DNA heeft steeds een RNA-complement (DNA is het gevolg van RNA transscriptie). Schrijf een programma dat een ingevoerde DNA-string omzet naar een RNA-string. De gebruiker voert steeds 1 DNA-nucleotide in per keer en duwt op enter, de RNA string wordt steeds groter.
De omzetting is als volgt:
* G wordt C
* C wordt G
* T wordt A
* A wordt U

Als de gebruiker dus ``ACGTGGTCTTAA`` heeft ingevoerd moet het resultaat: ``UGCACCAGAAUU`` zijn. 

Ga er van uit dat de gebruiker letter per letter invoert (telkens dus enter na een letter) en je de omgezette string doet groeien (m.b.v. ``+=``).

#### Armstrong nummer (PRO)
Een getal is een *narcistisch getal* of *armstronggetal* als het de som is van zijn eigen cijfers elk tot de macht verheven van het aantal cijfers.

* 9 is een Armstrong nummer, want 9 = 9^1 = 9
* 10 is geen Armstrong nummer, want 10 != 1^2 + 0^2 = 1
* 153 is een  Armstrong nummer, want: 153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
* 154 is geen  Armstrong nummer, want: 154 != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190

Schrijf een programma dat aan de gebruiker een getal vraagt en vervolgens toont of het ingevoerde getal een Armstrong-nummer is of niet.

{% hint style='tip' %}
Je zou deze oefening kunnen oplossen door het ingevoerde getal als string op te splitsen in individuele char's. Maar we raden je aan om de "wiskunde" weg te volgen zodat je terdege leert met loops en wiskunde te werken.

Stel dat je het getal 4560 hebt:

* Eerst deel je 4563 door 1000. Dit geeft **4**. 
* We trekken 4x1000 van 4563 af. Dit geeft 563.
* Deel 563 door 100. Dit geeft **5**.
* We trekken 5x100 van 563 af. Dit geeft 63.
* Deel 63 door 10. Dit geeft **6**.
* We trekken 6 x 10 van 63 af. Dit geeft **3**
{% endhint %}

{% hint style='tip' %}
Je kan van een string weten hoe groot deze is als volgt:

```java
//veronderstellend dat myInputGetal van het type string is
int lengte= myInputGetal.Length;  
```
Je kan dan nu met ``Math.Pow(10,lengte-1)`` berekenen vanaf welke exponent van 10 we moeten beginnen werken.
{% endhint %}


#### Euler project
Maak volgende opdracht van [projecteuler.net](http://projecteuler.net):
>Indien we alle natuurlijke getallen van 0 tot en met 10 oplijsten die een meervoud van 3 of 5 zijn, dan krijgen we de getallen 3,5,6,9 en 10. De som van deze 4 getallen is 33.
Maak nu een programma dat de som van alle veelvouden van 3 of 5 weergeeft van 0 tot 1000 (dit zou 234168 moeten geven).

{% hint style='tip' %}
De modulo-operator (``%``) is je grote held hier. Een getal is een veelvoud van x indien ``getal % x`` 0 als resultaat geeft.
{% endhint %}

#### For doordenker (PRO)
Schrijf een programma dat de volgende output geeft, gegeven dat de gebruiker een maximum waarde invoert, dus als hij 4 ingeeft dan zal de driehoek maximum 4 breed worden. Gebruik enkel 2 geneste for-loops!
```
*
**
***
****
***
**
*
```