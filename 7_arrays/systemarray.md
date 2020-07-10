## System.Array

Alle C# arrays erven over van de ``System.Array`` klasse (klassen en overerving zien we in het volgende deel), hierdoor kan je zaken zoals ``.Length`` gebruiken op je array. 
De ``System.Array`` klasse heeft echter ook nog een hoop andere nuttige methoden zoals de ``BinarySearch()``, ``Sort()``, ``Copy`` en ``Reverse()`` methoden. Het gebruik hiervan is steeds dezelfde zoals volgende voorbeelden tonen:

### Sort: Arrays sorteren
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

Uiteraard werkt dit ook op arrays van andere datatypes.

### Reverse: Arrays omkeren

Met de ``Array.Reverse()``-methode kunnen we dan weer de volgorde van de elementen van de array omkeren (dus het laatste element vooraan zetten en zo verder):

```csharp
Array.Reverse(myColors);
```

### Clear: Arrays leegmaken
Een array volledig leegmaken (alle elementen op hun standaard waarde zetten (bv ``0`` bij ``int`` of ``false`` bij ``bool``)) doe je met de ``Array.Clear()``-methode, als volgt:

```csharp
Array.Clear(myColors);
```

### Copy : array by value kopieren

De ``.Copy()`` behelst iets meer werk, daar deze methode
* een reeds aangemaakte, nieuwe array nodig heeft waar naar gekopiëerd moet worden.
* met meekrijgen hoe lang de bronarray is , of hoeveel elementen uit de bron array moeten gekopiëerd worden

Volgende voorbeeld toont hoe we alle elementen uit ``myColors`` kunnen kopiëren naar een nieuwe array ``copyColors``. De eerste parameter is de bron-array, dan de doel-array en finaal het aantal elementen dat moet gekopiëerd worden:

```csharp
string[] myColors = { "red", "green", "yellow", "orange", "blue" };
string[] copyColors = new string[myColors.Length];
Array.Copy(myColors, copyColors, myColors.Length);
```

Willen we enkel de eerste twee elementen kopieren dan zou dat er als volgt uitzien:
```csharp
Array.Copy(myColors, copyColors, 2);
```

{% hint style='tip' %}
Bekijk zeker ook de overloaded versies die de ``.Copy()`` methode heeft. Zo kan je ook een bepaald stuk van een array kopieren en ook bepalen waar in de doel array dit stuk moet komen.
{% endhint %}

### BinarySeach: Zoeken in arrays

De ``BinarySearch``-methode maakt het mogelijk om te zoeken naar de index van een gegeven element in een index. 

{% hint style='warning' %}
**Deze methode werkt enkel indien de elementen in de array gesorteerd staan!**
{% endhint %}

Je geeft aan de methode 2 parameters mee, enerzijds de array in kwestie en anderzijds het element dat we zoeken. Als resultaat wordt de index van het gevonden element teruggegeven. Indien niets wordt gevonden zal het resultaat -1 zijn.

Volgende code zal bijvoorbeeld de index teruggeven van de kleur "red" indien deze in de array ``myColors`` staat:

```csharp
Array.BinarySearch(myColors, "red");
```

Volgend voorbeeld toont het gebruik van deze methode:

```csharp
int[] rank = {224, 34, 156, 1023, -6};
Array.Sort(rank); //anders zal BinarySearch niet werken

Console.WriteLine("What rank do you need?");
int userchoice = Convert.ToInt32(Console.ReadLine());

int index = Array.BinarySearch(rank, userchoice);
if(index >= 0)
    Console.WriteLine($"{userchoice} found at index {index}");
else
    Console.WriteLine("Not found");
```