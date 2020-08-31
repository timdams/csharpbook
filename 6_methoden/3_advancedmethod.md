## Geavanceerde methode-technieken

Nu we methoden in de vingers krijgen, is het tijd om naar enkele gevorderde aspecten te kijken. Je hebt vermoedelijk al door dat methoden een erg fundamenteel concept zijn van een programmeertaal en dus hoe beter we ermee kunnen werken, hoe beter. 

Wat nu volgt is grotendeels gebaseerd op het volgende [artikel](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments).


### Named parameters
Wanneer je een methode aanroept is de volgorde van je argumenten belangrijk: deze moeten meegeven worden in de volgorde zoals de methode parameters ze verwachten.

Met behulp van **named parameters** kan je echter expliciet aangeven welke argument aan welke methode-parameter moet meegegeven worden. 

Stel dat we een methode hebben met volgende signatuur:
```java
static void PrintDetails(string seller, int orderNum, string product)
{
    //do stuff
}
```

Zonder named parameters zou een aanroep van deze methode als volgt kunnen zijn:
```java
PrintDetails("Gift Shop", 31, "Red Mug");
```

We kunnen named parameters aangeven door de naam van de parameter gevolgd door een dubbel punt en de waarde. Als we dus bovenstaande methode willen aanroepen kan dat ook als volgt met named parameters:

```java
 PrintDetails(orderNum: 31, product: "Red Mug", seller: "Gift Shop");
 ```
 of ook:

 ```java
 PrintDetails(product: "Red Mug", seller: "Gift Shop", orderNum: 31);
 ```

Kortom, op deze manier maakt de volgorde van parameter niets uit. Dit werkt enkel als je **alle** parameters zo gebruikt.

<!---{pagebreak} --->

#### Named en unnamed mixen: volgorde wél belangrijk

Je mag echter ook een combinatie gebruiken van named en gewone parameters, maar **dan is de volgorde belangrijk**: je moet je dan houden aan de volgorde van de methode-volgorde. Je verbeterd hiermee de leesbaarheid van je code dus (maar krijgt niet het voordeel van een eigen volgorde te hanteren).  Enkele **geldige** voorbeelden:
```java
PrintDetails("Gift Shop", 31, product: "Red Mug");
PrintDetails(seller: "Gift Shop", 31, product: "Red Mug");   
```

Enkele **niet geldige** voorbeelden:
```java
PrintDetails(product: "Red Mug", 31, "Gift Shop");
PrintDetails(31, seller: "Gift Shop", "Red Mug");
```


### Optionele parameters

Soms wil je dat een methode een standaard waarde voor een parameter gebruikt indien de programmeur in z'n aanroep geen waarde meegaf. Dat kan met behulp zogenaamde van **optionele of default parameters**. Je geeft aan dat een parameter optioneel is door deze een default waarde te geven in de methode-signatuur. Deze waarde zal dan gebruikt worden indien de parameter geen waarde van de aanroeper heeft gekregen. Let er op: **Optionele parameters worden steeds achteraan de parameterlijst van de methode geplaatst** .

In het volgende voorbeeld maken we een nieuwe methode aan en geven aan dat de laatste twee parameters (``optName`` en ``age``) optioneel zijn door er met de toekenningsoperator een default waarde aan te geven:
```java

static void BookFile(int required, string optName = "unknown", int age = 10)
```

Wanneer nu een parameter niet wordt meegegeven, dan zal deze default waarde in de plaats gebruikt worden:
```java
BookFile(15, "tim", 25); //klassieke aanroep, age zal 25 zijn, optName zal "tim" zijn
BookFile(20, "dams"); //age zal 10 zijn, optName "dams"
BookFile(35); //optName zal "default string" en age zal 10 zijn
```

**Je mag enkel de optionele parameters van achter naar voor weglaten. Volgende aanroepen zijn dus niet geldig**:

```java
BookFile(3, 4); //daar de tweede param een string moet zijn
```

Met optionele parameters kunnen we dit echter, indien gewenst, omzeilen. Volgende aanroep is wel geldig:
```java
BookFile(3, age: 4);
```


<!---{pagebreak} --->

### Method overloading

Method overloading wil zeggen dat je een **methode met dezelfde naam en returntype** meerdere keren definieert *maar met andere parameters qua datatype en aantal*. De compiler zal dan zelf bepalen welke versie moet aangeroepen worden gebaseerd op het aantal en type parameters dat je meegeeft.

Volgende methoden zijn overloaded:

```java
static int BerekenOppervlakte(int lengte, int breedte)
{
    int opp = lengte*breedte;
    return opp;
}

static int BerekenOppervlakte(int straal)
{
    int opp = (int)(Math.PI*straal*straal);
    return opp;
}
```

Afhankelijk van de aanroep zal dus de ene of andere uitgevoerd worden. Volgende code zal dus werken:
```java
Console.WriteLine($"Rechthoek: {BerekenOppervlakte(5, 6)}");
Console.WriteLine($"Cirkel: {BerekenOppervlakte(7)}");
```


#### Betterness rule

Indien de compiler twijfelt tijdens de **overload resolution** (welke versie moet aangeroepen worden) zal de **betterness rule** worden gehanteerd: de best 'passende' methode zal aangeroepen worden.

Stel dat we volgende overloaded methoden hebben:

```java
static int BerekenOppervlakte(int straal) //versie A
{
    int opp = (int)(Math.PI*straal*straal);
    return opp;
}

static int BerekenOppervlakte(double straal) //versie B
{
    int opp = (int)(Math.PI * straal * straal);
    return opp;
}
```

<!---{pagebreak} --->

Volgende aanroepen zullen dus als volgt uitgevoerd worden, gebaseerd op de betterness rule:

```java
Console.WriteLine($"Cirkel 1: {BerekenOppervlakte(7)}"); //versie A
Console.WriteLine($"Cirkel 2: {BerekenOppervlakte(7.5)}"); //versie B
Console.WriteLine($"Cirkel 3: {BerekenOppervlakte(7.3f)}"); //versie B
```

Volgende tabel geeft de betternes rule weer. In de linkse kolom staat het datatype van de parameter die wordt meegegeven. De rechtse kolom toont welk datatype het argument in de methodesignatuur meer voorkeur heeft van links naar rechts.

| Paramatertype  | Voorkeur van meeste voorkeur naar minste |
| ---------- | --------------- | 
| ``byte`` | ``short, ushort, int, uint, long, ulong, float, double, decimal`` |
| ``sbyte`` | ``short, int long, float, double, decimal`` |
| ``short`` | ``int, long, float, double, decimal`` |
| ``ushort`` | ``int, uint, long, ulong, float, double, decimal`` |
| ``int`` | ``long, float, double, decimal`` |
| ``uint`` | ``long, ulong, float, double, decimal`` |
| ``long`` | ``float, double, decimal`` |
| ``ulong`` | ``float, double, decimal`` |
| ``float`` | ``double`` |
| ``char`` | ``ushort, int, uint, long, ulong, float, double, decimal`` |

Als je dus bijvoorbeeld een parameter van het type ``int`` meegeeft bij een methode aanroep (eerste kolom), dan zal een methode waar het argument een``long`` verwacht geprefereerd worden boven een methode die voor datzelfde argument een ``float`` verwacht, enz.

Indien de betterness rule niet werkt, dan zal de eerste parameter bepalen wat er gebruikt wordt. Dat zien we in volgende voorbeeld:

```java
static void Main(string[] args)
{
    Toonverhouding(5, 3.4); //versie A
    Toonverhouding(6.2, 3); //versie B
}

static void Toonverhouding(int a, double b) //versie A
{
    Console.WriteLine($"{a}/{b}");
}

static void Toonverhouding(double a, int b) //versie B
{
    Console.WriteLine($"{a}/{b}");
}
```

<!---{pagebreak} --->

Indien ook die regel niet werkt dan zal een fout optreden zoals hier wat zal resulteren in een fout:

![We zien aan de foutboodschap duidelijk dat er eerst naar de eerste parameter wordt gekeken bij twijfel.](../assets/4_methoden/overl.png)

```java
static void Main(string[] args)
{ 
    Toonverhouding(5.6, 3.4);  
}

static void Toonverhouding(int a, double b)
{
    Console.WriteLine($"{a}/{b}");
}

static void Toonverhouding(double a, int b)
{
    Console.WriteLine($"{a}/{b}");
}
```

<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)
* [Method overloading](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=d43a3aa5-2481-4e8a-aef0-a9a700cb2821)
* [Named en optionele parameters](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=e8df8cd1-e83a-4632-b69f-a9a700cd9bc9)
<!---NOBOOKEND--->
