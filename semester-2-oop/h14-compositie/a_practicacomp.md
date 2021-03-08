# Labo-oefeningen

## UML naar code

Kan je volgende 2 UML-diagrammen implementeren in code? Uiteraard kan je dat: make it happen!

![](../../.gitbook/assets/compuml.png) [bron](https://www.visual-paradigm.com/guide/uml-unified-modeling-language/uml-aggregation-vs-composition/)

![](../../.gitbook/assets/multipplecompuml.png) [bron](http://www.jot.fm/issues/issue_2004_11/column5/)

## Moederbord

Maak een klasse `Moederbord` die een, je raadt het nooit, moederbord van een computer voorstelt. Kies een van de vele moederborden die je online vindt \([enkele voorbeelden](https://www.google.com/search?biw=1368&bih=802&tbm=isch&sa=1&ei=4oK9XNqCKt3UmwXbk5-4Cg&q=motherboard+parts&oq=motherboard+parts&gs_l=img.3..0l10.1974.2413..2560...0.0..0.68.290.5......1....1..gws-wiz-img.aurN6S4Da0I#imgrc=_)\) en bekijk uit welke delen een moederbord bestaat \('heeft een'\).

Maak voor ieder deel een aparte klasse. Voorzie vervolgens via compositie de nodige objecten in je moederbord. Denk er aan dat je bijvoorbeeld 2 \(of 4\) RAM-slots hebt en dus hier ofwel een array moet voorzien van het type `List<RAM>`, oftewel twee aparte delen `RAMSlot1` en `RAMSlot2`.

Maak een methode `TestMoederbord` in de klasse `Moederbord`. Wanneer je deze aanroept zal deze weergeven welke onderdelen nog leeg zijn \(`==null`\).

Iedere module moet via een property langs buiten ingesteld worden. \(beeld je in dat je effectief een moederbord ineenknutselt\):

```csharp
Moederbord Z390E_GAMING = new Moederbord();
Z390E_GAMING.AGP= new AGPSlot("GeForceRTX2080");
Z390E_GAMING.CPU= new CPUSlot("IntelCorei9_9900K");
//etc.
```

Kan je zelf een computer samenstellen door enkele objecten van verschillende types aan te maken en deze aan je moederbord-object toe te wijzen?

## Een eigen huis

Gebruik compositie én overerving om een klasse `Huis` te voorzien van enkele kamers, waarbij iedere kamer een klasse op zich is \(denk aan `BadKamer`, `Salon`, etc\). Alle kamers erven over van de klasse `Kamer`. Iedere kamer heeft een oppervlakte \(in vierkante meter\), een naam en prijs. Standaard is de prijs van een kamer 400euro, maar mogelijke child-klassen zullen deze property soms overriden:

Maak minstens volgende klassen:

* Badkamer: kost 500 euro
* Gang: kost 10euro per vierkante meter dat deze kamer groot is
* Salon: kost 300 euro indien er geen schouw aanwezig is \(via `bool` bijhouden\) anders 500euro

De klasse `Huis` heeft een array van kamers. De klasse heeft ook een methode `BerekenPrijs` die de totale prijs van het huis berekent gebaseerd op de prijzen van iedere kamer in de array.

Test je klasse door enkele huizen te maken en er enkele kamers in te plaatsen \(bepaal zelf hoe je de kamers aan het huis toevoegt: via methode, constructor, etc\) en vervolgens de prijs ervan te tonen.

## \(PRO\) Textbased RPG

Bekijk het volgende All-in-One project :[OO Textbased Game](../../semester-2-appendix/all-in-projecten/2_ootextgame.md).

Dit project gebruikt alle materie tot en met dit hoofdstuk. Kan je dit project maken én , belangrijker, uitbreiden met nieuwe functionaliteit?

