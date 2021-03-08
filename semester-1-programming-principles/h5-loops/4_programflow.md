# Programma flow analyse

{% hint style="success" %}
[Kennisclip](https://youtu.be/004pN5a0dBc)
{% endhint %}

{% file src="../../.gitbook/assets/flowchartstuderen.pdf" caption="flowchart \"studeren\" uit het filmpje" %}

{% file src="../../.gitbook/assets/flowchartwinkel.pdf" caption="flowchart \"naar de winkel gaan\" uit het filmpje" %}

{% hint style="warning" %}
In het filmpje worden pijlen met pijlen verbonden, in de PDF's verbinden pijlen enkel met figuren. De betekenis is dezelfde, maar pijlen met pijlen verbinden is lastiger in het tekenprogramma. De flowchart "studeren" in de PDF is iets efficiënter dan die in het filmpje maar ze beschrijven hetzelfde proces.
{% endhint %}

## Programma flow analyse

Door een flowchart op te stellen is het vaak veel eenvoudiger om een programma ofwel te analyseren \(van code naar idee\) ofwel om een programma te schrijven \(van idee naar code\).

Een flowchart \(letterlijk: _stroomkaart_\) of stroomdiagram is een schematische beschrijving van een proces. Met een flowchart kan je vaak ingewikkelde stukken code visualiseren waardoor het geheel plots niet meer zo ingewikkeld is.

Een flowchart bestaat uit een aantal elementen:

* **Pijl**: een pijl geeft aan naar welk volgende blok wordt gegaan. Indien boven de pijl een bepaalde waarde staat wil dit zeggen dat deze pijl enkel wordt gevolgd als de uitkomst van het vorige blok de getoonde waarde geeft. Wanneer twee pijlen samenkomen, wordt soms een bolletje getekend.
* **Start en einde**: aangegeven met een afgeronde rechthoek met daarin de woorden "Start" of "Einde" \(wordt niet altijd getekend\)
* **Verwerk-stap**: een statement zoals "Voeg 1 toe aan X" wordt in een rechthoek geplaatst. Alle code die geen invoer nodig heeft zet je in een rechthoek.
* **Input/output**: Een parallellogram gebruik je om in-of uitvoer van de gebruiker of scherm te tonen. Bv "Verkrijg X van gebruiker" of "Toon volgende zin op het scherm".
* **Condities en beslissingen**: Een ruit wordt gebruikt wanneer een beslissing moet genomen worden. De condities van if en while-loops zet je dus in een ruit. De pijlen die eruit volgen geven aan welke pijl moet gevolgd worden gegeven een bepaalde waarde van de conditie.

## Flow-elementen

We tonen nu kort de verschillende program flow elementen en hoe ze in een flowchart voorkomen.

### Elementen uit eerdere hoofdstukken

#### If-element

![](../../.gitbook/assets/if%20%282%29.png)

#### If-else element

![](../../.gitbook/assets/ifelse%20%282%29.png)

### Elementen die dit hoofdstuk aan bod komen

{% hint style="info" %}
Onderstaande elementen zal je pas herkennen nadat je dit hoofdstuk al eens volledig hebt gelezen. Als dit de eerste keer is dat je deze leerstof bekijkt, spring dan meteen naar het voorbeeld van een flowchart onderaan deze pagina. De diagrammen meteen onder deze info-box worden in de loop van het hoofdstuk uitgelegd.
{% endhint %}

#### While-element

![](../../.gitbook/assets/while%20%283%29.png)

#### Do while-element

![](../../.gitbook/assets/dowhile%20%282%29.png)

Merk op dat bij if en if-else de flow niet naar een eerder punt in de code gaat. Dit is dus de manier om een while/do while te herkennen: er wordt naar een eerder punt in de code gegaan, een punt waar we reeds geweest waren

#### For-element

![](../../.gitbook/assets/for%20%284%29.png)

## Voorbeeld flowchart

Door de eerder beschreven elementen nu samen te voegen kunnen we een programma als een flowchart voorstellen. Stel dat we een programma "Faculteit" maken. Hierin is het de bedoeling om de faculteit van een gegeven getal N dat door de gebruiker wordt ingevoerd, te berekenen \(bijvoorbeeld N=5 geeft dan `5! = 5x4x3x2x1 = 120` \). De finale flowchart ziet er als volgt uit:

![](../../.gitbook/assets/fullflow%20%282%29.png)

We kunnen een flowchart in beide richtingen gebruiken: om bestaande code te verduidelijken of om een proces te vertalen naar de juiste programmaconstructies.

