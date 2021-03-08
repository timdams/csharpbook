# Een project aanmaken en gebruiken

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/PfZeFpqO_gQ)
{% endhint %}

{% hint style="info" %}
De essentie van een computerprogramma is het algoritme:

* denk aan een "recept" of aan een procedure;
* een algoritme, net zoals een procedure, bestaat uit een reeks instructies die het programma moet uitvoeren telkens het wordt opgestart;
* het algoritme van een programma moet je zelf opstellen;
* de volgorde waarin de instructies worden uitgevoerd is zeer belangrijk;

Een algoritme om je fiets op te pompen kan zijn:

1. haal dop van het ventiel;
2. plaats pomp op ventiel;
3. begin te pompen;

Eender welke andere volgorde van bovenstaande algoritme zal vreemde en soms fatale fouten geven.
{% endhint %}

## Concept

### **Console-applicaties**

Een console-applicatie is een programma dat zijn in- en uitvoer via een klassiek commando/shell-scherm toont. Een console-applicatie draait in dezelfde omgeving als wanneer we in Windows een command-prompt openen \(via Start-&gt; Uitvoeren-&gt; cmd \[enter\] \). We zullen in deze cursus enkel console-applicaties leren maken. Grafische frontends, bv Windows UI's of websites, komen in deze cursus niet aan bod.

### Basisconcept

Het **basisconcept** van een programma kunnen we als volgt voorstellen:

![input-process-output CSharp Console App](../../.gitbook/assets/image%20%2851%29.png)

* **Invoer** \(input\) zijn de gegevens via invoerapparaten \(toetsenbord, sensoren\) in de computer worden ingevoerd.
* Het **proces** is de gegevensverwerking van de gegevens die werden zijn ingevoerd.
* **Uitvoer** \(output\) is de informatie, het resultaat van het gegevensverwerkingproces dat naar uitvoerapparaten zoals scherm, luidsprekers, enz. wordt gestuurd.

### **Codering**

De code om gegevens via het toetsenbord in te voeren of informatie naar het scherm te sturen gaan we niet zelf schrijven. Daarvoor gebruiken we een .NET Core bibliotheek. Deze bibliotheek is een klasse met de naam `Console` en zit in de namespace met de naam `System`. Dus helemaal bovenaan geven we aan dat we de bibliotheken in de namespace `System` willen gebruiken. We schrijven daarvoor hetvolgende statement:

```csharp
using System;
```

Let erop dat een statement eindigt met een puntkomma!

Je vindt de volledige beschrijving van de `Console` klasse op de documentatie website van Microsoft: [Console Class](https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netcore-3.1).

{% hint style="info" %}
`Hieronder nog even een korte samenvatting van het lezen en schrijven van en naar de console. Zie hiervoor tevens vorige onderdeel` [`Input/Output: ReadLine/WriteLine`](3_console.md)\`\`
{% endhint %}

### **Input**

Om gegevens in te voeren beschikt de Console klasse over o.a. de volgende methode:

#### **`Console.ReadLine`**

De `ReadLine`-methode leest een regel in uit het standaardinvoerapparaat. In de oefeningen in deze cursus is dat het toetsenbord.  
Als het standaardinvoerapparaat het toetsenbord is, wacht de `ReadLine`-methode totdat de gebruiker op de Enter-toets drukt.  
Een van de meest voorkomende toepassingen van de `ReadLine`-methode is om het consolescherm open de laten staan nadat het programma is uitgevoerd. De gebruiker wordt dan expliciet gevraagd om op Enter te drukken om de toepassing beëindigen.  
Het volgende statement zal de invoer van de gebruiker uitlezen tot de gebruiker op enter drukt. Het resultaat van de ingevoerde tekst wordt bewaard in de variabele `invoer` van het gegevenstype `string`:

`string invoer = Console.ReadLine();`

### Output

Om informatie naar het scherm te sturen beschikken we ook over twee methoden:

#### **`Console.Write`**

Met de `Write` methode van de `Console`-klasse schrijven we informatie naar het scherm. Wat er werd ingetypt wordt in de console getoond. De twee volgende statements:  
`Console.Write("Joseph");  
Console.Write("Ponthus")`;  
zorgen voor de volgende output:

![Console.Write voorbeeld](../../.gitbook/assets/image%20%2847%29.png)

#### **`Console.WriteLine`**

De `WriteLine` methode van de `Console`-klasse doet hetzelfde als `Console.Write` maar voegt op het einde een nieuwe regel toe. Wat er werd ingetypt wordt in de console getoond maar wordt gevolgd door een nieuwe lege regel. De twee volgende statements tonen de voornaam en de familienaam of twee regels en na de de tweede regel gaan we aan de lijn:  
`Console.WriteLine("Joseph");  
Console.WriteLine("Ponthus")`;

![Console.WriteLine voorbeeld](../../.gitbook/assets/image%20%2853%29.png)

Zoals je kan zien hierboven, wordt er na elke `WriteLine` een nieuwe lege regel toegevoegd.

