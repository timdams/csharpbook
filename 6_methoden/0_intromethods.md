# Methoden

## Hoe werken methoden

Veel code die we hebben geschreven wordt meerdere keren, al dan niet op verschillende plaatsen, gebruikt. Dit verhoogt natuurlijk de foutgevoeligheid. Door het gebruik van methodes kunnen we de foutgevoeligheid van de code verlagen omdat de code maar op 1 plek staat én maar 1 keer dient geschreven te worden. Echter, ook de leesbaarheid en dus onderhoudbaarheid van de code wordt verhoogd.

{% hint style='tip' %}
**Goede programmeurs zijn luie programmeurs**

Ene Bill Gates, je weet wel, de oprichter van een bedrijfje genaamd Microsoft zei ooit: "I will always choose a lazy person to do a difficult job. Because, he will find an easy way to do it."

Het is je misschien nog niet opgevallen, maar sinds het vorige hoofdstuk zijn we de jacht begonnen op zo weinig mogelijk code schrijven met zoveel mogelijk rendement. Loops was een eerste stap in de goede richting. De volgende zijn methoden! Tijd om nog luier te worden.
{% endhint %}

### Wat is een methode

Een methode, ook vaak functie genoemd, is in C# een stuk code ('block') bestaande uit een 0, 1 of meerdere statements. De methode kan herhaaldelijk opgeroepen worden, al dan niet met extra parameters, en kan ook een resultaat terug geven. Een methode kan van eender waar in je code aangeroepen worden.

Je gebruikt al sinds les 1 methoden. Telkens je ``Console.WriteLine()`` bijvoorbeeld gebruikte, roep je een methode aan. **Methoden in C# zijn namelijk herkenbaar aan de ronde haakjes achteraan, al dan niet met parameters tussen.** Kortom, alles wat we nu gaan zien heb je (onbewust) al gebruikt. Het grote verschil zal zijn dat we nu ook **zelf methoden** gaan definiëren, en niet enkel bestaande methoden gebruiken.

Methoden gebruiken hebben als voordeel dat je (kleine) herbruikbare stukken code kunt gebruiken en dus niet steeds deze code overal moet copy pasten. Daarnaast zullen methoden je code ook overzichtelijker maken.

### Methode syntax

De basis-syntax van een methode ziet er als volgt uit (de werking van het keyword ``static`` zien we later):

```java
static returntype MethodeNaam(optioneel_parameters)
{
    //code van methode
}
```

Vervolgens kan je deze methode elders oproepen als volgt, indien de methode geen parameters vereist:

```java
MethodeNaam();
```

Dat is een mondvol. We gaan daarom de methoden even stapsgewijs leren kennen. Let's go!

### Een eenvoudige methode

Beeld je in dat je een applicatie moet maken waarin je op verschillende plaatsen de naam van je programma moet tonen. Zonder methoden zou je telkens moeten schrijven ``Console.WriteLine("Timsoft XP");``

Als je later de naam van het programma wilt veranderen naar iets anders (bv ``Timsoft 10``) dan zal je manueel overal de titel moeten veranderen in je code. Met een methode hebben we dat probleem niet meer. We schrijven daarom een methode ``ToonTitel`` als volgt:

```java
static void ToonTitel()
{
    Console.WriteLine("Timsoft XP");
}
```



Vanaf nu kan je eender waar in je programma deze methode aanroepen door te schrijven:

```java
ToonTitel();
```

Volgende programma'tje toont dit:

```java
namespace Demo1
{
    class Program
    {

        static void Main(string[] args)
        {
            ToonTitel();
            Console.WriteLine("Welkom!");
            Console.WriteLine("Geef je naam aub");
            //....
            Console.WriteLine("Vaarwel");
            ToonTitel();
        }

        static void ToonTitel()
        {
            Console.WriteLine("Timsoft XP");
        }
    }
}
```

Volgende afbeelding toont hoe je programma doorheen de code loopt. De pijlen geven de flow aan:
![Visualisatie van bovenstaande code](../assets/4_methoden/timsoft.png)

### Main is ook een methode

Zoals je misschien al begint te vermoeden is dus de ``main`` waar we steeds onze code schrijven ook een methode. Een console-applicatie heeft een startpunt nodig en daarom begint ieder programma in deze methode, maar in principe kan je even goed je programma op een andere plek laten starten.

Wat denk je trouwens dat je dit doet?

```csharp
static void Main(string[] args)
{
    Main();
}

```

<!---{pagebreak} --->


## Returntypes van methoden

Voorgaande methode gaf niets terug. Dat kon je zien aan het keyword **``void``** (letterlijk: *leegte*). 

Vaak willen we echter wel dat de methode iets teruggeeft. Bijvoorbeeld het resultaat van een berekening.

Het returntype van een methode geeft aan wat het type is van de data die de methode als resultaat teruggeeft bij het beëindigen ervan. Eender welk type dat je kent kan hiervoor gebruikt worden, zoals ``int``, ``string``, ``char``, ``float``, etc. Ook zelfgemaakte (of bestaande) ``enum`` datatypes kunnen als returnwaarde door het leven.

Het is belangrijk dat in je methode het resultaat ook effectief wordt teruggegeven, dit doe je met het keyword **``return``** gevolgd door de variabele die moet teruggeven worden. 

Denk er dus aan dat deze variabele van het type is dat je hebt opgegeven als zijnde het returntype. Van zodra je ``return`` gebruikt zal je op die plek uit de methode 'vliegen'.

Wanneer je een methode maakt die iets teruggeeft (dus ander returntype dan ``void``) is het ook de bedoeling dat je resultaat van die methode opvangt en gebruikt. Je kan bijvoorbeeld het resultaat van de methode in een variabele bewaren. Dit vereist dat die variabele dan van hetzelfde returntype is! 

Volgend voorbeeld bestaat uit een methode die de naam van de auteur van je programma teruggeeft:

```java
static string GetNameAuthor()
{
    string name = "Tim Dams";
    return name;
}
```

Een mogelijke manier om deze methode in je programma te gebruiken zou nu kunnen zijn:

```java
string myName = GetNameAuthor();
```
<!---{width:60%}--->
![Visualisatie van de flow](../assets/4_methoden/return.png)


{% hint style='tip' %}
Zoals je merkt is er niet veel verschil met wat je al wist aangaande het gebruik van variabelen. Als je dus twijfelt wat methoden kunnen, beschouw ze als een soort "slimme variabelen" die finaal ook gewoon een waarde hebben, maar deze waarde kan het resultaat van een complex stuk code in the methode zijn.
{% endhint %}


{% hint style='tip' %}
Je mag zowel literals als variabelen en zelfs andere methode-aanroepen plaatsen achter het ``return`` keyword. Zolang het maar om een expressie gaat die een resultaat heeft kan dit. Voorgaande methode kunnen we dus ook schrijven als:

```java
static string GetNameAuthor()
{
    return "Tim Dams";
}
```
{% endhint %}


Hier een voorbeeld van een methode die de faculteit van 5 berekent. De oproep van de methode gebeurt vanuit de Main-methode:

```java
class Program
{
    static int FaculteitVan5()
    {
        int resultaat = 1;
        for (int i = 1; i <= 5; i++)
        {
            resultaat *= i;
        }
        return resultaat;
    }
 
    static void Main(string[] args)
    {
       Console.WriteLine($"Faculteit van 5 is {FaculteitVan5()}");
    }
}
```

<!---{pagebreak} --->

#### ``Void`` 

Indien je methode niets teruggeeft wanneer de methode eindigt (bijvoorbeeld indien de methode enkel tekst op het scherm toont) dan dien je dit ook aan te geven. Hiervoor gebruik je het keyword void. Een voorbeeld:

```java
static void ShowProgramVersion()
{
    Console.Write("The version of this program is: ");
    Console.Write(2.16 + "\n");
}
```

{% hint style='tip' %}
Het **void** keyword geeft aan dat deze methode niets "teruggeeft" van resultaat aan de code die de methode aanriep. **Zaken naar het scherm sturen met ``Console.WriteLine()`` heeft hier niets mee te maken.** 
{% endhint %}


#### ``return`` 

Je mag het ``return`` keyword eender waar in je methode gebruiken. Weet wel dat van zodra een statement met ``return`` wordt bereikt de methode ogenblikkelijk afsluit en het resultaat achter ``return`` teruggeeft. Soms is dit handig zoals in volgende voorbeeld:

```java
static string WindRichting()
{
    Random r = new Random();
    switch (r.Next(0,4))
    {
        case 0:
            return "noord";
            break;
        case 1:
            return "oost";
            break;
        case 2:
            return "zuid";
            break;
        case 3:
            return "west";
            break;
    }
    return "onbekend";
}
```

Merk op dat de onderste ``return "onbekend";`` nooit zal bereikt worden. Toch vereist C# dit!

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
Dacht je nu echt dat ik weg was?! Het is me opgevallen dat je niet altijd de foutboodschappen in VS leest. Ik blijf alvast uit jouw buurt als je zo doorgaat. Doe jezelf (en mij) dus een plezier en probeer die foutboodschappen in de toekomst te begrijpen. Er zijn er maar een handvol en bijna altijd komen ze op hetzelfde neer. Neem nou de volgende:**Not all code paths return a value**
Die ga je nog vaak tegenkomen!

Bovenstaande error zal je vaak krijgen en geeft altijd aan dat er bepaalde delen binnen je methode zijn waar je kan komen zonder dat er een ``return`` optreedt. Het einde van de methode wordt met andere woorden bereikt zonder dat er iets uit de methoden terug komt (wat enkel bij ``void`` mag)

![Foutboodschappen hebben de neiging om gecompliceerder te klinken dat de effectieve fout die ze beschrijven. Een beetje zoals een lector die lesgeeft over iets waar hij zelf niets van begrijpt.](../assets/3_loops/unasigned.png)

<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

## Parameters doorgeven

Methoden zijn handig vanwege de herbruikbaarheid. Wanneer je een methode hebt geschreven om de sinus van een hoek te berekenen, dan is het echter ook handig dat je de hoek als parameter kunt meegeven zodat de methode kan gebruikt worden voor eender welke hoekwaarde. 


Indien er wel parameters nodig zijn dan geef je die mee als volgt:

```java
MethodeNaam(parameter1, parameter2, …);
```

Je hebt dit ook al geregeld gebruikt. Wanneer je tekst op het scherm wilt tonen dan roep je de ``WriteLine`` methode aan en geef je 1 parameter mee, namelijk hetgeen dat op het scherm moet komen: ``Console.WriteLine(myName);`` of ``Console.WriteLine(666)`;``. Bij de ``Math`` bibliotheek waren er bijvoorbeeld methoden waar je 2 parameters aan kon meegeven, waarbij duidelijk was dat de volgorde belangrijk was: ``Math.Pow(6,3);`` 6 tot de 3e is niet hetzelfde als 3 tot de 6e wat je als volgt zou schrijven ``Math.Pow(3, 6);``.

Parameters kunnen op 2 manieren worden doorgegeven aan een methode:

1. Wanneer een parameter **by value** wordt meegegeven aan een methode, dan wordt **een kopie gemaakt van de huidige waarde** die wordt meegegeven.
2. Wanneer echter een parameter **by reference** wordt meegegeven dan zal een pointer worden meegegeven aan de methode. Deze pointer bevat het **adres van de eigenlijke variabele** die we meegeven. Aanpassingen aan de parameters zullen daardoor ook zichtbaar zijn binnen de scope van de originele variabele. Parameters *by reference* worden niet in dit boek behandeld, wel in het volgende deel.

### Methoden met argumenten
Om zelf een methode te definiëren die 1 of meerdere parameters aanvaardt, dien je per parameter het datatype en een tijdelijk naam (identifier) te definiëren (*argument*) in de methode-signatuur

Als volgt:

```java
static returntype MethodeNaam(type parameter1, type parameter2)
{
    //code van methode
}
```

Deze parameters zijn nu beschikbaar binnen de methode om mee te werken naar believen.

<!---{pagebreak} --->

Stel bijvoorbeeld dat we onze FaculteitVan5 willen veralgemenen naar een methode die voor alle getallen werkt, dan zou je volgende methode kunnen schrijven:

```java
static int BerekenFaculteit(int grens)
{
    int resultaat = 1;
    for (int i = 1; i <= grens; i++)
    {
        resultaat *= i;
    }
    return resultaat;
}
```

De naam ``grens`` kies je zelf. Maar we geven hier dus aan dat de methode ``BerekenFaculteit`` enkel kan aangeroepen worden indien er 1 parameter van het type ``int`` wordt meegegeven.

Aanroepen van de methode gebeurt dan als volgt:

```java
int getal= 5;
int resultaat= BerekenFaculteit(getal);
```

Of sneller:

```java
int resultaat= BerekenFaculteit(5);
```


Als we even later ``resultaat`` dan zouden gebruiken zal de waarde ``120`` er in zitten.

{% hint style='tip' %}
Parameters worden "by value" meegegeven (zie het hoofdstuk over Arrays verderop) wat wil zeggen dat een **kopie** van de waarde wordt meegegeven. Als je dus in de methode de waarde van de parameter aanpast, dan heeft dit géén invloed op de waarde van de originele parameter waar je de methode aanriep.
{% endhint %}

Je zou nu echter de waarde van getal kunnen aanpassen (door bijvoorbeeld aan de gebruiker te vragen welke faculteit moet berekend worden) en je code zal nog steeds werken.

{% hint style='warning' %}
Veel beginnende programmeurs zijn soms verward dat de naam van de parameter in de methode (bv ``grens``) niet dezelfde moet zijn als de naam van de variabele (of literal) die we bij de aanroep meegeven.

Het is echter logisch dat deze niet noodzakelijk gelijk moeten zijn: het enige dat er gebeurt is dat de methodeparameter de waarde krijgt die je meegeeft, ongeacht van waar de parameter komt.
{% endhint %}

<!---{pagebreak} --->

Stel bijvoorbeeld dat je de faculteiten wenst te kennen van alle getallen tussen 1 en 10, dan zou je schrijven:

```java
for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"Faculteit van {i} is {BerekenFaculteit(i)}" );  
}
```

![Visualisatie flow](../assets/4_methoden/fac.png)

Dit zal als resultaat geven

```
Faculteit van 1 is 1
Faculteit van 2 is 2
Faculteit van 3 is 6
Faculteit van 4 is 24
Faculteit van 5 is 120
Faculteit van 6 is 720
Faculteit van 7 is 5040
Faculteit van 8 is 40320
Faculteit van 9 is 362880
Faculteit van 10 is 3628800
```

{% hint style='tip' %}
Merk dus op dat dankzij je methode, je véél code maar één keer moet schrijven, wat de kans op fouten verlaagt.
{% endhint %}

<!---{pagebreak} --->

#### Volgorde van parameters

De volgorde waarin je je parameters meegeeft bij de aanroep van een methode is belangrijk. De eerste variabele wordt aan de eerste parameter toegekend, en zo voort. 

Het volgende voorbeeld toont dit. Stel dat je een methode hebt:

```java
static void ToonDeling(double teller, double noemer)
{
    string result= Convert.ToString(teller/noemer);
    if(noemer != 0)
        Console.WriteLine(teller/noemer);
    else
        Console.WriteLine("Een zwart gaat ontstaat!");
}
```

Stel dat we nu in onze main volgende aanroep doen:

```java
double n= 4.2;
double t= 5.2;
ToonDeling(n, t);
```

Dit zal een ander resultaat geven dan wanneer we volgende code zouden uitvoeren:

```java
ToonDeling(t, n);
```

Ook de volgorde is belangrijk zeker wanneer je met verschillende types als parameters werkt:

```java
static void ToonInfo(string name, int age)
{
   Console.WriteLine($"{name} is {age} old");
}
```

Deze aanroep is correct:

```java
ToonInfo("Tim", 37);
```

Deze is **FOUT** en zal niet compileren:

```java
ToonInfo(37, "Tim");
```

<!---{pagebreak} --->

#### Methoden nesten

In het begin ga je vooral vanuit je ``main`` methoden aanroepen, maar dat is geen verplichting. Je kan ook vanuit methoden andere methoden aanroepen, en van daaruit weer andere, en zo voort. Volgende (nutteloze) programma'tje toont dit in actie:

```java
public static void Main()
{
    SchrijfNaam();
}
static  void SchrijfNaam()
{
    SchrijfT();
    SchrijfI();
    SchrijfM();
    SchrijfM();
    SchrijfI();
}
static void SchrijfT()
{
    Console.WriteLine("T");
}
static void SchrijfI()
{
    Console.WriteLine("I");
}
static void SchrijfM()
{
    Console.WriteLine("M");
}
```
<!--- {width:50%} --->
![Visualisatie van bovenstaande code zonder terugkerende pijlen](../assets/4_methoden/mmethods.png)


#### Bugs met methoden

Wanneer je programma's complexer worden moet je zeker opletten dat je geen oneindige lussen creëert, zonder dat je loop-code gebruikt. Zie je de fout in volgende code?

```java
public static void Main()
{
    SchrijfNaam();
}
static  void SchrijfNaam()
{
    SchrijfNaam();
    Console.WriteLine("Klaar?");
}
```

Deze code heeft een methode die zichzelf aanroept, zonder dat deze ooit afsluit, waardoor we dus in een oneindige aanroep van de methode komen. Dit programma zal een leeg scherm tonen (daar er nooit aan de tweede lijn in de methode wordt geraakt) en dan crashen wanneer het werkgeheugen van de computer op is (daar de methoden nooit afsluit en telkens een kopie aanroept).

![Deze keer zijn er bewust geen terugkerende pijlen getekend: ze zijn er niet](../assets/4_methoden/oneindig.png)


<!---{pagebreak} --->

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
Even ingrijpen en je attenderen op recursie zodat je code niet in je gezicht blijft ontploffen. **Recursie** is een geavanceerd programmeerconcept wat niet in dit boek wordt besproken, maar laten we het hier kort toelichten. Recursieve methoden zijn methoden die zichzelf aanroepen maar wél op een gegeven moment stoppen wanneer dat moet gebeuren.Volgende voorbeeld is een recursieve methode om de som van alle getallen tussen ``start`` en ``stop`` te berekenen:

```java
static int BerekenSomRecursief(int start, int stop)
{
    int som = start;
    if(start < stop)
    {
        start++;
        return som += BerekenSomRecursief(start, stop);
    }
    return som;
}
```
Je herkent recursie aan het feit dat de methode zichzelf aanroept. Maar een controle voorkomt dat die aanroep blijft gebeuren zonder dat er ooit een methode wordt afgesloten. We krijgen 6 terug (1+2+3) als we de methode als volgt aanroepen:

```java
int einde = BerekenSomRecursief(1,3);
``` 

<!--- {width:50%} --->
![Flow van de recursie](../assets/4_methoden/recursie.png)

<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->


#### Commentaar toevoegen

Het is aan te raden om steeds boven een methode een Block-commentaar te plaatsen als volgt (dit werkt enkel bij methoden): ``///``

Visual Studio zal dan automatisch de parameters verwerken van je methode zodat je vervolgens enkel nog het doel van iedere parameter moet plaatsen.

Stel dat we een methode hebben geschreven die de macht van een getal berekent.  We zouden dan volgende commentaar toevoegen:

```java
/// <summary>
/// Berekent de macht van een getal.
/// </summary>
/// <param name="grondtal">Het getal dat je tot een bepaalde macht wilt verheffen</param>
/// <param name="exponent">De exponent van de macht</param>
/// <returns></returns>
static int Macht(int grondtal, int exponent)
{
    int result = grondtal;
    for (int i = 1; i < exponent; i++)
    {
        result *= grondtal;
    }
    return result;
}
```

Wanneer we nu elders de methode ``Macht`` gebruiken dan krijgen we automatische extra informatie:

<!--- {width:50%} --->
![Hoe comment getoond wordt](../assets/4_methoden/comment.png)

{% hint style='tip' %}
Vaak moet je code schrijven waarin je een getal aan de gebruiker vraagt:

```java
Console.WriteLine("Geef leeftijd");
int leeftijd= Convert.ToInt32(Console.ReadLine());
```

Waarbij je eerst een zinnetje toont aan de gebruiker en dan z'n input omzet naar een werkbaar getal.

Als deze constructie op meerdere plekken in een project voorkomt dan is het nuttig om deze twee lijnen naar een methode te verhuizen die er dan zo kan uitzien:

```java
static VraagInt(string zin)
{
    Console.WriteLine(zin);
    return  Convert.ToInt32(Console.ReadLine());
}
```

De code van zonet kan je dan nu herschrijven naar:

```java
int leeftijd= VraagInt("Geef leeftijd");
```

Het voorgaande voorbeeld toont ook ineens aan waarom methoden helpen om je code leesbaarder en onderhoudbaarder te maken. Je ``main`` blijft gevrijwaard van veel repeterende lijnen code en heeft aanroepen naar (hopelijk) goed benoemde methoden die ieder een specifiek ding doen. Dit maakt het debuggen ook eenvoudiger: je ziet in één oogopslag meestal wat een methode doet (als je ze niet te lang hebt gemaakt natuurlijk).
{% endhint %}


<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)
* [Introductie methoden](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=500f8c7e-874c-4e01-a2e5-aaf600dcda06)
* [Sneller methoden schrijven m.b.v. IntelliSense](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=b93447e7-88a1-49ec-992f-a9af00b22dde)
<!---NOBOOKEND--->