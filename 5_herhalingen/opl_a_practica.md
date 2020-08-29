
![](../assets/infoclip.png)

* [Micro-tips om loop-opgaven op te lossen](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=ea69bf95-f828-4b45-afca-f0ae911ab7c4)

# Oplossing practica deel 1
## Oplossing Tafels van vermenigvuldiging:
```java
int teller= 1;
while(teller <= 10)
{
    int product= teller * 10;
    Console.WriteLine($"{teller} x 10 = {product}");
    teller++;
}
```

## Oplossing DNA Transscriptie
```java
string inp= "", DNA= "", RNA= "";
do
{
    Console.WriteLine("Voer G, C, T of A in");
    inp = Console.ReadLine();
    switch(inp)
    {
        case "G":
            DNA += "G";
            RNA += "C";
            break;
        case "C":
            DNA += "C";
            RNA += "G";
            break;
        case "T":
            DNA += "T";
            RNA += "A";
            break;
        case "A":
            DNA += "A";
            RNA += "U";
            break;
        default:
            Console.WriteLine("Onbekende invoer. We stoppen ermee.");
            inp = "stop";
            break;
    }
}while(inp != "stop");
Console.WriteLine("Resultaat:");
Console.WriteLine(DNA);
Console.WriteLine(RNA);	  
```

## Oplossing Armstrong nummer
```java
    Console.WriteLine("Voer getal in:");
    int getal= Convert.ToInt32(Console.ReadLine());
    //1° Aantal cijfers ontdekken
    int aantalcijfers= 0;
    int deling= 0;
    int maaltien= 10;
    do
    {
        deling = getal / maaltien;
        maaltien *= 10;
        aantalcijfers++;
    } while (deling != 0);
    
    //2° Kijken of het armstrong is
    int som = 0;
    int enkelgetal = 0;
    int aantalloops = aantalcijfers;
    int tussengetal = getal;
    while (aantalloops > 0)
    {
        enkelgetal = tussengetal / (int)Math.Pow(10, aantalloops - 1);
        som += (int)Math.Pow(enkelgetal, aantalcijfers);

        tussengetal = tussengetal - (enkelgetal * (int)Math.Pow(10, aantalloops - 1));
        aantalloops--;
    }

    if (som == getal)
    {
        Console.WriteLine("Getal is een armstrong getal!");
    }
```

## Oplossing Euler project
```java
int som= 0;
for (int i= 0; i <= 1000; i++)
{
    if(i % 3 == 0 || i % 5 == 0)
    {
        som += i;
    }
}
Console.WriteLine($"Som:{som}");
```

## Oplossing for doordenker
```java
int rows= 4;
for (int i= 1; i <= rows; i++)
{
    for (int j= 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i= 1; i <= rows-1; i++)
{
    for (int j= 1; j <= 4 - i % 4; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
```

## Oplossing pro for doordenker extra

```java
int rows= 6;
int k= 0;
int space= 0;
for (int i= 1; i <= rows; i++,  k = 0)
{
    for (space = 1; space <= rows - i; space++)
    {
        Console.Write("  ");
    }

    while (k != 2 * i - 1)
    {
        Console.Write("*");
        k++;
    }

    Console.WriteLine();
}
```

# Oplossing practica deel 2 

![](../assets/infoclip.png)

* [Oplossingen deel 2 (deel 1)](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=93c5cd9e-e621-4e9f-a180-ab0a00d9c08f)

# Oplossing practica deel 3

## Oplossing grootste getal
Toe te voegen lijnen aangeduid met ``//NEW``.
```java
int x= 0;
int y= 0;
int grootste= int.MinValue; //NEW
do
{
    y = y + x;
    Console.WriteLine("Voer gehele waarden in (32767=stop)");
    string instring= Console.ReadLine();
    x = Convert.ToInt32(instring);
    if (x > grootste && x != 32767) //NEW
        grootste = x; //NEW
} while (x != 32767);
Console.WriteLine($"Som is {y}");
Console.WriteLine($"Grootste getal is {grootste}");//NEW
```

## Oplossing Boekhouder
```java
int som= 0, negsom= 0, plussom= 0, aantalingevoerd= 0;
Console.WriteLine("Voer getallen in. Dit programma stopt nooit.");
while (true)
{
    int invoer= Convert.ToInt32(Console.ReadLine());
    som += invoer;
    if (invoer > 0) 
        plussom += invoer;
    else
        negsom += invoer;

    aantalingevoerd++;

    Console.WriteLine($"Balans= {som}");
    Console.WriteLine($"Positieve balans= +{plussom}");
    Console.WriteLine($"Negatieve balans= {negsom}");
    Console.WriteLine($"Gemiddelde= {(double)som/aantalingevoerd}");
}
```

## Oplossing BeerSong
```java
for (int i= 99; i > 2; i--)
{
    Console.WriteLine($"{i} bottles of beers on the wall, {i} bottles of beer.");
    Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of beer on the wall.");
}
Console.WriteLine("2 bottles of beer on the wall, 2 bottles of beer.\n" +
                    "Take one down and pass it around, 1 bottle of beer on the wall.\n" +

                    "1 bottle of beer on the wall, 1 bottle of beer.\n" +
                    "Take it down and pass it around, no more bottles of beer on the wall.\n" +

                    "No more bottles of beer on the wall, no more bottles of beer.\n" +
                    "Go to the store and buy some more, 99 bottles of beer on the wall.");
```
