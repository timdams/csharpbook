# Geheugenmanagement in C#

Tot nog toe lagen we er niet van wakker wat er achter de schermen van een C# programma gebeurde. We duiken nu dieper in wat er juist gebeurt wanneer we variabelen aanmaken.

## Stack en heap : twee soorten geheugens

Wanneer een C# applicatie wordt uitgevoerd krijgt het twee soorten geheugen toegewezen dat het 'naar hartelust' kan gebruiken:

1. Het kleine, maar snelle **stack** geheugen
2. Het grote, maar tragere **heap** geheugen

Afhankelijk van het soort variabele wordt ofwel de stack, ofwel de heap gebruikt. **Het is uitermate belangrijk dat je weet in welk geheugen de variabele zal bewaard worden!** 

Er zijn twee soorten variabelen:

1. Value types
2. Reference types

Afhankelijk van het type variabele zal deze ofwel in de heap oftewel in de stack bewaard worden. 

Als je volgende tabel begrijpt dan beheers je geheugenmanagement in C#:

|         | Value types           | Reference types  |
| ------------- |-------------| -----|
|Inhoud van de variabele    | De eigenlijke data | Een referentie naar de eigenlijke data |
|Locatie      |  **Stack**      |   **Heap**  |
| Beginwaarde | ``0``,``0.0``, ``""``,``false``, etc.      |    ``null`` |
| Effect van = operator | Kopieert de actuele waarde     |   Kopieert het adres naar de actuele waarde |

![Stack en heap](../assets/5_arrays/gc1.png)

### Waarom twee geheugens?

Waarom plaatsen we niet alles in de stack? De reden hiervoor is dat bij het compileren van je applicatie er reeds zal berekend worden hoeveel geheugen de stack zal nodig hebben. Wanneer je programma dus later wordt uitgevoerd weet het OS perfect hoeveel geheugen het minstens moet reserveren bij het besturingssysteem.

Er is echter een probleem: de compiler kan niet alles perfect berekenen of voorspellen. Een variabele van het type ``int`` is perfect geweten hoe groot die zal zijn (32 bit). Maar wat met een string die je aan de gebruiker vraagt? Of wat met een array waarvan we pas tijdens de uitvoer de lengte gaan berekenen gebaseerd op *runtime* informatie. 

Het zou nutteloos (en zonde) zijn om reeds bij aanvang een bepaalde hoeveelheid stackgeheugen voor een array te reserveren als we niet weten hoe groot die zal worden. Beeld je in dat alle applicaties op je computer *voor alle zekerheid* een halve gigabyte aan geheugen zouden vragen: "just in case". Je computer zou enkele terrabyte aan geheugen nodig hebben. Het is dus veel realistischer om enkel het geheugen te reserveren waar de compiler 100% zeker van is dat deze zal nodig zijn.

De heap laat ons toe om geheugen op een wat minder gestructureerde manier in te palmen. Tijdens de uitvoer van het programma zal de heap als het ware dienst doen als een grote zandbak waar eender welke plek kan ingepalmd worden om zaken te bewaren (op voorwaarde dat die vrij is natuurlijk) De stack daarentegen is het kleine bankje naast de zandbak: handig, snel, en perfect geweten hoe groot.

### Value types in de stack

**Value** type variabelen worden in de stack bewaard. **De effectieve waarde van de variabele wordt in de stack bewaard.**
Dit zijn alle gekende, 'eenvoudige' datatypes die we totnogtoe gezien hebben, inclusief enums en structs:
* ``sbyte``, ``byte``
* ``short``, ``ushort``
* ``int``, ``uint``
* ``long``, ``ulong``
* ``char``
* ``float``, ``double``, ``decimal``
* ``bool``
* structs (zie appendix)
* enums (zie het vorige boek)

### = operator bij value types

Wanneer we een value-type willen kopiëren dan kopiëren de actuele waarde:

```java
int getal = 3;
int anderGetal = getal;
```

Vanaf nu zal ``anderGetal`` de waarde ``3`` hebben. Als we nu één van beide variabelen aanpassen dan zal dit **geen** effect hebben op de andere variabelen.

We zien hetzelfde effect wanneer we een methode maken die een parameter van het value type aanvaardt - we geven een kopie van de variabele mee:

```java
void DoeIets(int a)
{
    a++;
    Console.WriteLine($"In methode {a}");
}

//Elders:
int getal= 5;
DoeIets(getal);
Console.WriteLine($"Na methode {getal}");
```

De parameter ``a`` zal de waarde ``5`` gekopieerd krijgen. Maar wanneer we nu zaken aanpassen in ``a`` zal dit geen effect hebben op de waarde van ``getal``.

De output van bovenstaand programma zal zijn:
```
In methode 6
Na methode 5
```

### Reference types

**Reference** types worden in de heap bewaard. De *effectieve waarde* wordt in de heap bewaard, en in de stack zal enkel een **referentie** of **pointer** naar de data in de heap bewaard worden. Een referentie (of pointer) is niet meer dan het geheugenadres naar waar verwezen wordt (bv. ``0xA3B3163``)  Concreet zijn dit alle zaken die vaak redelijk groot zullen zijn of waarvan op voorhand niet kan voorspeld worden hoe groot ze *at runtime* zullen zijn:
* objecten, interfaces en delegates
* arrays

### = operator bij reference types
Wanneer we de = operator gebruiken bij een reference type dan kopiëren we de referentie naar de waarde, niet de waarde zelf.

#### Bij objecten

We zien dit gedrag bij alle reference types, zoals objecten:
```java
Student stud= new Student();
```

Wat gebeurt er hier?

1. ``new Student()``  : ``new`` roept de constructor van ``Student`` aan. Deze zal een constructor in de **heap** aanmaken en vervolgens de geheugenlocatie teruggeven.
2. Een variabele ``stud`` wordt in de **stack** aangemaakt.
3. De geheugenlocatie uit de eerste stap wordt vervolgens in ``stud`` opgeslagen in de stack.


#### Bij arrays

Zoals we in het vorige boek hebben gezien zien we het zelfde gedrag bij arrays:

```java
int[] nummers= {4,5,10};
int[] andereNummers= nummers;
```

In dit voorbeeld zal ``andereNummers`` nu dus ook verwijzen naar de array in de heap waar de actuele waarden staan.

Als we dus volgende code uitvoeren dan ontdekken we dat beide variabele naar dezelfde array verwijzen:

```java
andereNummers[0]=999;
Console.WriteLine(andereNummers[0]);
Console.WriteLine(nummers[0]);
```

We zullen dus als output krijgen:

```
999
999
```

Hetzelfde gedrag zien we bij objecten:

```java
Student a= new Student("Abba");
Student b= new Student("Queen");
a=b;
Console.WriteLine(a.Naam);
```

We zullen in dit geval dus ``Queen`` op het scherm zien omdat zowel ``b`` als ``a`` naar het zelfde object in de heap verwijzen. Het originele "abba"-object zijn we kwijt en zal verdwijnen (zie Garbage collector verderop).

{% hint style='warning' %}
De meeste klassen zullen met value type properties en datavelden werken in zich, toch worden ook samen met het gehele object in de heap bewaard en niet in de stack. Kortom **het hele object** ongeacht de vorm van z'n inhoud wordt in de heap bewaard.
{% endhint %}

### Methoden en reference parameters

Ook bij methoden geven we de dus de referentie naar de waarde mee. In de methode kunnen we dus zaken aanpassen van de parameter en dan passen we eigenlijk de originele variabele aan:
```java
void DoeIets(int[] a)
{
   a[0]++;
   Console.WriteLine($"In methode {a[0]}");
}

//Elders:
int[] getallen= {5,3,2};
DoeIets(getallen);
Console.WriteLine($"Na methode {getallen[0]}");
```

We krijgen als uitvoer:
```
In methode 6
Na methode 6
```

{% hint style='warning' %}
**Opgelet:** Wanneer we een methode hebben die een value type aanvaardt en we geven één element van de array mee dan geven we dus een kopie van de actuele waarde mee!
{% endhint %}

```java
void DoeIets(int a)
{
    a++;
    Console.WriteLine($"In methode {a}");
}

//Elders:
int[] getallen= {5,3,2};
DoeIets(getallen[0]); //<= VALUE TYPE!
Console.WriteLine($"Na methode {getallen[0]}");
```

De output bewijst dit:

```
In methode 6
Na methode 5
```

## De Garbage Collector (GC)
Een essentieel onderdeel van .NET is de zogenaamde GC, de Garbage Collector. Dit is een geautomatiseerd onderdeel van ieder C# programma dat ervoor zorgt dat we geen geheugen nodeloos gereserveerd houden.
De GC zal geregeld het geheugen doorlopen en kijken of er in de heap data staat waar geen references naar verwijzen. Indien er geen references naar wijzen zal dit stuk data verwijderd worden.

![Data in de heap waar geen referenties naar wijzen zullen ten gepaste tijde verwijderd worden](../assets/5_arrays/gc2.png)

In dit voorbeeld zien we dit in actie:

```java
int[] array1= {1,2,3};
int[] array2= {3,4,5};
array2=array1;
```

Vanaf de laatste lijn zal er geen referentie meer naar ``{3,4,5}`` zijn in de heap, daar we deze hebben overschreven met een referentie naar ``{1,2,3}``. De GC zal dus deze data verwijderen.

Wil je dat niet dan zal je dus minstens 1 variabele moeten hebben die naar de data verwijst. Volgend voorbeeld toont dit:

```java
int[] array1= {1,2,3};
int[] array2= {3,4,5};
int[] bewaarArray= array2;
array2=array;
```
De variabele ``bewaarArray`` houdt dus een referentie naar ``{3,4,5}`` bij en we kunnen dus later via deze variabele alsnog aan de originele data.

{% hint style='warning' %}
De GC werkt niet continue daar dit te veel overhead van je computer zou vereisen. De GC zal gewoon om de zoveel tijd alle gereserveerde geheugenplekken van de applicatie controleren en die delen verwijderen die niet meer nodig zijn.  
Je kan de GC manueel de opdracht geven om een opkuisbeurt te starten (``GC.Collect()``) maar dit is ten stelligste af te raden! De GC weet meestal beter dan ons wanneer er gekuist moet worden.
{% endhint %}

<!---NOBOOKSTART--->
# Meer weten?

Voor meer info, lees zeker volgende artikels:
* [Reference en value types](https://www.c-sharpcorner.com/uploadfile/prvn_131971/types-in-C-Sharp/)
* [Stack vs heap](https://www.c-sharpcorner.com/article/C-Sharp-heaping-vs-stacking-in-net-part-i/)

# Kennisclip
![](../assets/infoclip.png)
* [Stack vs heap](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=bf7ea9bc-7469-446b-b226-ab5e008085a8)
* [Stack Overflow Exception](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=640a52f0-9ea0-42fc-b1f6-ab7a0093eda6)
<!---NOBOOKEND--->
