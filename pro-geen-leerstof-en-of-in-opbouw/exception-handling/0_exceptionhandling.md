# Werken met exceptions

Veel fouten in code zijn het gevolg van:

* Het aanroepen van data die er niet is \(bijvoorbeeld een bestand dat werd verplaatst of hernoemd\)
* Invoerfouten door de gebruiker \(bijvoorbeeld de gebruiker voert een letter in terwijl het programma aan getal verwacht\)
* Programmeerfouten \(bijvoorbeeld de programmeur gebruikt een object dat nog niet met de new operator werd geïnitialiseerd\). Deling door nul is een andere klassieke fout!

In de voorgaande gevallen zijn dan _exceptions_ \(uitzonderingen\) nuttig. Door zogenaamde exceptions af te handelen \(_exception handling_\) kunnen we ons programma alternatieve opdrachten geven bij het optreden van een uitzondering.

## Code zonder exception handling

Je zal zelf al geregeld exceptions zijn tegengekomen in je console programma. Wanneer je je programma gewoon uitvoert en er verschijnt plots een hele hoop tekst \(met ondere andere het woord Exception in\) gevolgd door het prompt afsluiten ervan, dan heb je dus een exception gegenereerd die je niet hebt afgehandeld.

![](../../.gitbook/assets/exceptcode.png)

Vooral het eerste zinnetje van zo’n exception is altijd veel verklarender dan je denkt!

Indien je aan het debuggen bent en je krijgt een exception dan zal deze anders getoond worden, maar het gaat wel degelijk om dezelfde fout:

![](../../.gitbook/assets/excepinvs.png)

## Try en Catch

Het mechanisme om exceptions af te handelen in C\# bestaat uit 2 delen:

* Een `try` blok: binnen dit blok staat de code die je wil controleren op uitzonderingen
* Een of meerdere `catch`-blokken: dit blok zal mogelijk exceptions die in het bijhorende try-block voorkomen opvangen. Met andere woorden: in dit blok staat de code die de uitzondering zal ‘verwerken’ zodat het programma op een deftige manier verder kan.

De syntax is als volgt \(let er op dat de catch blok onmiddellijk na het try-blok komt!\):

```csharp
try
{
    //code waar exception mogelijk kan optreden
}
catch (Exception e)
{
    //exception handling code here
}
```

## Een try catch voorbeeld

In volgend stukje code kunnen uitzonderingen optreden:

```csharp
string input = Console.ReadLine();
int converted = Convert.ToInt32(input)
```

Een `FormatException` zal optreden wanneer de gebruiker tekst invoert of wanneer een komma-getal wordt ingevoegd. De conversie verwacht dit niet. `Convert.ToInt16()` kan enkel werken met gehele getallen.

We tonen nu hoe we dit met exception handling kunnen opvangen:

```csharp
try
{
    string input = Console.ReadLine();
    int converted = Convert.ToInt32(input);
}
catch (Exception e)
{
    Console.WriteLine("Verkeerde invoer!");
}
```

Indien er nu een uitzondering optreedt dan zal de tekst “Verkeerde invoer” getoond worden. Vervolgens gaat het programma verder met de code die mogelijk na het catch-blok staat.

## Meerdere catchblokken

`Exception` is een klasse van het .NET framework. Er zijn van deze basis-klasse meerdere exception-klassen afgeleid die een specifieke uitzondering behelsen. Enkele veelvoorkomende zijn:

| Klasse | Omschrijving |
| :--- | :--- |
| `Exception` | Basisklasse |
| `SystemException` | Klasse voor uitzonderingen die niet al te belangrijk zijn en die mogelijk verholpen kunnen worden. \(afgeleid van Exception\) |
| `IndexOutOfRangeException` | De index is te groot of te klein voor de benadering van een array \(afgeleid van SystemException\) |
| `NullReferenceException` | Benadering van een niet-geïnitialiseerd object \(afgeleid van SystemException\) |

Je kan in het catch blok aangeven welke soort exceptions je wil vangen in dat blok. In het voorbeeld hiervoor stond:

```csharp
catch (Exception e)
{
}
```

Hiermee vangen we dus **alle** Exceptions op, daar alle Exceptions van de klasse `Exception` afgeleid zijn en dus ook zelf een `Exception` zijn \(=polymorfisme eigenschap\).

We kunnen nu echter ook specifieke exceptions opvangen. De truk is om de meest algemene exception onderaan te zetten en naar boven toe steeds specifieker te worden. Stel bijvoorbeeld dat we weten dat de `FormatException` kan voorkomen en we willen daar iets mee doen. Volgende code toont hoe dit kan:

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
}
```

Indien een FormatException optreedt dan zal het eerste catch-blok uitgevoerd worden, anders het tweede. Het tweede blok zal niet uitgevoerd worden indien een FormatException optreedt.

## Welke exceptions worden gegooid?

De MSDN bibliotheek is de manier om te weten te komen welke exceptions een methode mogelijk kan gooien. Gaan we bijvoorbeeld naar de constructor-pagina van de StreamWrite klasse \([hier](https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter.-ctor?view=netframework-4.8#System_IO_StreamWriter__ctor_System_String_System_Boolean_System_Text_Encoding_System_Int32_) dan zie we daar een hoofstuk Exception waar klaar en duidelijk wordt beschreven wanneer welke Exception wordt gegooid.

![](../../.gitbook/assets/msdn.png)

## Werken met de exception parameter

De Exceptions die worden ‘gegooid’ door het programma zijn objecten van de Exception-klasse. Deze klasse bevat standaard een aantal interessante zaken, die je kan oproepen in je code.

Bovenaan de declaratie van het catch-blok geef je aan hoe het exception object in het blok zal heten. In de vorige voorbeelden was dit altijd `e` \(standaardnaam\)

![](../../.gitbook/assets/eexc.png)

Omdat alle exception van Exception afgeleid zijn bevatten ze allemaal minstens:

| Element | Omschrijving |
| :--- | :--- |
| `Message` | Foutmelding in relatief eenvoudige taal |
| `StackTrace` | Lijst van methoden die de exception hebben doorgegeven |
| `TargetSite` | Methode die de exception heeft gegeneerde \(staat bij StackTrace helemaal bovenaan\) |
| `ToString()` | Geeft het type van de exception, Message en StackTrace terug als string. |

We kunnen via deze parameter meer informatie uit de opgeworpen uitzondering uitlezen en bijvoorbeeld aan de gebruiker tonen

```csharp
catch (Exception e)
{
    Console.WriteLine("Exception opgetreden");
    Console.WriteLine("Message:"+e.Message);

    Console.WriteLine("Targetsite:" + e.TargetSite);
    Console.WriteLine("StackTrace:" + e.StackTrace);
}
```

**Opgelet**: vanuit security standpunt is het zelden aangeraden om Exception informatie zomaar naar de gebruiker te sturen. Mogelijk bevat de informatie gevoelige informatie en zou deze door kwaadwillige gebruikers kunnen misbruikt worden!

