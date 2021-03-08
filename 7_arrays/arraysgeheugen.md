# Geheugengebruik bij arrays

Met arrays komen we voor het eerst iets dichter tot een van de sterkstes van C#, namelijk het aspect **referenties**. [Bekijk daarom volgend filmpje op 31 minuten.](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=17ce5c87-2b6a-46ea-b7b1-a87e00a7e4e5)

Dit zeer essentiële concept zal in het volgende deel erg vaak aan bod komen.

# Arrays kopiëren

Arrays worden 'by reference' gebruikt in C#. Het gevolg hiervan is dat volgende code niet zal doen wat je wenst (``ploegen``, ``nieuwePloegen`` zijn twee arrays van bijvoorbeeld een ``string[]``).
```csharp
nieuwePloegen = ploegen;
```
Deze code zal perfect werken. Wat er er echter is gebeurd is dat we de referentie naar ``ploegen`` ook in ``nieuwePloegen`` hebben geplaatst. Bijgevolg verwijzen beide variabelen naar dezelfde array, namelijk die waar ``ploegen`` al naar verwees. We hebben een soort alias gemaakt en kunnen nu op twee manieren de array benaderen.
Als je dus  schrijft:
```csharp
nieuwePloegen[4] = "Beerschot";
```
Dan is dat hetzelfde als schrijven:
```csharp
ploegen[4] = "Beerschot";
```

En waar staan de ploegen in de nieuwePloegen array? *Die bestaat niet meer!*

Wil je dus arrays kopieren dan kan dat niet op deze manier: **je moet manueel ieder element van de ene naar de andere array kopiëren** als volgt:
```csharp
for(int i = 0; i < ploegen.Length; i++)
{
    nieuwePloegen[i] = ploegen[i];
}
```

{% hint style='warning' %}
**Opgelet: wanneer je met arrays van objecten ([zie later](../11_arraysvanklassen/7_arraysvanobj.md)) werkt dan zal bovenstaande mogelijk niet het gewenste resultaten geven daar we nu de individuele referenties van een object kopieren!**
{% endhint %}