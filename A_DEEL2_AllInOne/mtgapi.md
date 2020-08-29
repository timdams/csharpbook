# In opbouw
Dit project hoort niet bij de leerstof, daar het het concept van API gebruikt dat we nog niet hebben gezien. Dit is echter zo eenvoudig dat ik hoop dat het sommige studenten zin geeft om verder exploreren.

# Samenvatting

* API=Application programming interface
* .NET bibliotheek die praat met [magicthegathering.io](https://magicthegathering.io/)  (rate limited!)
* Broncode+ voorbeelden [hier](https://github.com/MagicTheGathering/mtg-sdk-dotnet)

# Nuget installeren

1. In project, rechterklikken op References ->  Manage Nuget packages…
2. Klikken op Browse, zoeken naar "mtg"
3. MtgApiManager.Lib installeren

# Broncode
We maken een applicatie die aan de gebruiker alle edities van Magic toont. De gebruiker kiest vervolgens van welke editie hij een 'boosterpack' wenst te generen (boosterpack= pakje kaarten dat je in de winkel kan kopen met daarin een vast aantal kaarten waarvan ook steeds minstens 1 zeldzame kaart).

Voeg zeker bovenaan toe:

```java
using MtgApiManager.Lib.Service;
```
## Stap 1 : Set tonen

```java
 SetService service = new SetService();
var result = service.All();
foreach (var set in result.Value)
{
    Console.WriteLine($"{set.Name} ({set.Code})");
}
```

## Stap 2: Controleren op geldige set
```java
Console.WriteLine("Voor welke set wil je booster (voer code tussen haakjes in)?");

string code = Console.ReadLine().ToLower();
bool isValid = false;
foreach (var set in result.Value)
{
    if (set.Code.ToLower() == code)
    {
        isValid = true;
        break;
    }
}
```
## Stap 3: Boosterpack generen en tonen

```java
var boosterresult = service.GenerateBooster(code);
var boosterpack = boosterresult.Value;
if (boosterpack != null)
{
    for (int i = 0; i < boosterpack.Count; i++)
    {
        Console.WriteLine($"{i}:{boosterpack[i].Name}");

    }
}
```

## Stap 4: kaart tonen
Vragen welke kaart getoond moet worden

```java
 Console.WriteLine("Welke kaart wenst u meer info");
int keuze = Convert.ToInt32(Console.ReadLine());
Console.Clear();
MtgApiManager.Lib.Model.Card chosenCard = boosterpack[keuze];
Console.WriteLine(chosenCard.Name);
Console.WriteLine(chosenCard.Text);
Console.WriteLine(chosenCard.Rarity);
Console.WriteLine("Druk op enter om afbeelding te tonen");
Console.ReadLine();
System.Diagnostics.Process.Start(chosenCard.ImageUrl.ToString());
```

# Alle code samen

```java
SetService service = new SetService();
var result = service.All();
foreach (var set in result.Value)
{
    Console.WriteLine($"{set.Name} ({set.Code})");
}

Console.WriteLine("Voor welke set wil je booster (voer code tussen haakjes in)?");

string code = Console.ReadLine().ToLower();
bool isValid = false;
foreach (var set in result.Value)
{
    if (set.Code.ToLower() == code)
    {
        isValid = true;
        break;
    }
}
if (isValid)
{
    var boosterresult = service.GenerateBooster(code);
    var boosterpack = boosterresult.Value;
    if (boosterpack != null)
    {
        for (int i = 0; i < boosterpack.Count; i++)
        {
            Console.WriteLine($"{i}:{boosterpack[i].Name}");

        }
        Console.WriteLine("Welke kaart wenst u meer info");
        int keuze = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        MtgApiManager.Lib.Model.Card chosenCard = boosterpack[keuze];
        Console.WriteLine(chosenCard.Name);
        Console.WriteLine(chosenCard.Text);
        Console.WriteLine(chosenCard.Rarity);
        Console.WriteLine("Druk op enter om afbeelding te tonen");
        Console.ReadLine();
        System.Diagnostics.Process.Start(chosenCard.ImageUrl.ToString());
    }
    else
    {
        Console.WriteLine("Iets is mislukt, sorry");
    }
}
```