### De basisconcepten van C#

<!---NOBOOKSTART--->
{% hint style='tip' %}
Het is aanbevolen dat je per hoofdstuk een nieuwe folder aanmaakt op je computer. Per oefening maak je dan best een nieuw project aan dat je in de folder zet. Geef ieder project een duidelijke naam (bv EuroNaarDollar) zodat je later vlot je oefeningen kan terugvinden. Denk er aan dat je je projecten best enkel met cijfers en letters benoemd (dus beter EuroNaarDollar dan Euro-Dollar).
{% endhint %}
<!---NOBOOKEND--->

#### Simple maths
Schrijf een programma dat de uitkomst van volgende resultaten op het scherm toont:

<!---{line-numbers:false}--->
```text
-1 + 4 * 6
( 35 + 5 ) % 7
14 + -4 * 6 / 11
2 + 15 / 6 * 1 - 7 % 2
```

Test wat er gebeurt indien je het resultaat in een ``int`` bewaard en wat er gebeurt als je deze in een ``double`` bewaard.
Toon beide uitkomsten (m.b.v. ``WriteLine``) telkens op het scherm.

{% hint style='warning' %}
De % hier is de modulo-operator.
{% endhint %}


#### Gemiddelde

Maak 3 variabelen aan van het type ``int`` genaamd ``september``, ``oktober`` en ``november``. Plaats in elke variabele de hoeveelheid uren slaap je die maand verwacht te doen. Bereken nu het gemiddelde van 3 maanden en toon het resultaat op het scherm (kies uiteraard 3 verschillende hoeveelheden slaap).

#### Euro naar dollar

Ontwerp een toepassing waarmee je een bedrag, inclusief komma-getallen  in euro kan omrekenen naar dollar. Gebruik hierbij de huidige wisselkoers. Je hoeft niet af te ronden. Het resultaat op het scherm wordt als volgt weergegeven: ``[x] EUR is gelijk aan [y] USD``.

#### Tafel en Console.Clear()

Met het statement ``Console.Clear();`` kan je de console - je raadt het nooit - leegmaken. Test deze code in het volgende programma:

Schrijf een programma dat de tafels van vermenigvuldigen geeft van 411 (dus 1x411= 411, 2x411= 822 tot en met 10x411= 4110). Toon telkens 1 zin en wacht dan tot de gebruiker op enter duwt om de volgende vermenigvuldiging op een nieuw scherm te tonen. De output ziet er dus als volgt uit:

<!---{line-numbers:false}--->
```text
1 x 411 = 411
Druk op enter voor de volgende lijn.
[Scherm leeg gemaakt]
2 x 411 = 822
Druk op enter voor de volgende lijn.
[Scherm leeg gemaakt]
...
```

**Plaats 411 in een variabele aan de start van het programma en gebruik deze in je berekeningen verderop. Toon dat je code ook werkt door de inhoud van de variabele in een ander getal te veranderen zodat je van dat nieuwe getal nu de tafels van vermenigvuldiging krijgt.**


Je kan wachten tot de gebruiker op enter duwt door gewoon een lege ``Console.ReadLine`` te doen, zoals volgende voorbeeld toont:

```java
Console.WriteLine("Eerste beeld");
Console.WriteLine("Druk enter om voort te gaan.");
Console.ReadLine();
Console.Clear();
Console.WriteLine("Tweede beeld");
```

{% hint style='tip' %}
Merk op dat ``Console.Clear()`` niet werkt zoals verwacht op Mac. 
{% endhint %}

#### Kill/Death-ratio

Maak twee variabelen ``double kills`` en ``double deaths`` aan. Wijs er jouw typische scores aan toe die je haalt in een spel naar keuze. Bereken en toon vervolgens je kill/death-ratio.


{% hint style='warning' %}
**Begrijp je waarom we best een van beide variabelen in ``double`` zetten?** Lees de waarschuwing van de voorman bij Expressies zeker nog eens na... Of test eens wat er gebeurt indien je met ``int`` zou werken.
{% endhint %}

#### BTW
Schrijf een programma waarin je het BTW-percentage 21% als een constante definieert door het keyword ``const`` voor de variabele te zetten. Vervolgens toon je een prijs naar keuze, met en zonder btw op het scherm. De prijs wordt getoond tot 2 cijfers na de komma.

#### Gewicht in space

Je massa is overal dezelfde. Je gewicht daarentegen is afhankelijk van de zwaartekracht van de plek waar je bent. Zo is je gewicht veel groter op Jupiter dan op Mars.

Maak een variabele ``double gewichtOpAarde`` aan. Wijs een gewicht toe (bv. het jouwe). Schrijf nu een programma dat onder elkaar jouw gewicht op verschillende planeten toont.

Hier de omzettingstabel (je gewicht op Mercurius is dus je gewicht op aarde x 0.38):

* Mercurius: 0.38
* Venus: 0.91
* Aarde: 1.00
* Mars: 0.38
* Jupiter: 2.34
* Saturnus: 1.06
* Uranus: 0.92
* Neptunus: 1.19
* Pluto: 0.06  (we laten de discussie achterwege of pluto wel of niet een planeet is)

De output zijn verschillende lijnen onder elkaar in de vorm van:

``Je weegt op [planeet] [gewichtopdieplaneet] kg.``

Plaats de zin met Jupiter in het rood, daar je daar het zwaarst weegt en die van pluto in het groen.

<!---{pagebreak}--->