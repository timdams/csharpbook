# Environment bibliotheek

De ``Console`` blibotheekis maar 1 van de vele bibliotheken die je in je C# programma's kunt gebruiken. Een andere erg nuttige is de ``Environment``-blibotheek. Deze geeft je applicatie allerlei nuttige informatie over de computer waarop het programma op dat moment draait. Denk maar aan het werkgeheugen, gebruikersnaam van de huidige gebruiker, het aantal processoren etc.


{% hint style='tip' %}
De laatste zin in vorige alinea is belangrijk: als je jouw programma dus op een andere computer laat uitvoeren zal je mogelijk andere informatie verkrijgen. 

Wil je een programma dus testen dat deze bibliotheek gebruikt is het aangeraden om het op meerdere systemen met verschillende eigenschappen te testen.
{% endhint %}


Hier enkele voorbeelden hoe je deze bibliotheek kunt gebruiken (kijk zelf of er nog nuttige properties over je computer in staan):

```csharp
bool is64bit = Environment.Is64BitOperatingSystem;
string pcname = Environment.MachineName;
int proccount = Environment.ProcessorCount;
string username = Environment.UserName;
long memory = Environment.WorkingSet; //zal ongeveer 10 Mb teruggeven.
```

{% hint style='tip' %}
**WorkingSet** geeft terug hoeveel geheugen het programma van windows toegewezen krijgt. Als je dus op 'run' klikt om je code te runnen dan zal dit programma geheugen krijgen en via WorkingSet kan het programma dus zelf zien hoeveel het krijgt. (Wat een vreemde lange zin.)
{% endhint %}

Je kan [hier](https://docs.microsoft.com/en-us/dotnet/api/system.environment?view=netframework-4.8) opzoeken welke nuttige zaken je nog met de blibotheek kunt doen.

# Programma afsluiten

De ``Enviroment`` bibliotheek heeft ook een methode om je applicatie af te sluiten. Je doet dit met behulp van ``Environment.Exit(0);`` Het getal tussen haakjes mag je zelf bepalen en is de zogenaamde foutcode die je wilt meegeven bij het afsluiten (als je dan later via logbestanden wilt opzoeken waarom het programma stopte dan kan je opzoeken weke foutcode er werd opgeworpen).

{% hint style='tip' %}
Wanneer we met complexere programma's gaan leren werken zal het soms nuttig zijn om ``Environment.Exit(0);`` te gebruiken. 

In deze fase ga je er nog niet veel aan hebben, daar alle code na de ``Exit`` nooit zal uitgevoerd worden.
{% endhint %} 