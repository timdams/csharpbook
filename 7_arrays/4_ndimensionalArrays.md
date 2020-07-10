## Meer-dimensionale Arrays
Voorlopig hebben we enkel met zogenaamde 1-dimensionale arrays gewerkt. Je kan er echter ook meerdimensionale array maken. Denk maar aan een n-bij-m array om een matrix voor te stellen.

{% hint style='tip' %}
We behandelen meerdimensionale arrays maar komt om de eenvoudige reden dat je die in de praktijk minder vaak zal nodig hebben.
{% endhint %}

Door een komma tussen rechte haakjes te plaatsen tijdens de declaratie van een array kunnen we meer-dimensionale arrays maken. 

Bijvoorbeeld om een 2D array te maken schrijven we:

```csharp
string[,] books;
```

Een 3D-array:
```csharp
short[,,] temperatures;
```
(enz.)

{% hint style='tip' %}
Ja, dit kan dus ook

```csharp
int[,,,,,,,,,,,] jeBentGekAlsJeHierMeeWiltWerken;
```
{% endhint %}

## Initialisatie

Ook om nu effectief een array aan te maken gebruiken we de komma-notatie, alleen moeten we nu ook de effectieve groottes aangeven. Voor en 5 bij 10 array bijvoorbeeld schrijven we (merk op dat dit dus een 2D-array is):

```csharp
int[,] matrix= new int[5,10];
```

Om een array ook onmiddellijk te initialiseren met waarden gebruiken we de volgende uitdrukking :

```csharp
string[,] books = {
        {"Macbeth", "Shakespeare", "ID12341"},
        {"Before I Get Old", "Dave Marsh", "ID234234"},
        {"Security+", "Mike Pastore", "ID3422134"}
    };
```

Merk op dat we dus nu een 3 bij 3 array maken maar dat dit dus nog steeds een 2D-array is. Iedere rij bestaat uit 3 elementen. We maken letterlijk een array van arrays.

Of bij een 3D:
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
{% hint style='tip' %}
Zoals je ziet worden meerdimensionale arrays snel een kluwen van komma's, accolades en haakjes. Probeer dus je dimensies te beperken. Je zal zelden een 3 -of meer dimensionale array nodig hebben. De regel is eenvoudig: als je een 7-dimensionale array nodig hebt is de kans groot dat je een  volledig verkeerd algoritme hebt verzonnen of dat je nog niet aan het tweede deel van dit boek bent begonnen. 
{% endhint %}

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

### Lengte van iedere dimensie in een n-dimensionale matrix

Indien je de lengte opvraagt van een meer-dimensionale array dan krijg je de som van iedere lengte van iedere dimensie. Onze books array zal bijvoorbeeld dus lengte 9 hebben (3*3) en temperatures heeft lengte 12 (3x2x2). 
Je kan echter de lengte van iedere aparte dimensie te weten komen met de ``.GetLength()`` methode die iedere array heeft. Als parameter geef je de dimensie mee waarvan je de lengte wenst:

```csharp
int arrayRijen = books.GetLength(0);
int arrayKolommen = books.GetLength(1);
```
Het aantal dimensies van een array wordt trouwens weergegeven door de ``.Rank`` eigenschap die ook iedere array heeft. Bijvoorbeeld:

```csharp
Console.WriteLine(myColors.Rank);
```

## Einde deel 1
![](../assets/me.png)
>Wel, je hebt het tot hier gehaald! Mooi zo. Heb je het gevoel dat je C# al een beetje begint door te krijgen?  Hopelijk wel. Je zou nu lekker nieuwsgierig naar het volgende deel kunnen gaan, maar dat is niet aan te raden. Probeer jezelf er van te verzekeren dat je de materie van dit deel zeer goed in de vingers hebt voor je verder gaat. Dit deel was letterlijk de fundering van het gebouw en het deel hierna is een verdieping erbovenop, dat enkel zal blijven staan als de fundering echt grondig gemaakt is.

![](../assets/attention.png)
>Mag ik er even op wijzen dat funderingen en andere bouw-gerelateerde termen mijn goto-woorden zijn als ik iets uitleg?!

![](../assets/gotopolice.png)
>Awel awel? Zei er hier iemand ``goto``!!

![](../assets/me.png)
>Zucht. Anyhow. Hopelijk laat je nog even dit deel dus in je brein inwerken, maak je er veel oefeningen op en pas wanneer je het gevoel hebt dat je methoden, arrays en loops grondig begrijpt mag je continueren in dit boek.

![](../assets/gotopolice.png)
>Ella! Opletten met ```continue`` he. En zeker met ``break``! 

![](../assets/me.png)
>"Goto hell!"