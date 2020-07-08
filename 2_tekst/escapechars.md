## Escape characters



{% hint style='warning' %}
<!--- {height:50%} --->
![](../assets/attention.png)
Voorman Tim hier! Escape characters zijn niet de boeiendste term om te bespreken. Je zou nog kunnen hopen dat het een opvolger is van Prison Break of zo. Helaas is dat niet zo. Echter: als je escape characters beheerst zal je veel eenvoudiger én mooier tekst op je scherm kunnen toveren. Let dus even goed op.
{% endhint %}

Naast letters en tekens mogen in string en chars ook escape characters staan. Escape characters worden met een backslash (`\`) gestart, gevolgd door het karakter dat we wensen te tonen. In C# hebben bepaalde tekens namelijk een speciale functie, zoals de dubbele aanhalingstekens (`"`) om het begin of einde van een string-literal aan te geven.

Zonder aan te geven dat we letterlijk dat teken willen tonen, en het niet in z’n C# functie gebruiken, zouden we problemen krijgen.

Laten we eens kijken naar de werking van het afkappingsteken als voorbeeld (de zogenaamde apostrof, gebruik in om bijvoorbeeld ``'s avonds`` te schrijven)
Volgende code zou de compiler verkeerd interpreteren, daar hij denkt dat we een leeg karakter wensen op te slaan:

```csharp
char apostrof= ''';
```
De juiste manier is om het teken effectief door een backslash vooraf te laten gaan:

```csharp
char apostrof= '\'';
```

Er zijn echter nog een heleboel andere escape characters die je geregeld zal moeten gebruiken, waaronder ``\n``  om een nieuwe lijn aan te geven en \t om een tab in de tekst te plaatsen.

Er zijn verschillende escape characters in C# toegelaten, we lijsten hier de belangrijkste op (voor een totaal overzicht kijk [hier](https://blogs.msdn.microsoft.com/csharpfaq/2004/03/12/what-character-escape-sequences-are-available/)):

* `\'` – Single quote, needed for character literals
* `\"` – Double quote, needed for string literals
* `\\` – Backslash
* `\n` – New line (zogenaamde 'enter')
* `\t` – Horizontal tab 
* `\uxxxx` – Unicode escape sequence for character with hex value xxxx


Je kan in grote Unicode-tabellen opzoeken wat de unicode (voorstelling van het teken in een geheel getal) van eender welk teken is. Je kan deze code dan gebruiken om eender welk teken, zelfs die die niet op je toetsenbord staan, toch te gebruiken. Je kan de unicode opzoeken op [https://unicode-table.com/en/](https://unicode-table.com/en/).

{% hint style='tip' %}
Wil je weten hoe je coole 'console'-tekeningen kan maken? Kijk dan zeker naar de appendix-sectie  ["Vreemde tekens in console tonen"](../B_appendix/prostuff.md).
{% endhint %}

### Escape characters in strings
Aangezien strings eigenlijk bestaan uit 1 of meerdere char-elementen, is het logisch dat je ook in een string met escape characters kunt werken. Het woord "'s avonds" schrijf je bijvoorbeeld als volgt:

```csharp
string woord= "\'s avonds";
```
We gebruiken vooral escape characters in strings om bijvoorbeeld witregels en tabulaties aan te geven. Test bijvoorbeeld volgende lijn eens:

```csharp
string eenString = "Een zin.\t na een tab \nDan eentje op een nieuwe regel";
```

Dit zal als output geven:

```csharp
Een zin.         na een tab
Dan eentje op een nieuwe regel
```

{% hint style='warning' %}
Het is belangrijk dat je vlot kan werken met escape characters in string, daar we dit geregeld nodig zullen hebben.

**De belangrijkste escape chars zijn: `` \t \n \" \'``**
{% endhint %}


``\a`` mag je enkel gebruiken als je een koptelefoon op hebt daar dit het escape character is om de computer een biep te laten doen (mogelijk doet dit niets bij jou, dit hangt van de je computerinstellingen af).

{% hint style='tip' %}
**Tab stop**
Als je het niet gewoon bent de tab-toets te gebruiken dan is de eerste werking van ``\t`` mogelijk verwarrend. Nochtans is ``\t`` in een string gebruiken exact hetzelfde als op de tab-toets te duwen. In je console-scherm zijn de tab stops vooraf bepaald. Wanneer je dus een tab invoegt zal de cursor zich verplaatsen naar de eerstvolgende tab stop. In volgende tekstuitvoer zie je de tabstops op de 2 lijn "gevisualiseerd":

```text
01234567890123456789012345678901234567890123456789
        1       2       3       4       5
```

Bovenstaande uitvoer werd als volgt gemaakt:

```csharp
Console.WriteLine("01234567890123456789012345678901234567890123456789");
Console.WriteLine("\t1\t2\t3\t4\t5");
```

{% endhint %}

### Optellen van char

Stel dat we volgende char-variabelen aanmaken. 

```csharp
char letter1 = 'A';
char letter2 = 'B';
```

Bij string mogen we de +-operator gebruiken om 2 strings aan elkaar te plakken. **Bij char mag dat niet!**

```csharp
Console.WriteLine(letter1 + letter2);
```

**Wanneer je deze code uitvoert dan krijg je `131` te zien?!**

Had je dit verwacht? Herinner je  dat het char-type z’n waarde als getallen bijhoudt, de zogenaamde UNICODE voorstelling van het karakter. Als de compiler het volgende ziet staan:

``letter1 + letter2`` 

dan zal de compiler deze twee waarden letterlijk optellen en het nieuw verkregen getal als resultaat geven:

* De UNICODE voorstelling van `A` is 0X041 oftewel **`65`** decimaal
* `B` is **`66`** decimaal
* als we dus de variabelen ``letter1`` en ``letter2`` optellen geeft dit **131**.

