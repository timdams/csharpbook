# Oefeningen deel 1

> Vanaf nu zul je véél meer oefeningen voorgeschoteld krijgen dan je kan afwerken in 1 labo tijd \(I dare you ;\). Selecteer zelf de oefeningen die je wenst te doen en sla die over waarvan je overtuigd bent ze al te kunnen. De oefening zijn , in de mate van het mogelijke, gerangschikt op moeilijkheid.

## De opwarmers

Bekijk maak de oefeningen 8 tot en met 13 van hoofdstuk 4 in volgende [pdf](https://github.com/v-nys/cursusprogrammeren/tree/13ea122a2e92d805feb8b618811589d4f57a8b23/assets/docs/oefenvragen2010.pdf)

> Ter info: Dit document staat ook in de lijst onderaan bij de nuttige extra's [hier](../../inleiding/nuttigeextras.md).

## De oefeningen

> Indien niet expliciet vermeld mag je kiezen met wat voor loop \(for, while, do while\) je het probleem zal oplossen.

### Tafels van vermenigvuldigen

Gebruik de kracht van loops om pijlsnel alle tafels van 1 tot en met 10 van vermenigvuldigen op het scherm te tonen \(dus van 1x1 tot 10x10 en alles daartussen\)

### RNA Transscriptie

DNA heeft steeds een RNA-complement \(DNA is het gevolg van RNA transscriptie\). Schrijf een programma dat een ingevoerde DNA-string omzet naar een RNA-string. De gebruiker voert steeds 1 DNA-nucleotide in per keer en duwt op enter, de RNA string wordt steeds groter. De omzetting is als volgt:

* G wordt C
* C wordt G
* T wordt A
* A wordt U

Als de gebruiker dus `ACGTGGTCTTAA` heeft ingevoerd moet het resultaat: `UGCACCAGAAUU` zijn.

Ga er van uit dat de gebruiker letter per letter invoert \(telkens dus enter na een letter\) en je de omgezette string doet groeien \(m.b.v `+=`\).

### PRO Armstrong nummer

Een getal is een _narcistisch getal_ of _armstronggetal_ als het de som is van zijn eigen cijfers elk tot de macht verheven van het aantal cijfers.

* 9 is een Armstrong nummer, want 9 = 9^1 = 9
* 10 is geen Armstrong nummer, want 10 != 1^2 + 0^2 = 1
* 153 is een  Armstrong nummer, want: 153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
* 154 is geen  Armstrong nummer, want: 154 != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190

  Schrijf een programma dat aan de gebruiker een getal vraagt en vervolgens toont of het ingevoerde getal een Armstrong-nummer is of niet.

> Je zou deze oefening kunnen oplossen door het ingevoerde getal als string op te splitsen in individuele char's. Maar ik raad je aan om de "wiskunde" weg te volgen zodat je terdege leert met loops te wiskunde.\*

Tip 1: Stel dat je het getal 4560 hebt:

* Eerst deel je 4563 door 1000. Dit geeft **4**. 
* We trekken 4x1000 van 4563 af. Dit geeft 563.
* Deel 563 door 100. Dit geeft **5**.
* We trekken 5x100 van 563 af. Dit geeft 63.
* Deel 63 door 10. Dit geeft **6**.
* We trekken 6 x 10 van 63 af. Dit geeft **3**

Tip 2: Je kan aan een string vragen hoe groot deze is als volgt:

```csharp
int lengte= myInputGetal.Length;  //veronderstellend dat myInputGetal van het type string is
```

Je kan dan nu met `Math.Pow(10,lengte-1)` berekenen vanaf welke exponent van 10 we moeten beginnen werken.

### Euler project

Maak volgende opdracht van [projecteuler.net](http://projecteuler.net):

> Indien we alle natuurlijke getallen van 0 tot en met 10 oplijsten die een meervoud van 3 of 5 zijn, dan krijgen we de getallen 3,5,6,9 en 10. De som van deze 4 getallen is 33. Maak nu een programma dat de som van alle veelvouden van 3 of 5 weergeeft onder van 0 tot 1000 \(dit zou 234168\) moeten geven.

**Tip: module is je grote held hier. Een getal is een veelvoud van x indien `getal%x` 0 als resultaat geeft.**

### PRO: For doordenker

Schrijf een programma dat de volgende output geeft , gegeven dat de gebruiker een maximum waarde invoert , dus als hij 4 ingeeft dan zal de driehoek maximum 4 breed worden. Gebruik enkel forloops!

```text
*
**
***
****
***
**
*
```

### PRO: For doordenker extra

Schrijf een programma dat de volgende output geeft \(zie ook WhileDoordenker van vorige labo\), gegeven dat de gebruiker een maximum waarde invoert die opgeeft uit hoeveel lijnen de boom bestaat. Maak enkel gebruik van for-loops.

```text
     *
    ***
   *****
  *******
 *********
***********
```

