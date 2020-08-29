# Generics
Talen als C# bieden goede mogelijkheden voor strong typing. Dit houdt in dat de compiler tijdens het compileren weet van welk type een variabele is en daardoor welke methoden en properties daarvoor beschikbaar zijn. Dit is gewenst, omdat op deze wijze de compiler goed kan controleren of er geen methoden worden aangeroepen die niet bestaan voor een bepaald type. Hoe meer compile-time gecontroleerd kan worden, hoe minder risico er is op fouten (bv exceptions) die pas at run-time naar voren komen. 

Run-time fouten zijn lastiger te detecteren, omdat deze alleen optreden op het moment dat de "foute" regel code uitgevoerd wordt en dus alleen door middel van testen en gebruik van het systeem boven water kunnen komen wat dus vaak resulteert in bugs. Via generieke klassen kunnen we aan strong typing doen en zo al een groot deel van potentiele problemen at compile-time opvangen. [Bron](http://www.sdn.nl/SDN/Artikelen/tabid/58/view/View/ArticleID/1668/Generic-Programming-in-C-20.aspx)

# Generieke methoden
Vaak schrijf je methoden die hetzelfde doen, maar waarvan enkel het type van de parameters en/of het returntype verschilt. Stel dat je een methode hebt die de elementen in een array onder elkaar toont. Je wil dit werkende hebben voor arays van ints, string, etc. Zonder generics moeten we dan per type een methode schrijven:

```java
public static void ToonArray(int[] array)
{
    foreach (var i in array)
    {
        Console.WriteLine(i);
    }
}
 
public static void ToonArray(string[] array)
{
    foreach (var i in array)
    {
        Console.WriteLine(i);
    }
}
```
Dankzij generics kunnen we nu het deel dat *generiek* moet zijn aanduiden (in dit geval met ``T``) en onze methode eenmalig definiëren:

```java
public static void ToonArray<T>(T[] array)
{
    foreach (T i in array)
    {
        Console.WriteLine(i);
    }
}
```

# Generic types
In het volgende codevoorbeeld is te zien hoe een eigen generic struct in C# gedefinieerd en gebruikt kan worden. Merk het gebruik van de aanduiding T , deze geeft aan dat hier een type (zoals int, double, Student,etc.) zal worden ingevuld tijdens het compileren.

## <T>
De typeparameter T wordt pas voor de specifieke instantie van de generieke klass of type ingevuld bij het compileren. Hierdoor kan de compiler per instantie controleren of alle parameters en variabelen die in samenhang met het generieke type gebruikt worden wel kloppen.

De afspraak is om .NET een T te gebruiken indien het type nog dient bepaald te worden (dit is niet verplicht).
[Meer info](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/introduction-to-generics)

## Voorbeeld generic type
We wensen een ``struct`` te maken die de locatie in X,Y,Z richting kan bewaren. We willen echter zowel ``float``, ``double`` als ``int`` gebruiken om deze X,Y,Z coördinaten in bij te houden:



```java
struct Location<T>
{
    public T X;
    public T Y;
    public T Z;
}
```
We kunnen deze struct nu als volgt gebruiken:

```java
static void Main(string[] args)
{
    Location<int> plaats;
    plaats.X = 34;
    plaats.Y = 22;
    plaats.Z = 56;
 
    Location<double> plaats2;
    plaats2.X = 34.5;
    plaats2.Y = 22.2;
    plaats2.Z = 56.7;
 
    Location<string> plaats3;
    plaats3.X = "naast de kerk";
    plaats3.X = "links van de bakker";
    plaats3.Z = "onder het hotel";
 
}
```

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)

Generics zijn een zeer krachtig concept van C#. De eerste maanden zal je vooral bestaande generieke klassen gebruiken die de .NET programmeurs reeds voor je hebben geprogrammeerd. Dankzij generics konden zij klassen schrijven die veel polyvalenter zijn omdat ze niet gebonden zijn aan een bepaald type. *Heb ik die klassen al gebruikt?* Wie weet. Maar als je straks de [generieke collections ontdekt ](../17_gencols/8_Collections.md) dan zal je direct verkocht zijn. Nog enkele hoofdstukken geduld dus!

<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->