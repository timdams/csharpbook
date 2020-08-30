## Switch

Een ``switch`` statement is een program-flow element om een veelvoorkomende constructie van ``if``/``if else``...``else`` elementen eenvoudiger te schrijven. Vaak komt het voor dat we bijvoorbeeld aan de gebruiker vragen om een keuze te maken (bijvoorbeeld een getal van 1 tot 10, waarbij ieder getal een ander menu-item uitvoert van het programma), zoals:

```java
int option;
Console.WriteLine("Kies: 1)afbreken\n2)opslaan\n3)laden:");
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

Met een ``switch`` kan dit eenvoudiger wat we zo meteen zullen tonen. Eerst bekijken we hoe ``switch`` juist werkt. De syntax van een ``switch`` is een beetje meer speciaal dan de andere programma flow-elementen (``if``, ``while``, etc.), namelijk als volgt:

```java
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

``value`` is de variabele die wordt gebruikt als booleaanse test in de switch (``option`` in ons voorbeeld hier boven) . Iedere case begint met het ``case`` keyword gevolgd door de waarde die ``value`` moet hebben om in deze case te *springen*. Na het dubbelpunt volgt vervolgens de code die moet uitgevoerd worden in deze ``case``. De ``case`` zelf mag eender welke code bevatten (methoden, nieuwe program flow elementen, etc.), maar moet zeker afgesloten worden met het ``break`` keyword.

Tijdens de uitvoer zal het programma ``value`` vergelijken met iedere case constant van boven naar onder. Wanneer een gelijkheid wordt gevonden dan wordt die case uitgevoerd. Indien geen case wordt gevonden die gelijk is aan ``value`` dan zal de code binnen de ``default``-case uitgevoerd worden (de ``else`` achteraan indien alle vorige ``if else``-tests negatief waren).

Het menu van zonet kunnen we nu herschrijven naar een ``switch``:
```java
int option;
Console.WriteLine("Kies: 1)afbreken\n2)opslaan\n3)laden:");
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

{% hint style='warning' %}
De case waarden moeten constanten zijn en mogen dus geen variabelen zijn. Constanten zijn de welgekende *literals* (``1``, ``"1"``, ``1.0``, ``1.d``, ``'1'``, etc.). Uiteraard moeten de case waarden van hetzelfde datatype zijn als die van de testwaarde.
{% endhint %}

<!---{pagebreak} --->

### Fallthrough

Soms wil je dat dezelfde code uitgevoerd wordt bij 2 of meer cases. Je kan ook zogenaamde fallthrough cases beschrijven wat er als volgt uit ziet:

```java
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

In dit geval zullen zowel de waarden ``2`` en ``3`` resulteren in de zin "Laden of opslaan gekozen" op het scherm.