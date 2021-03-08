# Fouten in je code

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/seZ8MfWdRf4)
{% endhint %}

## Doelstellingen

1. om wat hardnekkige fouten te zoeken kun je wel wat hulp gebruiken om de fouten te lokaliseren, zoals een debugger;

![](../../.gitbook/assets/image%20%2840%29.png)

{% hint style="danger" %}
Je code kan niet gecompileerd en uitgevoerd worden zolang er fouten in je code staan.

Indien je op de groene start knop duwt en volgende waarschuwing krijgt **KLIK DAN NOOIT OP YES EN DUID NOOIT DE CHECKBOX AAN**:

> Lees de boodschap eens: wat denk je dat er gebeurt als je op 'yes' duwt? Inderdaad, VS zal de laatste goed gelukte code uitvoeren en dus niet de code die je nu hebt staan waarin nog fouten staan.
{% endhint %}

### Opzettelijk een fout maken

We willen zien wat er gebeurt als er een fout in het programma staat. We verwijderen het puntkomma aan het einde van het statement in de Main functie. We vervangen

```csharp
Console.WriteLine("Hello World!");
```

door

```csharp
Console.WriteLine("Hello World!")
```

Het enige dat we hebben gewijzigd is de puntkomma op het einde.

### Opzettelijke fout testen

Klik op het groene pijltje bovenaan, vlak voor de naam van het project BeginnenMetCSharp om het programma opnieuw uit te proberen. De fout wordt in de editor onderlijnd met een rode golvende lijn. Je ziet het volgende:

![ Visual Studio Dialoogvenster met foutmelding](../../.gitbook/assets/image%20%2833%29.png)

### Fout detecteren 

We willen de laatste versie zonder fouten niet uitproberen en klikken dus op **No**. Dan wordt het **Error List** venster actief gemaakt:

1. we zien daarin uitleg over de fout;
2. dubbel klikken op de foutmelding en
3. de cursor verspringt in de editor naar de plaats waar de fout gevonden is en die wordt in de editor aangegeven met een rode golvende lijn onder de fout in de code:

![Visual Studio Zoeken waar de fout zit](../../.gitbook/assets/image%20%2839%29.png)

### Fout corrigeren

Plaats de puntkomma opnieuw op het einde van het statement op regel 9.

### Opnieuw testen

Voer het programma opnieuw uit door op het groene pijltje bovenaan te klikken, vlak voor de naam van het project BeginnenMetCSharp.

## Meest voorkomende fouten

De meest voorkomende fouten in deze eerste weken zullen zijn:

* **Puntkomma** vergeten.
* **Schrijffouten** in je code RaedLine i.p.v. ReadLine.
* Geen rekening gehouden met **hoofdletter gevoeligheid** Readline i.p.v. ReadLine \(zie volgende hoofdstuk\).
* Per ongeluk **accolades verwijderd**.
* Code geschreven op plekken waar dat niet mag.

