## System.Array

Je kan de ``System.Array`` bibliotheek gebruiken om je array-code te vereenvoudigen.Deze bibliotheek bevat naast de ``.Length`` eigenschap, ook enkele nuttige methoden zoals ``BinarySearch()``, ``Sort()``, ``Copy`` en ``Reverse()``. Het gebruik hiervan is bijna steeds dezelfde zoals volgende voorbeelden tonen.

{% hint style='tip' %}
De eerste zin is een vereenvoudiging, wat we in het volgende boekdeel zullen ontdekken. Technisch gezien erven alle arrays over van ``System.Array`` omdat dit niet een bibliotheek, maar een *klasse* is.
{% endhint %}

### Sort: Arrays sorteren
Om arrays te sorteren roep je de ``Sort()``-methode op en geef je als parameter de array mee die gesorteerd moet worden. Volgende voorbeeld toont hier het gebruik van:

```java
string[] myColors = {"red", "green", "yellow", "orange", "blue"};
Array.Sort(myColors); //Sorteren maar
//Toon resultaat van sorteren
for (int i = 0; i < myColors.Length; i++)
{
    Console.WriteLine(myColors[i]);
}
```

Wanneer je de Sort-methode toepast op een array van strings dan zullen de elementen alfabetisch gerangschikt worden. Uiteraard werkt dit ook op arrays van andere datatypes, zolang C# maar weet hoe dit type gesorteerd moet worden (getallen van klein naar groot, tekst volgens de regels van het alfabet, enums volgens hun interne voorstelling).

### Reverse: Arrays omkeren

Met de ``Array.Reverse()``-methode kunnen we dan weer de volgorde van de elementen van de array omkeren (dus het laatste element vooraan zetten en zo verder):

```java
Array.Reverse(myColors);
```

<!---{pagebreak} --->

### Clear: Arrays leegmaken
Een array volledig leegmaken (alle elementen op hun standaard waarde zetten (bv. ``0`` bij ``int`` of ``false`` bij ``bool``)) doe je met de ``Array.Clear()``-methode, als volgt:

```java
Array.Clear(myColors);
```


### Copy : array by value kopiëren

De ``.Copy()`` behelst iets meer werk, daar deze methode
* een reeds aangemaakte, nieuwe array nodig heeft waar naar gekopiëerd moet worden.
* moet meekrijgen hoe lang de bronarray (*source*) is, of hoeveel elementen uit de bronarray moeten gekopiëerd worden.

Volgende voorbeeld toont hoe we alle elementen uit ``myColors`` kunnen kopiëren naar een nieuwe array ``copyColors``. De eerste parameter is de bron-array, dan de doel-array en finaal het aantal elementen dat moet gekopiëerd worden:

```java
string[] myColors = { "red", "green", "yellow", "orange", "blue" };
string[] copyColors = new string[myColors.Length];
Array.Copy(myColors, copyColors, myColors.Length);
```

Willen we enkel de eerste twee elementen kopiëren dan zou dat er als volgt uitzien:
```java
Array.Copy(myColors, copyColors, 2);
```

{% hint style='tip' %}
Bekijk zeker ook de overloaded versies die de ``.Copy()`` methode heeft. Zo kan je ook een bepaald stuk van een array kopiëren en ook bepalen waar in de doel array dit stuk moet komen.
{% endhint %}

<!---{pagebreak} --->

### BinarySeach: Zoeken in arrays

De ``BinarySearch``-methode maakt het mogelijk om te zoeken naar de index van een gegeven element in een array. 

{% hint style='warning' %}
**De ``BinarySeach``-methode werkt enkel indien de elementen in de array gesorteerd staan!**
{% endhint %}

Je geeft aan de methode 2 parameters mee: enerzijds de array in kwestie en anderzijds het element dat we zoeken. Als resultaat wordt de index van het gevonden element teruggegeven. Indien niets wordt gevonden zal het resultaat -1 zijn.

Volgende code zal bijvoorbeeld de index teruggeven van de kleur "red" indien deze in de array ``myColors`` staat:

```java
int indexRed = Array.BinarySearch(myColors, "red");
```

Volgend voorbeeld toont het gebruik van deze methode:

```java
int[] metingen = {224, 34, 156, 1023, -6};
Array.Sort(metingen); //anders zal BinarySearch niet werken

Console.WriteLine("Welke meting zoekt u?");
int keuze = Convert.ToInt32(Console.ReadLine());

int index = Array.BinarySearch(metingen, keuze);
if(index >= 0)
    Console.WriteLine($"{keuze} gevonden op {index}");
else
    Console.WriteLine("Niet gevonden");
```