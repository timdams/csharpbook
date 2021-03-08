# Array principes

{% hint style="success" %}
[Kennisclip 1 \(nog een kennisclip onderaan de pagina bij de demonstratie\)](https://youtu.be/u4ffd11Df2Q)
{% endhint %}

## Arrays

Arrays zijn een veelgebruikt principe in vele programmeertalen. Het grote voordeel van arrays is dat je een enkele variabele kunt hebben die een grote groep waarden voorstelt van eenzelfde type. Hierdoor wordt je code leesbaarder en eenvoudiger in onderhoud. Arrays zijn een zeer krachtig hulpmiddel, maar er zitten wel enkele venijnige addertjes onder het gras.

Een array is niet meer dan een verzameling waarden van hetzelfde type \(bijvoorbeeld een verzameling ints, doubles of chars\). Deze waarden kunnen voorgesteld worden met één variabele. Door middel van een _index_ kan ieder afzonderlijk element uit de array aangepast of uitgelezen worden.

{% hint style="warning" %}
Een nadeel van arrays is dat, eens we de lengte van een array hebben ingesteld, deze lengte niet meer kan veranderen. Later zullen we leren werken met datastructuren die deze beperking niet hebben.
{% endhint %}

### Voorbeelden van arrays

Het basisidee achter arrays is dat je meerdere waarden van eenzelfde type als groep wil voorstellen.

Een boodschappenlijstje is een eenvoudig en nuttig voorbeeld. Je zou ruimte kunnen voorzien voor 3 items, voorgesteld als `string`, als volgt:

```csharp
string item1;
string item2;
string item3;
Console.WriteLine("Wat is het 1e item dat je nodig hebt?");
item1 = Console.ReadLine();
Console.WriteLine("Wat is het 2e item dat je nodig hebt?");
item2 = Console.ReadLine();
Console.WriteLine("Wat is het 3e item dat je nodig hebt?");
item3 = Console.ReadLine();
// hier nog wat code om deze items te tonen
// of om te markeren dat ze in de kar geplaatst zijn
```

Een groot nadeel van deze aanpak: als je vier items wil ondersteunen, heb je meer code nodig. Als je vijf items wil ondersteunen, heb je nog meer code nodig. Deze code kan de basis niet vormen van een degelijk boodschappenlijstje.

Andere mogelijke voorbeelden die je beter zou kunnen afhandelen met arrays dan met individuele variabelen zijn:

* metingen van de dagelijkse neerslag
* waarde van aandelen doorheen de tijd
* ...

## Basisgebruik arrays

### Arrays declareren

Net als andere waarden geef je een array een naam door hem toe te kennen aan een variabele. Daarom moet je variabelen kunnen declareren van een array-type, d.w.z. de compiler informeren dat er een array bestaat met een bepaalde naam en een bepaald type. Dit is bijna hetzelfde als het declareren van een variabele van een van de types die je al kent, maar je geeft aan dat het om een reeks gaat door middel van rechte haken.

We bouwen voort op de voorbeelden van hierboven:

```csharp
string[] items; // een reeks boodschappen voorgesteld als tekst
double[] metingen; // metingen van de neerslag als kommagetallen
decimal[] aandelen; // kommagetallen met hoge precisie
```

De rechte haken betekenen dus "een reeks van" en een declaratie van een reeks kan een heleboel declaraties van individuele variabelen vervangen. Met deze voorstelling heb je bijvoorbeeld `item1` en `item2` en `item3` niet meer nodig.

### Arrays initialiseren

Eveneens zoals bij de types die je al kent, moet je je variabelen na declaratie een waarde geven. Een waarde van een array-type stelt eigenlijk een hoeveelheid ruimte in het geheugen voor. Ruimte voor een bepaald aantal strings, voor een bepaald aantal getallen, maakt niet uit. Wat wel anders is dan bij de types die je al kent, is de syntax. Je moet deze ruimte reserveren met het keyword `new` en je moet zeggen hoe veel ruimte je nodig hebt. Bijvoorbeeld, met de declaraties van hierboven:

```csharp
items = new string[10]; // ruimte om 10 items op het lijstje bij te houden
metingen = new double[365]; // ruimte om een jaar aan metingen te voorzien
aandelen = new decimal[365*10]; // ruimte om de koers over (ongeveer) 10 jaar bij te houden
```

{% hint style="info" %}
Net als bij andere variabelen kan je de declaratie en de initialisatie op één regel zetten.
{% endhint %}

### Arrays opvullen

Nadat de nodige ruimte voorzien is, kan je deze gebruiken. Dit doe je door te zeggen dat een bepaalde waarde op een bepaalde positie in de reeks terechtkomt. Deze positie noemen we de **index** van het element. Opnieuw met bovenstaande declaraties en initialisaties:

{% hint style="danger" %}
Het eerste element krijgt index 0, niet 1. Het laatste krijgt een index gelijk aan de lengte van de array verminderd met 1.
{% endhint %}

```csharp
items[0] = "brood"; // het eerste element heeft index 0
items[1] = "thee";
items[2] = "fruit";
// nog wat boodschappen
items[9] = "krant";
// items[10] kan je niet gebruiken want de laatste index is 10-1
```

Dit hoeven geen vaste waarden te zijn! Je kan ook dit doen:

```csharp
Console.WriteLine(); // geef 10 items die je nodig hebt
items[0] = Console.ReadLine(); // het eerste element heeft index 0
items[1] = Console.ReadLine();
items[2] = Console.ReadLine();
// nog wat boodschappen
items[9] = Console.ReadLine();
// items[10] kan je niet gebruiken want de laatste index is 10-1
```

Dit levert je meteen een mogelijke besparing op ten opzichte van het gebruik van variabelen. Met 10 individuele variabelen, dus **zonder array**, zou je bovenstaande code ook zo kunnen schrijven:

```csharp
Console.WriteLine(); // geef 10 items die je nodig hebt
item1 = Console.ReadLine(); // het eerste element heeft index 0
item2 = Console.ReadLine();
item3 = Console.ReadLine();
// nog wat boodschappen
item10 = Console.ReadLine();
```

Maar **met een array** heb je ook deze optie:

```csharp
Console.WriteLine(); // geef 10 items die je nodig hebt
for(int i = 0; i <= 9; i++) {
    items[i] = Console.ReadLine();
}
```

En het kost je niet meer code als je beslist lijstjes van 1000 items te ondersteunen. We zullen nog vaak gebruik maken van arrays en lussen om herhaalde code te vermijden!

### Arrays uitlezen

Je gebruikt de notatie met rechte haken ook om een array uit te lezen:

```csharp
Console.WriteLine($"Het 1e item op je lijstje is {items[0]}");
Console.WriteLine($"Het 2e item op je lijstje is {items[1]}");
// herhaald
Console.WriteLine($"Het 10e item op je lijstje is {items[9]}");
```

Ook hier bespaar je vervelend werk met een lus:

```csharp
for(int i = 0; i <= 9; i++) {
    Console.WriteLine($"Het {i+1}e item op je lijstje is {items[i]}");
}
```

{% hint style="warning" %}
Als je een element probeert uit te lezen dat nog geen waarde gekregen heeft, krijg je een defaultwaarde. Wat voor waarde dat is, hangt af van de array. Binnenkort kunnen we deze defaultwaarden verklaren. Voorlopig veronderstellen we dat je **géén** gebruik maakt van defaultwaarden en je arrays altijd invult.
{% endhint %}

### De lengte van de array te weten komen

Soms kan het nodig zijn dat je in een later stadium van je programma de lengte van je array nodig hebt. De `Length` eigenschap geeft je deze lengte. Volgend voorbeeld toen dit:

```csharp
string[] items = new string[10];
Console.WriteLine("Geef de 10 items die je wil kopen:");
for(int i = 0; i < items.Length; i++) {
    items[i] = Console.ReadLine();
}
```

Het voordeel hiervan is je maar één keer moet vastleggen hoe groot de array is en daarna in het algemeen over de grootte kan spreken. Zo kan je bij het aanpassen van je code niet vergeten **overal** de juiste aanpassing te doen.

## Volledige demonstratie boodschappenlijstje

{% hint style="success" %}
[Kennisclip 2](https://youtu.be/ubExN7_Xz6A)
{% endhint %}

We geven hier een voorbeeld van een boodschappenlijstje dat je niet zou kunnen maken zonder een gegevensstructuur voor reeksen data. Het is niet perfect maar het staat je wel toe een aantal items naar keuze bij te houden, wat je eerder niet kon:

```csharp
public static void Main() {
    // we moeten dit vragen
    // de grootte van een array wordt vastgelegd bij het aanmaken
    Console.WriteLine("Hoe veel dingen heb je nodig van de winkel?");
    int aantal = Convert.ToInt32(Console.ReadLine());
    string[] items = new string[aantal];
    Console.WriteLine("Geef een voor een je items");
    for(int i = 0; i < aantal; i++) {
        items[i] = Console.ReadLine();
    }
    int aantalNogNodig = items.Length;
    while(aantalNogNodig > 0) {
        Console.WriteLine("Je hebt volgende zaken nodig.");
        for(int i = 0; i < items.Length; i++) {
            if (items[i] != "") {
                Console.WriteLine($"{i}. {items[i]}");
            }
        }
        Console.WriteLine("Geef de index van het item dat je nu in je kar legt.");
        int gevonden = Convert.ToInt32(Console.ReadLine());
        if (items[gevonden] != "") {
            items[gevonden] = "";
            aantalNogNodig--;
        }        
    }
    Console.WriteLine("Je hebt alles! Ga naar de kassa.");
}
```

