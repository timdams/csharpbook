# Text-gebaseerd spel mbv OO technieken

De prijs voor meest sexy titel gaan we niet winnen. Maar naar de aloude traditie van de klassieke tekst-gebaseerde adventure-games (zie [hier](https://en.wikipedia.org/wiki/List_of_text-based_computer_games) ) zullen we een eenvoudig object georiënteerd framework maken dat ons toelaat snel onze eigen games te maken. De nadruk van dit artikel ligt daarbij niet tot het creëren van een perfecte imitatie, maar wel om aan te tonen dat met een beetje object georiënteerde inzichten we tot zeer propere, herbruikbare én onderhoudbare code kunnen komen.

We maken uiteraard het spel in een Console-applicatie.

## Main
We willen de ``Main()`` methode van Program.cs zo leeg mogelijk laten. Daarom zullen we de meeste functionaliteit verpakken in een klasse GameManager. Het enige dat we dan nog hoeven te doen in onze main is een loop starten die steeds 3 zaken zal doen:

1. Huidige locatie beschrijven
2. Aan gebruiker tonen welke acties hij kan uitvoeren
3. Gewenste actie van gebruiker verwerken en uitvoeren

In code behelst dit:

```java
static void Main(string[] args)
{
    Console.WriteLine("Welkom bij AP Adventure. Een avontuur voor moedige en minder moedige studenten. Ben je er klaar voor?");
 
   GameManager theGame= new GameManager();
 
    //Start gameloop
    while(!theGame.Exit)
    {
        //Beschrijf kamer
        theGame.DescribeLocation();
        //Toon acties
        theGame.ToonActies();
        //Lees actie uit
        theGame.VerwerkActie();
 
    }
}
```
Een bool property ``Exit``  binnen het GameManager object zal ons toelaten om de loop te stoppen wanneer het spel wordt beëindigd.

## GameObject
Doorheen de verschillende locaties zullen elementen te vinden zijn. We beschrijven deze als GameObjects:

```java
class GameObjects
{
    public string Name { get; set; }
    public string Description { get; set; }
 
    public void Describe()
    {
        Console.WriteLine(Name+","+Description+".");
    }
}
```
## Location
De gebruiker kan van locatie naar locatie gaan. Een locatie bestaat uit een aantal zaken:

* Een beschrijving en titel
* Een lijst van GameObjecten (items) die zich op deze locatie bevinden
* Een lijst van Exits, namelijk de richtingen waar de gebruiker naar toe kan gaan die aansluiten op een andere locatie
* Een eerste versie van onze locatie klasse is dan:

```java
class Location
{
    public Location()
    {
        Exits = new List();
        ObjectsInRoom= new List();
    }
    public string Title { get; set; }
    public string Description { get; set; }
 
    public List Exits { get; set; }
    public List ObjectsInRoom { get; set; }
 
    public void Describe()
    {
        Console.WriteLine(Title + "\n*********");
        Console.WriteLine(Description  );
        Console.WriteLine("Voorts zie je ook nog:");
        foreach (var objects in ObjectsInRoom)
        {
            objects.Describe();
        }
        Console.WriteLine("\n*********");
    }
 
    //...
}
```
Merk op dat we gebruik maken van ``List<>`` ipv arrays. 

## Exit
Iedere exit in een locatie definieert minstens 2 zaken:

* De richting waar deze uitgang zich bevindt (Noord, Oost,Zuid, West)
* Een referentie naar het locatie-object waar deze uitgang toegang tot verschaft

We krijgen dus al:

```java
class Exit
{
    public Exit()
    {
        NeedsObject= new List<GameObjects>();
    }
    public Directions ExitDirection { get; set; }
    public Location GoesToLocation { get; set; }
 
    //...
}
```
Waarbij ``Directions`` een eigen gemaakt enum-type is:

```java
enum Directions
{
    North, South, West, East
}
```
## Van locatie veranderen
Binnen de locatie klasse voegen we een methode toe die de GameManager kan gebruiken om te weten te komen naar welke locatie de gebruiker gaat. De methode aanvaardt een ``Direction`` (i.e. de richting waarin de gebruiker wenst te gaan) en zal een referentie naar het location-object teruggeven waarnaar de gebruiker zal bewegen. Indien de richting waarin hij wenst te bewegen niet geldig is dan tonen we dit op het scherm:

```java
public Location GettLocationOnMove(Directions direction)
{
    foreach (var exit in Exits)
    {
        if (exit.ExitDirection == direction)
        {
 
            return exit.GoesToLocation;
        }
    }
    Console.WriteLine("Dat is geen geldige richting");
    return this;
 
}
```
Wanneer dus een exit wordt gevonden in de Exits lijst die voldoet aan de meegegeven ``Direction`` dan geven we een referentie terug naar de bijhorende locatie (``GoesToLocation``). Wordt er geen exit gevonden en bereiken we dus het einde van de foreach lus dan verschijnt de tekst op het scherm en geven we een referentie terug naar de huidige locatie.

## GameObjects als vereisten om exit te gebruiken
Stel nu dat we soms willen dat een bepaalde locatie pas bereikt kan worden indien de gebruiker reeds een bepaald ``GameObject`` in zijn bezit heeft. Hiervoor moeten we 2 zaken aanpassen:

* We beschrijven in de ``Exit`` klasse welk object(en) nodig zijn om deze exit te mogen gebruiken
* We controleren of de speler het ``GameObject`` heeft wanneer deze naar een nieuwe locatie wil gaan mbv de ``GetLocationOnMove()`` methode.

De nieuwe, volledige ``Exit`` klasse wordt dan:

```java
class Exit
{
    public Exit()
    {
        NeedsObject= new List<GameObjects>();
    }
    public Directions ExitDirection { get; set; }
    public Location GoesToLocation { get; set; }
 
    public List<GameObjects> NeedsObject { get; set; }
 
    public bool TestPassCondition(List<GameObjects> playerInventory)
    {
        int passCount = 0;
        for (int i = 0; i < NeedsObject.Count; i++)
        {
            if (playerInventory.Contains(NeedsObject[i]))
                passCount++;
        }
 
        if (passCount == NeedsObject.Count)
            return true;
        else
        {
            return false;
        }
    }
}
```
In deze ietwat knullige code tellen we dus of de speler alle GameObjecten in z’n inventory heeft (``playerInventory``) nodig om deze exit te gebruiken.

Deze methode ``TestPassCondition`` gebruiken we nu in de ``GetLocationOnMove()``-methode in de Location klasse om te bepalen of de exit mag gebruikt worden. De methode wordt dan:

```java
public Location GettLocationOnMove(Directions direction, List<GameObjects> playerInventory )
{
    foreach (var exit in Exits)
    {
        if (exit.ExitDirection == direction)
        {
 
            if(exit.TestPassCondition(playerInventory))
                return exit.GoesToLocation;
            else
            {
                Console.WriteLine("Je kan hier niet langs (je hebt niet alle vereiste items).");
                return this;
            }
        }
    }
    Console.WriteLine("Dat is geen geldige richting");
    return this;
 
}
```

## GameManager
Rest ons nu enkel nog  de ``GameManager`` klasse te maken. Ruw gezien is deze als volgt:


```java
class GameManager
{
 
    public GameManager()
    {
        InitGame();
    }
    private  Location currentLocation = null;
    public bool Exit { get; set; }
 
    public void DescribeLocation()
    {
        //...
    }
 
    public  void VerwerkActie()
    {
        //...
    }
 
    public  void ToonActies()
    {
        //...
    }
 
    private  List<Location> GameLocation = new List<Location>();
    private List<GameObjects> Objects = new List<GameObjects>();
    private List<GameObjects>  playerInventory= new List<GameObjects>();
    private  void InitGame()
    {
        //...
    }
}
```

Wat ogenblikkelijk opvalt zijn:

* De 3 publieke methoden ``DescribeLocation``,``VerwerkActie`` en ``ToonActies``
* Een private field ``currentLocation`` die een referentie bijhoudt naar de huidige locatie van de speler
* 3 lijsten met daarin de objecten die de speler heeft (``playerInventory``), alle objecten in het spel (``Objects``) en alle locaties in het spel (``GameLocation``)
* Een ``InitGame()`` methode waarin we alle gameobjecten, exits en locaties zullen aanmaken bij aanvang van het spel
* Een bool ``Exit`` zodat de externe gameloop weet wanneer het spel gedaan is

We zullen nu de afzonderlijke methoden invullen:

### DescribeLocation()
```java
public void DescribeLocation()
{
    this.currentLocation.Describe();
}
```

### VerwerkActie()

```java
string actie = Console.ReadLine();
bool error = false;
if (actie == "n")
    currentLocation = currentLocation.GettLocationOnMove(Directions.North, playerInventory);
else if (actie == "o")
    currentLocation = currentLocation.GettLocationOnMove(Directions.East, playerInventory);
else if (actie == "w")
    currentLocation = currentLocation.GettLocationOnMove(Directions.West, playerInventory);
else if (actie == "z")
    currentLocation = currentLocation.GettLocationOnMove(Directions.South, playerInventory);
else if (actie == "e")
    Exit = true;
else
{
    error = true;
}
Console.Clear();
if(error)
    Console.WriteLine("Onbekende actie");

```
We laten de speler dus toe door ``n,o,w,z`` in te typen dat gecontroleerd wordt naar welke nieuwe locatie zal gegaan worden. We passen hierbij de ``currentLocation`` property van de GameManager aan naar de, al dan niet nieuwe, locatie.

### ToonActies()
```java
public  void ToonActies()
{
    Console.WriteLine("Mogelijke acties: (typ bijvoorbeeld n indien u naar het noorden wil)");
    Console.WriteLine("n= noord");
    Console.WriteLine("o= oost");
    Console.WriteLine("z= zuid");
    Console.WriteLine("w= west");
 
    Console.WriteLine("e=exit");
 
}
```
### InitGame()
In deze methode definiëren nu de volledige spelinhoud. Wil je dus bijvoorbeeld dit spel uitbreiden met extra kamers en objecten, dan doe je dat in deze methode. Ter illustratie tonen we eerst hoe we 2 locaties aanmaken en deze aan elkaar hangen mbv de Exits (waarbij kamer één zich ten zuiden van kamer 2 bevindt)

```java
private  void InitGame()
 {
     //Maak Locaties
     Location l1 = new Location()
                       {
                           Title = "De poort",
                           Description =
                               "Je staat voor een grote grijze poort die op een kier staat. Rondom je is prikkeldraad, je kan enkel naar het noorden, door de poort gaan. "
                       };
 
     Location l2 = new Location()
                       {
                           Title = "Receptie",
                           Description =
                               "De receptie....veel blijft er niet meer over van wat eens een bruisende omgeving was. Hier en daar zie je skeletten van , waarschijnlijk, enkele studenten. Een grote poort staat op een kier naar het zuiden. Je ziet twee deuren aan de westelijke en noordelijke zijde."
 
                       };
 
     //Place exits
     l1.Exits.Add(new Exit() { ExitDirection = Directions.North, GoesToLocation = l2 });
 
     l2.Exits.Add(new Exit() { ExitDirection = Directions.South, GoesToLocation = l1 });
 
     //Voeg locatie toe
     GameLocation.Add(l1);
     GameLocation.Add(l2);
 
     currentLocation = l1;
}
```
Vergeet niet op het einde de 2 kamers toe te voegen aan de ``GameLocation`` lijst van de GameManager, alsook in te stellen wat de beginkamer is.

## GameInit met GameObject als conditie om kamer in te kunnen
Stel dat we even later in een kamer een sleutel plaatsen die als conditie dient om een andere kamer te kunnen openen. We schrijven dan in de ``GameInit()`` methode:


```java
    Location l6 = new Location()
    {
        Title = "Gang",
        Description =
            "Een brede gang waar makkelijk 5 mensen schouder aan schouder door kunnen. Zowel in het oosten als het westen zie je een deur."
 
    };
 
    Location l7 = new Location()
    {
        Title = "Computerruimte",
        Description =
            "Eindelijk; je hebt het gehaald. De plek waar iedereen naar toe wil: het computerlabo!"
    };
 
    //Place objects in rooms
    GameObjects keytol7 = new GameObjects() { Description = "Verroest en groot", Name = "Sleutel" };
    l5.ObjectsInRoom.Add(keytol7);
    //...
 
    l6.Exits.Add(new Exit() { ExitDirection = Directions.West, GoesToLocation = l4 , NeedsObject= new List<GameObjects>(){keytol7}});
    l6.Exits.Add(new Exit() { ExitDirection = Directions.East, GoesToLocation = l7 });
 
    //Voeg locatie toe
//..
    GameLocation.Add(l6);
    GameLocation.Add(l7);
```
## Een volledige GameInit ter illustratie
We hebben nu de belangrijkste onderdelen geschreven. We tonen daarom een iets uitgebreider spel, demo zeg maar, waar in we alles gecombineerd in actie zien:


```java
private  void InitGame()
{
    //Maak Locaties
    Location l1 = new Location()
                      {
                          Title = "De poort",
                          Description =
                              "Je staat voor een grote grijze poort die op een kier staat. Rondom je is prikkeldraad, je kan enkel naar het noorden, door de poort gaan. "
                      };
 
    Location l2 = new Location()
                      {
                          Title = "Receptie",
                          Description =
                              "De receptie....veel blijft er niet meer over van wat eens een bruisende omgeving was. Hier en daar zie je skeletten van , waarschijnlijk, enkele studenten. Een grote poort staat op een kier naar het zuiden. Je ziet twee deuren aan de westelijke en noordelijke zijde."
 
                      };
 
    Location l3 = new Location()
    {
        Title = "Koffieruime",
        Description =
            "Je staat in de koffieruimte achter de receptie. Menig pralinetje is hier vroeger met veel gusto opgesmikkeld. Een lege pralinedoos is het enige bewijs dat het hier ooit gezellig was. Een deur is de enige uitgang uit deze kamer naar het oosten."
    };
 
    Location l4 = new Location()
    {
        Title = "Tuin",
        Description =
            "Het is duidelijk herfst. Een kale boom en vele bruine bladeren op de grond...mistroosteriger kan eigenlijk niet. Je ziet een deur in het zuiden en in het westen en een grote klapdeur naar het noorden."
 
    };
 
    Location l5 = new Location()
    {
        Title = "Cafetaria",
        Description =
            "Ooit was dit een bruisende locati: veel eten, geroezemoes en licht door de grote ruiten. Nu enkel stof en lege tafel. Enkel een klapdeur is zichtbaar naar het zuiden."
    };
 
    Location l6 = new Location()
    {
        Title = "Gang",
        Description =
            "Een brede gang waar makkelijk 5 mensen schouder aan schouder door kunnen. Zowel in het oosten als het westen zie je een deur."
 
    };
 
    Location l7 = new Location()
    {
        Title = "Computerruimte",
        Description =
            "Eindelijk; je hebt het gehaald. De plek waar iedereen naar toe wil: het computerlabo!"
    };
 
    //Place objects in rooms
    GameObjects keytol7 = new GameObjects() { Description = "Verroest en groot", Name = "Sleutel" };
    l5.ObjectsInRoom.Add(keytol7);
 
    //Place exits
    l1.Exits.Add(new Exit() { ExitDirection = Directions.North, GoesToLocation = l2 });
 
    l2.Exits.Add(new Exit() { ExitDirection = Directions.South, GoesToLocation = l1 });
    l2.Exits.Add(new Exit() {ExitDirection = Directions.West, GoesToLocation =  l3});
    l2.Exits.Add(new Exit() { ExitDirection = Directions.North, GoesToLocation = l4 });
 
    l3.Exits.Add(new Exit() { ExitDirection = Directions.East, GoesToLocation = l2 });
 
    l4.Exits.Add(new Exit() { ExitDirection = Directions.South, GoesToLocation = l2 });
    l4.Exits.Add(new Exit() { ExitDirection = Directions.West, GoesToLocation = l6 });
    l4.Exits.Add(new Exit() { ExitDirection = Directions.North, GoesToLocation = l7 });
 
    l5.Exits.Add(new Exit() { ExitDirection = Directions.South, GoesToLocation = l4 });
 
    l6.Exits.Add(new Exit() { ExitDirection = Directions.West, GoesToLocation = l4 , NeedsObject= new List<GameObjects>(){keytol7}});
    l6.Exits.Add(new Exit() { ExitDirection = Directions.East, GoesToLocation = l7 }); //needs key condition
 
    l7.Exits.Add(new Exit() { ExitDirection = Directions.East, GoesToLocation = l6 }); //Winning room
 
    //Voeg locatie toe
    GameLocation.Add(l1);
    GameLocation.Add(l2);
    GameLocation.Add(l3);
    GameLocation.Add(l4);
    GameLocation.Add(l5);
    GameLocation.Add(l6);
    GameLocation.Add(l7);
 
    currentLocation = l1;
}
```

# What’s missing? Veel! 
Maar een eerste uitdaging zou kunnen zijn: hoe kunnen we de speler objecten van de grond laten oprapen en in de  inventaris plaatsen? Dat raadsel  laten we aan jou over over om op te lossen!
