# List

{% hint style="danger" %}
In onderstaande kennisclip wordt er een andere syntax gebruikt om objecten aan te maken dan wat wij gewoon zijn \(namelijk constructors met parameters\). Dat maakt geen verschil voor de werking van de datastructuur. Je zou net zo goed een constructor kunnen definiëren die hetzelfde doet.
{% endhint %}

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=ac1bfe58-b55b-4e7e-98f3-ab7a009085bc)
{% endhint %}

Een `List<>` collectie is de meest standaard collectie die je kan beschouwen als een flexibelere variant op een een doodnormale array.

{% hint style="info" %}
De Generieke `List<>` klasse bevindt zich in de `System.Collections.Generic` namespace. Je dient deze namespace dus als `using` bovenaan toe te voegen wil je deze klasse kunnen gebruiken.
{% endhint %}

### List aanmaken

De klasse `List<T>` is een zogenaamde generieke klasse. Tussen de `< >`tekens plaatsen we het type dat de lijst zal moeten gaan bevatten. Vaak wordt dit genoteerd als `T` voor "type". Bijvoorbeeld:

* `List<int> alleGetallen= new List<int>();`
* `List<bool> binaryList = new List<bool>();`
* `List<Pokemon> pokeDex = new List<Pokemon>();`
* `List<string[]> listOfStringarrays = new List<string[]>();`

Zoals je ziet hoeven we bij het aanmaken van een `List` geen begingrootte mee te geven, wat we wel bij arrays moeten doen. Dit is een van de voordelen van `List`: ze groeien mee. Als we toch een begingrootte meegeven \(zoals in de kennisclip even getoond wordt\) is dat enkel om de performantie van de code wat te verhogen in bepaalde scenario's. Wij gaan dit nooit doen.

### Elementen toevoegen

Via de `Add()` methode kan je elementen toevoegen aan de lijst. Je dient als parameter aan de methode mee te geven wat je aan de lijst wenst toe te voegen. **Deze parameter moet uiteraard van het type zijn dat de `List` verwacht.**

In volgende voorbeeld maken we een List aan die objecten van het type string mag bevatten en vervolgens plaatsen we er twee elementen in.

```csharp
List<String> myStringList = new List<String>();
myStringList.Add("This is the first item in my list!");
myStringList.Add("And another one!");
```

### Elementen indexeren

**Het leuke van een List is dat je deze ook kan gebruiken als een gewone array**, waarbij je mbv de indexer elementen kan aanroepen. Stel bijvoorbeeld dat we een lijst hebben met minstens 4 strings in. Volgende code toont hoe we de string op positie 3 kunnen uitlezen en hoe we die op positie 2 overschrijven:

```csharp
Console.WriteLine(myStringList[3]);
myStringList[2] = "andere zin";`
```

Ook de klassieke werking met `for` blijft gelden. De enige aanpassing is dat `List<T>` niet met `Length` werkt maar met **`Count`**.

```csharp
for(int i = 0 ; i < myStringList.Count; i++)
{
    Console.WriteLine(myStringList[i])
}
```

### Wat kan een List nog?

Interessante methoden en properties voorts zijn:

* `Clear()` :methode die de volledige lijst leegmaakt
* `Insert()`: methode om element op specifieke plaats in lijst toe te voegen, bijvoorbeeld:

  ```csharp
  myStringList.Insert(1,"A fourth sentence");
  ```

  voegt de string toe op de tweede plek en schuift de rest naar achter

* `Contains()`: geef als parameter een specifiek object mee \(van het type dat de List&lt;&gt; bevat\) om te weten te komen of dat specifieke object in de List&lt;&gt; terug te vinden is. Indien ja dan zal true worden teruggeven.
* `IndexOf()`: geeft de index terug van het element item in de rij. Indien deze niet in de lijst aanwezig is dan wordt -1 teruggegeven.
* `RemoveAt()`: verwijder een element op de index die je als parameter meegeeft.

### Foreach loops

Je kan met een eenvoudige `for` of while-loop over een lijst itereren, maar het gebruik van een foreach-loop is toch handiger.

Dit is dan ook de meestgebruikte operatie om eenvoudig en snel een bepaald stuk code toe te passen op ieder element van de lijst:

```csharp
List<int> integerList=new List<int>();
integerList.Add(2);
integerList.Add(3);
integerList.Add(7);

foreach(int prime in integerList)
{
   Console.WriteLine(prime);
}
```

