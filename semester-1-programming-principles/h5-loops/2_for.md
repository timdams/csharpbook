# For

## For

{% hint style="success" %}
[Kennisclip](https://youtu.be/ZlpqH51X-tM)
{% endhint %}

Een veelvoorkomende manier van while-loops gebruiken is waarbij je een bepaalde teller bijhoudt die je telkens met een bepaalde waarde verhoogt. Wanneer de teller een bepaalde waarde bereikt moet de loop afgesloten worden.

Bijvoorbeeld volgende code om alle even getallen van 0 tot 10 te tonen:

```csharp
int k = 0;
while(k < 11)
{
    Console.WriteLine(k);
    k = k + 2;
}
```

**Met een for-loop kunnen we deze veel voorkomende code-constructie verkort schrijven.**

### For syntax

De syntax van een `for`-loop is de volgende:

```csharp
for (setup; test; update)
{
    // C# die zal uitgevoerd worden zolang de finish test true geeft
}
```

* **setup**: In het setup gedeelte zetten we een "wachtervariabele" of "indexvariabele" op de gewenste beginwaarde. De wachtervariabele is de variabele die we tijdens de loop in het oog zullen houden en die zal bepalen hoe vaak de loop moet uitgevoerd worden.
* **test**: Hier plaatsen we een booleaanse expressie die \(**normaal**\) de wachter-variabele uit de setup gebruikt om te testen of de loop-code moet uitgevoerd worden.
* **update**: Hier plaatsen we wat er moet gebeuren telkens de loop z'n codeblock heeft uitgevoerd. Meestal zullen we hier de wachter-variabele verhogen of verlagen.

![](../../.gitbook/assets/for%20%283%29.png)

Gebruiken we deze kennis nu, dan kunnen we de eerder vermelde code om de even getallen van 0 tot en met 10 tonen als volgt:

```csharp
for (int i = 0; i < 11; i += 2)
{
    Console.WriteLine(i);
}
```

Voor de indexvariabele kiest men meestal `i`, maar dat is niet noodzakelijk. In de setup wordt dus een variabele op een start-waarde gezet. De test zal aan de start van iedere loop kijken of de voorwaarde nog waar is, indien dat het geval is dan wordt een nieuwe loop gestart en wordt i met een bepaalde waarde, zoals in update aangegeven, verhoogd.



