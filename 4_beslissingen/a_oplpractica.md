
![](../assets/infoclip.png)

* [Bespreking BMI met if](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=8d5602e2-ef82-486c-ba60-a981009b3a61)
* [Bespreking Ohmberekenaar](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=3d9dcd19-a130-4287-8ef2-a981009dc942)
* [Bespreking Orakeltje van Delphi, part Deux](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=d0ff5c46-9839-483f-97dd-a98100a28b9d)
* [Bespreking Kleurcode weerstand naar Ohm](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a272f856-78cd-44a6-afbd-a981009f7253)


# Code

## BMI met if

Voeg volgende code toe aan het bestaande BMI programma:
```java
if(bmi < 18.5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ondergewicht");
}
else if(bmi < 24.9)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Normaal gewicht");
}
else if (bmi < 29.9)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Overgewicht");
}
else if (bmi < 39.9)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Zwaarlijvigheid");
}
else
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Ernstige zwaarlijvigheid");
}
```

## Schoenverkoper

### a

```java
Console.WriteLine("Hoeveel schoenen koopt de klant?");
int aantal = Convert.ToInt32(Console.ReadLine());
int kortingboven = 9;
int prijs = 0;
if (aantal <= kortingboven)
{
    prijs = aantal * 20;
}
else
{
    prijs = kortingboven * 20;
    prijs += (aantal - kortingboven) * 10;
}
Console.WriteLine($"Prijs is {prijs}");
```

### b
```java
Console.WriteLine("Hoeveel schoenen koopt de klant?");
int aantal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Boven hoeveel schoenen wordt de korting gegeven?");
int kortingboven = Convert.ToInt32(Console.ReadLine());
int prijs = 0;
if (aantal <= kortingboven)
{
    prijs = aantal * 20;
}
else
{
    prijs = kortingboven * 20;
    prijs += (aantal - kortingboven) * 10;
}
Console.WriteLine($"Prijs is {prijs}");
```
## Enum seizoenen

```java
enum Seizoenen { Winter, Lente, Zomer, Herfst, Onbekend}     
```

```java
Console.WriteLine("Geef een maandnummer (1 tot 12)");
int maand = Convert.ToInt32(Console.ReadLine());
Seizoenen huidigSeizoen = Seizoenen.Onbekend;
switch(maand)
{
    case 1:
    case 2:
    case 3:
        huidigSeizoen = Seizoenen.Winter;
        break;
    case 4:
    case 5:
    case 6:
        huidigSeizoen = Seizoenen.Lente;
        break;
    case 7:
    case 8:
    case 9:
        huidigSeizoen = Seizoenen.Zomer;
        break;
    case 10:
    case 11:
    case 12:
        huidigSeizoen = Seizoenen.Herfst;
        break;
    default:
        huidigSeizoen = Seizoenen.Onbekend;
        break;

}

if(huidigSeizoen== Seizoenen.Winter || huidigSeizoen== Seizoenen.Herfst)
    Console.WriteLine("Dat is een koud seizoen!");
else if(huidigSeizoen == Seizoenen.Zomer || huidigSeizoen == Seizoenen.Lente)
    Console.WriteLine( "Dat is een warm seizoen!");
else //Seizoen.Onbekend
    Console.WriteLine("Dat is geen seizoen!");

```