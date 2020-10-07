# Compositie en aggregatie


{blurb, class: tip}
Dit hoofdstuk is kort maar krachtig. We gaan niets nieuws uitleggen, maar eerder zaken benoemen die je waarschijnlijk al toepaste zonder te weten dat er daar ook een naam voor was.
{/blurb}

We spreken over compositie (**composition**) en aggregatie (**aggregation**) wanneer we een object in een ander object gebruiken. Denk bijvoorbeeld aan een object van het type motor dat je gebruikt in een object van het type auto. Afhankelijk of het 'interne' object kan bestaan zonder het ouder-object bepaald of het gaat om aggregatie of compositie:

* **Compositie**: Het interne object heeft geen bestaansreden zonder het moederobject. Denk bijvoorbeeld aan een kamer in een huis. Als het huis verdwijnt, verdwijnt ook de kamer.
* **Aggregatie**: Beide objecten kunnen onafhankelijk van elkaar bestaan. Denk hierbij aan de motor in een auto. Wanneer de auto vernietigd wordt kan de motor gered worden en elders gebruikt worden. Een ander voorbeeld zijn de harde schijven in een computer.

Het lijdende voorwerp zal steeds het object zijn dat binnen het onderwerp zal geplaatst worden (*motor* in auto, *schijf* in computer).


## UML aanduiding

Compositie duiden we aan met een lijn die begint met een volle ruit aan de kant van de klasse die de objecten in zich heeft:

![Iedereen kan herleid worden tot armen, benen en een hoofd](../assets/6_klassen/compuml.png)
[bron](https://www.visual-paradigm.com/guide/uml-unified-modeling-language/uml-aggregation-vs-composition/)

Optioneel duidt een getal aan iedere kant van de lijn de verhouding aan. Bijvoorbeeld:

![Een complexer compositie voorbeeld](../assets/6_klassen/multipplecompuml.png)
[bron](http://www.jot.fm/issues/issue_2004_11/column5/)

Herinner je: Overerving duiden we aan met een pijl die wijst naar de parent-klasse




Aggregatie duiden we op exact dezelfde manier aan, maar de ruiten zijn niet gevuld. 


![Een complexer compositie voorbeeld](../assets/6_klassen/multipplecompuml.png)
[bron](http://www.jot.fm/issues/issue_2004_11/column5/)

{blurb, class: tip}
Bekijk zeker eens een complexer UML-diagramma zoals bijvoorbeeld van schaken [hier](https://stackoverflow.com/questions/17631125/trying-to-convert-diagram-of-a-chess-game-to-java-code-abstract)
{/blurb}


## Compositie en aggregatie in de praktijk

Het verschil tussen aggregatie en compositie is vooral van filosofische aard. In de praktijk zijn er weinig verschillen. 

We bekijken het voorbeeld van de computer en de harde schijf. We hebben twee klassen
```java
class PC
{
}

class Disk
{
}
```

Een *PC heeft een Disk*, dit wil zeggen dat we in de klasse ``PC`` een object van het type ``Disk`` zullen definiëren:

```java
class PC
{
    private Disk cDisk;
}
```

In principe kunnen we nu zeggen dat we aggregatie hebben toegepast. Uiteraard moeten we nu deze Disk nog instantiëren anders zal deze de hele levensduur van ieder PC-object ``null`` zijn. 

De instantatie van een geaggregeerd object kan op verschillende manieren en is afhankelijk van wat je nodig hebt in je applicatie. 

### Manier 1

Wanneer we wensen dat iedere nieuwe PC ogenblikkelijk een interne disk heeft dan kan dat als volgt:

```java
class PC
{
    private Disk cDisk=new Disk();
}
```

### Manier 2
Willen we echter bij het aanmaken van een nieuwe pc ook iets meer controle over wat voor disk er wordt geïnstalleerd, dan kan dit ook via de constructors. We zouden dan bijvoorbeeld afhankelijk van bepaalde parameters in de (overloaded) constructors de disk andere eigenschappen kunnen geven:

```java
class PC
{
    private Disk cDisk;    
    
    public PC(bool kortingscode)
    {
        //enkel interne harde schijf indien klant kortingscode gebruikte
        if(kortingscode) 
            cDisk = new Disk();
        //else cDisk == null 

    } 

}
```

### Manier 3
De vorige 2 voorbeelden waren eigenlijk voorbeelden van compositie. Wanneer de PC-objecten vernietigd worden (door de GC) zullen ook de interne harde schijven verdwijnen. 

Willen we echter via aggregatie de pc's bouwen, dan is het logischer dat we op een andere plaats de ``Disk`` objecten aanmaken en deze vervolgens, nadat de PC werd aangemaakt, in de PC plaatsen. We gebruiken hierbij Properties om toegang tot het geaggregeerde object te verschaffen:

```java
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
Disk myDisk= new Disk();
myPC.CDisk= myDisk;
```

Op deze manier hebben we nog steeds een referentie naar ``myDisk`` en zal de GC dit object dus niet verwijderen wanneer , om welke reden ook, ``myPC`` wordt opgekuist.

{blurb, class: tip}
Kortom, niets nieuws onder de zon. Alle manieren die ja al kende om met bestaande types objecten aan te maken gelden nog steeds. Compositie deed je al de hele tijd wanneer je bijvoorbeeld zei "een student heeft een leeftijd" en dan een variabele ``int age`` aanmaakte. Het grote verschil is echter dat objecten moeten geïnstantieerd worden , wat niet moest met value-types. 
{/blurb}

## Compositie en aggregatie objecten gebruiken

Stel je voor dat de klasse ``Disk`` ook een autoproperty ``MaxCapacity`` heeft. De klasse ``PC`` kan dankzij compositie dus nu ook die property gebruiken, zoals volgende voorbeeld toond:

```java
class PC
{
    private Disk cDisk=new Disk();

    public void ToonComputerInfo()
    {
        Console.WriteLine("Dit is een Intel i9");
        Console.WriteLine($"De harde schijf heeft een capaciteit van {cDisk.MaxCapacity} Gb");
    }
}
```

{blurb, class: warning}
### NullReference is een klassieke fout

Een veelvoorkomende fout bij compositie en aggregatie van objecten is dat je een intern object aanspreekt dat nooit werd geïnstantieerd. Je krijgt dan een ``NullReferenceException``.

Het is dus zeker bij compositie en aggregatie een goede gewoonte om zoveel mogelijk te controleren op ``null`` telkens je het object gaat gebruiken.  
{/blurb}

## "Heeft meerdere"- relatie

Wanneer een object meerdere objecten van een specifiek type heeft (denk maar aan "een boek heeft meerdere pagina's" of "een boom heeft bladeren") dan zullen we een array of een list als compositie-object gebruiken. 

Voorbeeld:

```java
class Page{}

class Boek
{
   private Page[] allPages= new Page[100];
}
```

Indien je nu een pagina wenst toe te voegen dan moet je ook deze individuele array-elementen nog instantieren. Een voorbeeld waarbij men van buitenuit het object bestaande pagina's kan toevoegen:

```java
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

```java
class Book
{
    public List<Page> AllPages{get;set;} = new List<Page>();
}

//Elders
myBook.AllPages.Insert(new Page(), 5); 
```

## Compositie of overerving

We vertelden in het begin van dit hoofdstuk dat compositie en aggregatie een "heeft een"-relatie aanduiden, terwijl overerving een "is een"-relatie behelst.  In de praktijk zal je véél vaker compositie en aggregatie moeten gebruiken dan overerving. 
Compositie en aggregatie laat ons toe om 2 (of meer) totaal verschillende soorten zaken met elkaar te laten samenwerken, iets wat met oververing enkel kan indien beide zaken een "is een"-relatie hebben.

Zoals je hopelijk beseft kan dus alles een compositieobject zijn in een ander object.  Denk maar aan een ``Dictionary`` van klanten die je gebruikt in een klasse ``Winkel``. Of wat te denken van de klasse ``Mens`` die uit een hele boel organen bestaat, allen zijnde compositie-objecten zoals 2 ``Nier`` en ``Long`` instantie, 1 ``Hart`` instantie etc. Iemand die in jouw Mens-simulator een nieuw hart nodig heeft kan dat dan dankzij Manier 3 , via een property ingeplant krijgen (excuses voor het wat lugubere voorbeeld):

```java
Mens patient = new Mens();
Mens donor = new Mens();

//Donor heeft een tragisch ongeluk en sterft
//Operatie start
patient.Hart = null; //vorig hart wordt "verwijderd"
patient.Hart = donor.Hart; 

donor = null //donor wordt begraven
```