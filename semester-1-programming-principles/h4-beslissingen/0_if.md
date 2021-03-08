# If

In dit deel zullen we bekijken hoe we ons programma dynamischer kunnen maken met behulp van het if-statement.

{% hint style="success" %}
[Kennisclip voor deze pagina](https://youtu.be/w0kPFKXHR1I)
{% endhint %}

## If

De `if` is een van de elementairste constructies in een programmeertaal. De syntax is als volgt:

```csharp
if (boolean expression) 
{
     // code hier moet uitgevoerd worden indien de booleaanse expressie waar is
}
```

Enkel indien de booleaanse expressie waar is, en dus `true` als resultaat heeft, zal de code binnen de accolades van het if-blok uitgevoerd worden. Indien de expressie niet waar is \(`false`\) dan wordt het blok overgeslagen en gaat het programma verder met de code eronder.

Een voorbeeld:

```csharp
int number = 3;

if ( number < 5 ) {
    Console.WriteLine ("A");
}
Console.WriteLine("B");
```

De uitvoer van dit programma zal zijn:

```text
A
B
```

Indien `number` groter of gelijk aan 5 was dan zou er enkel `B` op het scherm zijn verschenen. De lijn `Console.WriteLine("B")` zal sowieso uitgevoerd worden zoals je ook kan zien aan de volgende flowchart:

![](../../.gitbook/assets/ifflow%20%282%29.png)

Hierboven had `nummer` een vaste waarde, maar dat hoeft niet. Deze variabele kan ook willekeurig geïnitialiseerd worden of kan een waarde krijgen die door de gebruiker wordt ingegeven. In dat geval zal het programma zich tijdens verschillende uitvoeringen anders gedragen.

## if zonder block	

Het is aangeraden om steeds na de if-expressie met accolades te werken. Dit zorgt ervoor dat alle code in het block \(de accolades\) zal uitgevoerd worden indien de booleanse expressie waar was. **Gebruik je geen accolades dan zal enkel het eerste statement \(i.e. berekening\) na de** `if` **uitgevoerd worden bij** `true`**.**

{% hint style="warning" %}
We verwachten dat je `if` altijd met een block gebruikt, omdat dat leesbaarder is. De versie zonder block zien we als een stijlfout!
{% endhint %}

## Veelgemaakte if-fouten

Er zijn enkele veelgemaakte fouten waar je op moet letten:

### Appelen en peren vergelijken

De types in je booleanse expressie moeten steeds vergelijkbaar zijn. Volgende code is dus fout: `if( "4" > 3)` daar we hier een `string` met een `int` vergelijken.

### Accolades vergeten

Accolades vergeten plaatsen om een codeblock aan te duiden, maar je code toch zodanig outlinen \(met tabs\) dat het lijkt of je een heel codeblock hebt. Het gevolg zal zijn dat enkel het eerste statement na de `if` zal uitgevoerd worden indien `true`. Gebruiken we de `if` met block van daarnet maar zonder accolades dan zal het tweede statement altijd uitgevoerd worden ongeacht de `if`:

```csharp
if ( number < 5 )
    Console.WriteLine ("C");
    Console.WriteLine ("D");
```

![](../../.gitbook/assets/ifflownobrace%20%282%29.png)

Merk ook op dat je code anders uitlijnen géén invloed heeft op de uitvoer \(wat bijvoorbeeld wel zo is bij de programmeertaal Python\).

### Een puntkomma plaatsen na de booleanse expressie.

Dit zal ervoor zorgen dat er eigenlijk geen codeblock bij de `if` hoort en je dus een nietszeggende `if` hebt geschreven. De code na het puntkomma zal uitgevoerd worden ongeacht de `if`:

```csharp
if ( number < 5 );
    Console.WriteLine ("C");
    Console.WriteLine ("D");
```

![](../../.gitbook/assets/ifflowsemicolon%20%282%29.png)

## Booleaanse expressies algemeen

Je bent niet beperkt tot het gebruik van expressies met één relationele operator in de voorwaarde van een `if`. Je mag om het even welk type booleaanse expressie gebruiken. Anders gezegd: als het gedeelte tussen haakjes **uiteindelijk** maar `true` of `false` oplevert, is het goed.

We kunnen dus ook gebruik maken van `true` of `false` zelf, alsook van de logische operatoren `&&`, `||`, `!`.

Een voorbeeld:

```csharp
Random ranGen = new Random();

int a = ranGen.Next(1,11);
int b = ranGen.Next(1,11);
int c = ranGen.Next(1,11);
Console.WriteLine($"a is {a}");
Console.WriteLine($"b is {b}");
Console.WriteLine($"c is {c}");

if (true) {
    Console.WriteLine("Dit verschijnt sowieso.");
}

if (false) {
    Console.WriteLine("Dit verschijnt nooit.");
}

if (a == b)
{
        Console.WriteLine(a);
}

if ((a > c) || (a == b))
{  
    Console.WriteLine(b);
}

if ((a >= c) && (b <= c))
{
    Console.WriteLine(c);
}
```

Voer uit en verklaar wat je ziet.

## If/else

Met `if`/`else` kunnen we niet enkel zeggen welke code moet uitgevoerd worden als de conditie waar is maar ook welke specifieke code indien de conditie niet waar \(`false`\) is. Volgend voorbeeld geeft een typisch gebruik van een `if`/`else` structuur om 2 waarden met elkaar te vergelijken:

```csharp
Random ranGen = new Random();
int x = ranGen.Next(1,21);
Console.WriteLine($"x is {x}");

if ( x > 9 )
{
         Console.WriteLine ("x is groter dan 9!");
}
else
{
         Console.WriteLine ("x is kleiner dan of gelijk aan 9!");
}
```

## If/else if

Met een `if`/`else if` constructie kunnen we meerdere criteria opgeven die waar/niet waar moeten zijn voor een bepaald stukje code kan uitgevoerd worden. Sowieso begint men steeds met een `if`. Als men vervolgens een `else if` plaats dan zal de code van deze `else if` uitgevoerd worden enkel en alleen als de eerste expressie \(van de `if`\) niet waar was en de expressie van deze `else if` wel waar is.

Een voorbeeld:

```csharp
Random ranGen = new Random();
int x = ranGen.Next(1,21);
Console.WriteLine($"x is {x}");

if ( x <=6 )
{
         Console.WriteLine ("x is klein");
}
else if (x <= 14) {
         Console.WriteLine("x is medium");
}
else
{
         Console.WriteLine ("x is groot");
}
```

## Nesting

We kunnen met behulp van nesting ook complexere programma flows maken. Hierbij gebruiken we de accolades om het blok code aan te duiden dat bij een `if`/`else if`/`else` hoort. Binnen dit blok kunnen nu echter opnieuw `if`/`else if`/`else` structuren worden aangemaakt.

Volgend voorbeeld toont aan dat je `else if` niet echt nodig hebt, maar dat het wel leesbaardere code oplevert:

```csharp
Random ranGen = new Random();
int x = ranGen.Next(1,21);
Console.WriteLine($"x is {x}");

if ( x <=6 )
{
         Console.WriteLine ("x is klein");
}
else {
    if (x <= 14) {
         Console.WriteLine("x is medium");
    }
    else
    {
         Console.WriteLine ("x is groot");
    }
}
```

Andere vormen van nesting zijn mogelijk. Je mag ook een `if` in een `if` block zetten en je mag zo diep nesten als je maar wil.

