## Meer-dimensionale Arrays
Voorlopig hebben we enkel met 1-dimensionale array gewerkt. Je kan er echter ook meerdimensionale maken. Denk maar aan een n-bij-m array om een matrix voor te stellen.

Door een komma tussen rechte haakjes te plaatsen tijdens de declaratie kunnen we meer-dimensionale arrays maken. 

Bijvoorbeeld 2D:

```csharp
string[,] books;
```

3D:
```csharp
short[,,] temperatures;
```
(enz.)

Om een array ook onmiddellijk te initialiseren gebruiken we dan volgende uitdrukking:

```csharp
string[,] books = {
        {"Macbeth", "Shakespeare", "ID12341"},
        {"Before I Get Old", "Dave Marsh", "ID234234"},
        {"Security+", "Mike Pastore", "ID3422134"}
    };
```

Merk op dat we dus nu een 3 bij 3 array maken. Iedere rij bestaat uit 3 elementen.

OF bij een 3D:
```csharp
int[,,] temperatures= {
    {
        {3,4}, {5,4}
    },
    {
        {12,34}, {35,24}
    },
    {
        {-12,27}, {3,24}
    },
};
```

Stel dat we uit de books-array bijvoorbeeld de auteur van het derde boek wensen te tonen dan kunnen we schrijven:

```csharp
Console.WriteLine(books[2, 1]);
```

Dit zal ``Mike Pastore`` op het scherm zetten.

En bij de temperaturen:
```csharp
Console.WriteLine(temperatures[2, 0, 1]);
```
Zal ``27`` terug geven: we vragen van de laatste array (``[2]``), daarbinnenin de eerste array (``[0]``) en daarvan het tweede (``[1]``) element.

## Lengte van iedere dimensie in een n-dimensionale matrix

Indien je de lengte opvraagt van een meer-dimensionale array dan krijg je de som van iedere lengte van iedere dimensie. Onze books array zal bijvoorbeeld dus lengte 9 hebben. Je kan echter de lengte van iedere aparte dimensie te weten komen met de GetLength() methode die iedere array heeft. Als parameter geef je de dimensie mee waarvan je de lengte wenst.

```csharp
int arrayRijen = books.GetLength(0);
int arrayKolommen = books.GetLength(1);
```
Het aantal dimensies van een array wordt trouwens weergegeven door de rank eigenschap die ook iedere array heeft. Bijvoorbeeld:

```csharp
int arrayDimensions = myColors.Rank;
```
