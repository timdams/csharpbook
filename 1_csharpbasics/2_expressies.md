## Expressies en operators

Zonder expressies is programmeren saai: je kan dan enkel variabelen aan elkaar toewijzen. Expressies zijn als het ware eenvoudige tot complexe sequenties van bewerkingen die op 1 resultaat uitkomen met een specifiek datatype. De volgende code is bijvoorbeeld een expressie: `3+2`.

Het resultaat van deze expressie is  **``5``** (en dus van type ``int``). 

### Expressie-resultaat toewijzen

Meestal zal je expressies schrijven waarin je bewerkingen op en met variabelen uitvoert. Vervolgens zal je het resultaat van die expressie willen bewaren voor verder gebruik in je code. In de volgende code kennen we het **expressie**-resultaat toe aan een variabele:

```java
int temperatuursVerschil = temperatuurGisteren - temperatuurVandaag;
```

Hierbij zal de temperatuur uit de rechtse 2 variabelen worden uitgelezen, van elkaar wordt afgetrokken en vervolgens bewaard worden in ``temperatuursVerschil``. De voorgaande code kan echter ook langer geschreven worden als:

```java
int tussenResultaat = temperatuurGisteren - temperatuurVandaag;
int temperatuursVerschil = tussenResultaat;
```

Een ander voorbeeld van een **expressie**-resultaat toewijzen maar nu met literals:

```java
int temperatuursVerschil = 21 - 25;
```

Uiteraard mag je ook combinaties van literals en variabelen gebruiken in je expressies:

```java
int breedte = 15;
int hoogte = 20 * breedte;
```

### Operators
Om expressies te gebruiken hebben we ook zogenaamde **operators** nodig. Operators in C# zijn de welgekende wiskundige bewerkingen zoals optellen (`+`), aftrekken (`-`), vermenigvuldigen (`*`) en delen (`/`). Deze volgen de klassieke wiskundige regels van **volgorde van berekeningen**:

1. **Haakjes**
2. **Vermenigvuldigen, delen en modulo**: ``*`` (vermenigvuldigen), ``/`` (delen) en ``%`` (rest na deling, ook modulo genoemd)
3. **Optellen en aftrekken**: `+` en `-`, enz.

{% hint style='tip' %}
We spreken over operators en **operands**. Een operand is het element dat we links en/of rechts van een operator zetten. In de som ``3+2`` zijn ``3`` en ``2`` de operanden, en ``+`` de operator. In dit voorbeeld spreken we van een **binaire operator** omdat er twee operanden zijn.

Er bestaan ook **unaire operators** die maar 1 operand hebben. Denk bijvoorbeeld aan de ``-`` operator om het teken van een getal om te wisselen: ``-6``.
{% endhint %}

Net zoals in de wiskunde kan je in C# met behulp van de haakjes verplichten het deel tussen de haakjes eerst te doen, ongeacht de andere operators en hun volgorde van berekeningen:

```java
3+5*2 // zal 13 (type int) als resultaat geven
(3+5)*2  // zal 16 (type int) geven
``` 

Je kan nu complexe berekeningen doen door literals, operators en variabelen samen te voegen. Bijvoorbeeld om te weten hoeveel je op Mars zou wegen:
```java
double gewichtOpAarde= 80.3;        //kg
double gAarde= 9.81;    //m/s² 
double gMars= 3.711;    //m/s²

double  gewichtOpMars= (gewichtOpAarde/gAarde) * gMars; //kg
Console.WriteLine("Je weeg op Mars" + gewichtOpMars + " kg");
```

#### Modulo operator ``%``
De modulo operator die we in C# aanduiden met ``%`` verdient wat meer uitleg. Deze operator zal als resultaat de gehele rest teruggeven wanneer we het linkse getal door het rechtse getal delen:

```java
7%2  // zal 1 geven, daar 7 gedeeld door 2,  3 met rest 1 geeft 
10%5 // zal 0 geven, daar 10 gedeeld door 5, 2 met rest 0 geeft 
```

De modulo-operator zal je geregeld gebruiken om bijvoorbeeld te weten of een getal een veelvoud van iets is. Als de rest dan 0 is weet je dat het getal een veelvoud is van het getal waar je het door deelde.

Bijvoorbeeld om te testen of getal even is gebruiken we ``%2``:
```java
int getal= 1234234;
int rest= getal%2;
Console.WriteLine("Indien het getal als rest 0 geeft is deze even."); 
Console.WriteLine("De rest is: "+ rest);
```

<!---{pagebreak} --->

#### Verkorte operator notaties
Heel vaak wil je de inhoud van een variabele bewerken en dan terug bewaren in de variabele zelf. Bijvoorbeeld een variabele vermenigvuldigen met 10 en het resultaat ervan terug in de variabele plaatsen. Hiervoor zijn enkele verkorte notaties in C#.
Stel dat we een variabele ``int getal`` hebben:

| **Verkorte notatie** | **Lange notatie** | **Beschrijving**|
| :--- | :--- |:--- |
| ``getal++;`` | ``getal= getal+1;``| variabele met 1 verhogen|
| ``getal--;`` | ``getal= getal-1;``| variabele met 1 verlagen|
| ``getal+=3;`` | ``getal= getal+3;``| variabele verhogen met een getal|
| ``getal-=6;`` | ``getal= getal-6;``| variabele verminderen met een getal|
| ``getal*=7;`` | ``getal= getal*7;``| variabele vermenigvuldigen met een getal|
| ``getal/=2;`` | ``getal= getal/2;``| variabele delen door een getal|

{% hint style='tip' %}
Je zal deze verkorte notatie vaak tegenkomen. Ze zijn identiek aan elkaar en zullen dus je code niet versnellen. Ze zal enkel compacter zijn om te lezen. Bij twijfel, gebruik gewoon de lange notatie. 
{% endhint %}

##  Expressiedatatypes 

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
Gegroet! Zet je helm op en let alsjeblieft goed op. Als je het volgende stuk goed begrijpt (en blijft begrijpen) dan heb je al een grote stap vooruit gezet in de wondere wereld van C#. 

We vertelden al dat variabelen het hart van programmeren zijn. Wel, expressies zijn het bloedvatensysteem dat ervoor zorgt dat al je variabelen ook effectief gecombineerd kunnen worden tot wondermooie nieuwe dingen. 

Succes!
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

Lees deze zin enkele keren luidop voor, voor je verder gaat: **De types die je in je expressies gebruikt bepalen ook het type van het resultaat.** Als je bijvoorbeeld twee ``int`` variabelen of literals optelt zal het resultaat terug een ``int`` geven (klink logisch, maar lees aandachtig verder):

```java
int result= 3 + 4;
```

Je kan echter geen kommagetallen aan ``int`` toewijzen. Als je dus twee ``double`` variabelen deelt is het resultaat terug een ``double`` en zal deze lijn een fout geven daar je probeert een ``double`` aan een ``int`` toe te wijzen:
```java
int otherResult= 3.1 / 45.2;  //dit is fout!!!
```

Bovenstaande code geeft volgende fout:
![Voorspelling: deze error zal je vaak tegenkomen.](../assets/1_csharpbasics/casterror.jpg)

**Let hier op!**

<!---{pagebreak} --->

### But wait... it gets worse! 

Wat als je een ``int`` door een ``int`` deelt? Het resultaat is terug een ``int``. Je bent echter alle informatie na de komma kwijt. Kijk maar:
```java
int getal1= 9;
int getal2= 2;
int result= getal1/getal2;
Console.WriteLine(result);
```
**Er zal ``4`` op het scherm verschijnen!** (niet ``4.5`` daar dat geen ``int`` is). 

### Datatypes mengen in een expressie 

Wat als je datatypes mengt? Als je een berekening doet met bijvoorbeeld een ``int`` en een ``double`` dan zal C# het 'grootste' datatype kiezen. In dit geval een double. 

Volgende code zal dus werken:
```java
double result= 3/5.6;
```
Volgende code niet:
```java
int result= 3/5.6;
```
En zal weer dezelfde fout genereren:

![](../assets/1_csharpbasics/casterror.jpg)

Wil je dus het probleem oplossen om 9 te delen door 2 en toch 4.5 te krijgen (en niet 4) dan zal je minstens 1 van de 2 literals of variabelen naar een double moeten omzetten. 

Het voorbeeld van hierboven herschrijven we daarom naar:
```java
int getal1= 9;
double getal2= 2.0; //see what we do here!
double result= getal1/getal2;
Console.WriteLine(result);
```
En nu krijgen we wel ``4.5`` aangezien we nu een ``int`` door een ``double`` delen en C# dus ook het resultaat dan als een ``double`` zal teruggeven.

<!---{pagebreak} --->

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
Begrijp je nu waarom dit een belangrijk deel was? Je kan erg snel erg foute berekeningen en ongewenste afrondingen krijgen indien je niet erg bewust omgaat met je datatypes. 

Laten we eens kijken of je goed hebt opgelet, het kan kan namelijk subtiel en ambetant worden in grotere berekeningen.

Stel dat ik afspreek dat je van mij de helft van m'n salaris krijgt. Ik verdien  10000 euro per maand (I wish).

Ik stel je voor om volgende expressie te gebruiken om te berekenen wat je van mij krijgt:

```java
double helft= 10000.0 * (1 / 2);
```
Hoeveel krijg je van me? 

**0.0 euro, MUHAHAHAHA!!!**

Begrijp je waarom? De volgorde van berekeningen zal eerst het gedeelte tussen de haakjes doen: 
* 1 delen door 2 geeft 0, daar we een ``int`` door een ``int`` delen en dus terug een ``int`` als resultaat krijgen. 
* Vervolgens zullen we deze ``0`` vermenigvuldigen met ``10000.0`` waarvan ik zo slim was om deze in ``double`` te zetten. Niet dus. We vermenigvuldigen weliswaar een ``double`` (het salaris) met een ``int`` maar die ``int`` is reeds ``0`` en we krijgen dus ``0.0`` als resultaat.

Als ik dus effectief de helft van m'n salaris wil afstaan dan moet ik de expressie aanpassen naar bijvoorbeeld: 
```java
double helft = 10000.0 * (1.0 / 2);
```

Nu krijgt het gedeelte tussen de haakjes een ``double`` als resultaat, namelijk ``0.5`` dat we dan kunnen vermenigvuldigen met het salaris om ``5000.0`` te krijgen, wat hij vermoedelijk een fijner resultaat vindt.
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->


<!---NOBOOKSTART--->
## Kennisclip
![](../assets/infoclip.png)
* [Expressies](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=3a0370ef-b3da-4642-aeaa-a9660083e329)
<!---NOBOOKEND--->
