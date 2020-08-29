## Environment bibliotheek

De ``Console`` bibliotheek is maar 1 van de vele bibliotheken die je in je C# programma's kunt gebruiken. 

Een andere nuttige bibliotheek is de ``Environment``-bibliotheek. Deze geeft je applicatie allerlei informatie over de computer waarop het programma op dat moment draait. Denk maar aan het werkgeheugen, gebruikersnaam van de huidige gebruiker, het aantal processoren etc.

{% hint style='tip' %}
De laatste zin in vorige alinea is belangrijk: als je jouw programma dus op een andere computer laat uitvoeren zal je mogelijk andere informatie verkrijgen. 

Wil je een programma dus testen dat deze bibliotheek gebruikt is het aangeraden om het op meerdere systemen met verschillende eigenschappen te testen.
{% endhint %}

Hier enkele voorbeelden hoe je deze bibliotheek kunt gebruiken (kijk zelf of er nog nuttige properties over je computer in staan):

```java
bool is64bit = Environment.Is64BitOperatingSystem;
string pcname = Environment.MachineName;
int proccount = Environment.ProcessorCount;
string username = Environment.UserName;
long memory = Environment.WorkingSet; //zal ongeveer 10 Mb teruggeven.
```

Vervolgens zou je dan de inhoud van die variabelen kunnen gebruiken om bijvoorbeeld aan de gebruiker te tonen wat z'n machine naam is:

```java
Console.WriteLine($"Je computernaam is {pcName}");
Console.WriteLine($"en dit programma gebruikt {memory} Mb geheugen");
Console.WriteLine($"En je usernaam is {Environment.UserName}");
```

In de laatste lijn code tonen we dat je uiteraard ook rechtstreeks de variabelen uit``Environment`` in je string interpolatie kunt gebruiken en dus niet met een tussenvariabele moet werken.

{% hint style='tip' %}
**WorkingSet** geeft terug hoeveel geheugen het programma van Windows toegewezen krijgt. Als je dus op 'run' klikt om je code te runnen dan zal dit programma geheugen krijgen en via WorkingSet kan het programma dus zelf zien hoeveel het krijgt. (Wat een vreemde lange zin.). Test maar eens wat er gebeurt als je programma maakt dat uit meer lijnen code bestaat.
{% endhint %}

Je kan [hier](https://docs.microsoft.com/en-us/dotnet/api/system.environment) opzoeken welke nuttige zaken je nog met de bibliotheek kunt doen.

## Programma afsluiten

De ``Enviroment`` bibliotheek heeft ook een methode om je applicatie af te sluiten. Je doet dit met behulp van ``Environment.Exit(0);`` Het getal tussen haakjes mag je zelf bepalen en is de zogenaamde foutcode die je wilt meegeven bij het afsluiten (als je dan later via logbestanden wilt onderzoeken waarom het programma stopte dan kan je opzoeken weke foutcode er werd opgeworpen via de logs van je besturingssysteem).

{% hint style='tip' %}
Wanneer we met complexere programma's gaan leren werken zal het soms nuttig zijn om ``Environment.Exit(0);`` te gebruiken. 

In deze fase ga je er nog niet veel aan hebben, daar alle code na de ``Exit`` nooit zal uitgevoerd worden.
{% endhint %} 