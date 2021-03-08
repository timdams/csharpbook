# Input verwerken en omzetten

## Input van de gebruiker verwerken

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/DGhdggwcdDk)
{% endhint %}

{% hint style="info" %}
Dit hoofdstuk is niet lang, maar het is wel een zeer belangrijk aspect van console-applicaties!
{% endhint %}

En applicatie die geen input van de gebruiker vergt kan even goed een screensaver zijn. We hebben reeds gezien hoe we met `Console.ReadLine()` de gebruiker tekst kunnen laten invoeren en die we dan vervolgens kunnen verwerken om bijvoorbeeld z'n naam op het scherm te tonen.

**De uitdaging met `ReadLine` is dat deze altijd een string teruggeeft:**

```csharp
string userInput = Console.ReadLine();
```

Willen we dat de gebruiker een getal invoert, bijvoorbeeld z'n leeftijd, dan zullen dit nog steeds als `string` moeten opvangen **en vervolgens converteren**.

User input verwerken \(die een ander type dan `string` moet zijn\) omvat dus:

* Input **uitlezen** met `Console.ReadLine()`
* Het resultaat van `ReadLine` converteren

## Input converteren

Om strings naar een ander type te converteren gebruiken we best de Convert-klasse. De volgende code zal je dus erg vaak moeten schrijven. Stel dat we aan de gebruiker z'n gewicht vragen, dan moeten we dus doen:

```csharp
Console.WriteLine("Geef je gewicht");
string inputGewicht = Console.ReadLine();
double gewicht = Convert.ToDouble(inputGewicht);
```

## Foutloze input

Voorgaande code veronderstelt dat de gebruiker géén fouten invoert. De conversie zal namelijk mislukken indien de gebruiker bijvoorbeeld `IKWEEG10KG` invoert in plaats van `10,3`.

De komende hoofdstukken **moet** je er altijd van uitgaan dat de gebruiker foutloze input geeft. Later leer je wel hoe je dit kan afhandelen.

{% hint style="warning" %}
**Opgelet**: de invoer van kommagetallen door de gebruiker is afhankelijk van de landinstellingen van je besturingssysteem. Staat deze in Belgisch/Nederlands dan moet je kommagetallen met een **KOMMA**\(`,`\) invoeren \(dus `9,81`\), staat deze in het Engels dan moet je een **PUNT**\(`.`\) gebruiken \(`9.81`\).
{% endhint %}

{% hint style="warning" %}
**Opgelet 2**: In je C\# code moet je doubles ALTIJD met een punt schrijven. Dit is onafhankelijk van je taalinstellingen.
{% endhint %}

