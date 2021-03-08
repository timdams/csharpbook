# Out en Ref parameters

## Parameters by reference doorgeven

Je kan parameters op 2 manieren by reference doorgeven:

* Indien de parameters reeds een waarde heeft dan kan je het ref keyword gebruiken. Dit gebruik je dus voor in/out-parameters.
* Indien de parameter pas in de methode een waarde krijgt toegekend dan wordt het out keyword gebruikt. Dit gebruik je dus voor out-parameter.

Je geeft parameters by reference door door het keyword ref voor de parameter in kwestie te zetten, zowel in de methode-declaratie als in de aanroep van de methode zelf.

**Opgelet**:Het dient opgemerkt te worden dat parameters by reference doorgeven vaak tot problemen kan leiden indien je niet goed oplet, daar je rechtstreeks werkt met geheugenlocaties. Als je bijvoorbeeld verkeerdelijk een referentie optelt bij een value dan krijg je een nieuwe referentie die echter naar, mogelijk, een onbestaand stuk geheugen wijst. De ontwikkelaars van Visual Studio raden het gebruik van ref en out dan ook af, zeker indien je een beginnende programmeur bent. .

## Out en ref

Via de keywords out en ref kunnen we parameters by reference dooregeven \(ipv by value\), het verschil daarbij is:

* `ref`: de parameter bevat reeds een waarde wanneer deze naar de methode wordt gestuurd
* `out`: de parameter bevat nog geen parameter en er wordt verwacht dat deze een waarde krijgt in de methode 

Het verschil tussen het gebruik van `out` of `ref` keyword tonen we aan in het volgende voorbeeld.

Laten we dit aantonen met een voorbeeld. Stel dat we het vorige voorbeeld herschreven maar ‘vergeten’ om de parameter tweede een begin-waarde te geven:

```csharp
static void Main(string[] args)
{
    int eerste = 5;
    int tweede;
    RefValueVerschil(eerste, ref tweede);

    Console.WriteLine("Eerste bedraagt na method:{0}", eerste);
    Console.WriteLine("Tweede bedraagt na method:{0}", tweede);
}
```

Dan krijgen we volgende, terechte, foutmelding:

![](../../.gitbook/assets/outref1%20%282%29.png)

Door nu het out keyword te gebruiken geven we expliciet aan dat we beseffen dat de parameter in kwestie pas binnen de methode een waarde zal toegekend krijgen.

We zouden dus ons programma kunnen herschrijven met deze parameter. Hierbij moeten we ons ervan vergewissen dat we zeker de parameter getal2 een waarde toekennen in de methode!

```csharp
static void RefValueVerschil(int getal1, out int getal2)
{
    getal2 = 10;
    getal1 = getal1 + 1;
    getal2 = getal2 + 2;
    Console.WriteLine("Getal1 bedraagt in method:{0}", getal1);
    Console.WriteLine("Getal2 bedraagt in method:{0}", getal2);

}

static void Main(string[] args)
{
    int eerste = 5;
    RefValueVerschil(eerste, out int tweede);

    Console.WriteLine("Eerste bedraagt na method:{0}", eerste);
    Console.WriteLine("Tweede bedraagt na method:{0}", tweede);
}
```

Dit geeft terug als output:

```text
Getal1 bedraagt in method:6
Getal2 bedraagt in method:12
Eerste bedraagt na method:5
Tweede bedraagt na method:12
```

Volgende methode zal 2 parameters meekrijgen. De eerste wordt bij value gebruikt, de tweede by reference:

```csharp
static void RefValueVerschil(int getal1, ref int getal2)
{
    getal1 = getal1 + 1;
    getal2 = getal2 + 2;
    Console.WriteLine("Getal1 bedraagt in methode:{0}", getal1);
    Console.WriteLine("Getal2 bedraagt in methode:{0}", getal2);
}

static void Main(string[] args)
{
    int eerste = 5;
    int tweede = 10;
    RefValueVerschil(eerste, ref tweede);
    Console.WriteLine("Eerste bedraagt na methode:{0}", eerste);
    Console.WriteLine("Tweede bedraagt na methode:{0}", tweede);
}
```

De uitvoer is de volgende, zoals verwacht: :

```text
Getal1 bedraagt in method:6
Getal2 bedraagt in method:12
Eerste bedraagt na method:5
Tweede bedraagt na method:12
```

Merk dus op dat enkel de variabele tweede aangepast wordt buiten de methode doordat we deze by reference doorgeven.

## Foute invoer van de gebruiker opvangen

Vaak wil je de invoer van de gebruiker verwerken/omzetten naar een getal. Denk maar aan volgende applicatie:

```csharp
 Console.WriteLine("Geef je leeftijd");
string invoer = Console.ReadLine();
int leeftijd = Convert.ToInt32(invoer);
leeftijd += 10;
Console.WriteLine($"Over 10 jaar ben je {leeftijd} jaar oud");
```

Deze applicatie zal falen indien de gebruiker iets invoert dat niet kan geconverteerd worden naar een `int`.

### TryParse

De types `int`, `double`, `float` etc hebben allemaal een `TryParse` methode. Je kan deze gebruiken om de invoer van een gebruikeren **te proberen om te zetten** als deze niet lukt dan kan je dit ook weten zonder dat je programma crasht. De werking van `TryParse` is als volgt:

```csharp
bool gelukt = int.TryParse(invoer,out int leeftijd);
```

De methode `TryParse` zal de string in de eerste parameter \(`invoer` in dit voorbeeld\) trachten naar een `int` te converteren. Als dit lukt dan zal het resultaat in de variabele `int leeftijd` geplaatst worden. Merk op dat we `out` voor de parameter moeten zetten zoals we ook hierboven hebben gezien.

Het return resultaat van de methode is ````bool```: indien de conversie gelukt is dan zal deze````true`teruggeven, anders`false\`\`.

We kunnen nu onze applicatie herschrijven en minder foutgevoelig maken voor slechte invoer van de gebruiker:

```csharp
Console.WriteLine("Geef je leeftijd");
string invoer = Console.ReadLine();
bool gelukt = int.TryParse(invoer,out int leeftijd);
if (gelukt == true)
{
    leeftijd += 10;
    Console.WriteLine($"Over 10 jaar ben je {leeftijd} jaar oud");
}
else
{
    Console.WriteLine("Geen geldige invoer gegeven!");
}
```

### TryParse en loops

Daar `TryParse` een `bool` teruggeeft kunnen we deze ook gebruiken in loops als logische expressie. Volgende applicatie zal aan de gebruiker een komma getal vragen en pas verder gaan indien de gebruiker een geldige invoer heeft gegeven:

```csharp
double temperatuur;
string invoer = "";
do
{
    Console.WriteLine("Geef temperatuur");
    invoer = Console.ReadLine();

} while (! double.TryParse(invoer, out temperatuur));

//enkel verdergaan van zodra temperatuur een geldige waarde heeft gekregen
```

> Let er op dat de scope hier van belang is: `invoer` en `temperatuur` moet gekend zijn buiten de loop waar technisch gezien ook de `TryParse` zal gebeuren.

[Meer info en voorbeelden over TryParse nodig?](https://www.dotnetperls.com/parse)

