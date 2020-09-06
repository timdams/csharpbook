## Out en ref keywords

Zoals verteld kun je parameters aan een methode doorgeven *by value* (de waarde) of *by reference* (het geheugenadres) afhankelijk van het datatype dat je meegeeft (de primitieve datatypes zoals ``int`` en ``double`` worden *by value* meegegeven, arrays by reference). Je kan echter de primitieve datatypes ook *by reference* meegeven zodat de methode rechtstreeks toegang tot de meegegeven variabele heeft en niet met een kopie moet werken. Dit kan soms handig zijn, maar zorgt ook voor ongewenste bugs. Opletten dus.


### Parameters by reference doorgeven

Je kan parameters op 2 manieren by reference doorgeven aan een methode:

* Indien de actuele parameter **reeds een waarde** heeft dan kan je het **``ref``** keyword gebruiken. Dit gebruik je dus voor in/out-parameters.
* Indien de actuele parameter **pas in de methode een waarde** krijgt toegekend dan wordt het **``out``** keyword gebruikt. Dit gebruik je dus voor out-parameters.

### Ref
Je plaatst het ``ref`` keyword in de methode signatuur voor de formele parameter dat *by reference* moet meegegeven worden. Vanaf dan heeft de methode toegang tot de originele parameter en dus niet tot de kopie. Je dient ook expliciet het keyword voor de actuele parameter bij de aanroep van de methode te plaatsen:


```java
static void VerhoogWaarde(ref int getal)
{
    getal++;
}
 
static void Main(string[] args)
{
    int eerste=1;
    Console.WriteLine(eerste); //er verschijnt 1 op het scherm
    VerhoogWaarde(ref eerste); //let op het ref keyword!
    Console.WriteLine(eerste); //er verschijnt 2 op het scherm
}
```

<!---{pagebreak} --->

### Out
Door het ``out`` keyword te gebruiken geven we expliciet aan dat we beseffen dat de parameter in kwestie pas binnen de methode een waarde zal toegekend krijgen. Wat we hier tonen:


```java
static void GeefWaarde(out int getal)
{
    getal= 5;
}
 
static void Main(string[] args)
{
    int eerste;
    GeefWaarde(out eerste);
    Console.WriteLine(eerste); //er verschijnt 5 op het scherm
}
```

## Foute invoer van de gebruiker opvangen mbv ``TryParse``

Vaak wil je de invoer van de gebruiker verwerken/omzetten naar een getal. Denk maar aan volgende applicatie:
```java
Console.WriteLine("Geef je leeftijd");
string invoer = Console.ReadLine();
int leeftijd = int.Parse(invoer);
leeftijd += 10;
Console.WriteLine($"Over 10 jaar ben je {leeftijd} jaar oud");
```

Deze applicatie zal falen indien de gebruiker iets invoert dat niet kan geconverteerd worden naar een ``int``. We lossen dit op met behulp van ``TryParse``.

### Werking ``TryParse``

De primitieve datatypes ``int``, ``double``, ``float`` etc hebben allemaal een ``TryParse`` methode. Je kan deze gebruiken om de invoer van een gebruiker **te proberen om te zetten**, als deze niet lukt dan kan je dit ook weten zonder dat je programma crasht door een exception op te werpen. 

De werking van ``TryParse`` is als volgt:

```java
bool gelukt = int.TryParse(invoer,out int leeftijd);
```

De methode ``TryParse`` zal de string in de eerste parameter (``invoer`` in dit voorbeeld) trachten naar een ``int`` te converteren. Als dit lukt dan zal het resultaat in de variabele ``int leeftijd`` geplaatst worden. Merk op dat we ``out`` voor de parameter moeten zetten zoals besproken in de vorige sectie van de appendix. 

Het return resultaat van de methode is ``bool``: indien de conversie gelukt is dan zal deze ``true`` teruggeven, anders ``false``.

We kunnen nu onze applicatie herschrijven en minder foutgevoelig maken voor slechte invoer van de gebruiker:

```java
Console.WriteLine("Geef je leeftijd");
string invoer = Console.ReadLine();
bool gelukt = int.TryParse(invoer,out int leeftijd);
if (gelukt)
{
    leeftijd += 10;
    Console.WriteLine($"Over 10 jaar ben je {leeftijd} jaar oud");
}
else
{
    Console.WriteLine("Geen geldige invoer gegeven!");
}
```

### ``TryParse`` en loops

Daar ``TryParse`` een ``bool`` teruggeeft kunnen we deze ook gebruiken in loops als logische expressie. Volgende applicatie zal aan de gebruiker een komma getal vragen en pas verder gaan indien de gebruiker een geldige invoer heeft gegeven:

```java
double temperatuur;
string invoer = "";
do
{
    Console.WriteLine("Geef temperatuur");
    invoer = Console.ReadLine();
    
} while (! double.TryParse(invoer, out temperatuur));

//enkel verdergaan van zodra temperatuur een geldige waarde heeft gekregen
```

{% hint style='tip' %}
Let er op dat de scope hier van belang is: ``invoer`` en ``temperatuur`` moet gekend zijn buiten de loop waar technisch gezien ook de ``TryParse`` zal gebeuren. 
{% endhint %}
