# Alternatieve syntax

{% hint style="success" %}
[Kennisclip](https://youtu.be/LuwNkiPvBUQ)
{% endhint %}

De reeds besproken manier om arrays te maken is veelzijdig en toont alle aspecten, maar vraagt vrij veel schrijfwerk. Er zijn nog manieren om arrays aan te maken, maar deze veronderstellen dat je de array in één keer juist kan opvullen.

#### Manier 1: met `new`

Ook op deze manier moet je array gedeclareerd worden als volgt:

```csharp
type[] arraynaam; // type vervang je door het type in kwestie
```

Dit is hetzelfde als eerder. Je kan bijvoorbeeld volgende concrete code hebben:

```csharp
string[] items;
```

Nu kan je deze array meteen initialiseren op een andere manier dan eerder. Eerder schreven we `= new type[grootte]`, bijvoorbeeld `myColors = new string[5]`, om vervolgens onze array in te vullen. Een snellere werkwijze is om de grootte niet in te vullen en de gebruikte waarden tussen accolades te zetten, bijvoorbeeld:

```csharp
string[] items;
items = new string[] {"brood", "koffie", "fruit", "thee", "yoghurt"};
```

Er staan vijf elementen tussen de accolades, dus de compiler kan achterhalen dat je een nieuwe array van vijf elementen wil maken, zonder dat je dat uitdrukkelijk zegt.

#### Manier 2: verkorte declaratie en initialisatie

Indien je direct waarden wilt toekennen \(initialiseren\) tijdens het aanmaken van de array zelf dan mag dit ook als volgt:

```csharp
string[] items = {"brood", "koffie", "fruit", "thee", "yoghurt"};
```

Hier zal je array dus een vaste lengte van 5 elementen hebben. Merk op dat deze manier dus enkel werkt indien je reeds weet welke waarden in de array moeten. De andere opties bieden in dat opzicht meer flexibiliteit ten koste van meer schrijfwerk.

