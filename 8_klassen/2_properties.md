## Properties

In dit hoofdstuk bespreken we eerst waarom properties nodig zijn. Vervolgens bespreken we de 2 soorten properties die er bestaan:

1. Full properties
2. Auto properties


### In een wereld zonder properties 
Properties (*eigenschappen*) zijn de C# manier om objecten hun interne staat in en uit te lezen.
Ze zorgen voor een gecontroleerde toegang tot de interne structuur van je objecten.

Stel dat we volgende klasse hebben:
```java
class SithLord
{
    private int energy;
    private string sithName;
}
```

Een ``SithLord`` heeft steeds een verborgen Sith Name en ook een hoeveelheid energie die hij nodig heeft om te strijden.
**Het is uit den boze dat we eenvoudige data fields (``energy`` en ``name``) ``public`` maken.** Zouden we dat wel doen dan kunnen externe objecten deze geheime informatie uitlezen!

```java
SithLord Palpatine= new SithLord();
Console.WriteLine(Palpatine.sithName); //DIT ZAL DUS NIET WERKEN, daar sithName private is.
```

We willen echter wel van buiten uit het energy-level van een sithLord kunnen instellen. Maar ook hier hetzelfde probleem: wat als we de energy-level op -1000 instellen? Terwijl energy nooit onder 0 mag gaan.

**Properties** lossen dit probleem op*


### Full properties

Een **full property** ziet er als volgt uit:
```java
class SithLord
{
    private int energy;
    private string sithName;

    public int Energy
    {
        get
        {
            return energy;
        }
        set
        {
            energy=value;
        }
    }
}
```

Dankzij deze code kunnen we nu elders dit doen:

```java
SithLord Vader= new SithLord();
Vader.Energy= 20; //set
Console.WriteLine($"Vaders energy is {Vader.Energy}"); //get
```

Vergelijk dit met de vorige alinea waar we dit met Get en Set methoden moesten doen. Deze property syntax is veel eenvoudiger.


We zullen de property nu stuk per stuk analyseren:
* ``public int Energy``: een property is altijd ``public``. Vervolgens zeggen we wat voor type de property moet zijn en geven we het een naam. Indien je de property gaat gebruiken om een intern dataveld naar buiten beschikbaar te stellen, dan is het een goede gewoonte om dezelfde naam als dat veld te nemen maar nu met een hoofdletter. (dus ``Energy`` i.p.v. ``energy``).
* { }: Vervolgens volgen 2 accolades waarbinnen we de werking van de property beschrijven.
* ``get {}``: indien je wenst dat de property data **naar buiten** moet sturen, dan schrijven we de get-code. Binnen de accolades van de get schrijven we wat er naar buiten moet gestuurd worden. In dit geval ``return energy`` maar dit mag even goed bijvoorbeeld ``return 4`` of een hele reeks berekeningen zijn. Het element dat je returnt in de get code moet uiteraard van hetzelfde type zijn als waarmee je de property hebt gedefinieerd (``int`` in dit geval).
    * We kunnen nu van buitenaf toch de waarde van ``energy`` uitlezen via de property en het get-gedeelte: ``Console.WriteLine(Palpatine.Energy);``
* set{}: in het set-gedeelte schrijven we de code die we moeten hanteren indien men van buitenuit een waarde aan de property wenst te geven om zo een interne variabele aan te passen. De waarde die we van buitenuit krijgen (als een parameter zeg maar) zal **altijd** in een lokale variabele ``value`` worden bewaard. Deze zal van het type van de property zijn. Vervolgens kunnen we ``value`` toewijzen aan de interne variabele indien gewenst: ``energy=value`` 
    * We kunnen vanaf nu van buitenaf waarden toewijzen aan de property en zo ``energy`` toch bereiken: ``Palpatine.Energy=50``.

{% hint style='tip' %}
**Snel properties schrijven**

Visual Studio heeft een ingebouwde shortcut om snel een full property, inclusief een bijhorende private dataveld, te schrijven. **Typ ``propfull`` gevolgd door twee tabs!**
{% endhint %}


### Full property met toegangscontrole
De full property ``Energy`` heeft nog steeds het probleem dat we negatieve waarden kunnen toewijzen (via de ``set``) die dan vervolgens zal toegewezen worden aan ``energy``.

**Properties hebben echter de mogelijkheid om op te treden als wachters van en naar de interne staat van objecten.**

We kunnen in de ``set`` code extra controles inbouwen. Als volgt:

```java
   public int Energy
    {
        get
        {
            return energy;
        }
        set
        {
            if(value>=0)
                energy=value;
        }
    }
```
Enkel indien de toegewezen waarde groter of gelijk is aan 0 zal deze ook effectief aan ``energy`` toegewezen worden.
Volgende lijn zal dus geen effect hebben:
`` Palpatine.Energy=-1;``

We kunnen de code binnen ``set`` (en ``get``) zo complex maken als we willen.

### Property variaties
We zijn niet verplicht om zowel de ``get`` en de ``set`` code van een property te schrijven. 

#### Write-only property
```java
   public int Energy
    {
        set
        {
            if(value>=0)
                energy=value;
        }
    }
```
We kunnen dus enkel ``energy`` een waarde geven, maar niet van buitenuit uitlezen.

#### Read-only property
```java
   public int Energy
    {
        get
        {
            return energy;
        }
    }
```
We kunnen dus enkel ``energy`` van buitenuit uitlezen, maar niet aanpassen.


{% hint style='tip' %}
**Opgelet: het ``readonly`` keyword heeft andere doelen en wordt NIET gebruikt in C# om een readonly property te maken**
{% endhint %}





#### Read-only property met private set
Soms gebeurt het dat we van buitenuit enkel de gebruiker de property read-only willen maken. We willen echter intern (in de klasse zelf) nog steeds controleren dat er geen illegale waarden aan private datafields worden gegeven. Op dat moment definiëren we een read-only property met een private setter:

```java
   public int Energy
    {
        get
        {
            return energy;
        }
        private set
        {
            if(value>=0)
                energy=value;
        }
    }
```

Van buitenuit zal enkel code werken die de ``get`` van deze property aanroept: ``Console.WriteLine(Palpatine.Energy);``. Code die de ``set`` van buitenuit nodig heeft zal een fout geven zoals: ``Palpatine.Energy=65``; ongeacht of deze geldig is of niet.

**Nu goed opletten**: indien we in het object de property willen gebruiken dan moeten we deze dus ook effectief aanroepen, anders omzeilen we hem als we rechtstreeks ``energy`` instellen.

Kijk zelf naar volgende **slechte** code:
```java
class SithLord
{
    private int energy;
    private string sithName;

    public void ResetLord()
    {
        energy=-1;
    }

    public int Energy
    {
        get
        {
            return energy;
        }
        private set
        {
            if(value>=0)
                energy=value;
        }
    }
}
```

De nieuw toegevoegde methode ``ResetLord`` willen we gebruiken om de lord z'n energy terug te verlagen. Door echter ``energy=-1`` te schrijven geven we dus -1 rechtstreeks aan ``energy``. Nochtans is dit een illegale waarden.

We moeten dus in de methode ook expliciet via de property gaan en dus schrijven:

```java
public void ResetLord()
{
    Energy=-1; // Energy i.p.v. energy
}
```

{% hint style='tip' %}
> **Het is een goede gewoonte om zo vaak mogelijk via de properties je interne variabele aan te passen en niet rechtstreeks het dataveld zelf.**
{% endhint %}


#### Read-only properties die transformeren
Je bent uiteraard niet verplicht om voor iedere interne variabele een bijhorende property te schrijven. Omgekeerd ook: mogelijk wil je extra properties hebben voor data die je 'on-the-fly' kan genereren.

Stel dat we volgende klasse hebben
```java
class Persoon
{
    private string voornaam;
    private string achternaam;
}
```
We willen echter ook soms de volledige naam op het scherm tonen ("Voornaam + Achternaam"). Via een read-only property kan dit supereenvoudig:
```java
class Persoon
{
    private string voornaam;
    private string achternaam;
    public string FullName
    {
        get{ return $"{voornaam} {achternaam}";}
    }
    public string Email
    {
        get
        {
            return $"{voornaam}.{achternaam}@ap.be";
        }
    }
}
```

Of nog eentje:
```java
class Aarde
{
    public double ZwaarteKracht
    {
        get
        {
            return 9.81;
        }
    }
}
```

Nog een voorbeeldje:

```java
class Persoon
{
    private int age;

    public bool IsWaarschijnlijkNogLevend
    {
        get
        {
            if(age>120) return false;
            return true;
        }
    }
}
```

Vaak gebruiken we dit soort read-only properties om data te transformeren. Stel bijvoorbeeld dat we volgende klasse hebben:
```java
class Persoon
{
    private int age; //in jaren

    public int  LeeftijdInMaanden
    {
        get
        {
            return age*12;
        }
    }
}
```

## Auto properties
Automatische eigenschappen (autoproperties) in C# staan toe om eigenschappen (properties) die enkel een waarde uit een private variabele lezen en schrijven verkort voor te stellen.

Zo kan je eenvoudige de klasse Person herschrijven met behulp van autoproperties. De originele klasse:

```java
public class Person
    {
 
        private string _firstName;
        private string _lastName;
        private int _age;
 
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
 
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
 
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }
```
De herschreven klasse met autoproperties (autoprops):
```java
public class Person
    {
 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
 
    }
```

Beide klassen hebben exact dezelfde functionaliteit, echter is de laatste klasse aanzienlijk eenvoudiger om te lezen en te typen. 

### Beginwaarde van autoprops

Je mag autoproperties beginwaarden geven door de waarde achter de property te geven, als volgt:

```java
public int Age {get;set;} = 45;
```

### Altijd auto-properties? 
Merk op dat je dit enkel kan doen indien er geen extra logica in de property aanwezig is.
Stel dat je bij de setter van age wil controleren op een negatieve waarde, dan zal je dit zoals voorheen moeten schrijven en kan dit niet met een automatic property:

```java
set
{
    if( value > 0)
        _age = value;
}
```
**Voorgaande property kan dus *NIET* herschreven worden met een automatic property.**

### Alleen-lezen eigenschap
Je kan automatic properties ook gebruiken om bijvoorbeeld een read-only property te definiëren. Als volgt:

Originele klasse:
```java
public string FirstName
{
    get
    {
        return _firstName;
    }
}
```
Met autoprops:
```java
public string FirstName { get; private set; }
```

En andere manier die ook kan is als volgt:
```java
public string FirstName { get; }
```
De enige manier om FirstName een waarde te geven is via de constructor van de klasse. Alle andere manieren zal een error genereren. [Meer info.](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6#read-only-auto-properties)

{% hint style='tip' %}
**Opgelet: je hebt ook read-only properties die full property zijn. Lees zeker ook de tekst hierboven in ver band met de get-omvormers.**
{% endhint %}


### Snel autoproperties typen in Visual Studio:
Als je in Visual Studio in je code ``prop`` typt en vervolgens twee keer de tabtoets indrukt dan verschijnt al de nodige code voor een automatic property. Je hoeft dan enkel nog volgende zaken in orde te brengen:

* Het type van de property
* De naam van de property (identifier) 
* De toegankelijkheid van get/set (public, private, protected)

Via ``propg`` krijg je aan autoproperty met private setter.




<!---NOBOOKSTART--->
{% hint style='tip' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)
**Methode of property?**

Een veel gestelde vraag bij beginnende OO-ontwikkelaars is: "Moet dit in een property of in een methode gestoken worden?"

De regel is eenvoudig:
* Betreft het een actie, iets dat het object moet doen (tekst tonen, iets berekenen, etc) dan plaats je het in een **methode**
* Betreft het een eigenschap die een bepaalde waarde heeft, dan gebruik je een **property**

<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

