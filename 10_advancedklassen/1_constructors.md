# Gevorderde klasseconcepten

## Constructors

### Werking new operator
Objecten die je aanmaakt komen niet zomaar tot leven. Nieuwe objecten maken we aan met behulp van de ``new`` operator zoals we al gezien hebben:

```java
Student FrankVermeulen = new Student();

private int leeftijd= 35;
```

 De ``new`` operator doet 2 dingen:

* Het maakt een object aan in het geheugen
* Het roept de **operator** van het object aan voor eventuele extra initialisatie

Via de constructor van een klasse kunnen we extra code meegeven die moet uitgevoerd worden **telkens een nieuw object van dit type wordt aangemaakt**.

De constructor is een unieke methode die wordt aangeroepen bij het aanmaken van een object, daarom dat we ronde haakjes zetten bij ``new Student()``.

### Soorten constructors

Als programmeur van eigen klassen zijn er 3 opties voor je:

* Je gebruikt geen constructors: het leven gaat voort zoals het is. Je kunt objecten aanmaken zoals eerder getoond.
* Je hebt enkel een **default** constructor nodig. Je kan nog steeds objecten met ``new Student()`` aanmaken, maar je gaat zelf beschrijven wat er moet gebeuren bij de default constructor
* Je wenst gebruik te maken van een of meerdere **overloaded** constructoren, hierbij zal je dan actuele parameters kunnen meegeven bij de creatie van een object, bijvoorbeeld: ``new Student(24, "Jos")``.


{% hint style='warning' %}
### Constructors zijn soms gratis, soms niet

Een lege default constructor voor je klasse krijg je standaard wanneer je een nieuwe klasse aanmaakt. Je ziet deze niet en kan deze niet aanpassen. Je kan echter daarom altijd objecten met ``new myClass()`` aanmaken.

Van zodra je echter beslist om zelf een of meerdere constructors te schrijven zal C# zeggen "ok, jij je zin, nu doe je alles zelf". De default constructor die je gratis kreeg zal ook niet meer bestaan en heb je die dus nodig dan zal je die dus zelf moeten schrijven!
{% endhint %}


## Default constructors

De default constructor is een constructor die geen extra parameters aanvaardt. Een constructor bestaat ALTIJD uit volgende vorm:

* Dit semester is iedere constructor altijd ``public``
* Heeft geen returntype, ook niet ``void``.
* Heeft als naam de naam van de klasse zelf.

Stel dat we een klasse ``Student`` hebben:

```java
class Student
{
    private int age;
}

```

We willen telkens een Student-object wordt aangemaakt dat deze een random leeftijd heeft. Via de default constructor kunnen we dat oplossen (je kan namelijk niet schrijven ``private int age = random.Next(10,20)`` )

Eerst schrijven de default constructor, deze ziet er als volgt uit:

```java
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

```java
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


Telkens we nu een object zouden aanmaken met ``new Student()`` zal deze een willekeurige leeftijd hebben.

### Opmerking bij voorgaande code

* Als je twee of meerdere Studenten snel in je code na mekaar aanmaakt zullen deze dezelfde leeftijd hebben. Dit is omdat ieder object z'n eigen ``Random`` aanmaakt en zoals we weten zal een random generator dezelfde getallen genereren als deze vlak na mekaar (in tijd) zijn aangemaakt. Een oplossing zullen we hier later voor zien. Spoiler, ``static`` is de oplossing hiervoor:

```java
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

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)
* [Constructors intro en default constructor](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=8d9b4ad8-2732-47e7-8972-ab7a00935196)
<!---NOBOOKEND--->

