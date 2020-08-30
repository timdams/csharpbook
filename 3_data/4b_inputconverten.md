## Invoer van de gebruiker verwerken

En applicatie die geen input van de gebruiker vergt kan even goed een screensaver zijn. We hebben reeds gezien hoe we met ``Console.ReadLine()`` de gebruiker tekst kunnen laten invoeren en die we dan vervolgens kunnen verwerken om bijvoorbeeld z'n naam op het scherm te tonen:


![Deze vereenvouding van de meeste van onze applicatie blijft gelden](../assets/1_csharpbasics/inuit.png)

**De uitdaging met ``ReadLine`` is dat deze ALTIJD een string teruggeeft:**

```java
string userInput= Console.ReadLine();
```

Willen we dat de gebruiker een getal invoert, bijvoorbeeld z'n leeftijd, dan zullen dit nog steeds als ``string`` moeten opvangen **en vervolgens CONVERTEREN**  (dit mag dus niet: ``int userInput= Console.ReadLine();`` en zal in een conversion error resulteren).

Invoer van de gebruiker verwerken (dat een andere type dan ``string`` moet zijn) zal dus uit 3 stappen bestaan:
1. Input **uitlezen** met ``Console.ReadLine()``
2. Input **bewaren** in een ``string`` variabele
3. De variabele **converteren** met ``Convert.`` bibliotheek naar het gewenste type


### Input converteren 
Om strings naar een ander type te converteren gebruiken we best de Convert.-bibliotheek (maar ``.Parse()`` kan ook). De volgende code zal je dus erg vaak moeten schrijven. 

Stel dat we aan de gebruiker z'n gewicht vragen, dan moeten we dus doen:

```java
Console.WriteLine("Geef je gewicht:");
string inputGewicht= Console.ReadLine();
double gewicht= Convert.ToDouble(inputGewicht);
```

<!---{pagebreak} --->

Voorgaande code kan nog 1 lijntje sneller door ``ReadLine`` ogenblikkelijk als invoer aan de Convert-methode te geven:

```java
Console.WriteLine("Geef je gewicht:");
double gewicht= Convert.ToDouble(Console.ReadLine());
```

![Schematisch overzicht: ReadLine=>Conversie](../assets/2_beslissingen/readline.png)

### Foutloze input
Voorgaande code veronderstelt dat de gebruiker géén fouten invoert. De conversie zal namelijk mislukken indien de gebruiker bijvoorbeeld  ``IKWEEG10KG`` invoert in plaats van ``10,3``.

De komende hoofdstukken mag je er altijd van uitgaan dat de gebruiker foutloze input geeft.


{% hint style='warning' %}
De invoer van kommagetallen door de gebruiker is afhankelijk van de landinstellingen van je besturingssysteem. Staat deze in Belgisch/Nederlands dan moet je kommagetallen met een **KOMMA**(``,``) invoeren (dus ``9,81``), staat deze in het Engels dan moet je een **PUNT**(``.``) gebruiken (``9.81``).
{% endhint %}


{% hint style='warning' %}
**In je C# code moet je doubles altijd met een punt schrijven**. Dit is onafhankelijk van je taalinstellingen.
{% endhint %}

{% hint style='tip' %}
En wat als je toch foute invoer wilt opvangen? Zoals eerder aangegeven: dan is ``TryParse`` je vriend (zie appendix).
{% endhint %}
