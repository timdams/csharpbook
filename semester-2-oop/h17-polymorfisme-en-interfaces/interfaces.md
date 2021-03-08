# Interfaces

{% hint style="success" %}
[Kennisclip](https://www.youtube.com/watch?v=W0U06nzXh58)
{% endhint %}

## Betekenissen

Het woord "interface" heeft meerdere betekenissen:

* de totale verzameling methodes en properties van een bepaalde klasse
  * hierin wordt soms onderscheid gemaakt tussen de publieke interface en de totale interface
* een _language construct_ dat toestaat vast te leggen dat bepaalde methodes of properties deel uitmaken van de publieke interface in de eerste zin van het woord

Je moet beide betekenissen begrijpen. De eerste is meer een abstract concept, de tweede kan je programmeren in C\# en staat toe nog meer polymorfisme toe te passen.

{% hint style="warning" %}
Deze pagina heeft niet echt iets te maken met "grafische user interface". Ook daar wil "interface" zeggen "wat je kan gebruiken", maar verder is er geen verband.
{% endhint %}

Een interface als _language construct_ is een garantie dat bepaalde methodes en properties geïmplementeerd zijn door een bepaalde klasse. Dit vertelt ons niets over hoe deze methodes en properties geïmplementeerd zijn.

## Interfaces in C\#

Volgende code toont hoe we een interface implementeren voor data die we naar een CSV-file willen kunnen wegschrijven en die we terug willen kunnen uitlezen.

```csharp
interface ICSVSerializable
{
    string ToCsv();
    
    string Separator
    {
        get;
        set;
    }
}
```

Enkele opmerkingen:

* Het woord `class` wordt niet gebruikt, in de plaats daarvan gebruiken we `interface`.
* Het is een vrij algemene afspraak om interfaces met een `I` te laten starten in hun naamgeving
* Methoden en properties gaan niet vooraf van `public`: interfaces zijn van nature net publiek, dus alle methoden en properties van de interface zijn dat bijgevolg ook.
* Er wordt geen code/implementatie gegeven: iedere methode eindigt ogenblikkelijk met een puntkomma.
* Interfaces kunnen geen `static` members bevatten in C\#.

Als we deze interface nu koppelen aan een klasse, moeten we deze methodes implementeren.

{% hint style="info" %}
Een interface is een beschrijving hoe een component een andere component kan gebruiken, zonder te zeggen hoe dit moet gebeuren. De interface is met andere woorden 100% scheiding tussen de methode/Property-signatuur en de eigenlijke implementatie ervan.
{% endhint %}

### Regels voor interfaces

* Je kan geen velden declareren in een interface
* Je kan geen constructor declareren
* Je kan geen access specificeren \(`public`, `protected`, etc\): alles is public
* Een interface kan niet overerven van een klasse, wel van een andere interface. In dat geval moet een implementatie de velden en properties van de ouderinterface en de kindinterface voorzien.

### Toepassing interfaces

Volgende code toont hoe we kunnen aangeven dat een klasse `Student` serialisatie van en naar CSV voorziet:

```csharp
class Student : ICSVSerializable
{
    private string naam;
    private string leeftijd;
    private string separator;
    public Separator {
        get {
            return this.separator
        }
        set {
            this.separator = value;
        }
    }
    
    public Student(string naam, byte leeftijd) {
        this.naam = naam;
        this.leeftijd = leeftijd;
        this.Separator = ";";
    }
    
    public string ToCsv() {
        return $"Student{Separator}{this.naam}{Separator}{this.leeftijd}"
    }
}
```

Een nuttige toepassing van deze interface zou een data dump kunnen zijn. Als we een lijst bijhouden van alle `ICSVSerializable` objecten, kunnen we deze in één beweging exporteren. De code die deze export uitvoert mag dezelfde zijn voor allerlei verschillende soorten data: studenten, huisdieren, voedingsproducten,... Maakt niet uit!

### Meerdere interfaces

Het is toegelaten meerdere interfaces te implementeren. Volgende code staat toe een `Student` op te slaan op schijf door hem te serialiseren als CSV of XML, naargelang je voorkeur.

```csharp
interface IXmlSerializable
{
    string ToXml();
}

class Student : ICSVSerializable, IXMLSerializable
{
    private string naam;
    private string leeftijd;
    private string separator;
    public Separator {
        get {
            return this.separator
        }
        set {
            this.separator = value;
        }
    }
    
    public Student(string naam, byte leeftijd) {
        this.naam = naam;
        this.leeftijd = leeftijd;
    }
    
    public override string ToCsv() {
        return $"Student;{this.naam};{this.leeftijd}";
    }
    
    public override string ToXml() {
        return $@"<Student>
                    <naam>{this.naam}</naam>
                    <leeftijd>{this.leeftijd}</leeftijd>
                  </Student>";
    }
}
```

## Interfaces vs. overerving

Je kan je hier terecht afvragen of we interfaces wel nodig hebben, aangezien we abstractie en polymorfisme ook kunnen bereiken met behulp van \(al dan niet abstracte\) klassen. Maar er zijn goede redenen voor het bestaan van interfaces:

* Om technische redenen kan een klasse maar één ouderklasse hebben. Een klasse kan wel om het even welk aantal interfaces implementeren. Er zijn weliswaar talen waarin je meerdere ouderklassen kan hebben, maar daarin is een object altijd "iets meer" ouderklasse 1 dan ouderklasse 2 en dat kan heel onoverzichtelijk worden.
* Er is een betekenisverschil: een kindklasse **is** een specifieker type van de ouderklasse. Een klasse die een interface implementeert **kan** gewoon bepaalde zaken. Dit is een beetje een kwestie van interpretatie, maar als vuistregel leidt dit tot betere ontwerpen dan lukraak gebruik van overerving.
* Er is een praktisch verschil: bij overerving wil je **veel** overnemen van de ouderklasse, want zo bespaar je code. Interfaces wil je juist **beperkt** houden: je moet elk van je interfaces volledig implementeren.

Deze puntjes samen leiden ook tot een tweede vuistregel voor het gebruik van interfaces: kan je wel \(veel\) code besparen met overerving? Bijvoorbeeld bij `ToCsv` zal de methode voor elk object verschillen en win je dus niets met een ouderklasse tegenover een interface, terwijl je wel zorgt dat je geen andere ouderklasse meer kan hebben.



