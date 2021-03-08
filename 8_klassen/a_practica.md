# Oefeningen

## Richtlijnen
### Structuur oefeningen
Vanaf hier veronderstellen we dat je in één groot project werkt dat één klasse `Program` heeft. De oefeningen worden los van elkaar omschreven, maar je zorgt ervoor dat ze getest kunnen worden via het keuzemenu in je klasse `Program`.

#### meerdere `Main` methodes
Indien je meerdere klassen hebt met een methode `Main`, moet je aangeven welke normaal gebruikt wordt voor de uitvoering van je programma. Dat doe je door aan je `.csproj`-bestand het volgende toe te voegen: `<StartupObject>Namespace-van-de-opstartklasse.Naam-van-de-opstartklasse</StartupObject>`

{% hint style="danger" %}
Dit staat hier niet zomaar! Als je dit niet doet, zullen je oefeningen niet uitgevoerd kunnen worden. Je `.csproj` file staat in dezelfde map als je `.cs`-bestanden en indien het niet opent in Visual Studio, kan je het openen in Kladblok.
{% endhint %}

Bijvoorbeeld:

```text
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp3.0</TargetFramework>
    <StartupObject>OOP.Program</StartupObject>
  </PropertyGroup>
</Project>
```

(Je file zou er al gelijkaardig moeten uitzien, maar je moet zelf het `StartupObject` toevoegen.)

## Oefening: H8-dag-van-de-week

### Leerdoelen

* aanmaken van `DateTime` objecten
* formatteren van `DateTime` objecten

### Functionele analyse

We willen voor een willekeurige datum kunnen bepalen welke dag van de week het is.

### Technische analyse
* je moet eerst de dag, maand en jaar opvragen en een `DateTime` aanmaken
* daarna moet je laten zien over welke dag van de week het gaat
  * gebruik hiervoor formattering van een `DateTime`
  * laat ook de datum zelf zien in een formaat dat leesbaar is voor de gebruiker
  * als je computer niet volledig ingesteld is op Belgisch Nederlands, kan het resultaat er wat anders uitzien.
* noem de klasse waarin je dit schrijft `DayOfWeekProgram`
  * schrijf je code in de statische methode `Main`
  * roep de statische `Main` van `DayOfWeekProgram` op in het keuzemenu van `Program`

### Voorbeeldinteractie
```text
Welke dag?
> 14
Welke maand?
> 2
Welk jaar?
> 2020
14 februari 2020 is een vrijdag.
```

## Oefening: H8-ticks-sinds-2000

### Leerdoelen

* aanmaken van `DateTime` objecten

### Functionele analyse

We willen weten hoe veel fracties van een seconde al verlopen zijn sinds het begin van de jaren 2000.

### Technische analyse
* .NET stelt deze fracties (1 / 10000 milliseconden) voor als "ticks"
* We willen weten hoe veel ticks er voorbijgegaan zijn sinds het absolute begin van het jaar 2000
* Noem de klasse waarin je dit schrijft `Ticks2000Program`

### Voorbeeldinteractie
```text
Sinds 1 januari 2000 zijn er (hier wordt het aantal getoond) ticks voorbijgegaan.
```

## Oefening: H8-schrikkelteller

### Leerdoelen

* gebruik van een statische property

### Functionele analyse

We willen bepalen hoe veel schrikkeljaren er zijn tussen 1800 en 2020.

### Technische analyse
* implementeer zelf een logica voor schrikkeljaren, maar laat dit over aan de klassen `DateTime`
* maak gebruik van een statische methode van deze klasse
* noem je klasse `LeapYearProgram` en voorzie ze van een `Main`

### Voorbeeldinteractie
```text
Er zijn (hier wordt het aantal getoond) schrikkeljaren tussen 1800 en 2020.
```


## Oefening: H8-simpele-timing

### Leerdoelen
* eenvoudig code leren timen
* gebruiken van `DateTime`
* herhaling arrays

### Functionele analyse
We zijn benieuwd hoe lang het duurt een array van 1 miljoen `int`s te maken en op te vullen met de waarden 1,2,...

### Technische analyse
* Bepaal het tijdstp voor en na aanmaken van de array.
* Vul de array in met een `for`-lus.
* Noem de klasse waarin je dit schrijft `ArrayTimerProgram`

### Voorbeeldinteractie
```text
Het duurt (hier wordt het aantal getoond) milliseconden om een array van een miljoen elementen aan te maken en op te vullen met opeenvolgende waarden.
```

## Oefening: H8-RapportModule-V1

### Leerdoelen

* werken met klassen en objecten
* gebruik maken van simpele properties en methodes

### Functionele analyse

Dit programma geeft op basis van de input van een percentage de graad weer die je met dit gegeven zou behaald hebben.

### Technische analyse

Ontwerp een klasse `ResultV1` die je zal tonen wat je graad is gegeven een bepaald behaald percentage. Het enige dat je aan een `ResultV1`-object moet kunnen geven is het behaalde percentage. Enkel het totaal behaalde percentage wordt bijgehouden. Via een methode `PrintHonors` kan de behaalde graad worden weergegeven. Dit zijn de mogelijkheden:

* &lt; 50: niet geslaagd;
* tussen 50 en 68: voldoende;
* tussen 68 en 75: onderscheiding;
* tussen 75 en 85: grote onderscheiding;
* &gt; 85: grootste onderscheiding.

Je hoeft voorlopig geen rekening te houden met ongeldige waarden. Test je klasse door `ResultV1` ook van een statische methode `Main` te voorzien, waarin je enkele objecten van deze klasse aanmaakt en de verschillende properties waarden te geeft en vervolgens `PrintHonors` oproept.

## Oefening: H8-RapportModule-V2

### Leerdoelen

* werken met klassen en objecten
* gebruik maken van simpele properties en methodes

### Functionele analyse

Dit programma geeft op basis van de input van een percentage de graad weer die je met dit gegeven zou behaald hebben.

### Technische analyse

Ontwerp een klasse `ResultV2` die je zal vertellen wat je graad is gegeven een bepaald behaald percentage. Het enige dat je aan een `ResultV2`-object moet kunnen geven is het behaalde percentage. Enkel het totaal behaalde percentage wordt bijgehouden. Via een methode `ComputeHonors` kan de behaalde graad worden teruggegeven. Dit werkt op dezelfde manier als in versie 1 van deze oefening, maar de verschillende graden worden voorgesteld met een `Enum`, `Honors`. De methode `ComputeHonors` toont het resultaat niet, maar geeft een waarde van deze `Enum` terug. Het is aan de `Main` om deze waarde af te printen, zodat je kan zien of je code werkt.

Test je klasse op dezelfde manier als versie 1. De teruggegeven waarden van `Honors` mag je in de `Main` meegeven aan `Console.WriteLine`.

## Oefening: H8-Getallencombinatie

### Leerdoelen

* werken met klassen en objecten
* gebruik maken van properties

### Functionele analyse

Dit programma geeft op basis van de input van twee getallen de som van beide getallen, het verschil, het product en de deling. In het laatste geval en indien er een deling door nul zou worden uitgevoerd, wordt dit woordelijk weergegeven.

### Technische analyse

Maak een eenvoudige klasse `NumberCombination`. Deze klasse bevat 2 getallen \(type `int`\). Er zijn 4 methoden, die allemaal een `double` teruggeven:

* `Sum`: geeft som van beide getallen weer
* `Difference`: geeft verschil van beide getallen weer
* `Product`: geeft product van beide getallen weer
* `Quotient`: geeft deling van beide getallen weer. Print `"Error"` naar de console indien je zou moeten delen door 0 en voer dan de deling uit. Wat er dan gebeurt, is niet belangrijk.

Gebruik **full properties** voor `Number1` en `Number2` en toon in je `Main` aan dat je code werkt.

Volgende code zou namelijk onderstaande output moeten geven:

```csharp
NumberCombination pair1 = new NumberCombination();
pair1.Number1 = 12;
pair1.Number2 = 34;
Console.WriteLine("Paar:" + pair1.Number1 + ", " + pair1.Number2);
Console.WriteLine("Sum = " + pair1.Sum());
Console.WriteLine("Verschil = " + pair1.Difference());
Console.WriteLine("Product = " + pair1.Product());
Console.WriteLine("Quotient = " + pair1.Quotient());
```

#### Voorbeeldinteractie\(s\)

```text
Paar: 12, 34
Som = 46
Verschil = -22
Product = 408
Quotient = 0,352941176470588
```

## Oefening: H8-Figuren

### Leerdoelen

* werken met klassen en objecten
* gebruik maken van properties om geldige waarden af te dwingen

### Functionele analyse

Dit programma maakt enkele rechthoeken en driehoeken met gegeven afmetingen \(in meter\) aan, berekent hun oppervlakte en toont deze info aan de gebruiker. De rechthoeken en driehoeken die worden aangemaakt, zijn al gecodeerd in het programma. De gebruiker hoeft dus niets anders te doen dan het programma te starten.

### Technische analyse
Er is een klasse `Rectangle` met **properties** `Width` en `Height` en een klasse `Triangle` met `Base` en `Height`. Je programma maakt de figuren die hierboven beschreven worden aan met waarde `1.0` voor elke afmeting en stelt daarna hun afmetingen in via de setters voor deze properties. De oppervlakte wordt bepaald in een read-only property, `Surface` van het type `double`.

Indien om het even welk van deze properties wordt ingesteld op `0` (of minder) wordt er een foutboodschap afgeprint en wordt de afmeting niet aangepast.

De wiskundige formule voor de oppervlakte van een driehoek is basis * hoogte / 2.

Schrijf de voorbeelden uit in de `Main` van een extra klasse, `FigureProgram`.

#### Voorbeeldinteractie\(s\)
(Er worden twee rechthoeken en twee driehoeken aangemaakt. De afmetingen van de eerste rechthoek worden eerst op `-1` en `0` ingesteld.

```text
Het is verboden een breedte van -1 in te stellen!
Het is verboden een breedte van 0 in te stellen!
Een rechthoek met een breedte van 2,2m en een hoogte van 1,5m heeft een oppervlakte van 3,3m².
Een rechthoek met een breedte van 3m en een hoogte van 1m heeft een oppervlakte van 3m².
Een driehoek met een basis van 3m en een hoogte van 1m heeft een oppervlakte van 1,5m².
Een driehoek met een basis van 2m en een hoogte van 2m heeft een oppervlakte van 2m².
```

## Oefening: H8-Studentklasse

### Leerdoelen

* werken met klassen en objecten
* gebruik maken van properties om geldige waarden af te dwingen

### Functionele analyse

Dit programma vraagt om de naam en leeftijd van een student. Er moet ook worden meegeven in welke klasgroep de student is ingeschreven. De groepen zijn `EA1`, `EA2` en `EB1`. Vervolgens worden de punten voor 3 vakken gevraagd, waarna het gemiddelde wordt teruggegeven. 

### Technische analyse

Maak een nieuwe klasse `Student`. Deze klasse heeft 6 properties. Leeftijd en de punten stel je voor met **full properties**. Een student kan nooit ouder zijn dan 120. Je kan ook nooit een cijfer boven 20 behalen. Over leeftijden en cijfers onder 0 hoef je je geen zorgen te maken, want de achterliggende variabelen zijn `byte`s en die zijn altijd minstens 0.

* Name \(string\)
* Age \(byte\)
* ClassGroup \(maak hiervoor een `enum` `ClassGroups`\)
* MarkCommunication \(byte\)
* MarkProgrammingPrinciples \(byte\)
* MarkWebTech \(byte\)

Voeg aan de klasse een read-only property `OverallMark` toe. Deze berekent het gemiddelde van de 3 punten als `double`.

Voeg aan de klasse ook de methode `ShowOverview()` toe. Deze methode zal een volledig rapport van de student tonen \(inclusief het gemiddelde m.b.v. de `OverallMark`-property\).

Test je programma door enkele studenten aan te maken en in te stellen. Volgende statische methode `Main` zet je in de klasse `Student`.

```csharp
Student student1= new Student();
student1.Class = ClassGroups.EA2;
student1.Age = 21;
student1.Name = "Joske Vermeulen";
student1.MarkCommunication = 12;
student1.MarkProgrammingPrinciples = 15;
student1.MarkWebTech = 13;
student1.ShowOverview();
```

#### Voorbeeldinteractie\(s\)

```text
Joske Vermeulen, 21 jaar
Klas: EA2

Cijferrapport:
**********
Communicatie:             12
Programming Principles:   15
Web Technology:           13
Gemiddelde:               13.3
```

## Oefening: H8-RapportModule-V3

### Leerdoelen

* werken met klassen en objecten
* gebruik maken van properties om geldige waarden af te dwingen

### Functionele analyse
Deze is gelijkaardig aan de vorige versie van het programma, maar gebruikt iets geavanceerdere technieken.

### Technische analyse
Maak een nieuwe versie van H8-RapportModule-V2, waarbij je een full property gebruikt voor het percentage. Zorg ervoor dat dit steeds tussen 0 en 100 ligt. Vervang ook `ComputeHonors` door een read-only property, `Honors`.
