# Jagged arrays

Jagged arrays \(letterlijk _gekartelde arrays_\) zijn arrays van arrays maar van verschillende lengte. In tegenstelling tot de eerdere meer-dimensionale arrays moeten de interne arrays steeds dezelfde lengte hebben, bijvoorbeld 3 bij 2 bij 4. Bij jagged arrays hoeft dat dus niet:

![jagged array](../../.gitbook/assets/jagged%20%282%29.png)

## Jagged arrays aanmaken

Het grote verschil bij het aanmaken van bijvoorbeeld een 2D jagged arrays is het gebruik van de vierkante haken:

```csharp
double[][]tickets;
```

\(en dus niet `tickets[,]`\)

Vanaf nu kan je dan individuele arrays toewijzen aan ieder element van ```tickets``:

```csharp
tickets={
   new double[] {3.0, 40, 24},
   new double[] {123 , 31.3 },
   new double[] {2.1}

 };
```

Zoals je kan zien moeten de interne arrays dus niet de zelfde grootte hebben.

## Indexering

De indexering blijft dezelfde, uiteraard moet je er wel rekening mee houden dat niet eender welke index binnen een bepaalde sub-array zal werken. ![indexering bij jagged arrays](../../.gitbook/assets/jagged2%20%282%29.png)

