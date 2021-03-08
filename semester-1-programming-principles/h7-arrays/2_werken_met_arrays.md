# Werken met arrays

{% hint style="success" %}
[Kennisclip,](https://youtu.be/ke81v8ePJhA) maar lees onderstaande opmerking
{% endhint %}

{% hint style="danger" %}
In een eerdere versie van de pagina zei ik, en in de kennisclip zeg ik, dat binarysearch -1 teruggeeft als het gezochte element niet voorkomt. Dit is niet altijd waar. Het resultaat is wel altijd een negatief getal als het gezochte element niet voorkomt.
{% endhint %}

## Nuttige array methoden

Net zoals we hebben gezien dat de Math-klasse een heleboel nuttige methoden in zich heeft, zo heeft ook iedere array een aantal methoden waar handig gebruik van gemaakt kan worden.

> ![](../../.gitbook/assets/attention%20%285%29.jpg)
>
> Om deze methoden te kunnen gebruiken moet je bovenaan je file de volgende lijn toevoegen: `using System.Linq;`. Dit staat je toe elementen uit de `Linq` namespace te gebruiken.

```csharp
class Program
{
    public static void Main()
    {
        int[] getallen = new int[101];
        Random ranGen = new Random();
        for(int i = 0; i < getallen.Length; i++) {
            getallen[i] = ranGen.Next(1,1001);
        }
        Console.WriteLine($"De som is: {getallen.Sum()}");
        Console.WriteLine($"Het gemiddelde is: {getallen.Average()}");
    }
}
```

Wanneer je een array hebt gemaakt kan je met de IntelliSense van Visual Studio bekijken wat je allemaal kan doen met de array:

![](../../.gitbook/assets/arrays2%20%282%29.png)

Al deze methoden hier beschrijven zal ons te ver nemen. De volgende methoden zijn echter zeer handig om te gebruiken en hebben een vanzelfsprekende betekenis:

`Max()`, `Min()`, `Sum()` en `Average()`.

Volgende code geeft bijvoorbeeld het grootste getal terug uit een array genaamd "leeftijden":

```csharp
int oudsteleeftijd = leeftijden.Max();
```

## System.Array

Alle C\# arrays erven over van de `System.Array` klasse \(klasse en overerving zien we later\), hierdoor kan je zaken zoals `Length` gebruiken op je array. De `System.Array` klasse heeft echter ook nog een hoop andere nuttige methoden zoals de `BinarySearch()`, `Sort()` en `Reverse()` methoden. Het gebruik hiervan is steeds dezelfde zoals volgende voorbeelden tonen:

### Sort: Arrays sorteren

Om arrays te sorteren roep je de `Sort()`-methode op als volgt, als parameter geef je de array mee die gesorteerd moet worden.

Volgende voorbeeld toont hier het gebruik van:

```csharp
string[] items = {"brood","koffie","fruit"};
Array.Sort(items);

// Toon resultaat van sorteren
// De items zullen alfabetisch getoond worden
for (int i = 0; i < items.Length; i++)
{
    Console.WriteLine(items[i]);
}
```

Wanneer je de Sort-methode toepast op een array van strings dan zullen de elementen alfabetisch gerangschikt worden. Merk op dat je niet meteen iets merkt nadat je `Sort` hebt opgeroepen. Intern zijn er normaal elementen van plaats gewisseld, maar je ziet dit pas als je bijvoorbeeld de elementen afprint.

### Reverse: Arrays omkeren

Met de `Array.Reverse()`-methode kunnen we dan weer de elementen van de array omkeren \(dus het laatste element vooraan zetten en zo verder.

```csharp
Array.Reverse(items);
```

Ook hier zie je pas iets als je de elementen toont.

### BinarySeach: Zoeken in arrays

De `BinarySearch`-methode maakt het mogelijk om te zoeken naar de index van een gegeven element in een index. _Deze methode werkt enkel indien de elementen in de array gesorteerd staan!_ De methode heeft twee parameters, enerzijds de array in kwestie en anderzijds het element dat we zoeken. Als resultaat wordt de index van het gevonden element teruggegeven. Indien niets wordt gevonden zal het resultaat een negatief getal zijn \(dus -1 of kleiner\).

Volgende code zal bijvoorbeeld de index teruggeven van het item `"koffie"` indien dit in de array `items` staat:

```csharp
Array.Sort(items);
Array.BinarySearch(items, "koffie");
```

Volgend voorbeeld toont het gebruik van deze methode:

```csharp
string[] items = {"brood","koffie","fruit"};

Array.Sort(items);
Console.WriteLine("Wil je weten of iets al op je lijstje staat? Geef de naam van het item.");
string item = Console.ReadLine();
int index = Array.BinarySearch(items,item);
if(index >= 0) {
    Console.WriteLine($"{item} staat op het lijstje met index {index}");
}
else {
    Console.WriteLine("staat nog niet op het lijstje");
}
```

## Manueel zoeken in arrays

{% hint style="success" %}
[Kennisclip 2](https://youtu.be/BA-jhGdXIkM)
{% endhint %}

Het zoeken in arrays kan met behulp van `while` of `for`-loops tamelijk snel. Volgend programmaatje gaat zoeken of het getal 12 aanwezig is in de array. Indien ja, dan wordt de index bewaard van de positie in de array waar het getal staat:

```csharp
int teZoekenGetal = 12;

int[] getallen = {5,10,12,25,16};
int index = -1;

for (int i = 0; i < getallen.Length && index == -1; i++)
{
    if (getallen[i] == teZoekenGetal)
    {
        index = i;
    }
}
```

Voorgaande stukje code is één mogelijke oplossing. Bedenk echter wat er gebeurt indien het getal dat we zoeken 2 of meerdere keren in de array staat. Index zal dan de positie bevatten van de eerst gevonden 12 in de array.

#### Manueel zoeken met for en while

We tonen nu een voorbeelden van hoe je kan zoeken in een array wanneer we bijvoorbeeld 2 arrays hebben die "synchroon" zijn. Hiermee wordt bedoeld dat het element op indexpositie `i` in array 1 hoort bij het element op indexpositie `i` in array 2. Bijvoorbeeld: de prijs van de producten staat steeds op dezelfde index in de andere array:

{% hint style="danger" %}
Je kan hier geen gebruik maken van `BinarySearch` omdat dat alleen gaat als je array gesorteerd is. Als je een array met productnamen en een array met bijbehorende prijzen sorteert, horen de elementen op overeenkomstige posities niet noodzakelijk bij elkaar!
{% endhint %}

```csharp
string[] producten = { "appel","peer","citroen" };
double[] prijzen = { 0.65, 0.35, 0.70 };
```

We vragen nu aan de gebruiker van welk product de prijs getoond moet worden:

```csharp
Console.WriteLine("Voor welk product wil je de prijs weten?");
string product = Console.ReadLine();
```

We tonen nu hoe we met `while` eerst het juiste product zoeken en dan vervolgens die index bewaren en gebruiken om de prijs te tonen:

```csharp
int productIndex = -1;
int teller = 0;
// kan ook met for
while (teller < producten.Length && productIndex == -1)
{
    if(producten[teller] == product) {
        productIndex = teller;
    }
    else {
        teller++;
    }
}
if (productIndex != -1)
{
    Console.WriteLine($"Prijs van {product} is {prijzen[productIndex]}");
}
else
{
    Console.WriteLine("Dit product wordt niet te koop aangeboden");
}
```

{% hint style="info" %}
Moet je dit altijd zo doen? Nee, je kan `Array.IndexOf(producten,product)` gebruiken in plaats van de lus. Maar we leggen het uit omdat je dit soort zaken wel moet kunnen schrijven.
{% endhint %}

