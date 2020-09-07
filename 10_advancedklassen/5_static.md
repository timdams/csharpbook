## Static

Je hebt het keyword ``static`` al een paar keer zien staan voor methoden het vorige semester. En dit semester werd er dan weer nadrukkelijk verteld géén ``static`` voor methoden te plaatsen. Wat is het nu?

Bij klassen en objecten duidt ``static`` aan dat een methode of variabele "gedeeld" wordt over alle objecten van die klasse.

``static`` kan op 2 manieren gebruikt worden:

1. Bij *variabelen* om een gedeelde variabele aan te maken, over de objecten heen.
2. Bij *methoden* om zogenaamde methoden-bibliotheken of hulpmethoden aan te maken.

### Variabelen en het static keyword

Zonder het keyword heeft ieder object z'n eigen variabelen en aanpassingen binnen het object aan die variabelen heeft geen invloed op andere objecten. We tonen eerst de werking zoals we gewend zijn en vervolgens hoe ``static`` werkt.

#### Variabelen ZONDER static

Gegeven volgende klasse:

```java
class Mens
{
    private int leeftijd=1;
    public void Jarig()
    {
        leeftijd++;
    }

    public void ToonLeeftijd()
    {
        Console.WriteLine(leeftijd);
    }
}
```

Als we dit doen:

```java
Mens m1= new Mens();
Mens m2= new Mens();

m1.Jarig();
m1.Jarig();

m2.Jarig();

m1.ToonLeeftijd();
m2.ToonLeeftijd();
```

Dan zien we volgende uitvoer:

<!---{line-numbers:false}--->
```text
3
2
```

Ieder object houdt de stand van z'n eigen variabelen bij. Ze kunne mekaars interne (zowel publieke als private) staat niet veranderen.

#### Variabelen MET static

We maken de variabele ``private int leeftijd`` static als volgt: ``private static int leeftijd=1;``.

We krijgen dan:

```java
class Mens
{
    private static int leeftijd=1;
    public void Jarig()
    {
        leeftijd++;
    }

    public void ToonLeeftijd()
    {
        Console.WriteLine(leeftijd);
    }
}
```

**We hebben nu gezegd dat ALLE objecten de variabele leeftijd delen. Er wordt van deze variabele dus maar een "instantie" in het geheugen gemaakt.**

Voeren we nu terug volgende code uit:

```java
Mens m1= new Mens();
Mens m2= new Mens();

m1.Jarig();
m1.Jarig();

m2.Jarig();

m1.ToonLeeftijd();
m2.ToonLeeftijd();
```

Dan wordt de uitvoer:

```
4
4
```

Static laat je dus toe om informatie over de objecten heen te delen. **Gebruik static niet te pas en te onpas: vaak druist het in tegen de concepten van OO en wordt het vooral misbruikt**
Ga je dit vaak nodig hebben? Niet zo vaak. Het volgende concept wel.

### Methoden met static

Heb je er al bij stil gestaan waarom je dit kan doen:

```
Math.Pow(3,2);
```

Zonder dat we objecten moeten aanmaken in de trend van:

```java
Math myMath= new Math(); //dit mag niet!
myMath.Pow(3,2)
```

De reden dat je de math-bibliotheken kan aanroepen rechtsreeks **op de klasse** en niet op objecten van die klasse is omdat de methoden in die klasse als ``static`` gedefineerd staan.

#### Voorbeeld van static methoden

Stel dat we enkele veelgebruikte methoden willen groeperen en deze gebruiken zonder telkens een object te moeten aanmaken dan doen we dit als volgt:

```java
class EpicLibray
{
    static public void ToonInfo()
    {
        Console.WriteLine("Ik ben ik");
    }

    static public int TelOp(int a, int b)
    {
        return a+b;
    }
}
```

We kunnen deze methoden nu als volgt aanroepen:

```java
EpicLibrary.ToonInfo();

int opgeteld= EpicLibrary.TelOp(3,5);
```

Mooi toch.

#### Nog een voorbeeld

In het volgende voorbeeld gebruiken we een ``static`` variabele om bij te houden hoeveel objecten (via de constructor) er van de klasse reeds zijn aangemaakt:

```java
class Fiets
{
    private static int aantalFietsen = 0;
    public Fiets()
    {
        aantalFietsen++;
		Console.WriteLine($"Er zijn nu {aantalFietsen} gemaakt");
    }
	
	public static void VerminderFiets()
	{
		aantalFietsen--;
	}
}
```

Merk op dat we de methoden ``VerminderFiets`` enkel via de klasse kunnen aanroepen:

```java
Fiets.VerminderFiets();
```

### Static vs non-static

Van zodra je een methode hebt die ``static`` is dan zal deze methode enkel andere  ``static` methoden en variabelen kunnen aanspreken. Dat is logisch: een static methode heeft geen toegang tot de gewone niet-statische variabelen van een individueel object, want welk object zou hij dan moeten aanpassen?

Volgende code zal dus een error geven:

```java
class Mens
{
	private int gewicht=50;
	
	private static void VerminderGewicht()
	{
		gewicht--;
	}
```

De error die verschijnt **An object reference is required for the non-static field, method, or property 'Program.Fiets.gewicht'** zal bij de lijn ``gewicht--`` staan.

Een eenvoudige regel is te onthouden dat van zodra je in een static omgeving (meestal een methode) bent je niet meer naar de niet-static delen van je code zal geraken.

### Static en main

Dit verklaart ook waarom je bij console applicaties in Program.cs steeds alle methoden ``static`` moet maken. Een console-applicatie is als volgt beschreven wanneer je het aanmaakt:

```java
public class Program
{
		public static void Main()
		{

	    }
}
```

Zoals je ziet is de ``Main`` methode als ``static`` gedefinieerd. Willen we dus vanuit deze methode andere methoden aanroepen dan moeten deze als ``static`` aangeduid zijn.

Uiteraard kan je wel niet-static zaken gebruiken en daarom kan je dus gewone objecten etc. in je static methoden aanmaken.

### Een use-case met static

Beeld je in dat je (weer) een pong-variant moet maken waarbij meerdere balletjes over het scherm moeten botsen. Je wilt echter niet dat de balletjes zelf allemaal apart moeten weten wat de grenzen van het scherm zijn. Mogelijk wil bijvoorbeeld dat je code ook werkt als het speelveld kleiner is dan het eigenlijke Console-scherm.

We gaan dit oplossen met een static property waarin we de grenzen voor alle balletjes bijhouden. Onze basis-klasse wordt dan al vast:

```java
class Mover
{
    static public int Width { get; set; }
    static public int Height { get; set; }

    public void Update()
    {
        //Soon
    }

    public void Draw()
    {
        //Soon
    }
}
```

Elders kunnen we nu dit doen:

```java
Mover.Height = Console.WindowHeight;
Mover.Width = Console.WindowWidth;

Mover m1 = new Mover();
Mover m2= new Mover();
```

Maar dat hoeft dus niet, even goed maken we de grenzen voor alle balletjes kleiner:

```java
Mover.Height = 20;
Mover.Width = 10;

Mover m1 = new Mover();
Mover m2= new Mover();
```

De interne werking van de balletjes hoeft dus geen rekening meer te houden met de grenzen van het scherm.
De klasse ``Mover`` bereiden we nu uit naar de standaard "beweeg" en "teken jezelf" code:

```java
class Mover
{
    public Mover(int xi, int yi, int dxi, int dyi)
    {
        x = xi;
        y = yi;
        dx = dxi;
        dy = dyi;
    }

    static public int Width { get; set; }
    static public int Height { get; set; }

    private int dx=1;
    private int dy=0;
    private int x=0;
    private int y=0;

    public void Update()
    {
        x += dx;
        if(x>=Mover.Width|| x<0)  //hier gebruiken we de static Width
        {
            dx *= -1;
            x += dx;
        }

        y += dy;
        if (y >= Mover.Height || y<0)
        {
            dy *= -1;
            y += dy;
        }
    }

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write("O");
    }
}
```

En nu kunnen we vlot balletjes laten rondbewegen op het scherm:

```java
static void Main(string[] args)
{
    Console.CursorVisible = false; //handig dit hoor
    Mover.Height = Console.WindowHeight;
    Mover.Width = Console.WindowWidth;

    Mover m1 = new Mover(1,1,1,1);
    Mover m2 = new Mover(6,7,-2,1);
    
    while (true)
    {
        m1.Update();
        m1.Draw();

        m2.Update();
        m2.Draw();

      
        System.Threading.Thread.Sleep(50);
        Console.Clear();
    }
}
```

Stel dat we nu elke seconden het speelveld met 1 willen vergroten, dan hoeven we hiervoor enkel een extra variabele ``int count=0`` voor de loop te zetten en dan in de loop het volgende te doen:

```java
 if(count%20==0) //iedere seconde (daar we telkens 50ms slapen (1seconde =1000 ms => 1000ms/50ms == 20))
{
    Mover.Width++;
    Mover.Height++;
}
```

#### Maximum grootte

Als je voorgaande code zou runnen zal je zien dat je redelijk snel een error krijgt. Dit komt omdat de hoogte en breedte van een Console maar tot bepaalde waardes kunnen verhogen. 

We kunnen dit opvangen door in de klasse ``Mover`` volgende twee autoproperties:

```java
    static public int Width { get; set; }
    static public int Height { get; set; }
```

Te vervangen door fullproperties die controleren of er niet over de grenzen wordt gegaan mbv ``Console.LargestWindowWidth`` en ``Console.LargestWindowHeight``. Voor ``Width`krijgen we dan:

```java
private static int width;

public static int Width
{
    get { return width; }
    set
    {
        if (value > 0 && value <  Console.LargestWindowWidth)
            width = value;
    }
}
```

<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)
* [static keyword](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=04805e97-94e8-4593-b30c-ab750089ffa6)
<!---NOBOOKEND--->