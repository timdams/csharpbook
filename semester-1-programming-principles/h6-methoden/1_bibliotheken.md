# Documentatie

{% hint style="success" %}
[Kennisclip](https://youtu.be/18YGO18-AAI)
{% endhint %}

Je herkent een methode aan de ronde haakjes na de methodenaam. Je hebt dus reeds een aantal methoden gebruikt zonder dat je het wist, denk maar aan `WriteLine(), ReadLine() en Parse()`.

Dit zijn dus alle 3 methoden: stukken code die een specifieke taak uitvoeren.

Sommige methoden, zoals `WriteLine()`, vereisen dat je een aantal parameters meegeeft. De parameters dien je tussen de ronde haakjes te zetten. Hierbij is het uiterst belangrijk dat je de volgorde respecteert die de ontwikkelaar van de methode heeft gebruikt. Indien je niet weet wat deze volgorde is kan je altijd Intellisense gebruiken. Typ gewoon de methode in je code en stop met typen na het eerste ronde haakje, vervolgens verschijnen alle mogelijke manieren waarop je deze methoden kan oproepen.

![](../../.gitbook/assets/methoden1%20%282%29.png)

Tussen de haakjes zien we welke parameters en hun type je mag meegeven aan de methode, gevolgd door het return-type van de methode en een eventuele beschrijving \(merk dus op dat je de WriteLine-methode ook mag aanroepen zonder parameters, dit zal resulteren in een lege lijn in de console\).

Met behulp van de F1-toets kunnen meer info over de methode in kwestie tonen. Hiervoor dien je je cursor op de Methode in je code te plaatsen, en vervolgens op F1 te drukken.

Voor `WriteLine` geeft dit:

![](../../.gitbook/assets/methoden2%20%282%29.png)

In de overload list zien we de verschillende manieren waarop je de methode in kwestie kan aanroepen. Je kan op iedere methode klikken voor meer informatie en een codevoorbeeld.

## Je eigen methodes documenteren

Als je de juiste documentatie voorziet, kan je bovenstaande ondersteuning ook krijgen voor je eigen methodes. Je doet dit met **XML-comments** als volgt:

```csharp
    /// <summary>
    /// Adds two doubles and returns the result.
    /// </summary>
    /// <returns>
    /// The sum of two doubles.
    /// </returns>
    /// <param name="a">A double precision number.</param>
    /// <param name="b">A double precision number.</param>
    public static double Add(double a, double b)
    {
        return a + b;
    }
```

In de `summary` tag zet je een omschrijving van wat de methode doet. In de `returns` tag leg je uit wat voor resultaat je precies terugkrijgt. De `param` tags leggen uit welke informatie verwacht wordt. Merk op dat je drie slashes schrijft voor dit speciaal soort commentaar in plaats van de gewoonlijke twee.

