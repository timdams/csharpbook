# Console-filmpjes maken
Volgende tutorial toont hoe je een eenvoudig filmpje kan maken dat je, mits wat fantasie, vlot kan uitbreiden over enkele weken met interactieve aspecten.

## Basisloop voor het filmpje
Volgende voorbeeld toont wat je bijvoorbeeld kan doen. Kopieer dit alles naar een eigen project tussen de accolades van de main:
```java
 int framenummer = 0;
int sleeptime = 1000; // in milliseconden
while (true)
{
        
    framenummer = framenummer + 1;
    if (framenummer == 1)
    {
        Console.WriteLine("Het begin");
    }
    else if  (framenummer == 2)
    {
        Console.WriteLine("Tweede frame");
    }
    else if (framenummer == 3)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Derde frame Andere kleur");
    }
    else if (framenummer == 4)
    {
        sleeptime = 4000; //vergeet niet terug te zetten in latere frames indien je dit maar eenmalig wil
        Console.WriteLine("Frame dat langer blijft staan");
    }
    else if (framenummer == 5)
    {
        sleeptime = 500;
        Console.WriteLine("Moving ball:       *");
    }
    else if (framenummer == 6)
    {
        Console.WriteLine("Moving ball:      *");
    }
    else if (framenummer == 7)
    {
        Console.WriteLine("Moving ball:     *");
    }
    else if (framenummer == 8)
    {
        Console.WriteLine("Moving ball:   *");
    }
    
//Voeg hier frames tussen

    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\n\n\nThe End");
    }
    System.Threading.Thread.Sleep(sleeptime); //Pauzeer programma
    Console.Clear();
```

Deze code zal een teller (framenummer) per seconde (instelbaar via sleeptime) met 1 verhogen. Vervolgens zal de code uitgevoerd worden binnen de else-if clausule die overeenkomt met de huidige framenummer.
De eerste keer staat de teller op 1 en wordt dus de code tussen volgende if uitgevoerd.
```java
if (framenummer == 1)
{
    Console.WriteLine("Het begin");
}
```
Vervolgens wordt deze met 1 verhoogd en wordt deze code uitgevoerd:
```java
else if  (framenummer == 2)
{
    Console.WriteLine("Tweede frame");
}
```
En zo voort. Je kan dus zelf frames toevoegen door steeds een constructie als de volgende toevoegen waar de commentaar  ``//Code om uit te voeren in dit frame`` staat:
```java
else if  (framenummer == x)
{
    //Code om uit te voeren in dit frame
}
```
(**vervang X  door het framenummer dat dit moet zijn**)

## Inspiratie nodig
Mogelijke uitbreidingen kunnen zijn:
* Kleuren aanpassen om zo mooiere zaken te tonen (zie voorbeeldframe 3)
* Timing aanpassen wanneer volgende frame moet getoond worden (zie voorbeeldframe 4)
    * Bijgevolg kan je ook animaties doen, verlaag gewoon de tijd tussen frame en zet zaken op andere plekken (zie voorbeeldframes 5 t.e.m. 8)
* Ipv tekst zou je heeldere Unicode-art afbeeldingen kunnen tonen (én animeren)

## Geavanceerde uitbreidingen
### Niet-sequentiële flow
Je kan ook bepalen wat het volgende frame moet zijn door de variabele framenummer aan te passen naar het framenummer dat je nodig hebt -1 . Stel dat je bijvoorbeeld in frame 8 wenst dat na dit frame frame 3 wordt uitgevoerd, dan schrijf je:
```java
else if (framenummer == 8)
{
    framenummer = 2;
    Console.WriteLine("Moving ball:      *");
}
```

### Cursor verzetten
Via de methode ``ConsoleSetCursorPosition`` kan je instellen waar de cursor moet gezet worden. Je geeft tussen de haakjes van deze methode de x,y coördinaten (integers) mee waar de cursor moet gezet worden.
Als je vervolgens tekst schrijft dan wordt die weggeschreven vanaf dat punt. De coördinaten zijn x,y coördinaten, waarbij het punt (1,1) het eerste karakter linksboven in de console is.
Volgende frame zet bijvoorbeeld een "X" 10 letters naar rechts, 20 lijnen naar beneden
```java
else if (framenummer == 9)
{
    Console.SetCursorPosition(10, 20);
    Console.WriteLine("X");
}
```
