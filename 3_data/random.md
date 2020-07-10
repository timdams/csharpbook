## Random getallen genereren
Random getallen genereren in je code kan leuk zijn om de gebruiker een interactievere ervaring te geven. Beeld je in dat je monsters steeds dezelfde weg zouden bewandelen of dat er steeds op hetzelfde tijdstip een orkaan op je stad neerdwaalt. **SAAI**!

### Random generator
De ``Random``-klasse laat je toe om eenvoudig willekeurige gehele en komma-getallen te maken. Je moet hiervoor twee zaken doen:

1. Maak *eenmalig* een Random-generator aan
2. Roep de ``Next`` methode aan telkens je een nieuw willekeurige getal nodig hebt.

Als volgt: 
```csharp
Random randomGenerator= new Random();
int mijnLeeftijd= randomGenerator.Next();
```

De eerste stap dien je dus maar 1 keer te doen. Vanaf dan kan je telkens aan de generator een nieuw getal vragen m.b.v. ``Next``. 

Volgende code toont bijvoorbeeld 3 random getallen op het scherm:
```csharp
Random mygen= new Random();
int getal1= mygen.Next();
int getal2= mygen.Next();
int getal3= mygen.Next();
Console.WriteLine(getal1);
Console.WriteLine(getal2);
Console.WriteLine(getal3);
```

{% hint style='tip' %}
De ``new Random()`` code is iets wat in het tweede deel van dit boek volledig uit de doeken zal gedaan worden. Lig er dus niet van wakker.
{% endhint %}

#### Next mogelijkheden
Je kan de ``Next`` methode ook 2 parameters meegeven, namelijk de grenzen waarbinnen het getal moet gegenereerd worden. De tweede parameter is exclusief dit getal zelf. Wil je dus een getal tot en met 10 dan schrijf je 11, niet 10.

Enkele voorbeelden:
```csharp
Random somegenerator = new Random();

int a= somegenerator.Next(0,10);  //getal tussen 0 tot en met 9
int b= somegenerator.Next(5,101);  //getal tussen 5 tot en met 100
int c= somegenerator.Next(0,b);  //getal tussen 0 tot en b
```

#### Genereer kommagetallen met NextDouble
Met de ``NextDouble`` methode kan je kommagetallen genereren tussen ``0.0`` en ``1.0`` (1.0 zal niet gegenereerd worden).

Wil je een groter kommagetal dan zal je dit gegenereerde getal moeten vermenigvuldigen naar de range die je nodig hebt.
Stel dat je een getal tussen 0.0 en 10.0 nodig hebt, dan schrijf je:
```csharp
Random myran= new Random();
double randomgetal= myran.NextDouble() * 10.0;
```

En wat als je een kommagetal tussen 5.0 en 12.5 wenst? Als volgt:
```csharp
Random myran= new Random();
double randomgetal= 5.0+  (myran.NextDouble() * 7.5);
```

Je bereik is 7.5, namelijk ``12.5 - 5.0`` en vermenigvuldig je het resultaat van je generator hiermee. Vervolgens verschuif je dat bereik naar 5.


{% hint style='warning' %}
<!--- {height:50%} --->
![](../assets/attention.png)
**Ik krijg dezelfde random getallen? Wat nu?**

Wel wel, wie we hier hebben. Werkt je Random generator niet naar behoren? Wil je het ding in de vuilbak gooien omdat het niet zo willekeurige lijkt te werken als je hoopte?  Gelukkig ben ik er! Zet je helm dus op en luister.

Wanneer je twee ``Random`` objecten aanmaakt op quasi hetzelfde tijdstip in je code, dan zullen deze twee generators ook dezelfde getallen genereren:

```csharp
Random a = new Random();
Random b = new Random();
Console.WriteLine(a.Next());
Console.WriteLine(b.Next());
```

De ``Random`` bibliotheek gebruikt namelijk de tijd als een soort "willekeurig" startpunt. Het is namelijk een **pseudo-willekeurige nummer generator**. 

Dit is de reden waarom je in je code steeds maar **1 rRandom generator** mag aanmaken!

Wil je toch dezelfde willekeurige reeks getallen na elkaar genereren (bijvoorbeeld om je code te testen met steeds dezelfde reeks getallen) dan kan je bij het aanmaken van je generator ook een parameter meegeven. In volgende voorbeeld zullen generator a en c dezelfde getallen na elkaar maken (ongeacht het tijdstip waarop de code werd uitgevoerd), maar b niet:

```csharp
Random a = new Random(666);
Random b = new Random();
Random c = new Random(666);
```
{% endhint %}


<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)
* [Random toepassen](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=ffa0ea68-0b47-4446-9922-a91100d3f61e)
<!---NOBOOKEND--->
