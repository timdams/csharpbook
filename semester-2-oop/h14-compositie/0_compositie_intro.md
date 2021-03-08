# Compositie

## Compositie

We spreken over compositie \(**composition**\) wanneer we een object in een ander object gebruiken. Denk bijvoorbeeld aan een object van het type motor dat je gebruikt in een object van het type auto.

### Heeft een-relatie

Wanneer twee objecten een "heeft een"-relatie hebben dan spreken we over compositie:

* Een auto heeft een motor 
* Een computer heeft een harde schijf

Het lijdende voorwerp zal steeds het object zijn dat binnen het onderwerp zal geplaatst worden \(_motor_ in auto, _schijf_ in computer\).

### Aanduiding

Compositie duiden we aan met een lijn die begint met een volle ruit aan de kant van de klasse die de objecten in zich heeft:

![](../../.gitbook/assets/compuml.png) [bron](https://www.visual-paradigm.com/guide/uml-unified-modeling-language/uml-aggregation-vs-composition/)

Optioneel duidt een getal aan iedere kant van de lijn de verhouding aan. Bijvoorbeeld:

![](../../.gitbook/assets/multipplecompuml.png) [bron](http://www.jot.fm/issues/issue_2004_11/column5/)

Herinner je: Overerving duiden we aan met een pijl die wijst naar de parent-klasse

{% hint style='tip' %}
Bekijk zeker eens een complexer UML-diagramma zoals bijvoorbeeld van schaken [hier](https://stackoverflow.com/questions/17631125/trying-to-convert-diagram-of-a-chess-game-to-java-code-abstract)
{% endhint %}

### In de praktijk

We bekijken het voorbeeld van de computer en de harde schijf. We hebben twee klassen

```csharp
class PC
{
}

class Disk
{
}
```

Een PC heeft een Disk, dit wil zeggen dat we in de klasse PC een object van het type Disk zullen definiëren:

```csharp
class PC
{
    private Disk cDisk;
}
```

Uiteraard moeten we deze Disk nog instantiaren, dit kan op verschillende mogelijkheden en is afhankelijk van wat je nodig hebt. We tonen er drie, maar er zijn er nog.

#### Manier 1

Ogenblikkelijk:

```csharp
class PC
{
    private Disk cDisk=new Disk();
}
```

#### Manier 2

Ogenblikkelijk, maar in constructor:

```csharp
class PC
{
    public PC()
    {
       cDisk= new Disk();
    } 
    private Disk cDisk;
}
```

#### Manier 3

Door een extern object, bv via een property:

```csharp
class PC
{
    public Disk CDisk
    {
      get{return cDisk;}
      set{cDisk= value;}
    }
    private Disk cDisk;
}

// Elders dan:
myPC.CDisk= new Disk();
```

### Kortom

Alle manieren die ja al kende om met bestaande types objecten aan te maken gelden nog steeds. Compositie deed je al de hele tijd wanneer je bijvoorbeeld zij "een student heeft een leeftijd" en dan een variabele `int age` aanmaakte. Het grote verschil is echter dat objecten moeten geïnstantieerd worden , wat niet moest met value-types.

### NullReference is een klassieke fout

Een veelvoorkomende fout bij compositie van objecten is dat je een object aanspreekt dat nooit werd geïnstantieerd. Je krijgt dan een `NullReferenceException`.

## "Heeft meerdere"- relatie

Wanneer een object meerdere objecten van een specifiek type heeft \(denk maar aan "een boek heeft meerdere pagina's" of "een boom heeft bladeren"\) dan zullen we een array of een list als compositie-object gebruiken.

Voorbeeld:

```csharp
class Page{}

class Boek
{
   private Page[] allPages= new Page[100];
}
```

Indien je nu een pagina wenst toe te voegen dan moet je ook deze individuele array-elementen nog instantieren. Een voorbeeld waarbij men van buitenuit het object bestaande pagina's kan toevoegen:

```csharp
class Book
{
   public void InsertPage(Page toAdd, int Position)
   {
       allPages[Position]= toAdd;
   }

   private Page[] allPages= new Page[100];
}

//Elders
Book myBook= new Book();
Page myThirdPage= new Page();
myBook.InsertPage(myThirdPage, 2);
```

Of een voorbeeld met List:

```csharp
class Book
{
    public List<Page> AllPages{get;set;} = new List<Page>();
}

//Elders
myBook.AllPages.Insert(new Page(), 5);
```

# Kennisclip
![](../assets/infoclip.png)

* [Compositie](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=799210db-6683-49f1-afba-ab9d00cf6792)
* [Compositie in praktijk basics](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=26d08209-4de8-40b5-b5cc-ab9d00d33aa5)
* [Compositie in praktijk demo met kaartspel deel 1](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=d9c2280d-7b1d-4a83-8851-ab9d00e13cca)
* [Compositie in praktijk demo met kaartspel dee2](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a1009330-272d-4978-a078-aba2012ab2b8)
* [Compositie in praktijk: Demo met helden](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=235d6b90-d246-4529-a911-ab9d00db6f56)
