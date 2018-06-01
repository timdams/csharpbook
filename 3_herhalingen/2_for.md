# For

## Intro
Een veelvoorkomende manier van while-loops gebruiken is waarbij je een bepaalde teller bijhoudt die je telkens met een bepaalde waarde verhoogt. Wanneer de teller een bepaalde waarde bereikt moet de loop afgesloten worden.

Bijvoorbeeld volgende code om alle even getallen van 0 tot 10 te tonen:

```csharp
int k = 0;
while(k<11)
{
    Console.WriteLine(k);
    k = k + 2;
}
```
## For syntax
Met een for-loop kunnen we deze veel voorkomende code-constructie verkort schrijven, met volgende algemene syntax:

```csharp
for (setup; finish test; update)
{
    // C# code to be performed while finish test evaluates to true
}
```

Gebruiken we deze kennis nu, dan kunnen we de eerder vermelde code om de even getallen van 0 tot en met 10 tonen als volgt:

```csharp
for (int i = 0; i < 11; i = i + 2)
{
    Console.WriteLine(i);
}
```
Voor de setup-variabele kiest men meestal i, maar dat is niet noodzakelijk. In de setup wordt dus een variabele op een start-waarde gezet. De finish test zal aan de start van iedere loop kijken of de finish test nog waar is, indien dat het geval is dan wordt een nieuwe loop gestart en wordt i met een bepaalde waarde, zoals in update aangegeven, verhoogd.
