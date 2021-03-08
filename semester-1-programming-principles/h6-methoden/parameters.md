# Parameters

{% hint style="success" %}
[Kennisclip](https://youtu.be/3T7acLgWgA4)
{% endhint %}

## Wat zijn parameters?

Een methode is een stappenplan voor een bepaalde taak. Met de syntax die we tot hiertoe gezien hebben, wordt deze taak altijd op exact dezelfde manier uitgevoerd. Dat beperkt de mogelijkheden enorm.

Een niet-digitaal voorbeeld. Ik plan een feest. Een van mijn deeltaken is om een simpele appeltaart te maken. De tweede is om een simpele perentaart te maken.

Het stappenplan voor de appeltaart is als volgt:

1. leg taartdeeg in een ronde bakvorm
2. doe er wat pudding op
3. snij een appel in stukken
4. beleg met de stukjes fruit
5. zet in de oven

Het stappenplan voor de perentaart is als volgt:

1. leg taartdeeg in een ronde bakvorm
2. doe er wat pudding op
3. snij een peer in stukken
4. beleg met de stukjes fruit
5. zet in de oven

Dit is hetzelfde stappenplan, op het gebruikte fruit na. Eigenlijk kan je in stap 3 allerlei soorten fruit gebruiken, afhankelijk van het resultaat dat je wenst. We kunnen het stappenplan dus algemener formuleren:

1. leg taartdeeg in een ronde bakvorm
2. doe er wat pudding op
3. snij het stuk fruit dat je wil gebruiken in stukken
4. beleg met de stukjes fruit
5. zet in de oven

Op het moment dat we een taart willen bakken, moeten we pas voor een bepaald stuk fruit kiezen. In de tekst hierboven is "het stuk fruit" dus een soort variabele: we schrijven een naam maar we bedoelen daarmee een waarde die in de uitvoering wordt vastgelegd.

In code zijn dit soort variabelen **parameters** van een methode. In de definitie van de methode werken we met hun naam \(zoals "het stuk fruit"\). Wanneer we de methode oproepen, voorzien we hun waarde \(zoals een appel of een peer of een ananas\). In de call spreken we ook over **argumenten** in plaats van parameters.

Eerst een voorbeeld in code, daarna lichten we de werking toe. Volgende methode berekent en toont een bepaalde macht van een bepaald getal. De werkwijze is altijd dezelfde, maar de gebruiker beslist zelf welke macht hij wil berekenen en van welk getal:

```csharp
static void Macht(int grondtal, int macht)
{
    int resultaat = grondtal;
    for (int i = 1; i < macht; i++)
    {
        resultaat *= grondtal;
    }
    Console.WriteLine($"De {macht}e macht van {grondtal} is {resultaat}");
}
```

Dit is een definitie van een methode, dus vergelijkbaar met een stappenplan of een flowchart. We geven aan dat er twee stukjes informatie zijn die per uitvoering kunnen verschillen: het grondtal en de macht. Omdat dit eigenlijk variabelen zijn \(met een scope beperkt tot deze methode\) geven we ook hun type, net zoals bij variabelen die we op de reeds gekende wijze declareren.

Als we deze methode willen gebruiken, kunnen we dit doen:

```csharp
public static void Main() {
    Console.WriteLine("Welk grondtal wil je gebruiken?");
    int grond = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tot welke macht wil je verheffen?");
    int gewensteMacht = Convert.ToInt32(Console.ReadLine());
    Macht(grond,gewensteMacht);
}
```

De laatste regel bevat de call van de methode. De definitie bevat een paar "gaten" en de call vult deze in met de gewenste getallen. Het is belangrijk dat de gebruikte types en de verwachte types compatibel zijn. Het is bijvoorbeeld niet mogelijk `Macht("Hello World","blabla");` te schrijven als call want strings kunnen niet automatisch geïnterpreteerd worden als `int` en dat is wat er in de definitie staat.

### De verbinding van definitie en oproep

Als je het stappenplan bovenaan deze pagina gebruikt om een appeltaart te maken, heb je achteraf geen appel meer. Hier kan het mechanisme van methodes je wat verrassen. Je moet in het achterhoofd houden dat de parameters van een methode hetzelfde werken als gewone variabelen.

Een voorbeeld:

```csharp
int a = 3;
int b = a;
b = b+1;
Console.WriteLine(a);
Console.WriteLine(b);
```

Dit programma zal je eerst `3` tonen en dan, op de volgende regel, `4`. Dit komt omdat de `=` op regel 2 niet betekent "`a` is hetzelfde als `b`", maar wel "kopieer het ding met naam `a` en geef de kopie de naam `b`". Dit is hoe toekenning werkt met alle types die we tot hiertoe gezien hebben.

{% hint style="warning" %}
Dit is niet hoe toekenning altijd werkt. Wanneer we arrays en eigen objecten zien, zullen de zaken anders liggen.
{% endhint %}

Met argumenten van een methode-oproep is het hetzelfde. Nog een voorbeeld:

```csharp
public static void VeranderGetal(int getal) {
  getal = getal - 1;
  Console.WriteLine($"Het getal is {getal}");
}

public static void Main() {
  int mijnGetal = 4;
  Console.WriteLine($"Het getal is {mijnGetal}");
  VeranderGetal(mijnGetal);
  Console.WriteLine($"Het getal is {mijnGetal}");
}
```

Je ziet dat het getal enkel gewijzigd is binnen de methode VeranderGetal en daarna weer teruggezet lijkt op de oude waarde. Dit is niet helemaal correct. Wat eigenlijk gebeurt is het volgende:

1. een waarde 4 krijgt de naam `mijnGetal`
2. de waarde met naam `mijnGetal` wordt getoond
3. de waarde met naam `mijnGetal` wordt gekopieerd en krijgt de naam `getal`
4. de naam `mijnGetal` wordt toegekend aan het getal dat je verkrijgt door de kopie met één te verminderen en verwijst nu dus naar een 3
5. deze 3 wordt getoond
6. de oproep eindigt
7. heel de tijd is `mijnGetal` blijven verwijzen naar 4 en daarom wordt er terug een 4 getoond

`mijnGetal` en `getal` hebben dus nooit dezelfde data bevat. Bij het begin van een oproep van `VeranderGetal` zijn hun data wel kopieën van elkaar, maar na regel 2 is zelfs dat niet meer waar.

### Gekende parameters

Je hebt al vaak waarden als argument meegegeven:

* de tekst die je laat zien via `WriteLine`
* de grenzen waarbinnen een willekeurig getal bepaald moet worden met `Next`
* de tekst die je wil vervangen en de tekst die hem vervangt met `Replace`

Ook hier wordt altijd hetzelfde stappenplan gevolgd, maar de manier waarop dat plan doorlopen wordt, verschilt afhankelijk van de gebruikte argumenten.

### De rol van scope

Voor de eenvoud hebben we in bovenstaand voorbeeld twee namen gebruikt: `mijnGetal` en `getal`. Eigenlijk hoefde dat niet. We kunnen ook dit doen:

```csharp
public static void VeranderGetal(int getal) {
  getal = getal - 1;
  Console.WriteLine($"Het getal is {getal}");
}

public static void Main() {
  int getal = 4;
  Console.WriteLine($"Het getal is {getal}");
  VeranderGetal(getal);
  Console.WriteLine($"Het getal is {getal}");
}
```

De parameter `getal` van `VeranderGetal` is niet dezelfde variabele als de variabele `getal` van `Main`. Elke functiedefinitie bakent een scope af. Vermits de definitie van `VeranderGetal` niet genest is in de definitie van `Main` \(en het omgekeerde ook niet waar is\) staan hun scopes los van elkaar. Binnenin `Main` bestaat er een variabele met naam getal, binnenin `VeranderGetal` bestaat er een andere variabele met naam getal.

Er staat wel een oproep van `VeranderGetal` in `Main`, maar dit heeft geen effect op de variabelen in scope. Enkel de definities zijn hier van belang.

