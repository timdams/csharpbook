# Bestaande methoden en bibliotheken

Je herkent een methode aan de ronde haakjes na de methodenaam. Je hebt dus reeds een aantal methoden gebruikt zonder dat je het wist, denk maar aan ``WriteLine(), ReadLine() en Parse()``.

Dit zijn dus alle 3 methoden: stukken code die een specifieke taak uitvoeren.

Sommige methoden, zoals ``WriteLine()``, vereisen dat je een aantal parameters meegeeft. De parameters dien je tussen de ronde haakjes te zetten. Hierbij is het uiterst belangrijk dat je de volgorde respecteert die de ontwikkelaar van de methode heeft gebruikt. Indien je niet weet wat deze volgorde is kan je altijd Intellisense gebruiken. Typ gewoon de methode in je code en stop met typen na het eerste ronde haakje, vervolgens verschijnen alle mogelijke manieren waarop je deze methoden kan oproepen.

![](../assets/4_methoden/methoden1.png)

Tussen de haakjes zien we welke parameters en hun type je mag meegeven aan de methode, gevolgd door het return-type van de methode en een eventuele beschrijving (merk dus op dat je de WriteLine-methode ook mag aanroepen zonder parameters, dit zal resulteren in een lege lijn in de console).

Met behulp van de F1-toets kunnen meer info over de methode in kwestie tonen. Hiervoor dien je je cursor op de Methode in je code te plaatsen, en vervolgens op F1 te drukken.

Voor ``WriteLine`` geeft dit:

![](../assets/4_methoden/methoden2.png)

In de overload list zien we de verschillende manieren waarop je de methode in kwestie kan aanroepen. Je kan op iedere methode klikken voor meer informatie en een codevoorbeeld.


## Intellisense
"Hoe kan je deze methode nu gebruiken?" is een veelgestelde vraag. Zeker wanneer je de basis van C# onder knie hebt en je stilletjes aan met bestaande .NET bibliotheken wil gaan werken. Wat volgt is een essentieel onderdeel van VS dat veel gevloek en tandengeknars zal voorkomen.

De help-files van VS zijn zeer uitgebreid en dankzij IntelliSense krijg je ook aardig wat informatie tijdens het typen van de code zelf.

Type daarom onder vorige WriteLine-zin het volgende:

```csharp
System.Console.
```

Wacht nu even en er zal na het punt (``.``) een lijst komen van methoden en fields die beschikbaar zijn. Je kan hier met de muis doorheen scrollen en zo zien welke methoden allemaal bij de Console klasse horen.

![](../assets/4_methoden/methoden4.png)

Scroll maar eens naar de WriteLine-methode en klik er op. Je krijgt dan extra informatie over die methode te zien:

![](../assets/4_methoden/methoden5.png)

Doe hetzelfde voor de ReadLine methode:

![](../assets/4_methoden/methoden6.png)

Je ziet bovenaan ``string Console.ReadLine()``  staan. Bij de WriteLine stond er ``void Console.WriteLine()``. Die void wil zeggen dat de methode WriteLine niets terugstuurt. In tegenstelling tot ReadLine dat een string teruggeeft. Indien de methode één of meerdere parameters vereist dan zullen deze hier ook getoond worden:

![](../assets/4_methoden/methoden7.png)

De ``Math.Pow`` methode vereist dus bijvoorbeeld 2 parameters van het type double. Wanneer je nu begint te typen dan zal intellisense tonen waarvoor iedere parameter staat wanneer je aan die parameter gaat beginnen typen:

![](../assets/4_methoden/methoden8.png)


