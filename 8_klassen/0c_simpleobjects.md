### De anatomie van een klasse

We zullen nu enkele basisconcepten van klassen en objecten toelichten aan de hand van praktische voorbeelden.

#### Object methoden

Stel dat we een klasse willen maken die ons toelaat om objecten te maken die verschillende mensen voorstellen. We willen aan iedere mens kunnen vragen waar deze woont en die zal dat dan op het scherm tonen.

We maken een nieuwe klasse ``Mens`` en maken een methode ``Praat`` die iets op het scherm zet:

```java
class Mens
{
    public void Praat()
    {
        Console.WriteLine("Ik ben een mens!");
    }
}
```

We zien twee nieuwe aspecten:

* Het keyword **``static``** komt bij een klasse niet aan te pas (of toch minder zoals we [later zullen zien](/10_advancedklassen/5_static.md))
* Voor de methode plaatsen we ``public`` : dit leggen we zo meteen uit

Je kan nu elders objecten aanmaken en ieder object z'n methode ``Praat`` aanroepen:

```java
Mens joske = new Mens();
Mens alfons = new Mens();

joske.Praat();
alfons.Praat();
```

Er zal 2x ``Ik ben een mens!`` op het scherm verschijnen. Waarbij telkens ieder object (``joske`` en ``alfons``) zelf verantwoordelijk ervoor waren dat dit gebeurde.

#### Public en private access modifiers


De **access modifier** geeft aan hoe zichtbaar een bepaald deel van de klasse is. Wanneer je niet wilt dat "van buitenuit" (bv objecten van je klasse in de Main) een bepaalde methode kan aangeroepen worden, dan dien je deze als ``private`` in te stellen. Wil je dit net wel dat moet je er expliciet ``public`` voor zetten.

Test in de voorgaande klasse eens wat gebeurt wanneer je ``public`` verwijderd voor de methode. Inderdaad, je zal de methode ``Praat`` niet meer op de objecten kunnen aanroepen.

De reden: **wanneer je voor een methode (of klasse) niet expliciet ``public`` zet, dan kan deze methode niet van uit alle andere klassen worden aangeroepen.**

Test volgende klasse eens, kan je de methode ``VertelGeheim`` vanuit de Main op ``joske`` aanroepen?

```java
class Mens
{
    public void Praat()
    {
        Console.WriteLine("Ik ben een mens!");
    }

    void VertelGeheim()
    {
        Console.WriteLine("Mijn geheim is dat ik leef!");
    }
}
```

Als je duidelijk wil maken dat bepaalde code niet van buitenaf aangeroepen kan worden, schrijf dan ``private`` in plaats van ``public``. Als je geen van beide schrijft, zit je code ergens tussenin ``public`` en ``private`` (zie later). Als beginnende programmeur maak je er best een gewoonte van duidelijk te kiezen voor ``public`` of ``private``.

#### Reden van private

Waarom zou je bepaalde zaken ``private`` maken? 

Stel dat we in de klasse extra (hulp)methoden willen gebruiken die enkel intern nodig zijn, dan doen we dit. Volgende voorbeeld toont hoe we in de methode ``Praat`` de private methode ``VertelGeheim`` gebruiken:


```java
class Mens
{
    public void Praat()
    {
        Console.WriteLine("Ik ben een mens!");
        VertelGeheim();
    }

    void VertelGeheim()
    {
        Console.WriteLine("Mijn geheim is dat ik leef!");
    }
}
```

Als we nu elders een object laten praten als volgt:

```java
Mens rachid = new Mens();
rachid.Praat();
```

Dan zal de uitvoer worden:

{line-numbers:false}
```text
Ik ben een mens!
Mijn geheim is dat ik leef!
```

#### Instantievariabelen

We maken onze klasse wat groter, we willen dat een object een leeftijd heeft die we kunnen verhogen via een methode ``VerjaardagVieren`` (we hebben de methode ``VertelGeheim`` even weggelaten):

```java
class Mens
{
    private int leeftijd = 1;

    public void VerjaardagVieren()
    {
        Console.WriteLine("Hiphip hoera voor mezelf!");
        leeftijd++;
        Praat();
    }

    public void Praat()
    {
        Console.WriteLine("Ik ben een mens! ");
        Console.WriteLine($"Ik ben {leeftijd} jaar oud");
    }

}
```

Hier zien we een pak details die onze aandacht vereisen:

* Ook variabelen zoals ``int leeftijd`` mogen een access modifier krijgen in een klasse. Ook hier, als je niet expliciet ``public`` zet wordt deze als ``private`` beschouwd.
* Ook al is ``leeftijd`` ``private`` alle methoden in de klasse kunnen hier aan. Het is enkel langs buiten dat bijvoorbeeld volgende code niet zal werken ``rachid.leeftijd = 34;``.
* We kunnen iedere variabele een beginwaarde geven.
* **Ieder object zal z'n eigen leeftijd hebben.**

Die laatste opmerking is een kernconcept van OOP: ieder object heeft z'n eigen interne staat die kan aangepast worden individueel van de andere objecten van hetzelfde type.

We zullen dit testen in volgende voorbeeld waarin we 2 objecten maken en enkel 1 ervan laten verjaren. Kijk wat er gebeurt:

```java
Mens Elvis = new Mens();
Mens Bono = new Mens();

Elvis.VerjaardagVieren();
Elvis.VerjaardagVieren();
Evlis.VerjaardagVieren();
Bono.VerjaardagVieren();
```

Als je deze code zou uitvoeren zal je zien dat de leeftijd van Elvis verhoogt en niet die van Bono wanneer we ``VerjaardagVieren`` aanroepen. Zoals het hoort!

#### Initiële waarde van een instantievariabele
Bekijk opnieuw het voorbeeld:

```java
class Mens
{
    private int leeftijd = 1;

    public void VerjaardagVieren()
    {
        Console.WriteLine("Hiphip hoera voor mezelf!");
        leeftijd++;
        Praat();
    }

    public void Praat()
    {
        Console.WriteLine("Ik ben een mens! ");
        Console.WriteLine($"Ik ben {leeftijd} jaar oud");
    }

}
```

De eerste regel binnenin de klasse betekent dat een ``Mens`` wordt aangemaakt met een leeftijd van 1 jaar. WE noemen dit de initiële waarde van de instantievariabele ``leeftijd``. Het is niet verplicht deze te voorzien. Als je niet aangeeft welke waarde een variabele krijgt (hier of in, zoals we iets verder zullen zien, de constructor), dan zal de instantievariabele een defaultwaarde krijgen die afhangt van zijn type.
