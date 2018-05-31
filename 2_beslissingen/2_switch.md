# Switch

Een switch statement is een program-flow element om een veelvoorkomende constructie van if/if else.else elementen eenvoudiger te tonen. Vaak komt het voor dat we bijvoorbeeld aan de gebruiker vragen om een keuze te maken (bijvoorbeeld een getal van 1 tot 10, waarbij ieder getal een ander menu-item uitvoert van het programma), zoals:

```csharp
int option;
Console.WriteLine("Kies 1 voor afbreken, 2 voor opslaan, 3 voor laden:");
option = int.Parse(Console.ReadLine());
 
if (option == 1)
    Console.WriteLine("Afbreken gekozen");
if (option == 2)
    Console.WriteLine("Opslaan gekozen");
if (option == 3)
    Console.WriteLine("Laden gekozen");
```

Met een switch kan dit eenvoudiger. De syntax van een switch is een beetje specialer dan de andere programma flow-elementen (if, while, etc), namelijk als volgt:

```csharp
switch (value)
{
      case constant:
           statements
           break;
      case constant:
           statements
           break;
      default:
           statements
           break;
  }
```

Value is de waarde of variabele (beide mogen) die wordt gebruikt als test in de switch. Iedere case begint met het case keyword gevolgd door de waarde die value moet hebben om in deze case te *springen*. Na het dubbelpunt volgt vervolgens de code die moet uitgevoerd worden in deze case. De case zelf mag eender welke code bevatten (methoden, nieuwe program flow elementen, etc), maar moet zeker afgesloten worden met het break keyword.

Tijdens de uitvoer zal het programma value vergelijken met iedere case constant van boven naar onder. Wanneer een gelijkheid wordt gevonden dan wordt die case uitgevoerd. Indien geen case wordt gevonden die gelijk is aan value dan zal de code binnen de default-case uitgevoerd worden.

## Opgelet:

De case waarden moeten constanten zijn en mogen dus geen variabelen zijn. Constanten zijn de welgekende *literals* (``1, "1", 1.0, 1.d, '1'``, etc.)

Het voorbeeldprogramma bovenaan wordt dan:
```csharp
int option;
Console.WriteLine("Kies 1 voor afbreken, 2 voor opslaan, 3 voor laden:");
option = int.Parse(Console.ReadLine());
 
switch(option)
{
    case 1:
        Console.WriteLine("Afbreken gekozen");
        break;
    case 2:        
        Console.WriteLine("Opslaan gekozen");
        break;
    case 3:
        Console.WriteLine("Laden gekozen");
        break;
    default: 
        Console.WriteLine("Ongeldige optie");
        break;
 }
```

