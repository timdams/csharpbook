# Switch

{% hint style="success" %}
[Kennisclip](https://youtu.be/FFsVqOTGIHw)
{% endhint %}

## `switch`

Een `switch` statement is een program-flow element om een veelvoorkomende constructie van `if`/`if else`...`else` elementen eenvoudiger te tonen. Vaak komt het voor dat we bijvoorbeeld aan de gebruiker vragen om een keuze te maken \(bijvoorbeeld een getal van 1 tot 10, waarbij ieder getal een ander menu-item uitvoert van het programma\), zoals:

```csharp
int option;
Console.WriteLine("Kies 1 voor afbreken, 2 voor opslaan, 3 voor laden:");
option = Convert.ToInt32(Console.ReadLine());

if (option == 1)
    Console.WriteLine("Afbreken gekozen");
else if (option == 2)
    Console.WriteLine("Opslaan gekozen");
else if (option == 3)
    Console.WriteLine("Laden gekozen");
else
    Console.WriteLine("Onbekende keuze");
```

Met een `switch` kan dit eenvoudiger. De syntax van een `switch` is een beetje specialer dan de andere programma flow-elementen \(`if`, `while`, etc.\), namelijk als volgt:

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

`value` is de waarde die wordt gebruikt als test in de switch \(en dat mag ook een variabele zijn\). Iedere case begint met het `case` keyword gevolgd door de waarde die value moet hebben om in deze case te _springen_. Na het dubbelpunt volgt vervolgens de code die moet uitgevoerd worden in deze `case`. De `case` zelf mag eender welke code bevatten \(methoden, nieuwe program flow elementen, etc.\), maar moet zeker afgesloten worden met het `break` keyword.

Tijdens de uitvoer zal het programma `value` vergelijken met iedere case constant van boven naar onder. Wanneer een gelijkheid wordt gevonden dan wordt die case uitgevoerd. Indien geen case wordt gevonden die gelijk is aan `value` dan zal de code binnen de `default`-case uitgevoerd worden \(de `else` achteraan indien alle vorige `if else`-tests negatief waren\).

Het menu van zonet kunnen we nu herschrijven naar een `switch`:

```csharp
int option;
Console.WriteLine("Kies 1 voor afbreken, 2 voor opslaan, 3 voor laden:");
option = Convert.ToInt32(Console.ReadLine());
switch (option)
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
        Console.WriteLine("Onbekende keuze");
        break;
  }
```

### Opgelet:

De case waarden moeten literals zijn. Dit zijn waarden die je letterlijk uitschrijft, d.w.z. die je niet voorstelt als variabele \(`1`, `"1"`, `1.0`, `1.d`, `'1'`, etc.\)

## Fallthrough

Soms wil je dat dezelfde code uitgevoerd wordt bij 2 of meer cases. Je kan ook zogenaamde fallthrough cases beschrijven wat er als volgt uit ziet:

```csharp
switch (option)
{
    case 1:
        Console.WriteLine("Afbreken gekozen");
        break;
    case 2:
    case 3:
        Console.WriteLine("Laden of opslaan gekozen");
        break;
    default:
        Console.WriteLine("Onbekende keuze");
        break;
  }
```

Na `case 2` staat er niets. In dit geval zullen zowel de waarden `2` en `3` resulteren in de zin "Laden of opslaan gekozen" op het scherm.

## `switch` met `enum`

`switch` werkt goed samen met `enum` types. Als je deze twee samen gebruikt, kan Visual Studio hulp bieden bij het invullen van de mogelijkheden.

```csharp
Weekdagen keuze;
Console.WriteLine("Welke dag is het vandaag?");
Console.WriteLine($"{(int) Weekdagen.Maandag}. {Weekdagen.Maandag}");
Console.WriteLine($"{(int) Weekdagen.Dinsdag}. {Weekdagen.Dinsdag}");
// enzovoort
keuze = (Weekdagen) Convert.ToInt32(Console.ReadLine());
switch (keuze)
{
    case Weekdagen.Maandag:
        Console.WriteLine("Je moet het vuilnis buitenzetten.");
        break;
    case Weekdagen.Dinsdag:
        Console.WriteLine("Gitaarles!");
        break;
    case Weekdagen.Woensdag:
        Console.WriteLine("Algemene muzikale vorming.");
        break;
    case Weekdagen.Donderdag:
    case Weekdagen.Vrijdag:
        Console.WriteLine("Een volle werkdag.");
        break;
    default:
        Console.WriteLine("Weekend.");
        break;
}
```

