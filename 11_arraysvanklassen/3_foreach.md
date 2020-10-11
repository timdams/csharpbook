## Foreach loops

In het vorige boekdeel bespraken we reeds de ``while``, ``do while`` en `` for``-loops. Er is echter een vierde soort loop in C# die vooral zijn nut zal bewijzen wanneer we met arrays van objecten werken: de ``foreach`` loop.

Wanneer je geen indexering nodig hebt, maar toch snel over alle elementen in een array wenst te gaan, dan is het **foreach** statement een zeer nuttig is.
Een ``foreach`` loop zal ieder element in de array één voor één in een tijdelijke variabele plaatsen (de **iteration variable**) zodat binnenin de loop met dit ene element kan gewerkt worden. Het voordeel hierbij is dat je geen teller/index nodig hebt en dat loop zelf de lengte van de array zal bepalen: *je code wordt net iets leesbaarder* voor leken als we dit bijvoorbeeld vergelijken met hoe een ``for`` loop geschreven is.

Volgende code toont de werking waarbij we een array van `doubles` hebben en alle elementen ervan op het scherm willen tonen:

```java
double[] killdeathRates= {1.2, 0.89, 3.15, 0.1};

foreach (double kdrate in killdeathRates)
{
   Console.WriteLine($"Kill/Death rate is {kdrate}");
}
```

Het belangrijkste nieuwe concept is de *iteration variable* die we definiëren als ``kdrate``. Deze moet uiteraard van het type zijn van de individuele elementen in de array. Vervolgens schrijven we het nieuwe keyword  ``in`` gevolgd door de array waar we over wensen te itereren. 

De eerste keer dat we in de loop gaan zal het element ``killdeathRates[0]`` aan ``kdrate`` toegewezen worden voor gebruik in de loop-body, vervolgens wordt ``killdeathRates[1]`` toegewezen, enz. De output zal dan zijn:

```text
Kill/Death rate is 1.2
Kill/Death rate is 0.89
Kill/Death rate is 3.15
Kill/Death rate is 0.1

```

Stel dat we een array van Studenten hebben, ``deKlas``, en wensen van deze studenten de naam en geboortejaar op het scherm te tonen, dan kan dat met een ``foreach`` erg eenvoudig:

```java
foreach(Student eenStudent in deKlas)
{
   Console.WriteLine($"{eenStudent.Naam}, Geboortejaar: {eenStudent.GeboorteJaar}");
}

```

### Opgelet bij het gebruik van foreach loops

De foreach loop is weliswaar leesbaarder en eenvoudiger in gebruikt, er zijn ook 2 erg belangrijke nadelen aan:

* De foreach iteration variabele is *read-only*: je kan dus geen waarden in de array aanpassen, enkel uitlezen. Dit ogenschijnlijk eenvoudige zinnetje heeft echter veel gevolgen. Je kan met een ``foreach``-loop dus **nooit de inhoud van de variabele aanpassen**. Wens je dat wel te doen, dan dien je de klassieke ``while``, ``do while`` of ``for`` loops te gebruiken.
* De foreach loop gebruik je enkel als je **alle elementen van een array wenst te benaderen**. In alle andere gevallen zal je een ander soort loop moeten gebruiken. 


{% hint style='warning' %}
Het feit dat de foreach iteration variabele read-only is wil niet zeggen dat we de inhoud van het onderliggend object niet kunnen aanpassen. De iteration variabele krijgt bij een array van objecten telkens een referentie naar het huidige element. Dit referentie kunnen we niet aanpassen, maar we mogen wel de referentie "volgen" om vervolgens iets in het huidige object zelf aan te passen.

Dit mag dus niét:
```java
foreach(Student eenStudent in deKlas)
{
   eenStudent= new Student();
}
```

Maar dit mag wél:
```java
foreach(Student eenStudent in deKlas)
{
   eenStudent.Geboortejaar++;
}
```

{% endhint %}

## Het ``var`` keyword

C# heeft een **``var``** keyword. Je mag dit keyword gebruiken ter vervanging van het datatype (bv ``int``) op voorwaarde dat de compiler kan achterhalen wat het type (*implicit type*) moet zijn aan de hand van de expressie rechts van de toekenningsoperator.

```java
var getal= 5; //var zal int zijn
var myArray= new double[20]; //var zal double[] zijn
var tekst= "Hi there handsome"; //var zal string zijn
```

{% hint style='warning' %}
**Opgelet**: het ``var`` keyword is gewoon een *lazy programmer syntax toevoeging* om te voorkomen dat je als programmeur niet constant het type moet schrijven.


Bij JavaScript heeft ``var`` een totaal andere functie, daar zegt het eigenlijk: "het type dat je in deze variabele kan steken is...variabel". M.a.w. het kan de ene  keer een ``string`` zijn, dan een int. Bij C# gaat dit niet: eens je een variabele aanmaakt dan zal dat type onveranderbaar zijn en kan je er alleen waarden aan toekennen van dat type. JavaScript is namelijk een *dynamically typed language* terwijl C# een *statically typed language* is (er is één uitzondering bij C# hieromtrent: wanneer je met ``dynamic`` leert werken kan je C# ook tijdelijk als een dynamically typed taal gebruiken, maar dat wordt niet besproken in dit boek).

{% endhint %}

### var en foreach

Wanneer je de Visual Studio code snippet voor ``foreach`` gebruikt ``foreach [tab][tab]`` dan zal deze code ook een ``var`` gebruiken voor de iteration variabele. De compiler kan aan de te gebruiken array zien wat het type van een individueel element in de array moet zijn.

De foreach die we zonet gebruikten kan dus herschreven worden naar:

```java
foreach (var kdrate in killdeathRates)
{
   Console.WriteLine($"Kill/Death rate is {kdrate}");
}
```

Merk op dat dit hoegenaamd geen invloed heeft op je applicatie. Wanneer je code gaat compileren die het keyword ``var`` bevatten dan zal de compiler eerst alle *vars* vervangen door het juiste type, én dan pas beginnen compileren.

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)
* [var keyword](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=8ba39f71-889e-4e48-9f3b-ab750087d034)
* [De foreach loop](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=e268b0f3-5226-4279-a69c-ab7500892031)
<!---NOBOOKEND--->