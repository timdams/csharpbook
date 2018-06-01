
## While
De syntax van een while loop is eenvoudig:

```csharp
while (condition) 
{
// C# code to be performed while expression evaluates to true
}
```
Waarbij we, net als bij een if statement, de conditie uitgedrukt wordt als een booleaanse expressie met 1 of meerdere relationele operators.

Zolang de conditie true is zal de code binnen de accolades uitgevoerd worden. Indien dus de conditie reeds vanaf het begin false is dan zal de code binnen de while-loop niet worden uitgevoerd.

Een voorbeeld van een eenvoudige while loop:

```csharp
int myCount = 0;
 
while (myCount < 100)
{
    myCount++;
    Console.WriteLine(myCount);
}
```
Zolang myCount kleiner is dan 100 (myCount<100) zal myCount met 1 verhoogd worden en zal de huidige waarde van myCount getoond worden. Daar de test gebeurt aan het begin van de loop wil dit zeggen dat het getal 100 nog wel getoond zal worden. Test dit zelf!

## Do while
In tegenstelling tot een while loop, zal een do-while loop sowieso **minstens 1 keer uitgevoerd worden**. Ongeacht de opgegeven conditie zal de do-while loop zijn code 1 keer uitvoeren. We herhalen deze zin uitdrukkelijk 2x zodat het verschil tussen beide type loops duidelijk blijft.

De syntax van een do-while is eveneens verraderlijk eenvoudig:

```csharp
do
{
     // C# code to be performed while expression evaluates to true
} while (condition);
```

Merk op dat achteraan de conditie een kommapunt na het ronde haakje staat. **Dit is een véél voorkomende fout. Bij een while is dit niet!**
Daar de test van een do-while achteraan de code van de loop gebeurt is het logisch dat een do-while dus minstens 1 keer wordt uitgevoerd
Volgende eenvoudige aftelprogramma toont de werking van de do-while loop


```csharp
int i = 10;
do
{
    i--;
    Console.WriteLine(i);
} while (i < 10);
```

## Complexe condities

Uiteraard mag de conditie waaraan een loop moet voldoen complexer zijn door middel van de booleaanse logische operator.
Volgende while bijvoorbeeld zal uitgevoerd worden zolang teller groter is dan 5 en de variabele naam van het type string niet gelijk is aan "tim":
```csharp
while (teller > 5 && naam != "tim")
{
  // Keep repeating
}
```

## Oneindige loops
Indien de loop-conditie nooit false wordt dan heb je een oneindige loop gemaakt. Soms is dit gewenst gedrag (bijvoorbeeld bij de gameloop) soms is dit een bug en zal je dit moeten debuggen.

Volgende twee voorbeelden tonen dit:
* Een bewuste oneindige loop:
```csharp
while (true)
{
 // See you in infinity
}
```
* Een bug die een oneindige loop veroorzaakt:
```csharp
int teller = 0; 
while (teller<10)
{
  Console.WriteLine(teller);
  teller--;    // oops, dit had teller++ moeten zijn
}
```

## Scope van variabelen in loops
Let er op dat de scope van variabelen bij loops zeer belangrijk is. Indien je een variabelen binnen de loop definieert dan zal deze steeds terug "gereset" worden wanneer de volgende cyclus van de loop start.
Volgende code toont bijvoorbeeld **foutief** hoe je de som van de eerste 10 getallen (1+2+3+...+10) zou maken:

```csharp
int teller = 1;
while(teller<=10)
{
   int som=0;
   som= som+teller;
}
Console.WriteLine(som); //deze lijn zal fout genereren
```

De **correcte** manier om dit op te lossen is te beseffen dat de variabele som enkel binnen de accolades van de while-loop gekend is. Op de koop toe wordt deze steeds terug op 0 gezet en er kan dus geen som van alle teller-waarden bijgehouden worden:
```csharp
int teller = 1;
int som = 0;  
while(teller<=10)
{
   
   som = som+teller;
}
Console.WriteLine(som); // Deze lijn zal fout genereren
```
