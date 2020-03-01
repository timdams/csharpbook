# Methoden

Veel code die we hebben geschreven wordt meerdere keren, al dan niet op verschillende plaatsen, gebruikt. Dit verhoogt natuurlijk de foutgevoeligheid. Door het gebruik van methodes kunnen we de foutgevoeligheid van de code verlagen omdat de code maar op 1 plek staat én maar 1 keer dient geschreven te worden. Echter, ook de leesbaarheid en dus onderhoudbaarheid van de code wordt verhoogd.

## Wat is een methode

Een methode, ook vaak functie genoemd, is in C# een stuk code ('block') bestaande uit een 0, 1 of meerdere statements. De methode kan herhaaldelijk opgeroepen worden, al dan niet met extra parameters, en kan ook een resultaat terug geven.

De basis-syntax van een methode is de volgende indien je een methode in je hoofdprogramma wenst te schrijven (de werking van het keyword ``static`` zien we later):

```csharp
static returntype MethodeNaam(parameters)
{
    //code van methode
}
```
Vervolgens kan je deze methode elders oproepen als volgt, indien de methode geen parameters vereist:

```csharp
MethodeNaam();
```

Indien er wel parameters nodig zijn dan geef je die mee als volgt, het is belangrijk dat de volgorde van de parameters gehanteerd wordt zoals je in de methode zelf hebt beschreven.

```csharp
MethodeNaam(parameter1, parameter2, …);
```

## Returntypes

Het returntype van een methode geeft aan wat het type is van de data die de methode als resultaat teruggeeft bij het beëindigen ervan. Eender welk type dat je kent kan hiervoor gebruikt worden, zoals int, string, char, float, etc. Maar ook klassen (zie later) zoals Student, Canvas, etc.

Het is belangrijk dat in je methode het resultaat ook effectief wordt teruggegeven, dit doe je met het keyword ``return``
gevolgd door de variabele die moet teruggeven worden. Denk er dus aan dat deze variabele van het type is dat je hebt opgegeven als zijnde het returntype. Van zodra je ``return`` gebruikt zal je op die plek uit de methode 'vliegen'.

Volgend voorbeeld bestaat uit een methode die de naam van de auteur van je programma teruggeeft:

```csharp
static string GetNameAuthor()
{
    string name = "Tim Dams";
 
    return name;
}
```

Mogelijke manieren om deze methode in je programma te gebruiken zouden kunnen zijn:

```csharp
string myName = GetNameAuthor();
```

Of bijvoorbeeld ook:

```csharp
Console.WriteLine("This program is written by "+ GetNameAuthor());
```

Hier een voorbeeld van een methode die de faculteit van 5 berekent. De oproep van de methode gebeurt vanuit de Main-methode:

```csharp
partial class Program
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
       Console.WriteLine("Faculteit van 5 is {0}", FaculteitVan5());
    }
}
```

### Void returntype

Indien je methode niets teruggeeft wanneer de methode eindigt (bijvoorbeeld indien de methode enkel tekst op het scherm toont) dan dien je dit ook aan te geven. Hiervoor gebruik je het keyword void. Een voorbeeld:

```csharp
static void ShowProgramVersion()
{
    Console.Write("The version of this program is: ");
    Console.Write(2.16 + "\n");
}
```

## Parameters doorgeven

Parameters kunnen op 2 manieren worden doorgegeven aan een methode:

1. Wanneer een parameter **by value** wordt meegegeven aan een methode, dan wordt een kopie gemaakt van de huidige waarde die wordt meegegeven.
2. Wanneer echter een parameter **by reference** wordt meegegeven dan zal een pointer worden meegegeven aan de methode. Deze pointer bevat het adres van de eigenlijke variabele die we meegeven. Aanpassingen aan de parameters zullen daardoor ook zichtbaar zijn binnen de scope van de originele variabele.

### Parameters doorgeven by value

Je methode definitie kan ook 1 of meerdere parameters bevatten. Hierbij gebruik je volgende syntax:

```csharp
static returntype MethodeNaam(type parameter1, type parameter2)
{
    //code van methode
}
```

Deze parameters zijn nu beschikbaar binnen de methode om mee te werken naar believen.

Stel bijvoorbeeld dat we onze FaculteitVan5 willen veralgemenen naar een methode die voor alle getallen werkt, dan zou je volgende methode kunnen schrijven:

```csharp
static int BerekenFaculteit(int grens)
{
    int resultaat = 1;
    for (int i = 1; i <= grens; i++)
    {
        resultaat *= i;
    }
    return resultaat;
}
static void Main(string[] args)
{
    int getal = 5;
    Console.WriteLine("Faculteit van {0} is {1}", getal, BerekenFaculteit(getal));
}
```

Dit geeft als uitvoer: ``Faculteit van 5 is 120``.

Je zou nu echter de waarde van getal kunnen aanpassen (door bijvoorbeeld aan de gebruiker te vragen welke faculteit moet berekend worden) en je code zal nog steeds werken.

Stel bijvoorbeeld dat je de faculteiten wenst te kennen van alle getallen tussen 1 en 10, dan zou je schrijven:

```csharp
for (int i = 1; i < 11; i++)
{
    Console.WriteLine("Faculteit van {0} is {1}", i, BerekenFaculteit(i));  
}
```

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

Merk dus op dat dankzij je methode, je véél code maar één keer moet schrijven, wat de kans op fouten verlaagt.

### Volgorde van parameters

De volgorde waarin je je parameters meegeeft bij de aanroep van een methode is belangrijk. De eerste variabele wordt aan de eerste parameter toegekend, en zo voort. 

Het volgende voorbeeld toont dit. Stel dat je een methode hebt:

```csharp
static void ToonDeling(double teller, double noemer)
{
    string result= Convert.ToString(teller/noemer);
    Console.WriteLine(teller/noemer);
}
```

Stel dat we nu in onze main volgende aanroep doen:

```csharp
double n= 4.2;
double t= 5.2;
ToonDeling(n, t);
```

Dit zal een ander resultaat geven dan wanneer we volgende code zouden uitvoeren:

```csharp
ToonDeling(t, n);
```

Ook de volgorde is belangrijk zeker wanneer je met verschillende types als parameters werkt:

```csharp
static void ToonInfo(string name, int age)
{
   Console.WriteLine($"{name} is {age} old");
}
```

Deze aanroep is correct:

```csharp
ToonInfo("Tim", 37);
```

Deze is **FOUT** en zal niet compileren:

```csharp
ToonInfo(37, "Tim");
```

## Commentaar toevoegen

Het is aan te raden om steeds boven een methode een Block-commentaar te plaatsen als volgt (dit werkt enkel bij methoden): ``///``

Visual Studio zal dan automatisch de parameters verwerken van je methode zodat je vervolgens enkel nog het doel van iedere parameter moet plaatsen.

Stel dat we een methode hebben geschreven die de macht van een getal berekent.  We zouden dan volgende commentaar toevoegen:

```csharp
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

![Hoe comment getoond wordt](../assets/4_methoden/comment.png)

# Kennisclip
![](../assets/infoclip.png)
* [Introductie methoden](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=500f8c7e-874c-4e01-a2e5-aaf600dcda06)
* [Sneller methoden schrijven m.b.v. IntelliSense](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=b93447e7-88a1-49ec-992f-a9af00b22dde)




# Why should I care?
![](../assets/care.jpg)

Volg nu een voorbeeld (bron: handboek Visual C# 2008, Dirk Louis) waar het gebruik van methoden onmiddellijk duidelijk wordt. 

Stel, je hebt 15000 euro op een spaarrekening vastgezet waarvoor de bank u een rente geeft van 3,5%. Nu wil je natuurlijk weten hoe je kapitaal van jaar tot jaar groeit. Stel dat je aan de verleiding weerstaat en de jaarlijkse rente niet opneemt, maar op de spaarrekening laat staan. Je berekent dan je kapitaal na *n* jaren met de volgende formule:

```csharp
eindkapitaal = startkapitaal x (1 + (rentepercentage/100))^n
```

(^ is tot de macht in pseudocode)

Nu kan je berekenen hoeveel geld je de volgende zeven jaren verdient, het bijhorende programma ziet er zo uit:

```csharp
static void Main(string[] args)
{
    double startKapitaal = 15000;
    double rentepercentage = 3.5;
    double eindkapitaal;
 
    //Berekening eindkapitaal
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 1);
    Console.WriteLine("Na 1 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 2);
    Console.WriteLine("Na 2 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 3);
    Console.WriteLine("Na 3 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 4);
    Console.WriteLine("Na 4 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 5);
    Console.WriteLine("Na 5 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 6);
    Console.WriteLine("Na 6 jaar:" + (int)eindkapitaal + "euro");
 
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), 7);
    Console.WriteLine("Na 7 jaar:" + (int)eindkapitaal + "euro");
}
```

Dit geeft als uitvoer:

```text
Na 1 jaar:15524euro
Na 2 jaar:16068euro
Na 3 jaar:16630euro
Na 4 jaar:17212euro
Na 5 jaar:17815euro
Na 6 jaar:18438euro
Na 7 jaar:19084euro
```

Het programma werkt naar behoren, maar zoals je zelf kan zien wordt er aardig wat code herhaalt, op enkele kleine details na. Bij iedere berekening en het tonen van de interest verandert enkel de macht en het aantal jaar. Als er nu een fout in je interestberekening zou staan dan zal je die op 7 plaatsen telkens moeten veranderen.

### Rente berekenen verbeterd, versie 1

We kunnen nu terug naar onze rente-berekenaar en dit programma aanzienlijk vereenvoudigen door gebruik te maken van methoden. Namelijk als volgt:

```csharp
public static void RenteOpRenteBerekenen(double looptijd)
{
    double startKapitaal = 15000;
    double rentepercentage = 3.5;
    double eindkapitaal;
 
    //Berekening eindkapitaal
    eindkapitaal = startKapitaal * Math.Pow((1 + rentepercentage / 100), looptijd);
    Console.WriteLine("Na "+ (int)looptijd+"jaar:" + (int)eindkapitaal + "euro");
}
 
static void Main(string[] args)
{
    RenteOpRenteBerekenen(1);
    RenteOpRenteBerekenen(2);
    RenteOpRenteBerekenen(3);
    RenteOpRenteBerekenen(4);
    RenteOpRenteBerekenen(5);
    RenteOpRenteBerekenen(6);
    RenteOpRenteBerekenen(7);
 
}
```
Dit programma zal de zelfde output geven als het originele programma, maar de code is aanzienlijk verkleint en minder foutgevoelig (je moet maar op één plek je interestberekening aanpassen indien nodig). (Merk op dat we uiteraard de main kunnen verbeteren m.b.v. een for-loop: ``for(int i=0;i<8;i++) {RenteOpRenteBerekenen(i);}``

## Rente berekenen verbeterd, versie 2

Je code opdelen in methoden is een zeer goede eerste stap naar modulair programmeren: kleine stukken code die ieder een eigen verantwoordelijkheid hebben. Om perfect modulair te zijn moet een methode zo praktisch en algemeen mogelijk blijven, zodat de methode herbruikbaar is in andere projecten.

In het vorige voorbeeld is de methode van de renteberekening niet perfect modulair. Stel dat je later in het programma opnieuw de rente wil berekening maar niet het resultaat op het scherm wil tonen. Of stel dat je de rente wil berekenen met een andere percentage, dan kunnen we de eerder geschreven methode dus niet gebruiken.

**Modulair programmeren**: indien je modulair wenst te programmeren moet je je aan volgende zaken houden:

* Beperk de methode strikt tot het uitvoeren van de opgedragen taak. Dus in het voorbeeld: alleen de renteberekening en geen verdere verwerking van de resultaten.
* Als de methode een waarde teruggeeft, declareer hiervoor dan een passende returnwaarde.

Geef alle grootheden waarmee je de werkwijze van de methode wilt aanpassen mee aan de methode als parameter. In dit voorbeeld zijn dat dus de variabelen startkapitaal, rentepercentage en looptijd.

De nieuwe algemene, verbeterde methode wordt dan:

```csharp
public static double RenteOpRenteBerekenen(double startkapitaal, double rentepercentage, double looptijd)
{
    double eindkapitaal;
 
    //berekenig eindkapitaal
    eindkapitaal = startkapitaal * Math.Pow((1 + rentepercentage / 100), looptijd);
 
    return eindkapitaal;
}
```

De aanroep van deze methode in de main wordt dan de volgende:

```csharp
double eindkapitaal;
eindkapitaal = RenteOpRenteBerekenen(15000, 3.5, 7);
Console.WriteLine("Het eindbedrag na 7 jaar:" +(int)eindkapitaal);
```

## Een Nuttige methode

Vaak moet je code schrijven van volgende vorm:

```csharp
Console.WriteLine("Geef leeftijd");
int leeftijd= Convert.ToInt32(Console.ReadLine());
```

Waarbij je eerst een zinnetje toont aan de gebruiker en dan z'n input omzet naar een werkbaar getal.

Als deze constructie op meerdere plekken in een project voorkomt dan is het nuttig om deze twee lijnen naar een methode te verhuizen die er dan zo kan uitzien:

```csharp
static VraagInt(string zin)
{
    Console.WriteLine(zin);
    return  Convert.ToInt32(Console.ReadLine());
}
```

De code van zonet kan je dan nu herschrijven naar:

```csharp
int leeftijd= VraagInt("Geef leeftijd");
```


