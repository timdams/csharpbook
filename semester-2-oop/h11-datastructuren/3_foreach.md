# Foreach en var

## Foreach loops

Wanneer je geen indexering nodig hebt, maar toch snel over alle elementen in een array wenst te gaan, dan is het **foreach** statement een zeer nuttig is. Een foreach loop zal ieder element in de array een voor een in een tijdelijke variabele plaatsen \(de **iteration variable**\). Volgende code toont de werking waarbij we een array van `string`s hebben en alle elementen er in op het scherm willen tonen:

```csharp
string[] boodschappen= {"ontbijtgranen", "koekjes", "fruit"};
foreach (string boodschap in boodschappen)
{
   Console.WriteLine($"Niet vergeten: {boodschap}");
}
```

De eerste keer dat we in de loop gaan zal het element `boodschappen[0]` aan `boodschap` toegewezen worden voor gebruik in de loop-body, vervolgens wordt `boodschappen[1]` toegewezen, enz.

Het voordeel is dat je dus geen teller/index nodig hebt en dat foreach zelf de lengte van de array zal bepalen.

{% hint style="warning" %}
### Opgelet bij het gebruik van foreach loops

* De foreach iteration variable is _read-only_: je kan dus geen waarden in de array aanpassen, enkel uitlezen.
* De foreach gebruik je enkel als je alle elementen van een array wenst te benaderen. In alle andere gevallen zal je een ander soort loop \(for, while, etc.\) moeten gebruiken.
{% endhint %}

## var keyword

C\# heeft een **`var`** keyword. Je mag dit keyword gebruiken ter vervanging van het type \(bv int\) op voorwaarde dat de compiler kan achterhalen wat het type moet zijn.

```csharp
var getal= 5; //var zal int zijn
var myArray= new double[20]; //var zal double[] zijn
var tekst= "Hi there handsome"; //var zal string zijn
```

{% hint style="warning" %}
**Opgelet**: het `var` keyword is in deze cursus nooit **nodig**. Het vergemakkelijkt het schrijfwerk, want het wordt door de compiler vertaald in een specifiek type. Er zijn scenario's waarin het wel nodig is, maar die zijn meer geavanceerd \("anonieme types"\).
{% endhint %}

Het betekent **niet** hetzelfde als de `var` van JavaScript. In JavaScript hoef je namelijk geen type vast te leggen voor variabelen en kan je dit doen:

```csharp
var something = "hello";
something = 3;
```

In C\# levert dit een compilatiefout. Met de eerste regel zeg je dat de compiler uit de rechterzijde mag afleiden dat `var` hier vervangen kan worden door `string`. Je kan geen waarde `3` in een variabele van type `string` plaatsen, dus dit levert een compilatiefout.

## var en foreach

Wanneer je de Visual Studio [code snippet](https://msdn.microsoft.com/en-us/library/z41h7fat.aspx) voor foreach gebruikt `foreach [tab][tab]` dan zal deze code ook een var gebruiken voor de iteration variabele. De compiler kan aan de te gebruiken array zien wat het type van een individueel element in de array moet zijn. De foreach van zonet kan dus herschreven worden naar:

```csharp
foreach (var boodschap in boodschappen)
{
   Console.WriteLine($"Niet vergeten: {boodschap}");
}
```

