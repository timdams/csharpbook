# Mapmaker "all-in-one-project"

Volgende hoofdstuk toont het gebruik van van de belangrijkste OO concepten in een applicatie waarmee we een huis-plattegrond kunnen visualiseren. Het doel van dit hoofdstuk is zoveel mogelijk elementen van de voorbije hoofdstukken te integreren tot een groter werkend geheel.



## Abstracte klasse

Eerst definiëren we een kleine hulpklasse Point die een punt in de ruimte voorstelt. We kunnen deze klasse ook gebruiken om een vector voor te stellen:
```java
    class Point
    {
        public Point(int inx, int iny)
	{
            x = inx;
            y = iny;
	}
	    
        public int X
	{
	  get{return x;}
	  set{x=value;}
	}
        public int Y	 
	{
	  get{return y;}
	  set{y=value;}
	}
    }
```
We maken nu  een abstracte klasse MapObject, die we vervolgens zullen gebruiken om over te erven zodat nieuwe klassen aangemaakt kunnen worden. 

```java
    abstract class MapObject
    {
        private Point location;
        private double price ;
        private char drawChar;
        
        //Teken object in de console
        public abstract void Paint();
    }
```

De variabele Price zal de prijs van het object bevatten, zodat we vlot kunnen berekenen wat de totale kostprijs van onze kaart zal zijn. Location bevat de coördinaten (x,y) waar het object in de console zal getekend moeten worden. drawChar geeft aan met welk karakter het item moet getoond worden.

**Belangrijk**: Merk op dat deze klasse minimaal is en allerlei essentiële zaken mankeert, zoals minstens een default constructor etc.

Indien je dit project dus in de praktijk wenst te gebruiken dan zal je nog zelf de nodige properties (of get/set-methoden, naar keuze) waarmee je toegang krijgt tot Location, Price krijgt en ook drawChar methode moeten schrijven.



 
## Overerving
We maken de ``MapObject`` klasse expres abstract, we willen voorkomen dat deze klasse rechtstreeks als object in het programma kan gebruikt worden. 

Laten we nu een nieuwe klasse aanmaken dat overerft van de abstract klasse MapObject 
```java
    class WallElement: MapObject
    {
        public override void Paint()
        {}
    }
```
De methode van Paint moeten we verplicht overriden (daar ze abstract was in de base klasse), voorts is het aan te raden om een default constructor te maken. De Paint-methode bevat zeer eenvoudigweg volgende 2 lijntjes code:
```java
            Console.SetCursorPosition(Location.X, Location.Y);
            Console.Write(DrawChar);
```

### Elementen op het scherm
We kunnen nu in ons hoofdprogramma (main-methode) al direct elementen op het scherm brengen met bijvoorbeeld volgende code:

```java
            WallElement steen1= new WallElement();
            steen1.Paint();
```

Dit geeft,als je een default constructor hebt gemaakt die automatisch ieder object op locatie (1,1) zet,, een sterretje op positie (1,1) op het scherm.

We zouden dus nu bijvoorbeeld meerdere stenen kunnen plaatsen (met verschillende prijs, naargelang de soort) en dan de totaalprijs opvragen.
### Grotere objecten
We hebben nu een basis om andere zaken te maken. Stel dat we grotere objecten op het scherm wensen. We zouden dan kunnen definiëren dat de variabele Location het punt linksboven van het object bepaalt. Volgende nieuwe object erft over van de MapObject en geeft een grotere figuur weer (vierkant, maar je kan natuurlijk je fantasie de vrije loop laten gaan):

```java
    class FurnitureElement: MapObject
    {

        private int unitSize;
        public int UnitSize
        {
            get { return unitSize; }
            set { if (value > 0) unitSize = value; }
        }

        public override void Paint()
        {
            for (int i = Location.X; i < Location.X + UnitSize; i++)
            {
                for (int j = Location.Y; j < Location.Y + UnitSize; j++)
                {
                    if (i < Console.WindowWidth && j < Console.WindowHeight)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(DrawChar);
                    }
                }
            }
        }
    }
```
We kunnen dan eenvoudig weg allerlei meubels definiëren, zoals een zetel:

```java
    class ZetelElement: FurnitureElement
    {
        public ZetelElement()
        {
            Price = 100;
            DrawChar = '+';
            UnitSize = 2;
        }
    }
```
Of als je de zetel anders wil getekend zien (geen rechthoek bijvoorbeeld, maar iets dat meer op zetel trekt, dan voeg je nog volgende code toe:
```java
        public override void Paint()
        {
            //Code om complexere zetel op scherm te tonen
        }
 ```
## Polymorfisme
We kunnen nu ongelooflijk veel objecten op het scherm tonen (laten we veronderstellen dat je een overloaded constructor telkens hebt geschreven), met behulp van een List-object, als volgt:
```java
            List<MapObject> allObjects= new List<MapObject>(); //lang leve polymorfisme
            
            //Muurtje
            for (int i = 0; i <10 ; i++)
            {
                Point tempLoc= new Point(2+i,3);
                WallElement tempWall= new WallElement(tempLoc,'=',10.0);
                allObjects.Add(tempWall);
            }

            //Zetel
            allObjects.Add(new ZetelElement(new Point(6,8), 3 ));
            
            //Teken alle objecten
            for (int i = 0; i < allObjects.Count; i++)
            {
                allObjects[i].Paint();
            }

```
Dankzij polymorfisme kunnen we alle objecten die overgeërfd zijn van MapObject in de MapObject-list plaatsen. Wanneer we dan Paint aanroepen gebruiken we de implementatie van het object zelf indien aanwezig.
 
![](../assets/7_overerving/mapmaker1.png)
 
## Maken van een grafisch menu
Het maken van een semi-grafisch menu is verrassend eenvoudig. 

### Menu Tekenen
Volgende klasse toont een kadertje met wat tekst in:
 ```java
    class Menu
    {
        public Menu()
        {}

        public void ShowMenu()
        {
            //Tekenen
            TekenBalk(1);
            TekenOpties(2);
            TekenBalk(5);
         }
        private void TekenBalk(int hoogte)
        {
             for (int i = 0; i < Console.WindowWidth; i++)
             {
                 Console.SetCursorPosition(i, hoogte);
                 Console.Write('*');
             }
        }
        private void TekenOpties(int hoogte)
        {
            Console.SetCursorPosition(5,hoogte);
            Console.Write("A) Voeg zetel toe op willekeurige locatie");
            Console.SetCursorPosition(5, hoogte+1);
            Console.Write("B) Beweeg kaart naar beneden");
            Console.SetCursorPosition(5, hoogte+2);
            Console.Write("Wat wilt u doen?...");
        }
    }
```
Je kan dit dan als volgt oproepen in je main:

```java
Menu menu= new Menu();
menu.ShowMenu();
```

### Tekstverwerken van Menu
We geven onze lijst van objecten mee aan ons Menu zodat het Menu object nieuwe zaken aan de map kan toevoegen:

```java
        public void GetInput(List<MapObject> list)
        {
            string input=Console.ReadLine();
            if(input=="A" || input=="a")
            {
                //Voeg randomzetel toe
            }
            if (input == "B" || input == "b")
            {
                //Beweeg kaart naar beneder
            }
        }
```
	
We kunnen dan in de main volgende code plaatsen die constant het scherm hertekent en telkens op input van de gebruiker wacht:
```java
            List<MapObject> allObjects = new List<MapObject>();
            Menu menu= new Menu();
            do
            {
                menu.ShowMenu();
                menu.GetInput(allObjects);
                Console.Clear();
                //Teken alle objecten
                for (int i = 0; i < allObjects.Count; i++)
                {
                    allObjects[i].Paint();
                }
            } while (true);
```
### Map verplaatsen
De map  verplaatsen is wederom verrassend eenvoudig. Stel dat je je map naar beneden wenst te verplaatsen als de B wordt ingedrukt; Je update gewoon de locatie van ieder object waarbij de y-positie gewoon met 1 wordt verhoogd:

```java
        if (input == "B" || input == "b")
        {
            //Beweeg kaart naar beneder
            for(int i=0;i<list.Count;i++)
            {
                list[i].Location = new Point(list[i].Location.X, list[i].Location.Y + 1);
            }

        }
```
![](../assets/7_overerving/mapmaker2.png)
![](../assets/7_overerving/mapmaker3.png)

 
## Composiet-klassen
Voorts kunnen we bijvoorbeeld nu meerdere klassen aanmaken (tafels, stoelen, deuren, etc) en dan een composiet-klasse aanmaken die bijvoorbeeld een volledig salon beschrijft, de code zou er dan als volgt kunnen uitzien:
```java
    class SalonElement: MapObject
    {
        private List<MapObject> elementen= new List<MapObject>();

        public SalonElement(Point salonLoc)
        {
          
            elementen.Add(new ZetelElement(new Point(2, 2), 3, '+'));
            elementen.Add(new ZetelElement(new Point(5, 9), 3, '+'));

            Location = salonLoc;
        }

        public override void Paint()
        {
            for (int i = 0; i < elementen.Count; i++)
            {
                elementen[i].Paint();
            }

        }
    }
```
Merk op dat we rekening moeten houden met het feit dat de locatie van het salon het punt linksboven is, en dat dus de nieuwe locaties van de zetels vanaf dit punt hun oorsprong hebben. Althans dat willen we.. Als we in het main-programma dan schrijven:

```java
            SalonElement salon1= new SalonElement(new Point(6,5));
            salon1.Paint();
```

![](../assets/7_overerving/mapmaker4.png)
Dan verschijnen onze zetels wel, maar niet op de locatie zoals we wilden (nu verschijnen de zetels op locatie (2,2) en (5,9), terwijl we liever hebben dat ze verschijnen op (2+6, 2+5) en (5+6, 9+5), dus rekening houdende met de locatie van het salon zelf

## Interface 
We willen nu ervoor zorgen dat wanneer we volgende code schrijven, dat ook alle elementen van het Salon mee verhuizen naar de nieuwe locatie:

```java
            List<MapObject> allObjects = new List<MapObject>();
            allObjects.Add(new SalonElement(new Point(5, 5)));
            allObjects[0].Paint();

          //Verplaats salon
            allObjects[0].Location= new Point(10,10);
            allObjects[0].Paint();
```
Echter, dat gebeurt niet. De oplossing is een gevorderd principe, maar eentje dat hopelijk het voordeel van een Interface laat zien.


We leggen een nieuwe interface IComposite vast die iedere composietklasse moet implementeren:

```java
    interface IComposite
    {
        void UpdateElements(Point offset);
    }
```

Ons SalonElement wordt krijgt dan volgende aanpassing:

```java
    class SalonElement: MapObject,IComposite
    {
        private List<MapObject> elementen= new List<MapObject>();

        public SalonElement(Point salonLoc)
        {
          ...
        }

        public override void Paint()
        {
		...
        }

        public void UpdateElements(Point offset)
        {
          ...
        }
    }
```
De UpdateElements methode zou er dan als volgt kunnen uitzien:

```java
            for (int i = 0; i < elementen.Count; i++)
            {
                Point elementLoc = elementen[i].Location;
                elementLoc.X += offset.X;
                elementLoc.Y += offset.Y;
                elementen[i].Location = elementLoc;
            }
```
## Is/as
Telkens we dus UpdateElements aanroepen dan worden alle elementen die bij het object horen ook geüpdatet.

Nu rest ons nog één aanpassing, dat is ervoor zorgen dat deze methode ook effectief telkens wordt aangeroepen. De methode moet aangeroepen worden telkens we een aanpassing aan de Location van het SalonElement doen. Hierbij controleren we eerst of de locatie überhaupt al geïnitialiseerd is (anders is deze waarde gelijk aan ‘null’). Vervolgens berekenen we de offset, dit is het verschil tussen de huidige en de nieuwe locatie van de composietklasse.
Daar Location bij MapObject hoort, moeten we dus in die klasse een aanpassing doen. We bereiden daarom de Locationproperty uit als volgt:

```java
        public Point Location
        {
            get { return location; }
            set
            {
                Point prevloc = location;
                Point offset = new Point(1, 1);
                if (location != null)
                {
                   
                    offset.X = value.X - prevloc.X;
                    offset.Y = value.Y - prevloc.Y;
                }
                
                location = value;
                if (this is IComposite)
                {
                    IComposite obj = this as IComposite;
                    obj.UpdateElements(offset);
                }
               
            }
        }
```
Deze code kan misschien wat toelichting gebruiken:

* Telkens we de set aanroepen van Location (dus in bijvoorbeeld allObjects[0].Location= new Point(10,10);) dan veranderen sowieso de locatie van het object naar de nieuwe waarde.
* We bewaren de huidige locatie zodat we de offset kunnen berekenen.
* Indien er een ‘huidige locatie’ is (location!=null) dan berekenen we de offset in de x en de y richting.
* Nu passen we de locatie van de composietklasse aan.
* Vervolgens kijken we of het object in kwestie (aangegeven met this, daar we in het object zelf zitten) de IComposite interface ‘heeft’.
* Als dit zo is dan zetten we het object even om naar een IComposite-object zodat we de UpdateElements()-methode kunnen aanroepen.

We kunnen nu dus zelfs een volledig Huis als klasse beschrijven en zo verschillende soorten huizen definiëren. Telkens we dan een huis verplaatsen dan verplaatst de hele inboedel mee. 

**Belangrijk**: Het gebruik van de interface is hier louter illustratief. Dit probleem kan je beter oplossen door een CompositeElement klasse aan te maken die overerft van MapObject. Deze klasse bevat dan een lijst van elementen en een UpdateElements methode. In MapObject controleer je dan of een object van het type CompositeElement is (ipv IComposite)

Een nog betere oplossing is die waarbij je gewoon direct zegt dat MapObject een lijst van elementen kan bevatten. Als een MapObject exact 1 element in zijn lijst bevat dan is de werking dezelfde als ervoor, maar nu kunnen we dus zonder veel code aanpassingen ook composiet objecten aanmaken.

Think about it.


 
