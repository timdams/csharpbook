# Input van de gebruiker verwerken
> Dit hoofdstuk zal niet lang zijn, maar het is wel een zeer belangrijk aspect van console-applicaties!

En applicatie die geen input van de gebruiker vergt kan even goed een screensaver zijn. We hebben reeds gezien hoe we met ``Console.ReadLine()`` de gebruiker tekst kunnen laten invoeren en die we dan vervolgens kunnen verwerken om bijvoorbeeld z'n naam op het scherm te tonen.

**De uitdaging met ``ReadLine`` is dat deze ALTIJD een string teruggeeft:**
```csharp
string userInput= Console.ReadLine();
```
Willen we dat de gebruiker een getal invoert, bijvoorbeeld z'n leeftijd, dan zullen dit nog steeds als ``string`` moeten opvangen **en vervolgens CONVERTEREN**. 

User input verwerken (dat een andere type dan string moet zijn) bestaat dus uit 3 stappen:
* Input uitlezen met ``Console.ReadLine()``
* Input bewaren in een ``string`` variabele
* De variabele converteren met ``Convert.`` bibliotheek naar het gewenste type

# Input converteren 
Om strings naar een ander type te converteren gebruiken we best de Convert.-bibliotheek (maar ``.Parse()`` kan ook). De volgende code zal je dus erg vaak moeten schrijven. 
Stel dat we aan de gebruiker z'n gewicht vragen, dan moeten we dus doen:
```csharp
Console.WriteLine("Geef je gewicht");
string inputGewicht= Console.ReadLine();
double gewicht= Convert.ToDouble(inputGewicht);
```


# Foutloze input
Voorgaande code veronderstelt dat de gebruiker géén fouten invoert. De conversie zal namelijk mislukken indien de gebruiker bijvoorbeeld  ``IKWEEG10KG`` invoert in plaats van ``10,3``.

De komende hoofdstukken **moet**  je er altijd van uitgaan dat de gebruiker foutloze input geeft.

**Opgelet**: de invoer van kommagetallen door de gebruiker is afhankelijk van de landinstellingen van je besturingssysteem. Staat deze in Belgisch/Nederlands dan moet je kommagetallen met een **KOMMA**(``,``) invoeren (dus ``9,81``), staat deze in het Engels dan moet je een **PUNT**(``.``) gebruiken (``9.81``).

**Opgelet 2**: In je C# code moet je doubles ALTIJD met een punt schrijven. Dit is onafhankelijk van je taalinstellingen.


# Fouten in input
En wat als je toch foute invoer wilt opvangen? Dan is ``TryParse`` je vriend. We zullen dit bespreken wanneer we aan Methoden komen. Ongeduldig? [Lees hier alles over TryParse](https://www.dotnetperls.com/parse).

