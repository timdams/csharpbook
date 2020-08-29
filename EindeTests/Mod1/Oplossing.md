# Oplossing module 1 Eindetest
Om deze opgave op te lossen begin je best met het geheel in kleinere delen op te splitsen, die je dan afzonderlijk oplost en test.  Op het einde integreer je dan alle delen tot de finale oplossing.

Er zijn 5 duidelijk afzonderlijke delen: 
1. Het menu-systeem
2. De rekenmachine
3. De password test
4. De recyclage
5. De computer solver

We zullen deze nu deel per deel apart schrijven en testen:

### Het menu-systeem
Het menusysteem vraagt een getal aan de gebruiker en zal dan code uitvoerne afhankelijk van die keuze. We zouden dit met een reeks ``if``-statements kunnen oplossen maar gaan het eens met een ``switch``. We krijgen dan:
```java
Console.WriteLine("Welkom bij de multitool applicatie. Maak uw keuze:");
Console.WriteLine("1.Rekenmachine");
Console.WriteLine("2.Password tester");
Console.WriteLine("3.Recyclage");
Console.WriteLine("4.Computersolver");
int keuze = Convert.ToInt32(Console.ReadLine());
switch (keuze)
{
    case 1:
        //Hier rekenmachine code
        break;
    case 2:
        //Hier password tester code
        break;
    case 3:
        //Hier recyclage code
        break;
    case 4:
        //Hier computersolver code
        break;
    default:
        Console.WriteLine("Onbekend keuze ingevoerd. Voer getal tussen 1 en 4 in");
        break;
}
```

We gebruiken comments om aan te duiden waar we straks de andere delen kunnen plaatsen. Eventueel zet je in iedere case een ``WriteLine`` die toont welk deel van het programma zou uitgevoerd worden (bv ``Console.WriteLine("Password test zal nu starten";``)). Op die manier kan je je code testen om te zien of alles werkt.

### De rekenmachine
De rekenmachine zal eerste 2 getallen vragen alsook welke bewerking. Dan zal die bewerking toegepast worden op de getallen. Finaal veranderen we de kleur indien de uitkomst negatief is.

Dit ziet er dan zo uit, waarbij we deze keer een ``if-else``-structuur kiezen om het probleem op te lossen (maar kan ook met een ``switch``).

```java
Console.WriteLine("Geef getal 1");
int getal1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Geef getal 2");
int getal2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Welke bewerking wil je doen? (+,-,*,/,%)");
char keuzebew = Convert.ToChar(Console.ReadLine());
double result = 0;
if (keuzebew == '+')
{ result = getal1 + getal2; }
else if (keuzebew == '-')
{ result = getal1 - getal2; }
else if (keuzebew == '*')
{ result = getal1 * getal2; }
else if (keuzebew == '/')
{ result = getal1 / getal2; }
else if (keuzebew == '%')
{ result = getal1 % getal2; }

if (result < 0)
    Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine($"Uitkomst is:{result}");
```

### De password-tester
Deze is een eenvoudige ``if-else`` structuur. Als extra'tje zetten we het correct passwoord in een constante (``const``) bovenaan in een variabele, zodat we in de toekomst snel het passwoord kunnen veranderen:
```java
const string MAINPASS = "TrumpSux";
Console.WriteLine("Geef paswoord");
string inputPass = Console.ReadLine();
if(inputPass==MAINPASS)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Toegelaten");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Verboden");
}
```

### De recyclage
Kies eender welke oefening uit het verleden en copy paste alles binnen de ``Main`` naar case 3. Het enige dat hier kan mislopen is dat je in die oefening variabele namen hebt die je reeds gebruikt hebt in andere delen van dit project.  In dat geval krijg een een scope-error en moet je dus de variabele(n) in kwestie hernoemen.

### De Computer solver
Dit los je best stap voor stap op. We gaan er hierbij van uit dat als de gebruiker iets anders dan ``y`` invoert hij ``n`` (NO) bedoeld. Uiteraard moet dat niet.

We beginnen bovenaan, dan krijgen we:
```java
Console.WriteLine("Does the computer turn on?(y/n)");
string inp = Console.ReadLine();
if(inp=="y")
{

}
else
{

}
```

Nu lossen we de linkervraag indien de eerste vraag ``YES`` was op. We herbruiken daarbij de ``inp`` variabele:
```java
Console.WriteLine("Does the computer turn on?(y/n)");
string inp = Console.ReadLine();
if(inp=="y")
{
    Console.WriteLine("Are there any messages?");
    inp = Console.ReadLine();
    if(inp=="y")
    {
        Console.WriteLine("Perform a search for the error message");
    }
    else
    {
        Console.WriteLine("Computer is fine");
    }
}
else
{

}
```

Nu de "andere zijde", namelijk de  ``else`` indien de eerste vraag ``NO`` was en dus krijgen we voor dit deel als finale code:
```java
Console.WriteLine("Does the computer turn on?(y/n)");
string inp = Console.ReadLine();
if(inp=="y")
{
    Console.WriteLine("Are there any messages?");
    inp = Console.ReadLine();
    if(inp=="y")
    {
        Console.WriteLine("Perform a search for the error message");
    }
    else
    {
        Console.WriteLine("Computer is fine");
    }
}
else
{
    Console.WriteLine("Is the computer light on?");
    inp = Console.ReadLine();
    if(inp=="y")
    {
        Console.WriteLine("Turn the computer monitor on");
    }
    else
    {
        Console.WriteLine("Check the computer power cord");
    }
}
```

## Alles samenvoegen 
Voegen we nu deze bovenstaande 5 stukken code samen (door de 4 laatste delen in de juiste case van deel 1 (het menu) te plaatsen), dan krijgen wel als finale oplossing:
```java
Console.WriteLine("Welkom bij de multitool applicatie. Maak uw keuze:");
Console.WriteLine("1.Rekenmachine");
Console.WriteLine("2.Password tester");
Console.WriteLine("3.Recyclage");
Console.WriteLine("4.Computersolver");
int keuze = Convert.ToInt32(Console.ReadLine());
switch (keuze)
{
    case 1:
        //Hier rekenmachine code
        Console.WriteLine("Geef getal 1");
        int getal1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Geef getal 2");
        int getal2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Welke bewerking wil je doen? (+,-,*,/,%)");
        char keuzebew = Convert.ToChar(Console.ReadLine());
        double result = 0;
        if (keuzebew == '+')
        { result = getal1 + getal2; }
        else if (keuzebew == '-')
        { result = getal1 - getal2; }
        else if (keuzebew == '*')
        { result = getal1 * getal2; }
        else if (keuzebew == '/')
        { result = getal1 / getal2; }
        else if (keuzebew == '%')
        { result = getal1 % getal2; }

        if (result < 0)
            Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"Uitkomst is:{result}");
        break;
    case 2:
        //Hier password tester code
        Console.WriteLine("Geef paswoord");
        const string MAINPASS = "TrumpSux";
        string inputPass = Console.ReadLine();
        if (inputPass == MAINPASS)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Toegelaten");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Verboden");
        }
        break;
    case 3:
        //Hier recyclage code
        break;
    case 4:
        //Hier computersolver code
        Console.WriteLine("Does the computer turn on?(y/n)");
        string inp = Console.ReadLine();
        if (inp == "y")
        {
            Console.WriteLine("Are there any messages?");
            inp = Console.ReadLine();
            if (inp == "y")
            {
                Console.WriteLine("Perform a search for the error message");
            }
            else
            {
                Console.WriteLine("Computer is fine");
            }
        }
        else
        {
            Console.WriteLine("Is the computer light on?");
            inp = Console.ReadLine();
            if (inp == "y")
            {
                Console.WriteLine("Turn the computer monitor on");
            }
            else
            {
                Console.WriteLine("Check the computer power cord");
            }
        }
        break;
    default:
        Console.WriteLine("Onbekend keuze ingevoerd. Voer getal tussen 1 en 4 in");
        break;
}
```
