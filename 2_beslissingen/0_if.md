# Beslissingen/If statements
Nu we de elementaire zaken van C# en Visual Studio kennen is het tijd om onze programma's wat interessanter te maken. De ontwikkelde programma's tot nog toe waren steevast lineair van opbouw, ze werden lijn per lijn uitgevoerd zonder de mogelijkheid om de *flow* van het programma aan te passen.

In dit deel  zullen we bekijken hoe we ons programma dynamischer kunnen maken met behulp van het if-statement.

## If
De ``if`` uitdrukking is 1 van de elementairste uitdrukking in een programmeertaal. De syntax is als volgt:

```csharp
if (boolean expression) 
{
     // C# code to be performed when expression evaluates to true
}
```
Enkel indien de boolean expressie true als resultaat geeft zal de code binnen de accolades van het if-blok uitgevoerd worden. Indien de expressie false teruggaf dan wordt het blok overgeslagen en gaat het programma verder met de code eronder.

Een voorbeeld:
```csharp
int x = 10;
 
if ( x > 9 )
{
         System.Console.WriteLine("x is greater than 9!");
}
```


## If/else
Met if/else kunnen we niet enkel zeggen welke code moet uitgevoerd worden als de conditie waar is maar ook welke specifieke code indien de conditatie niet waar (false). Volgende voorbeeld geeft een typisch gebruik van een if/else structuur om 2 waarden met mekaar te vergelijken:

```csharp
int x = 10;
 
if ( x > 9 )
{
         System.Console.WriteLine("x is greater than 9!");
}
else
{
         System.Console.WriteLine("x is less than 9!");
}
```
## If/else if
Met een if/ else if constructie kunnen we meerdere criteria opgeven die waar/niet waar moeten zijn voor een bepaald stukje code kan uitgevoerd worden. Sowieso begint men steeds met een if. Als men vervolgens een else if plaats dan zal de code van deze else if uitgevoerd worden enkel en alleen als de eerste expressie (van de if) niet waar was en de expressie van deze else if wel waar is.

Een voorbeeld:

```csharp
int x = 9;
 
if (x == 10)
{
     System.Console.WriteLine("x is 10");
}
else if (x == 9)
{
     System.Console.WriteLine("x is 9");
}
else if (x == 8)
{
     System.Console.WriteLine("x is 8");
}
```

## Relationele operators
Met de [relationele operators](1_logic_and_relationsoperator.md) (++, !=, <, >, <= en >=) kunnen we expressie schrijven die als uitkomst waar (true) of niet waar (false) geven.

Een voorbeeld:
```csharp
int a, b, c;  
 
a = 2;  
b = 3;  
 
if(a < b) Console.WriteLine("a is less than b"); 
 
// this won't display anything  
if(a == b) Console.WriteLine("you won't see this");  
 
Console.WriteLine(); 
 
c = a - b; // c contains -1 
 
Console.WriteLine("c contains -1"); 
if(c >= 0) Console.WriteLine("c is non-negative"); 
if(c < 0) Console.WriteLine("c is negative"); 
 
Console.WriteLine(); 
 
c = b - a; // c now contains 1 
Console.WriteLine("c contains 1"); 
if(c >= 0) Console.WriteLine("c is non-negative"); 
if(c < 0) Console.WriteLine("c is negative"); 
```
We kunnen ook meerdere expressie combineren zodat we complexere uitdrukkingen kunnen maken. Hierbij kan je gebruik maken van de [logische operators](1_logic_and_relationsoperator.md) *AND (&&)** en **OR (||)** operators. .

Een voorbeeld:
```csharp
int a = 5, b = 5, c = 10;
 
if (a == b)
    Console.WriteLine(a);
 
if ((a > c) || (a == b))
    Console.WriteLine(b);
 
if ((a >= c) && (b <= c))
    Console.WriteLine(c);
```

## Nesting
We kunnen met behulp van nesting ook complexere programma flows maken. Hierbij gebruiken we de accolades om het blok code aan te duiden dat bij een if/else/if else hoort. Binnen dit blok kunnen nu echter opnieuw if/else/if else structuren worden aangemaakt.

Volgende voorbeeld toont dit aan (bekijk wat er gebeurt als je emergencyValve aan ``closed`` gelijkstelt) :

````csharp
int reactorTemp = 1500;
string emergencyValve = " ";
 
if (reactorTemp < 1000)
{
    System.Console.WriteLine("Reactor temperature normal");
}
else
{
    System.Console.WriteLine("Reactor temperature too high!");
    if (emergencyValve == "closed")
    {
        System.Console.WriteLine("Reactor meltdown in progress!");
    }
}
```