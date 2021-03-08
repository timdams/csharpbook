# Properties

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/qIg23NniDkM)
{% endhint %}

Properties zijn een feature van C♯ om de leesbaarheid van code te verhogen. Ze zien er uit zoals attributen, maar werken zoals methoden.

{% hint style="info" %}
Methoden behoren tot een algemenere categorie onderdelen van objecten genaamd **members**.
{% endhint %}

## Properties

In dit hoofdstuk bespreken we eerst waarom properties nuttig zijn. Vervolgens bespreken we de 2 soorten properties die er bestaan:

1. Full properties
2. Auto properties

#### In een wereld zonder properties

Stel dat we volgende klasse hebben:

```csharp
public class Auto
{
    private int kilometers;
    private double benzine;
}
```

Stel nu dat we het benzinepeil van een auto als volgt proberen aanpassen:

```csharp
Auto auto = new Auto();
auto.benzine += 10; //DIT ZAL DUS NIET WERKEN, daar benzine private is.
```

Misschien is de eerdere methode `TankVol()` te beperkt en willen we wel een willekeurige hoeveelheid benzine kunnen toevoegen of verwijderen, zo lang we niet minder dan 0l of meer dan 50l in de tank doen.

Een eerste mogelijkheid is om hier methodes voor te schrijven:

```csharp
public class Auto
{
    private int kilometers;
    private double benzine;
    public double GetBenzine() {
        return this.benzine;
    }
    public void SetBenzine(double waarde) {
        if(waarde >= 0 && waarde <= 50) {
            this.benzine = waarde;
        }
    }
}
```

Dit gaat. De methodes zijn public, dus we kunnen ze overal oproepen. Bovendien verhindert de `SetBenzine`-methode ongeldige waarden. Het nadeel is dat de syntax om deze methodes te gebruiken zwaar is. Met publieke attributen konden we dit doen:

```csharp
Auto auto = new Auto();
auto.Benzine += 10;
```

Met de zogenaamde **getter** en **setter** moeten we dit doen:

```csharp
Auto auto = new Auto();
auto.SetBenzine(auto.GetBenzine() + 10);
```

Het lijkt niet zo veel, maar code stapelt zich op doorheen de tijd. Properties lossen dit probleem op. Ze zorgen ervoor dat we kunnen "doen alsof" we publieke velden hebben, maar dezelfde hoeveelheid controle kunnen uitoefenen als met getters en setters.

### Full properties

Een **full property** ziet er als volgt uit:

```csharp
class Auto
{
    private int kilometers;
    private double benzine;

    public double Benzine
    {
        get
        {
            return benzine;
        }
        set
        {
            benzine = value;
        }
    }
}
```

Dankzij deze code kunnen we nu elders dit doen:

```csharp
Auto auto = new Auto();
auto.Benzine = 20; //set
Console.WriteLine($"Het benzinepeil is {auto.Benzine}"); //get
```

Vergelijk dit met de vorige alinea waar we dit met Get en Set methoden moesten doen. Deze property syntax is veel eenvoudiger in het gebruik.

We zullen de property nu stuk per stuk analyseren:

* `public double Benzine`: Merk op dat we `Benzine` met een hoofdletter schrijven. Vaak wordt gekozen voor dezelfde naam als de variabele die we afschermen \(in dit geval `benzine` met een kleine "b"\), maar dan in Pascal case. Dat is niet strikt noodzakelijk. Je zou ook `Naft` kunnen schrijven. `public` en `double` staan er om dezelfde reden als in de oplossing met methodes `GetBenzine()` en `SetBenzine()`: we willen deze property buiten de klasse kunnen gebruiken en als we hem opvragen, krijgen we een `double`.
* { }: Vervolgens volgen 2 accolades waarbinnen we de werking van de property beschrijven.
* `get {}`: indien je wenst dat de property data **naar buiten** moet sturen, dan schrijven we de `get`-code. Binnen de accolades van de `get` schrijven we wat er naar buiten moet gestuurd worden. In dit geval `return benzine` maar dit mag even goed bijvoorbeeld `return 4` of een hele reeks berekeningen zijn. Eigenlijk werkt dit net als de body van een methode en kan je hierin doen wat je in een methode kan doen.
  * We kunnen nu van buitenaf toch de waarde van `benzine` onrechtstreeks uitlezen via de property en het `get`-gedeelte: `Console.WriteLine(auto.Benzine);`
* `set {}`: in het `set`-gedeelte schrijven we de code die we moeten hanteren indien men van buitenuit een waarde aan de property wenst te geven om zo een instantievariabele aan te passen. De waarde die we van buitenuit krijgen \(eigenlijk is dit een parameter van een methode\) zal **altijd** in een lokale variabele `value` worden bewaard. Deze zal van het type van de property zijn. In dit geval dus `double`, want het type bij `Benzine` is `double`. Vervolgens kunnen we `value` toewijzen aan de interne variabele indien gewenst: `benzine=value` .

{% hint style="danger" %}
Let goed op dat je in je setter schrijft `benzine = value` en niet `Benzine = value`. Dat eerste past de verborgen instantievariabele aan. Dat tweede roept de setter opnieuw op. En opnieuw. En opnieuw. Probeer gerust eens een breakpoint te plaatsen voor de toekenning en dan de debugger te starten als je niet ziet waarom dit een probleem is.
{% endhint %}

{% hint style="info" %}
Visual Studio heeft een ingebouwde shortcut om snel een full property, inclusief een bijhorende private dataveld, te schrijven. **Typ `propfull` gevolgd door twee tabs!**
{% endhint %}

#### Full property met toegangscontrole

De full property `Benzine` heeft nog steeds het probleem dat we negatieve waarden kunnen toewijzen \(via de `set`\) die dan vervolgens zal toegewezen worden aan `benzine`.

We kunnen in de `set` code extra controles inbouwen. Als volgt:

```csharp
   public double Benzine
    {
        get
        {
            return benzine;
        }
        set
        {
            if(value >= 0 and value <= 50) {
                benzine = value;
            }
        }
    }
```

Deze code zal het benzinepeil enkel aanpassen als het geldig is en anders stilletjes niets doen. Wat je vaak tegenkomt is `throw new ArgumentException($"{value} is geen geldig benzinepeil")`. Dit doet je programma crashen, maar legt ook uit waarom. We kunnen de code binnen `set` \(en `get`\) zo complex maken als we zelf willen.

{% hint style="warning" %}
Je kan dus extra controles toevoegen, maar deze hebben alleen zin als je de variabele **via de property** aanpast. Als je in een methode van de klasse auto `benzine` met kleine "b" aanpast en niet voorzichtig bent, kan je nog steeds een negatief peil instellen. Daarom wordt aangeraden **ook binnen de klasse** gebruik te maken van de property, dus zo veel mogelijk `Benzine` in plaats van `benzine` te gebruiken.
{% endhint %}

#### Property variaties

We zijn niet verplicht om zowel de `get` en de `set` code van een property te schrijven.

**Write-only property**

```csharp
   public double Benzine
    {
        set
        {
            if(value >= 0) {
                benzine = value;
            }
        }
    }
```

We kunnen dus enkel `benzine` een waarde geven, maar niet van buitenuit uitlezen.

#### Read-only property

```csharp
   public double Benzine
    {
        get
        {
            return benzine;
        }
    }
```

**Read-only property met private set**

Soms gebeurt het dat we van buitenuit enkel de gebruiker de property read-only willen maken. We willen echter intern \(in de klasse zelf\) nog steeds controleren dat er geen illegale waarden aan private datafields worden gegeven. Op dat moment definieren we een read-only property met een private setter:

```csharp
   public double Benzine
    {
        get
        {
            return benzine;
        }
        private set
        {
            if(value >= 0) {
                benzine = value;
            }
        }
    }
```

Van buitenuit zal enkel code werken die de`get`-van deze property aanroept: `Console.WriteLine(auto.Benzine);`. Code die de `set` van buitenuit nodig heeft zal een fout geven zoals: `auto.Benzine=40`.

**Read-only Get-omvormers**

Veel properties bieden toegang tot een achterliggende variabele van hetzelfde type, maar dat is niet verplicht. Je kan ook iets berekenen en dat teruggeven via een getter.

Als we verder gaan met de klasse `Auto`:

```csharp
public class Auto
{
    private int kilometers;
    private double benzine;
    // stelt het aantal blokjes benzine voor op je display
    // bij 50l heb je 5 blokjes
    // bij tussen 40 en 50l heb je 4 blokjes
    // ...
    // bij minder dan 10l heb je 0 blokjes
    public int Blokjes {
        get {
            return Math.Floor(this.benzine / 10);
        }
    }
}
```

Je hebt iets gelijkaardigs gezien bij `DateTime`. Daar kan je allerlei stukjes informatie uit opvragen, maar eigenlijk wordt er maar één ding bijgehouden: het aantal "ticks". Dat zijn fracties van seconden sinds een bepaalde startdatum. Als je het uur of het aantal minuten of de maand of de weekdag of nog iets anders opvraagt via een `DateTime`, wordt deze ter plekke berekend uit het aantal ticks. Zo moet maar één stukje informatie worden bijgehouden, wat leidt tot minder fouten.

### Auto properties

Automatische eigenschappen \(autoproperties\) in C\# staan toe om eigenschappen \(properties\) die enkel een waarde uit een private variabele lezen en schrijven verkort voor te stellen. Ze zorgen dat je al snel properties hebt, maar staan je niet toe complexe berekeningen te doen of waarden te controleren zoals full properties dat wel doen.

Voor `Auto` kan je bijvoorbeeld schrijven:

```csharp
public class Auto
{
    public double Benzine
    { get; set; }
}
```

Dit maakt achter de schermen een privé-attribuut aan zoals `benzine` met kleine "b", maar met een een verborgen naam. We kunnen dus niet rechtstreeks aan dat attribuut.

Wij zullen niet veel gebruik maken van autoproperties, omdat het verschil met publieke attributen pas in meer geavanceerde scenario's zichtbaar wordt. We geven ze hier mee zodat je ze kan herkennen als je ze tegenkomt.

