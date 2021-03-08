# Constructors

## Constructors

### Werking new operator

Objecten die je aanmaakt komen niet zomaar tot leven. Nieuwe objecten maken we aan met behulp van de `new` operator zoals we al gezien hebben:

```csharp
Student FrankVermeulen = new Student();

private int leeftijd= 35;
```

De `new` operator doet 2 dingen:

* Het maakt een object aan in het geheugen
* Het roept de **operator** van het object aan voor eventuele extra initialisatie

Via de constructor van een klasse kunnen we extra code meegeven die moet uitgevoerd worden **telkens een nieuw object van dit type wordt aangemaakt**.

De constructor is een unieke methode die wordt aangeroepen bij het aanmaken van een object, daarom dat we ronde haakjes zetten bij `new Student()`.

## Soorten constructors

Als programmeur van eigen klassen zijn er 3 opties voor je:

* Je gebruikt geen constructors: het leven gaat voort zoals het is. Je kunt objecten aanmaken zoals eerder getoond.
* Je hebt enkel een **default** constructor nodig. Je kan nog steeds objecten met `new Student()` aanmaken, maar je gaat zelf beschrijven wat er moet gebeuren bij de default constructor
* Je wenst gebruik te maken van een of meerdere **overloaded** constructoren, hierbij zal je dan extra argumenten kunnen meegeven bij de creatie van een object, bijvoorbeeld: `new Student(24, "Jos")`.

{% hint style="warning" %}
### Constructors zijn soms gratis, soms niet

Een lege default constructor voor je klasse krijg je standaard wanneer je een nieuwe klasse aanmaakt. Je ziet deze niet en kan deze niet aanpassen. Je kan echter daarom altijd objecten met `new myClass()` aanmaken.

Van zodra je echter beslist om zelf een of meerdere constructors te schrijven zal C\# zeggen "ok, jij je zin, nu doe je alles zelf". De default constructor die je gratis kreeg zal ook niet meer bestaan en heb je die dus nodig dan zal je die dus zelf moeten schrijven!
{% endhint %}

### Default constructor

De default constructor is een constructor die geen extra parameters aanvaardt. Een constructor bestaat ALTIJD uit volgende vorm:

* Dit semester is iedere constructor altijd `public` \([meer info](https://stackoverflow.com/questions/30995942/do-constructors-always-have-to-be-public)\)
* Heeft geen returntype, ook niet `void`.
* Heeft als naam de naam van de klasse zelf.

Stel dat we een klasse `Student` hebben:

```csharp
class Student
{
    private int age;
}
```

We willen telkens een Student-object wordt aangemaakt dat deze een random leeftijd heeft. Via de default constructor kunnen we dat oplossen \(je kan namelijk niet schrijven `private int age = random.Next(10,20)` \)

Eerst schrijven de default constructor, deze ziet er als volgt uit:

```csharp
class Student
{
    public Student()
    {
        // zet hier de code die bij initialisatie moet gebeuren
    }

    private int age;
}
```

Zoals verteld moet de constructor de naam van de klasse hebben, public zijn en geen returntype definiëren.

Vervolgens voegen we de code toe die we nodig hebben:

{% hint style="danger" %}
Dit is in veel programmeertalen slecht gebruik van `Random`, maar we hebben nog niet de nodige achtergrond om de juiste werkwijze te tonen. Dat komt binnenkort!
{% endhint %}

```csharp
class Student
{
    public Student()
    {
        Random r= new Random();
        age= r.Next(10,20);
    }

    private int age;
}
```

Telkens we nu een object zouden aanmaken met `new Student()` zal deze een willekeurige leeftijd hebben.

#### Opmerking bij voorgaande code

* Als je op een gelijkaardige manier in andere programmeertalen twee of meerdere Studenten snel na mekaar aanmaakt zullen deze dezelfde leeftijd hebben. Dit is omdat ieder object z'n eigen `Random` aanmaakt en zoals we weten zal een random generator dezelfde getallen genereren als deze vlak na mekaar \(in tijd\) zijn aangemaakt. Een oplossing zullen we hier later voor zien. Spoiler, `static` is de oplossing hiervoor:

```csharp
class Student
{
    static Random r= new Random();
    public Student()
    {
        age= r.Next(10,20);
    }

    private int age;
}
```

#### Constructor met parameter\(s\)

Soms wil je argumenten aan een object meegeven bij creatie. We willen bijvoorbeeld de leeftijd meegeven die het object moet hebben bij het aanmaken. Met andere woorden, stel dat we dit willen schrijven:

```csharp
Student jos= new Student(19);
```

Als we dit met voorgaande klasse , die enkel een default constructor heeft, uitvoeren zal de code een fout geven. C\# vindt geen constructor die een int als parameter aanvaardt.

[Net zoals bij overloading van methoden](https://github.com/v-nys/cursusprogrammeren/tree/e865f37d2ea41dc32c32aa2e02a9a763c7ea56f5/semester-1-programming-principles/h6-methoden/3_advancedmethod.md) kunnen we ook constructors overloaden. De code is verrassen gelijkaardig als bij method overloading:

```csharp
class Student
{
    public Student(int startage)
    {
        age= startage
    }

    private int age;
}
```

Dat was eenvoudig. **Maar** denk eraan: je hebt een eigen constructor geschreven en dus heeft C\# gezet "ok, je schrijft zelf constructor, trek je plan. Maar de default zal je ook zal moeten schrijven!" Je kan nu enkel je objecten met `new Student(25)` aanmaken. Schrijf je `new Student()` dan zal je een error krijgen. Wil je die constructor nog hebben, dan zal je die met de hand moeten schrijven, bijvoorbeeld:

```csharp
class Student
{
    public Student(int startage) // met parameter
    {
        age= startage;
    }

    public Student() //default
    {
        Random r= new Random();
        age= r.Next(10,20);
    }

    private int age;
}
```

#### Wanneer heb ik constructoren nodig?

Tot zeer recent maakten we onze objecten steeds aan met de default constructor. Pas daarna gaven we eventuele properties de juiste waarde. Dat houdt een risico in: er is een periode waarin onze objecten nog niet "af" zijn. In het slechtste geval vergeten we zelfs om de properties in te stellen en krijgen we objecten die misschien ongeldig zijn.

Constructoren helpen dit probleem te voorkomen. Als we één constructor hebben, bijvoorbeeld `Student(string name)`, **moeten** we die gebruiken. We kunnen dus niet vergeten bijvoorbeeld `frankVermeulen.Name = "Frank Vermeulen"` te schrijven, want we worden gedwongen meteen `new Student("Frank Vermeulen")` te schrijven.

Samengevat: **als er eigenschappen zijn die je meteen bij het aanmaken van een object wil instellen, maak er dan parameters van een constructor voor**.

**Overloaded constructoren**

Wil je meerdere overloaded constructors, dan mag dat ook. Je wilt misschien een constructor die de leeftijd vraag alsook een bool om mee te geven of het om een werkstudent gaat:

```csharp
class Student
{
    public Student(int startage) //overloaded
    {
        age= startage;
    }

    public Student(int startage, bool werkstart) //overloaded
    {
        age= startage;
        isWerkStudent= werkstart;
    }

    public Student() //default
    {
        Random r= new Random();
        age= r.Next(10,20);
    }

    private int age;
    private bool isWerkStudent
}
```

**Constructor chaining**

Als je meerdere overloaded constructoren hebt, hoef je niet in elke constructor alle code voor objectinitialisatie te schrijven. Het sleutelwoordje `this` biedt de mogelijkheid **eerst** een andere constructor aan te roepen en eventueel andere operaties toe te voegen. Dit heet **constructor chaining**. In bovenstaand voorbeeld kan je ook dit schrijven:

```csharp
class Student
{
    public Student(int startage) : this(startage, false)
    {
    // niet nodig hier code uit uitgebreidere constructor te herhalen
    // hier kan nog extra code worden uitgevoerd na de oproep van de uitgebreide constructor
    }

    public Student(int startage, bool werkstart) //overloaded
    {
        age= startage;
        isWerkStudent=werkstart;
    }

    public Student() //default
    {
        // helaas wordt onderstaande code pas **na** de chained constructor opgeroepen
    // gebruik van this heeft hier dus niet veel zin
        Random r= new Random();
        age= r.Next(10,20);
    }

    private int age;
    private bool isWerkStudent
}
```

## Kennisclip

![](../../.gitbook/assets/infoclip%20%282%29.png)

* [Constructors intro en default constructor](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=8d9b4ad8-2732-47e7-8972-ab7a00935196)

