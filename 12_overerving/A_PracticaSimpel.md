# Het dierenrijk

![Vereenvoudigde voorstelling van (een deel van het) dierenrijk](../assets/7_overerving/animals.png)

Maak bovenstaande klassenhierarchie na. Animal is de parentklasse , mammal en reptile zijn childklassen van Animal en zo voort.

Verzin voor iedere klasse een property die de parent klasse niet heeft. (bv Animal heeft "BeweegVoort", Reptile heeft "AantalSchubben", etc).

Voorzie in de klasse Animal een virtual methode ``ToonInfo`` die alle properties van de klasse op het scherm zet. De overgeërfde klassen overriden deze methode door de extra properties ook te tonen (maar gebruik base.ToonInfo om zeker de parentklasse werking te bewaren).

Maak nu van iedere klasse een object en roep de ToonInfo methode van ieder object aan.

Plaats deze dieren nu in een ``List<Animal>`` en kijk wat er gebeurt als je deze met een foreach aanroept om alle ToonInfo-methoden van ieder dier te gebruiken.

# Ziekenhuis

## Deel 1 
Maak een basisklasse ``Patient`` die een programma kan gebruiken om de doktersrekening te berekenen.
Een patiënt heeft:

* een naam
* het aantal uur dat hij in het ziekenhuis heeft gelegen

Een ``virtual`` methode ``BerekenKost`` zal de totaalkost berekenen. Deze bestaat uit 50euro+  20euro per uur dat de patiënt in het ziekenhuis lag.

Maak een methode ``ToonInfo`` die steeds de naam van de patiënt toont gevolgd door het aantal uur en z'n kosten.

## Deel 2
Maak een specialisatieklasse ``VerzekerdePatient``. Deze klasse heeft alles dat een gewone ``Patient`` heeft, echter de berekening van de kosten zal steeds gevolgd worden door een 10% reductie.

Toon de werking aan van deze klasse.

# HiddenBookmark

 Voeg een ``HiddenBookmark`` klasse toe aan je bestaande Bookmark Manager applicatie van vorige hoofdstuk.

 De ``HiddenBookmark`` is een ``Bookmark`` klasse die de browser in Incognito-modus zal opstarten bij het openen van de bookmark. Dit kan je bewerkstelligen door ``-incognito`` achter ``chrome.exe`` te plaatsen. Maak de ``OpenSite`` methode ``virtual``  in ``BookMark`` om vervolgens via ``override`` in ``HiddenBookmark`` dit op te lossen.

 Test wat er gebeurt als je al je bookmarks vervangt door ``HiddenBookmarks``.

Afhankelijk van de browser die je wilt aanroepen moet je de incognito parameter iets anders doorgeven:
**Let op de spatie na "-private ", deze moet er staan anders plak je je url aan de parameter:**

```java
Process.Start("iexplore.exe", "-private " + url);
Process.Start("chrome.exe", "-incognito " + url);
Process.Start("firefox.exe", "-private-window " + url);
Process.Start("iexplore.exe", "-private " + url);
```



# Ballspel met overerving (zie hoorcollege voor extra uitleg)

Volgende code toont hoe we een bestaande klasse  ``Ball`` kunnen overerven om een bestuurbare bal te maken 

## Basisklasse Ball

We maken een klasse ``Ball`` die via ``Update`` en ``Draw`` zichzelf over het consolescherm beweegt. Enkele opmerkingen:

* We maken sommige variabelen ``protected`` zodat later de overgeërfde klasse er aan kunnen
* Een ``static`` methode ``CheckHit`` laat ons toe te ontdekken of twee ``Ball``objecten mekaar raken

```java
class Ball
{
   public int X { get { return x; } }
   public int Y { get { return y; } }
   private int x = 0;
   private int y = 0;
   protected int vx = 0;
   protected int vy = 0;
   protected char drawChar = 'O';
   protected ConsoleColor drawColor = ConsoleColor.Red;

   public Ball(int xin, int yin, int vxin, int vyin)
   {
      x = xin;
      y = yin;
      vx = vxin;
      vy = vyin;
   }

   public void Update()
   {
      x += vx;
      y += vy;
      if (x >= Console.WindowWidth || x < 0)
      {
            vx *= -1;
            x += vx;
      }
      if (y >= Console.WindowHeight || y < 0)
      {
            vy *= -1;
            y += vy;
      }
   }
   public void Draw()
   {
      Console.SetCursorPosition(x, y);
      Console.ForegroundColor = drawColor;
      Console.Write(drawChar);
      Console.ResetColor();

   }

   static public bool CheckHit(Ball ball1, Ball ball2)
   {

      if (ball1.X == ball2.X && ball1.Y == ball2.Y)
            return true;

      return false;
   }
}
```

## Specialisatie klasse PlayerBall

De overgeërfde klasse ``PlayerBall`` is een ``Ball`` maar zal z'n ``vx`` en ``vy`` updaten gebaseerd op input via de ``ChangeVelocity`` methode:

```java
class PlayerBall : Ball
{
   public PlayerBall(int xin, int yin, int vxin, int vyin) : base(xin, yin, vxin, vyin)
   {
      drawChar = 'X';
      drawColor = ConsoleColor.Green;
   }

   public void ChangeVelocity(ConsoleKeyInfo richting)
   {
      switch (richting.Key)
      {
            case ConsoleKey.UpArrow:
               vy--;
               break;
            case ConsoleKey.DownArrow:
               vy++;
               break;
            case ConsoleKey.LeftArrow:
               vx--;
               break;
            case ConsoleKey.RightArrow:
               vx++;
               break;
            default:
               break;
      }
   }
}
```

## Eenvoudig spel

We maken nu een rudimentair spel waarin de gebruiker een bal moet proberen te raken. 

```java
static void Main(string[] args)
{
   Console.CursorVisible = false;
   Console.WindowHeight = 20;
   Console.WindowWidth = 30;
   Ball b1 = new Ball(4, 4, 1, 0);
   PlayerBall player = new PlayerBall(10, 10, 0, 0);
   while (true)
   {

         Console.Clear();

         //Ball
         b1.Update();
         b1.Draw();
         
         //SpelerBall
         if (Console.KeyAvailable)
         {
            var key = Console.ReadKey();
            player.ChangeVelocity(key);
         }

         player.Update();
         player.Draw();
         
         //Check collisions
         if (Ball.CheckHit(b1, player))
         {
            Console.Clear();
            Console.WriteLine("Gewonnen!");
            Console.ReadLine();
         }
         System.Threading.Thread.Sleep(100);
   }
}
```

Kan je dit uitbreiden met?

* Ballen met andere eigenschappen
* Meerdere ballen die over het scherm vliegen (benodigdheden: array )
* Meerdere levels 
* Score gebaseerd op tijd die gebruiker nodig had om bal te raken (benodigdheden: teller die optelt na iedere ``Sleep``)
* PRO: collision detection tussen de ballen