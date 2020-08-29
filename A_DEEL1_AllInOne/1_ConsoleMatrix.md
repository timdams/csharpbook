# Matrix Console
In de vorige eeuw was The Matrix een uiterst memorabele film. In volgende code tonen we hoe je het "bekende" computer-beeld kunnen nadoen waarin groene, random letters op het scherm verschijnen.

```java
Random rangen = new Random();
Console.ForegroundColor = ConsoleColor.Green;
while (true)
{
    //Genereer nieuw random teken:
    char teken = Convert.ToChar(rangen.Next(62, 400));
    //Zet teken op scherm
    Console.Write(teken);
    
    //Ietwat vertragen
    System.Threading.Thread.Sleep(1);
    
    //Af en toe donker kleurtje
    if(rangen.Next(0,3)==0)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
}
```

Enkele opmerkingen:
* ``System.Threading.Sleep()`` is een ingebouwde C# methode die aan de computer verteld dat je applicatie(thread) gedurende *x* milliseconden mag gepauzeerd (Sleep) worden. Het argument geeft weer hoeveel milliseconden dit moet zijn. Wil je dus 1 seconden pauzeren dan geef je 1000 mee. 

* **Opgelet**: Sleep zal je programma volledig "blokkeren", het zal met andere woorden ook geen andere zaken doen zoals input van de gebruiker detecteren. 