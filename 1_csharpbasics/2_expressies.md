# Expressies

Zonder expressies is programmeren saai: je kan dan enkel variabelen aan mekaar toewijzen. Expressies zijn als het ware eenvoudige tot complexe sequenties van bewerkingen die resulteren tot 1 resultaat. De volgende code is bijvoorbeeld een expressie: `3+2`

Het resultaat van deze expressie is 5. [Meer informatie over expressies hier](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expressions).

## Expressie-resultaat toewijzen

Meestal zul je expressies schrijven waarin je bewerkingen op en met variabelen uitvoert. Vervolgens zal je het resultaat van die expressie willen bewaren voor verder gebruik in je code.

Voorbeeld van **expressie**-resultaat toekennen:

```csharp
int temperatuursVerschil = temperatuurGisteren - temperatuurVandaag;
```

Hierbij zal de temperatuur uit de rechtse 2 variabelen worden uitgelezen, van mekaar wordt afgetrokken en vervolgens bewaard worden in temperatuursVerschil.

De voorgaande code kan ook langer geschreven worden als:

```csharp
int tussenResultaat = temperatuurGisteren - temperatuurVandaag;
int temperatuursVerschil = tussenResultaat;
```

Een ander voorbeeld van en expressie-resultaat toewijzen maar nu met literal \(stel dat we temperatuursVerschil reeds hebben gedeclareerd eerder\):

```csharp
temperatuursVerschil = 21 - 25;
```

Uiteraard mag je ook combinaties van literals en variabelen gebruiken in je expressies:

```csharp
int breedte = 15;
int hoogte = 20 * breedte;
```



