# Expressies en operators

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=3a0370ef-b3da-4642-aeaa-a9660083e329)
{% endhint %}

## Expressies en operators

Zonder expressies is programmeren saai: je kan dan enkel variabelen aan elkaar toewijzen. Expressies zijn als het ware eenvoudige tot complexe sequenties van bewerkingen die op 1 resultaat uitkomen. De volgende code is bijvoorbeeld een expressie: `3+2`.

Het resultaat van deze expressie is 5.

{% hint style="info" %}
Over expressies in C\# is véél te vertellen, maar niet aan de orde in deze cursus. Bekijk [zeker volgende tekst](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expressions) indien je meer interesse hebt.
{% endhint %}

### Expressie-resultaat toewijzen

Meestal zal je expressies schrijven waarin je bewerkingen op en met variabelen uitvoert. Vervolgens zal je het resultaat van die expressie willen bewaren voor verder gebruik in je code.

Voorbeeld van **expressie**-resultaat toekennen:

```csharp
int temperatuursVerschil = temperatuurGisteren - temperatuurVandaag;
```

Hierbij zal de temperatuur uit de rechtse 2 variabelen worden uitgelezen, van elkaar wordt afgetrokken en vervolgens bewaard worden in temperatuursVerschil.

De voorgaande code kan ook langer geschreven worden als:

```csharp
int tussenResultaat = temperatuurGisteren - temperatuurVandaag;
int temperatuursVerschil = tussenResultaat;
```

Een ander voorbeeld van een **expressie**-resultaat toewijzen maar nu met literals \(stel dat we temperatuursVerschil reeds hebben gedeclareerd eerder\):

```csharp
temperatuursVerschil = 21 - 25;
```

Uiteraard mag je ook combinaties van literals en variabelen gebruiken in je expressies:

```csharp
int breedte = 15;
int hoogte = 20 * breedte;
```

## Operators

Operators in C\# zijn de welgekende 'wiskundige bewerkingen' zoals optellen \(`+`\), aftrekken \(`-`\), vermenigvuldigen \(`*`\) en delen \(`/`\). Deze volgen de wiskundige regels van **volgorde van berekeningen**:

1. **Haakjes**
2. **Vermenigvuldigen, delen en modulo**: `*` \(vermenigvuldigen\), `/` \(delen\) en `%` \(rest na deling, ook module genoemd\)
3. **Optellen en aftrekken**: `+` en `-`

   \(etc.\)

Net zoals in de wiskunde kan je in C\# met behulp van de haakjes verplichten het deel tussen de haakjes eerst te doen, ongeacht de andere operators en hun volgorde van berekeningen:

```text
3+5*2 => zal 13 als resultaat geven
(3+5)*2 => zal 16 geven
```

Je kan nu complexe berekeningen doen door literals, operators en variabelen samen te voegen. Bijvoorbeeld om te weten hoeveel je op Mars zou wegen:

```csharp
double gewichtOpAarde = 80.3;        //kg
double zwaartekrachtAarde = 9.81;    //m/s² 
double zwaartekrachtMars = 3.711;    //m/s²

double  gewichtOpMars = (gewichtOpAarde/zwaartekrachtAarde) * zwaartekrachtMars; //kg
Console.WriteLine("Je weegt op Mars" + gewichtOpMars + " kg");
```

### Modulo operator `%`

De modulo operator die we in C\# aanduiden met `%` verdient wat meer uitleg. Deze operator zal als resultaat de gehele rest teruggeven wanneer we het linkse getal door het rechtse getal delen:

```text
7%2 => zal 1 geven, daar 7 gedeeld door 2,  3 met rest 1 geeft 
10%5 => zal 0 geven, daar 10 gedeeld door 5, 2 met rest 0 geeft
```

De modulo-operator zal je geregeld gebruiken om bijvoorbeeld te weten of een getal een veelvoud van iets is. Als de rest dan 0 is weet je dat het getal een veelvoud is van het getal waar je het door deelde.

Bijvoorbeeld om te testen of getal even is gebruiken we `%2`:

```csharp
int getal = 1234234;
int rest = getal%2;
Console.WriteLine($"Indien het getal als rest 0 geeft weten we dat het even is. De rest is: {rest}");
```

### Verkorte operator notaties

Heel vaak wil je de inhoud van een variabele bewerken en dan terug bewaren in de variabele zelf. Bijvoorbeeld een variabele vermenigvuldigen met 10 en het resultaat ervan terug in de variabele plaatsen. Hiervoor zijn enkele verkorte notaties in C\#. Stel dat we een variabele `int getal` hebben:

| **Verkorte notatie** | **Lange notatie** | **Beschrijving** |
| :--- | :--- | :--- |
| `getal++;` | `getal= getal+1;` | variabele met 1 verhogen |
| `getal--;` | `getal= getal-1;` | variabele met 1 verlagen |
| `getal+=3;` | `getal= getal+3;` | variabele verhogen met een getal |
| `getal-=6;` | `getal= getal-6;` | variabele verminderen met een getal |
| `getal*=7;` | `getal= getal*7;` | variabele vermenigvuldigen met een getal |
| `getal/=2;` | `getal= getal/2;` | variabele delen door een getal |

Je zal deze verkorte notatie vaak tegenkomen. Ze zijn identiek aan elkaar en zullen dus je code niet versnellen. Ze zal enkel compacter zijn om te lezen. Bij twijfel, gebruik gewoon de lange notatie.

## Expressiedatatypes

![](../../.gitbook/assets/attention%20%285%29.jpg)

De types die je in je berekeningen gebruikt bepalen ook het type van het resultaat. Als je bijvoorbeeld twee `int` variabelen of literals optelt zal het resultaat terug een `int` geven.

```csharp
int result = 3+4;
```

Je kan echter geen kommagetallen aan `int` toewijzen. Als je dus twee `double` variabelen deelt is het resultaat terug een `double` en zal deze lijn een fout geven daar je probeert een `double` aan een `int` toe te wijzen:

```csharp
int otherResult = 3.1/45.2;
```

**Let hier op!**

But wait... it gets worse!

Wat als je een `int` door een `int` deelt? Het resultaat is terug een `int`. Je bent gewoon alle informatie na de komma kwijt. Kijk maar:

```csharp
int getal1 = 9;
int getal2 = 2;
int result = getal1/getal2;
Console.WriteLine(result);
```

Er zal `4` op het scherm verschijnen! \(niet `4.5` daar dat geen `int` is\).

Wat als je datatypes mengt? Als je een berekening doet met een `int` en een `double` dan zal C\# het 'grootste' datatype kiezen. In dit geval een double. Volgende code zal dus werken:

```csharp
double result = 3/5.6;
```

Volgende niet:

```csharp
int result = 3/5.6;
```

Wil je dus het probleem oplossen om 9 te delen door 2 dan zal je minstens 1 van de 2 literals of variabelen door een double moeten omzetten. Het voorbeeld van hierboven herschrijven we dan naar:

```csharp
int getal1 = 9;
double getal2 = 2.0;
double result = getal1/getal2;
Console.WriteLine(result);
```

En nu krijgen we wel `4.5`.

### En complexer?

Het kan subtiel en ambetant worden in grotere berekeningen.

Stel dat ik afspreek dat je van mij de helft van m'n salaris krijgt. Ik verdien \(fictief\) 10000 euro per maand. Ik gebruik volgende formule:

```csharp
double helft = 10000.0 * (1/2);
```

Hoeveel krijg je van me? **0.0 euro, MUHAHAHAHA!!!**

De volgorde van berekeningen zal eerst het gedeelte tussen de haakjes doen: 1 delen door 2 geeft 0, daar we een `int` door een `int` delen en dus terug een `int` als resultaat krijgen. Vervolgens zullen we deze `0` vermenigvuldigen met `10000.0` waarvan ik zo slim was om deze in `double` te zetten. Niet dus. We vermenigvuldigen weliswaar een `double` \(het salaris\) met een `int` maar die `int` is reeds `0` en we krijgen dus `0.0` als resultaat.

Wil je het dus eerlijk spelen dan zal je de formule moeten aanpassen naar:

```csharp
double helft = 10000.0 * (1.0/2);
```

Nu krijgt het gedeelte tussen de haakjes een `double` als resultaat, namelijk `0.5` dat we dan kunnen vermenigvuldigen met het salaris om `5000.0` te krijgen.

