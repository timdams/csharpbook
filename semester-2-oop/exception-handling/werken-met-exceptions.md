# Werken met exceptions

{% hint style="success" %}
[Kennisclip inleiding](https://youtu.be/v_A8EOOeGj4)
{% endhint %}

Een methode is, in essentie, een stappenplan. Een stappenplan kan niet altijd rekening houden met elke mogelijke situatie. Soms treden er uitzonderlijke situaties op waarin het plan niet meer gevolgd kan worden. Het programmeerconcept dat overeenstemt met zo'n "uitzonderlijke situatie" is de _exception_ \(Engels voor "uitzondering"\).

Een uitzonderlijke situatie kan niet altijd verholpen worden door het stappenplan uit te breiden. Code die een deling implementeert kan bijvoorbeeld gewoonweg niet verder als je ze gebruikt om door het getal 0 te delen. Een methode als `File.ReadAllLines` kan zelf niet weten wat ze moet doen als de file die je wil lezen niet bestaat: moet er gebruik gemaakt worden van default data, moet de gebruiker gevraagd worden om de file eerst in te vullen,...? Er is geen eenduidig antwoord. Het hangt af van de **context** waarin de methode gebruikt wordt. Dat wil zeggen: de code die, rechtstreeks of onrechtstreeks, de code heeft opgeroepen waarin de uitzonderlijke situatie is opgetreden.

Exceptions staan toe de verantwoordelijkheid voor het afhandelen van deze uitzonderlijke situatie, dus de exception, te verschuiven naar de context. Zonder het mechanisme te geven, schetst onderstaande code een mogelijke probleemsituatie en mogelijke oplossingen:

```csharp
public void StartProgrammaOp() {
  // dit kan fout lopen
  string[] config = File.ReadAllLines(@"C:\configuratiebestand.txt");
  // StartProgrammaOp weet wat er moet gebeuren als config niet juist is uitgelezen
  // OPTIE 1, misschien is dit wat je wil
  Console.WriteLine("Je hebt geen configuratiebestand. Gelieve het in te vullen en dit programma opnieuw op te starten.");
  // -1 betekent "iets is misgelopen"
  Environment.Exit(-1);
  // OPTIE 2, misschien is dit wat je wil
  config = ["debug mode","colorblind mode"];
  File.WriteAllLines(@"C:\configuratiebestand.txt",config);
}
```

Misschien is optie 1 beter voor jouw programma, misschien is optie 2 beter voor jouw programma. De auteur van `File.ReadAllLines` kan dat niet voorspellen en kan dus zelf het probleem niet afhandelen. Het probleem moet afgehandeld worden in `StartProgrammaOp`.

## Code zonder exception handling

{% hint style="success" %}
[Kennisclip onafgehandelde exceptions](https://youtu.be/AHjPBv-Mqhg)
{% endhint %}

Je zal zelf waarschijnlijk al exceptions zijn tegengekomen in je console programma's. Wanneer je je programma gewoon uitvoert en er plots een hele hoop tekst verschijnt \(met ondere andere het woord _Exception_ in\), gevolgd door het prompt afsluiten ervan, dan heb je een exception gegenereerd die je niet hebt afgehandeld.

![Niet-afgehandelde exception](../../.gitbook/assets/image%20%2824%29.png)

Vooral het eerste zinnetje van zo'n exception is vaak verhelderend. Hier wordt duidelijk aangegeven dat de gezochte file niet bestaat.

Indien je aan het debuggen bent en je krijgt een exception dan zal deze anders getoond worden, maar het gaat wel degelijk om dezelfde fout:

![In VS is de foutboodschap iets leesbaarder](../../.gitbook/assets/image%20%2825%29.png)

## Try en Catch

{% hint style="success" %}
[Kennisclip try en catch](https://youtu.be/giXT_Ru061Y)
{% endhint %}

Het mechanisme om exceptions af te handelen in C\# bestaat uit 2 delen:

* Een `try` blok: dit is de context waarin een mogelijke exception verwacht wordt
* Een of meerdere `catch`-blokken: dit blok zal exceptions die in het bijhorende try-block voorkomen afhandelen. Met andere woorden: in dit blok staat de code die de uitzondering zo goed mogelijk zal verhelpen.

De syntax is als volgt:

```csharp
try
{
    // context waarin exception mogelijk kan optreden
}
// hieronder zal niet altijd letterlijk Exception staan
// meestal gaat het om specifieke types Exceptions
catch (Exception e)
{
    // code om het probleem zo goed mogelijk af te handelen
}
```

Merk op dat het `catch`-blok meteen na het `try`-blok komt, vergelijkbaar met hoe een `else`-blok meteen na een if-`blok` komt.

Als methode A \(zonder geschikt `catch`-blok\) methode B oproept en B een exception genereert, moeten we kijken naar de bredere context waarin B is opgeroepen. Dat kan een methode C zijn die A heeft opgeroepen. Een foutmelding zoals in de figuren hoger op deze pagina zie je als er geen context bestaat waarin de exception goed wordt afgehandeld.

Vergelijk deze situatie met een hiërarchisch georganiseerde werkvloer. Veronderstel dat er drie niveaus zijn:

* een directeur
* een departementsmanager
* een bediende

Wat als de bediende tijdens zijn werkdag een belangrijke fout in de boekhouding ontdekt, die hij zelf niet mag rechtzetten? Dan meldt hij dat aan zijn manager. Misschien kan de manager de fout rechtzetten als het gaat om iets dat met zijn eigen departement te maken heeft. Misschien ook niet. Dan moet hij de fout melden aan de directeur, die dan moet beslissen wat er mee moet gebeuren. Als dat niet lukt, kan het bedrijf zware schade oplopen of failliet gaan.

Vervang de directeur door methode C \(bijvoorbeeld `Main`\), de departementsmanager door methode A \(een methode die wordt opgeroepen van uit methode C\) en de bediende door methode B. Dan krijg je het mechanisme achter exceptions.

## try catch voorbeeld

{% hint style="success" %}
[Voorbeeld try catch](https://youtu.be/KwCYAbqyyZs)
{% endhint %}

In volgend stukje code kunnen uitzonderingen optreden:

```csharp
string input = Console.ReadLine();
int converted = Convert.ToInt32(input)
```

Een `FormatException` zal optreden wanneer de gebruiker tekst invoert of wanneer een komma-getal wordt ingevoegd. De conversie verwacht dit niet. `Convert.ToInt32()` kan enkel werken met gehele getallen.

We tonen nu hoe we dit met exception handling kunnen opvangen:

```csharp
string input = Console.ReadLine();
try
{
    int converted = Convert.ToInt32(input);
}
catch (Exception e)
{
    Console.WriteLine("Verkeerde invoer!");
}
```

Indien er nu een uitzondering optreedt dan zal de tekst “Verkeerde invoer” getoond worden. Vervolgens gaat het programma verder met de code die mogelijk na het catch-blok staat. Merk ook op dat we het `try`-blok zo klein mogelijk gemaakt hebben door het enkel rond de conversiestap te zetten. Het is een goede gewoonte de context waarin een exception kan optreden zo nauwkeurig mogelijk af te bakenen. Maak je `try`-blokken zo klein als nodig is het gewenste gedrag uit je programma te krijgen, maar niet kleiner.

## Meerdere `catch`-blokken

{% hint style="success" %}
[Kennisclip soorten exceptions](https://youtu.be/L-O8kFSK_UI)
{% endhint %}

`Exception` is een klasse van het .NET framework. Er zijn van deze ouderklasse meerdere exception-klassen afgeleid die een specifieke probleemsituatie beschrijven. Enkele veelvoorkomende zijn:

| Klasse | Omschrijving |
| :--- | :--- |
| `Exception` | Basisklasse. Erg breed, dus je gebruikt beter specifiekere exception klassen in je catch blokken. |
| `SystemException` | Ouderklasse van ingebouwde exceptions. Erg breed, dus je gebruikt beter specifiekere exception klassen in je catch blokken. |
| `IndexOutOfRangeException` | De index is te groot of te klein voor de benadering van een array. |
| `NullReferenceException` | Benadering van een niet-geïnitialiseerd object. Deze zie je bijvoorbeeld als je een objectmethode oproept van een variabele met waarde `null`. |
| `ApplicationException` | Een ouderklasse voor exceptions die je zelf definieert en die een specifiek soort probleem in jouw applicatie aangeven. |

Je kan in het catch blok aangeven welke soort exceptions je wil vangen in dat blok. In het voorbeeld hiervoor stond:

```csharp
catch (Exception e)
{
}
```

Hiermee vangen we dus **alle** Exceptions op, daar alle Exceptions van de klasse `Exception` afgeleid zijn en dus ook zelf een `Exception` zijn. Dit is een vorm van **polymorfisme**: één type data kan meerdere concrete vormen aannemen.

We kunnen nu echter ook specifieke exceptions opvangen. Wanneer je meerdere `catch`-blokken hebt, wordt het eerste eerst toegepast indien mogelijk. Daarom moet je eerst `catch`-blokken voor specifiekere exceptions voor blokken voor algemenere exceptions plaatsen. Stel bijvoorbeeld dat we weten dat de `FormatException` kan voorkomen en we willen daar iets mee doen. Volgende code toont hoe dit kan:

```csharp
try
{
    //...
}
catch (FormatException e)
{
    Console.WriteLine("Verkeerd invoerformaat");
}
catch (Exception e)
{
    Console.WriteLine("Exception opgetreden");
    // hier kunnen we waarschijnlijk niet meer veel aan de fout doen
    // eventueel kunnen we ze wel naar een log schrijven, maar oplossen zal niet gaan
}
```

Indien een `FormatException` optreedt dan zal het eerste catch-blok uitgevoerd worden, anders het tweede. Het tweede blok zal niet uitgevoerd worden indien een `FormatException` optreedt.

## Welke exceptions worden gegooid?

De MSDN bibliotheek is de manier om te weten te komen welke exceptions een methode mogelijk kan gooien. Gaan we bijvoorbeeld naar [de pagina van de `ReadAllLines` methode van de `File` klasse](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalllines?view=netcore-3.1#System_IO_File_ReadAllLines_System_String_), dan zien we onder "Exceptions" een aantal scenario's waarin het kan foutlopen en hoe deze gesignaleerd worden.

## De stack \(trace\)

{% hint style="success" %}
[Kennisclip stack \(trace\)](https://youtu.be/E2RdKJ1BFXg)
{% endhint %}

Herinner je uit [het hoofdstuk rond geheugenbeheer](../h9-geheugenmanagement-bij-klassen/6_memorymanagement.md) dat elke methode-oproep data op de stack plaatst, het "snelle programmageheugen". Dus als methode A methode B oproept en methode B roept methode C op, krijg je een stack die er als volgt uitziet:

|  |
| :---: |
| informatie over methode C |
| informatie over methode B |
| informatie over methode A |

Hier is een belangrijke link met exceptions: de methodes die op een gegeven moment op stack worden opgevolgd, vormen de context waarin een exception kan optreden. Als er een exception optreedt in C is het aan B om die af te handelen. Lukt dat niet, dan is het aan A. Wanneer er een exception optreedt, krijg je een gedeeltelijke weergave van de stack te zien. Deze weergave heet de **stack trace**. Ze is een erg nuttig hulpmiddel als je probeert op te sporen waar een exception precies vandaan komt.

## Werken met de exception parameter

{% hint style="success" %}
[Kennisclip exception parameter](https://youtu.be/pzxW98J53KA)
{% endhint %}

De Exceptions die worden ‘gegooid’ door het programma zijn objecten van de Exception-klasse. Deze klasse bevat standaard een aantal interessante properties en methoden, die je kan oproepen in je code.

Bovenaan de declaratie van het catch-blok geef je aan hoe het exception object in het blok zal heten. Je kent de exception dus toe aan een variabele. In de vorige voorbeelden was dit altijd `e` .

![IntelliSense toont de verschillende methodes en properties](../../.gitbook/assets/image%20%2823%29.png)

Omdat alle exception van Exception afgeleid zijn bevatten ze allemaal minstens:

| Element | Omschrijving |
| :--- | :--- |
| `Message` | Foutmelding in relatief eenvoudige taal |
| `StackTrace` | De weergave van de stack die je vertelt hoe de exception is ontstaan. |
| `TargetSite` | Methode die de exception heeft gegenereerd. Dit is de onmiddellijke context waarin de exception is opgetreden. Ze staat ook bovenaan de strack trace. |
| `ToString()` | Geeft het type van de exception, Message en StackTrace terug als string. |

We kunnen via deze parameter meer informatie uit de opgeworpen uitzondering uitlezen en bijvoorbeeld aan de gebruiker tonen:

```csharp
catch (Exception e)
{
    Console.WriteLine("Exception opgetreden");
    Console.WriteLine($"Message: {e.Message}");
    Console.WriteLine($"Targetsite: {e.TargetSite}");
    Console.WriteLine($"StackTrace: {e.StackTrace}");
}
```

**Opgelet**: vanuit security standpunt is het zelden aangeraden om Exception informatie zomaar naar de gebruiker te sturen. Mogelijk bevat de informatie gevoelige informatie en zou deze door kwaadwillige gebruikers kunnen misbruikt worden!

