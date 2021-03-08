# Random getallen genereren
Random getallen genereren in je code kan leuk zijn om de gebruiker een interactievere ervaring te geven. Beeld je in dat je monsters steeds dezelfde weg zouden bewandelen of dat er steeds op hetzelfde tijdstip een orkaan op je stad neerdwaalt. **SAAI**!

# Random generator
De ``Random``-klasse laat je toe om eenvoudig willekeurige gehele en komma-getallen te maken. Je moet hiervoor twee zaken doen:

1. Maak *eenmalig* een Random-generator aan: ``Random randomgen= new Random();``  (wat dit juist wil zeggen zien we in [Semester 2](../8_klassen/0_oop_intro.md)).

2. Roep de ``Next`` methode aan telkens je een nieuw getal nodig hebt, bijvoorbeeld: ``int mijnGetal= randomgen.Next();`` De aanroep van de methode ``Next()`` zal een geheel getal willekeurig genereren.

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

# Next mogelijkheden
Je kan de ``Next`` methode ook 2 parameters meegeven, namelijk de grenzen waarbinnen het getal moet gegenereerd worden. De tweede parameter is exclusief dit getal zelf. Wil je dus een getal tot en met 10 dan schrijf je 11, niet 10.

Enkele voorbeelden:
```csharp
Random somegenerator = new Random();

int a= somegenerator.Next(0,10);  //getal tussen 0 tot en met 9
int b= somegenerator.Next(5,101);  //getal tussen 5 tot en met 100
int c= somegenerator.Next(0,b);  //getal tussen 0 tot en met het getal dat de lijn ervoor werd gegenereerd.
```

# Genereer kommagetallen met NextDouble
Met de ``NextDouble`` methode kan je kommagetallen genereren tussen ``0.0`` en ``1.0`` (1.0 zal niet gegenereerd worden).

Wil je een groter kommagetal dan zal je dit gegenereerde getal moeten vermenigvuldigen naar de range die je nodig hebt.
Stel dat je een getal tussen 0.0 en 10.0 nodig hebt, dan schrijf je:
```csharp
Random myran= new Random();
double randomgetal= myran.NextDouble() * 10.0;
```

{% hint style='warning' %}
**Ik krijg dezelfde random getallen? Wat nu?**

[Zie hier voor meer informatie indien je dezelfde random nummers genereert.](http://csharpindepth.com/Articles/Chapter12/Random.aspx)
{% endhint %}


# Kennisclip
![](../assets/infoclip.png)
* [Random toepassen](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=ffa0ea68-0b47-4446-9922-a91100d3f61e)
