
# Escape characters

{% hint style='warning' %}
In het verleden is dit altijd een van de meest overgeslagen hoofdstukken geweest. Menig student heeft hier nog steeds spijt van en heeft uit miserie besloten te stoppen met leren programmeren ;)
{% endhint %}

Naast letters en tekens mogen in string en chars ook escape characters staan. Escape characters worden met een backslash (`\`) gestart, gevolgd door het karakter dat we wensen te tonen. In C# hebben bepaalde tekens namelijk een speciale functie, zoals de dubbele aanhalingstekens (`"`) om het begin of einde van een string-literal aan te geven.

Zonder aan te geven dat we letterlijk dat teken willen tonen, en het niet in z’n C# functie gebruiken, zouden we problemen krijgen.

Denk bijvoorbeeld aan de apostrof…
Volgende code zou de compiler verkeerd interpreteren, daar hij denkt dat we een leeg karakter wensen op te slaan:

```csharp
char apostrof= ''';
```
De juiste manier is om het teken dus door een backslash vooraf te laten gaan:

```csharp
char apostrof= '\'';
```
Er zijn echter nog een heleboel andere escape characters die je geregeld zal moeten gebruiken, waaronder `` \n``  om een nieuwe lijn aan te geven en \t om een tab in de tekst te plaatsen.

Er zijn verschillende escape characters in C# toegelaten, we lijsten hier de belangrijkste op (voor een totaal overzicht kijk [hier](https://blogs.msdn.microsoft.com/csharpfaq/2004/03/12/what-character-escape-sequences-are-available/)):
* `\'` – Single quote, needed for character literals
* `\"` – Double quote, needed for string literals
* `\\` – Backslash
* `\n` – New line (zogenaamde 'enter')
* `\t` – Horizontal tab 
* `v\uxxxx` – Unicode escape sequence for character with hex value xxxx


Je kan in grote Unicode-tabellen opzoeken wat de unicode (voorstelling van het teken in een geheel getal) van eender welk teken is. Je kan deze code dan gebruiken om eender welk teken, zelfs die die niet op je toetsenbord staan, toch te gebruiken. Je kan de unicode opzoeken op [https://unicode-table.com/en/](https://unicode-table.com/en/).

{% hint style='tip' %}
Wil je weten hoe je coole 'console'-tekeningen kan maken? Kijk dan zeker naar de appendix-sectie  ["Vreemde tekens in console tonen"](../B_appendix/prostuff.md).
{% endhint %}

## Escape characters in strings

We gebruiken vooral escape characters in strings, om bijvoorbeeld witregels en tabulaties aan te geven. Test bijvoorbeeld volgende lijn eens:

```csharp
string eenString = "Eerst een zin.\t dan een zin na een tab \n Dan eentje op een nieuwe regel";
```
Het is belangrijk dat je vlot kan werken met escape characters in string, daar we dit geregeld nodig zullen hebben.

{% hint style='tip' %}
**De belangrijkste escape chars zijn: `` \t \n \" \'``**
{% endhint %}


``\a`` mag je enkel gebruiken als je een koptelefoon op hebt daar dit het escape character is om de computer een biep te laten doen (mogelijk doet dit niets bij jou, dit hangt van de je computerinstellingen af).

## Optellen van char 
Stel dat we volgende char-variabelen aanmaken. Bij string mogen we de +-operator gebruiken om 2 strings aan elkaar te plakken. Bij char mag dat niet!

```csharp
char letter1 = 'A';
char letter2 = 'B';
Console.WriteLine(letter1 + letter2);
```
**Wanneer je deze code uitvoert dan krijg je `131` te zien?!**

Had je dit verwacht? Herinner je  dat het char-type z’n waarde als getallen bijhoudt, de zogenaamde UNICODE voorstelling van het karakter. Als de compiler het volgende ziet staan:

``letter1 + letter2`` 

dan zal de compiler deze twee waarden letterlijk optellen en het nieuw verkregen getal als resultaat geven:

* De UNICODE voorstelling van `A` is 0X041 oftewel **`65`** decimaal (zie [hier](https://unicode-table.com/en/#0041))
* `B` is **`66`** decimaal
* als we dus de variabelen ``letter1`` en ``letter2`` optellen geeft dit **131**.
