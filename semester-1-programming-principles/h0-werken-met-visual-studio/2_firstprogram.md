# Je eerste programma

{% hint style="warning" %}
Hier is geen kennisclip voorzien. Die van de vorige pagina doorloopt dezelfde materie.
{% endhint %}

## Console-applicaties

Een console-applicatie is een programma dat zijn in- en uitvoer via een klassiek commando/shell-scherm toont. Een console-applicatie draait in dezelfde omgeving als wanneer we in Windows een command-prompt openen \(via Start-&gt; Uitvoeren-&gt; `cmd` \[enter\] \). We zullen in deze cursus enkel console-applicaties leren maken. Grafische frontends \(bv WPF\) komen in deze cursus niet aan bod.

### ReadLine en WriteLine

Console-applicaties maken in C\# vereist dat je minstens twee belangrijke C\# methoden leert gebruiken: Via **`Console.WriteLine()`** kunnen we tekst op het scherm tonen en met behulp van **`Console.ReadLine()`** kunnen we input van de gebruiker inlezen en in ons programma verwerken.

## Je eerste console programma

Maak een nieuw console-project aan \(noem het Demo1\) en open het Program.cs bestand \(indien het nog niet open is\). **Veeg de code die hier reeds staat niet weg!**

Voeg onder de lijn `Console.WriteLine("Hello World!");` volgende code toe:

```csharp
Console.WriteLine("Hoi, ik ben het!");
```

Zodat je dus volgende code krijgt:

```csharp
using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hoi, ik ben het");
        }
    }
}
```

Compileer deze code en voer ze uit: \*\*druk hiervoor op het groene driehoekje. Of via het menu Debug en dan Start Debugging.

{% hint style="danger" %}
**Let erop dat je iedere 'zin' eindigt met een puntkomma.**
{% endhint %}

{% hint style="danger" %}
### Moet ik niets bewaren?

Neen. Telkens je op de groene "build en run" knop duwt worden al je aanpassingen bewaard. Trouwens: **Kies nooit voor "save as..."**!!!!

Dit zal aardig wat problemen in je project veroorzaken, geloof me maar.
{% endhint %}

### Analyse van de code

We gaan nu iedere lijn code kort bespreken. Sommige lijnen code zullen lange tijd niet belangrijk zijn. Onthoud nu alvast dat: **alle belangrijke code staat tussen de accolades onder de lijn `static void Main(string[] args)`**!

* `using System;` :  Alle `Console`-commando's die we verderop gebruiken zitten in de `System` bibliotheek. Als we deze lijn \(een zogenaamde **directive**\) niet zouden schrijven dan moesten we `System.Console.WriteLine` i.p.v. `Console.WriteLine` schrijven verderop in de code. 
* `namespace Demo1`: Dit is de unieke naam waarbinnen we ons programma zullen steken, en het is niet toevallig de naam van je project. Verander dit nooit tenzij je weet wat je aan het doen bent.
* `class Program{}`: Hier start je echte programma. Alle code binnen deze Program accolades zullen gecompileerd worden naar een uitvoerbaar bestand.
* `static void Main(string[] args)`: Het startpunt van iedere console-applicatie. Wat hier gemaakt wordt is een **methode** genaamd `Main`. Je programma kan meerdere methoden \(of functies\) bevatten, maar enkel degene genaamd `Main` zal door de compiler als het startpunt van het programma gemaakt worden.
* `Console.WriteLine("Hello world");`: Dit is een **statement** dat de WriteLine-methode aanroept van de `Console`-klasse. Het zal alle tekst die tussen de aanhalingstekens staat op het scherm tonen. 
* `Console.WriteLine("Hoi ik ben het");`: en ook deze lijn komt op het scherm.
* Sluitende accolades: vervolgens moet voor iedere openende accolade eerder in de code nu ook een bijhorende sluitende volgen.

Laat deze info rustig inzinken en onthoudt alvast volgende belangrijke zaken:

* Al je code komt binnen de `Main` accolades.
* Eindig iedere lijn code daar met een puntkomma \( ; \).

### WriteLine: Tekst op het scherm

De WriteLine-methode is een veelgebruikte methode in Console-applicaties. Het zorgt ervoor dat we tekst op het scherm kunnen tonen.

Voeg volgende lijn toe na de vorige WriteLine-lijn in je project:

`Console.WriteLine("Wie ben jij?!");`

De WriteLine methode zal alle tekst tonen die tussen de " " staan tussen de haakjes van de methode. **De aanhalingstekens aan het begin en einde van de tekst zijn uiterst belangrijk! Alsook het puntkomma helemaal achteraan.**

Je programma is nu:

```csharp
using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hoi, ik ben het");
            Console.WriteLine("Wie ben jij?!");
        }
    }
}
```

Kan je ook deze code uitvoeren?! Make it happen en ga dan gezwind naar het volgende hoofdstuk!

