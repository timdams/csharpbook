# Escape sequenties en verbatim strings

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/LXUckCWukYU)
{% endhint %}

## Escapesequenties

Strings moeten normaal op één regel staan. Hoe toon je dan tekst die over meerdere regels gaat? Via een **escape sequentie**. Dit is tekst die iets anders voorstelt dan wat je schrijft.

Probeer volgende code eens uit om het effect in actie te zien:

```csharp
Console.WriteLine("Hallo wereld,\nHoe gaat het met jou?\nMet mij gaat het goed.")
```

Ook al staat er maar één `WriteLine`, toch verschijnt de tekst over drie regels. Dat komt omdat `\n` een escapesequentie is die een line break voorstelt, dat wil zeggen een overgang naar een volgende regel.

Er zijn veel escapesequenties, maar de nuttigste zijn deze:

| escapesequentie | betekenis |
| :--- | :--- |
| \n | line break |
| \" | dubbele aanhalingstekens \(soms nodig binnen string\) |
| \' | enkel aanhalingsteken \(soms nodig als `char`\) |
| \\ | backslash \(een enkele backslash begint een sequentie\) |
| \t | tab-symbool |

{% hint style="info" %}
Een escapesequentie is niet alleen bruikbaar in een string, maar ook als char. Dus `'\n'` stelt één newline symbool voor. Het is dus niet zo dat er altijd maar één teken getypt wordt tussen de enkele aanhalingstekens.
{% endhint %}

{% hint style="warning" %}
Op Windows wordt een line break eigenlijk voorgesteld als \r\n en niet als \n. Héél af en toe is het nuttig dit te weten.
{% endhint %}

## Verbatim strings

In tekst heb je niet zo vaak een backslash nodig. Bovendien kom je meestal ook toe met strings die op één regel te noteren zijn. Daarom zal een "gewone" C\#-string een backslash behandelen als het begin van een escape sequentie en line breaks binnenin tekst verbieden. Meestal is dat goed, maar soms is het lastig. Als je veel backslashes en/of line breaks nodig hebt, kan je misschien meer leesbare code verkrijgen door een **verbatim string** te gebruiken.

Dit is een string die voorafgegaan wordt door `@`, waarin backslashes gewoon het backslash-symbool voorstellen en waarin line breaks gewoon line breaks voorstellen. Een voorbeeld kan dit verduidelijken:

```csharp
Console.WriteLine("Een newline noteer je door \\n te schrijven.\nDeze tekst komt dus op de volgende regel.");
Console.WriteLine(@"Een newline noteer je door \n te schrijven.
Deze tekst komt dus op de volgende regel.");
```

{% hint style="info" %}
Alles wat je met een verbatim string kan schrijven, kan je ook met een gewone string schrijven. Het is soms gewoon handiger een verbatim string te gebruiken. Achter de schermen worden verbatim strings zelfs vertaald in gewone strings. Verbatim strings hebben dus net dezelfde functionaliteit als gewone strings. Je kan hun lengte opvragen, je kan ze splitsen,...
{% endhint %}

### Verbatim strings met stringinterpolatie

Je kan ook in een verbatim string stringinterpolatie toepassen. Dat doe je door `$@` voor de eerste aanhalingstekens te plaatsen. Dit kan van pas komen als je een eerder grote template hebt waarin je gegevens wil tonen. Onderstaande code toont bijvoorbeeld hoe je persoonsgegevens zou kunnen tonen op meerdere regels:

```csharp
Console.WriteLine("Je naam ajb?");
string naam = Console.ReadLine();
Console.WriteLine("Je leeftijd ajb?");
int leeftijd = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($@"Naam: {naam} 
Leeftijd: {leeftijd:D3}");
```

