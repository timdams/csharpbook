# Functionaliteit van strings

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/db7Pz4fv3M0)
{% endhint %}

Strings bevatten veel ingebouwde functionaliteit. Als je deze leert gebruiken, kan je al snel nuttige programmaatjes voor tekstverwerking schrijven.

## `Length`

De lengte van een string is het aantal symbolen in de weergegeven versie. Dat wil zeggen: zonder de aanhalingstekens, zonder een eventuele `$` of `@` vooraan, in de veronderstelling dat een escapesequentie één karakter voorstelt en dat accolades in geïnterpoleerde strings al zijn uitgewerkt. Je plaatst `.Length` achter de string om de lengte te weten te komen. Enkele voorbeelden: 

```csharp
Console.WriteLine("hallo".Length); // levert 5 want: 5 letters
Console.WriteLine("hallo\\Wereld".Length); // 12 = 5 letters + 1 escape + 6 letters
Console.WriteLine($"hallo\\Wereld".Length); // 12, zie boven, $ bestaat achter de schermen niet meer
Console.WriteLine(@"hallo\Wereld".Length); // 12, want de backslash wordt achter de schermen \\ en dat stelt dan weer één symbool voor
```

## `Substring`

Een string is een reeks van 0 of meer symbolen in een bepaalde volgorde. Dat wil zeggen dat we elk symbool een nummer kunnen toekennen. Misschien wat vreemd, maar het eerste symbool krijgt nummer 0, het tweede krijgt nummer 1, het derde nummer 2,... en het laatste krijgt een nummer gelijk aan de `Length` van de string min één. Dit nummer heet de **index** van het symbool.

We kunnen een **substring** \(= deel van een string\) opvragen door de index van het eerste symbool en de lengte mee te geven als volgt:

```csharp
Console.WriteLine("Hallo, wereld".Substring(4,5)); // toont o, we
```

Je mag de lengte achterwege laten om vanaf de gegeven index tot het einde van de string te gaan:

```csharp
Console.WriteLine("Hallo, wereld".Substring(4)); // toont o, wereld
```

## `IndexOf`

Een index is, zoals hierboven aangegeven, de positie van een teken in de string. Als we willen weten waar een bepaalde substring in een string voorkomt, gebruiken we `IndexOf`:

```csharp
Console.WriteLine("C# is cool".IndexOf("cool")); // geeft 6
Console.WriteLine("C# is cool".IndexOf("z")); // geeft -1 want komt niet voor
Console.WriteLine("C# is cool".IndexOf("Cool")); // geeft -1 want "Cool" MET HOOFDLETTER komt niet voor
```

## `ToUpper` / `ToLower`

Met deze twee methodes bereken je een versie van de string waarop je ze toepast, maar dan in hoofdletters of in kleine letters. Let op: je past de oorspronkelijke string niet aan!

```csharp
Console.WriteLine("C# is cool".ToUpper()); // C# IS COOL
Console.WriteLine("C# is cool".ToLower()); // c# is cool
string tekst = "DiT iS EnGe TeKsT";
tekst.ToLower();
Console.WriteLine(tekst); // DiT iS EnGe TeKsT -> tekst wordt niet aangepast door ToLower
tekst.ToUpper();
Console.WriteLine(tekst); // DiT iS EnGe TeKsT -> tekst wordt niet aangepast door ToLower
string berekendeTekst = tekst.ToUpper();
Console.WriteLine(berekendeTekst); // DIT IS ENGE TEKST -> uit tekst is iets anders berekend, wel in hoofdletters
```

## `Replace`

Met deze methode kan je een substring vervangen door een andere substring. Ook deze methode past de oorspronkelijke tekst niet aan.

```csharp
Console.WriteLine("C# is cool".Replace("C#","Racket")); // Racket is cool
Console.WriteLine("C# is cool".Replace("Java","Racket")); // C# is cool -> Java kwam niet voor dus is niet vervangen
string tekst = "C# is cool";
tekst.Replace("C#","Racket");
Console.WriteLine(tekst); // C# is cool -> uit tekst is iets anders berekend, tekst is niet aangepast
```

## `TrimStart` / `TrimEnd / Trim`

Met deze methodes verwijder je witruimte \(spaties, tabs, newlines,...\) aan het begin of aan het einde van een string:

```csharp
Console.WriteLine("     C# is cool".TrimStart()); // C# is cool, eerste teken is C en geen spatie
Console.WriteLine(@"



BOE!



".TrimStart().TrimEnd()); // BOE! (op één regel) (kan ook als gewoon Trim())
```

{% hint style="info" %}
Dus geen van bovenstaande zaken past de oorspronkelijke tekst aan. Wat past de oorspronkelijke tekst dan wel aan? **Niets!** In C\# is er geen manier om tekst aan te passen, maar je kan wel andere tekst berekenen. Je kan ook de inhoud van een variabele aanpassen van de oorspronkelijke tekst naar de berekende tekst, dus dit vormt geen probleem.
{% endhint %}

