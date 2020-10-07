## List collectie

Een ``List<>``-collectie is de meest standaard collectie die je kan beschouwen als een veiligere variant op een doodnormale array. Het is een soort array on steroids zeg maar. Het voegt een klasse "rond" het concept van de array, waardoor je toegang krijgt tot een hoop nuttige methoden die het werken met arrays een pak eenvoudiger maakt.

{% hint style='tip' %}
De Generieke ``List<>`` klasse bevindt zich in de ``System.Collections.Generic`` namespace. Je dient deze namespace dus als ``using`` bovenaan toe te voegen wil je deze klasse kunnen gebruiken.
{% endhint %}

### List aanmaken

De klasse ``List<>`` is een zogenaamde generieke klasse (wat we later zullen behalen). Tussen de ``< >``tekens plaatsen we het datatype dat de lijst zal moeten gaan bevatten. Bijvoorbeeld:

* ``List<int> alleGetallen= new List<int>();``
* ``List<bool> binaryList = new List<bool>();``
* ``List<Pokemon> pokeDex = new List<Pokemon>();``
* ``List<string[]> listOfStringarrays = new List<string[]>();``

Zoals je ziet hoeven we bij het aanmaken van een ``List`` geen begingrootte mee te geven, wat we wel bij arrays moeten doen. Dit is één van de voordelen van ``List``: ze groeien mee.

### Elementen toevoegen

Via de ``Add()``-methode kan je elementen toevoegen aan de lijst. Je dient als parameter aan de methode mee te geven wat je aan de lijst wenst toe te voegen. **Deze parameter moet uiteraard van het type zijn dat de ``List`` verwacht.** 

In volgende voorbeeld maken we een List aan die objecten van het type string mag bevatten en vervolgens plaatsen we er twee elementen in.

```java
List<String> mijnPersonages = new List<String>();
mijnPersonages.Add("Reinhardt");
mijnPersonages.Add("Mercy");
``` 

Ook objecten kan je dus toevoegen:

```java
List<Pokemon> pokedex =new List<Pokemon>();
pokedex.Add(new Pokemon());
```

Via object syntax initializer kan dit zelfs nog sneller:
```java
List<Pokemon> pokedex =new List<Pokemon>()
    {
        new Pokemon(),
        new Pokemon()
    };
```

{% hint style='tip' %}
Je kan ook een stap verder gaan en ook binnenin deze initializer syntax dezelfde soort initialize syntax gebruiken om de objecten individueel aan te maken:

```java
List<Pokemon> pokedex =new List<Pokemon>()
    {
        new Pokemon() {Naam= "Pikachu", HP_Base= 5},
        new Pokemon() {Naam= "Bulbasaur", HP_Base= 15}
    };
```

{% endhint %}

### Elementen indexeren

**Het leuke van een List is dat je deze ook kan gebruiken als een gewone array**, waarbij je m.b.v. de indexer elementen individueel kan aanroepen. Stel bijvoorbeeld dat we een lijst hebben met minstens 4 strings in. Volgende code toont hoe we de string op positie 3 kunnen uitlezen en hoe we die op positie 2 overschrijven, net zoals we reeds kenden van arrays:

```java
Console.WriteLine(mijnPersonages[3]);
mijnPersonages[2] = "Torbjorn";`
```

Ook de klassieke werking met loops blijft gelden. De enige aanpassing is dat ``List<>`` niet met ``Length`` werkt maar met **``Count``**:

```java
for(int i = 0 ; i < mijnPersonages.Count; i++)
{
    Console.WriteLine(mijnPersonages[i])
}
```

### Wat kan een List nog?

Interessante methoden en properties voorts zijn:

* ``Clear()`` :methode die de volledige lijst leegmaakt en de lengte (``Count``) terug op 0 zet.
* ``Insert()``: methode om een element op een specifieke plaats in lijst toe te voegen, bijvoorbeeld:
```java
mijnPersonages.Insert(1,"Orise");
```
Dit voegt de ``string`` toe op de tweede plek en schuift de rest naar achter.
* ``IndexOf()``: geeft de index terug van het element item in de rij. Indien deze niet in de lijst aanwezig is dan wordt -1 teruggegeven.
* ``RemoveAt()``: verwijdert een element op de index die je als parameter meegeeft.

### Foreach loops

Je kan met een eenvoudige ``for`` of while-loop over een lijst itereren, maar het gebruik van een foreach-loop is toch handiger.

Dit is dan ook de meestgebruikte operatie om eenvoudig en snel een bepaald stuk code toe te passen op ieder element van de lijst. Stel je voor dat we een lijst ``OverwatchKarakters`` hebben waarin objecten van het type ``Karakter`` in zitten. Als we van ieder karakter in de lijst de naam op het scherm willen tonen dan kan dan als volgt:

```java
foreach(Karakter personage in OverwatchKarakters)
{
   Console.WriteLine(personage.Naam);
}
```


<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [List<> klasse](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=ac1bfe58-b55b-4e7e-98f3-ab7a009085bc)
<!---NOBOOKEND--->