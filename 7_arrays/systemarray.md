
Alle C# arrays erven over van de ``System.Array`` klasse (klasse en overerving zien we later dit semester), hierdoor kan je zaken zoals ``Length`` gebruiken op je array. De ``System.Array`` klasse heeft echter ook nog een hoop andere nuttige methoden zoals de ``BinarySearch()``, ``Sort()`` en ``Reverse()`` methoden. Het gebruik hiervan is steeds dezelfde zoals volgende voorbeelden tonen:

# Sort: Arrays sorteren
Om arrays te sorteren roep je de ``Sort()``-methode op als volgt, als parameter geef je de array mee die gesorteerd moet worden.

Volgende voorbeeld toont hier het gebruik van:

```csharp
string[] myColors = {"red", "green", "yellow", "orange", "blue"};
//Sorteer
Array.Sort(myColors);
 
//Toon resultaat van sorteren
for (int i = 0; i < myColors.Length; i++)
{
    Console.WriteLine(myColors[i]);
}
```
Wanneer je de Sort-methode toepast op een array van strings dan zullen de elementen alfabetisch gerangschikt worden.

# Reverse: Arrays omkeren
Met de ``Array.Reverse()``-methode kunnen we dan weer de elementen van de array omkeren (dus het laatste element vooraan zetten en zo verder:

```csharp
Array.Reverse(myColors);
```

## Clear: Arrays leegmaken
Een array volledig leegmaken (alle elementen op ‘null’ zetten) doe je met de ``Array.Clear``-methode, als volgt:

```csharp
Array.Clear(myColors);
```

# BinarySeach: Zoeken in arrays

De ``BinarySearch``-methode maakt het mogelijk om te zoeken naar de index van een gegeven element in een index. 

{% hint style='warning' %}
*Deze methode werkt enkel indien de elementen in de array gesorteerd staan!* 
{% endhint %}

Je geeft aan de methode 2 parameters mee, enerzijds de array in kwestie en anderzijds het element dat we zoeken. Als resultaat wordt de index van het gevonden element teruggegeven. Indien niets wordt gevonden zal het resultaat -1 zijn.

Volgende code zal bijvoorbeeld de index teruggeven van de kleur "red" indien deze in de array ``myColors`` staat:

```csharp
Array.BinarySearch(myColors, "red");
```

Volgend voorbeeld toont het gebruik van deze methode:

```csharp
int[] rank = {224, 34, 156, 1023, -6};
Array.Sort(rank);

Console.WriteLine("What rank do you need?");
int userchoice = Convert.ToInt32(Console.ReadLine());

int index = Array.BinarySearch(rank, userchoice);
if(index >= 0)
    Console.WriteLine($"{userchoice} found at index {index}");
else
    Console.WriteLine("Not found");
```

## Copy : Array kopieren

In het vorige hoofdstuk vertelden we reeds over het venijn van arrays kopiëren, daar deze 'by reference' worden bewaard. Lijn 2 in deze code creëert dus enkel een alias naar dezelfde array en geen kopie:

```csharp
int[] arrayA = {1, 2, 3};
int[] arrayB = arrayA; //Sure?!
```

Willen we een kopie dan moet dit dus zoals in vorige hoofdstuk manueel gebeuren, of je maakt gebruikt van de ``Array.Copy()`` methode, als volgt:

```csharp
int[] ar = {1, 2, 3};
int[] bar = new int[ar.Length];
Array.Copy(ar, bar, ar.Length);
```

De methode ``Array.Copy`` vereist minimaal 3 parameters, waaronder de originele array, de doel array (die reeds moet aangemaakt zijn!) alsook hoeveel elementen je uit de originele array wenst te kopieren. Bekijk zeker ook de overloaded versies die deze methode heeft. Zo kan je ook een bepaald stuk van een array kopieren en ook bepalen waar in de doel array dit stuk moet komen.