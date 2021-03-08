# Attributen

{% hint style="success" %}
[Kennisclip](https://youtu.be/eT5uhSw9nFo). Deze bevat een voorbereiding op het labo die hieronder niet is uitgeschreven. Je moet het SchoolAdmin project mee maken met het filmpje.
{% endhint %}

**Attributen**, ook **velden** of **instantievariabelen** genoemd, zijn stukjes data die je bijhoudt in objecten. Ze stellen informatie voor die deel uitmaakt van een \(object van een\) klasse. Ze werken zoals de variabelen die je al kent, maar hun scope is een klasse of een object van een klasse, afhankelijk van de vraag of ze `static` zijn of niet. Door gebruik te maken van attributen, kunnen we stukjes data die samen horen ook samen houden op het niveau van de code. Alle data die samen hoort netjes groeperen en op een gestructureerd toegankelijk maken valt onder het begrip **encapsulatie** dat reeds eerder aan bod kwam.

{% hint style="info" %}
Attributen behoren tot een algemenere categorie onderdelen van objecten genaamd **members**.
{% endhint %}

## Basisvoorbeelden

Een typisch voorbeeld van een klasse is `Auto`. Er zijn verschillende stukjes data die deel kunnen uitmaken van één auto: de kilometerstand, het benzinepeil, de datum van het laatste onderhoud,...

Een reeds gekende manier om verwante informatie bij te houden is met behulp van "gesynchroniseerde" arrays, d.w.z. arrays die verwante data bijhouden op overeenkomstige posities. Onderstaand voorbeeld toont dit voor auto's:

```csharp
class Program {
    public static void Main() {
        int aantalAutos = 3;
        int[] kilometers = new int[aantalAutos];
        double[] benzine = new double[aantalAutos];
        DateTime[] onderhoud = new DateTime[aantalAutos];
        for (int i = 0; i < aantalAutos; i++) {
            Console.WriteLine($"Kilometerstand van auto {i+1}?");
            kilometers[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Benzinepeil van auto {i+1}?");
            benzine[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Jaar recentste onderhoud auto {i+1}?");
            int jaar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Maand recentste onderhoud auto {i+1}?");
            int maand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dag recentste onderhoud auto {i+1}?");
            int dag = Convert.ToInt32(Console.ReadLine());
            onderhoud[i] = new DateTime(jaar,maand,dag);
        }
        // later in de code
        for (int i = 0; i < aantalAutos; i++) {
            PrintOnderhoudsrapport(kilometers[i],benzine[i],onderhoud[i]);
        }
    }
}
```

Als we nu een methode willen uitvoeren die iets doet met alle informatie over een auto \(bijvoorbeeld een onderhoudsrapport afprinten\), moeten we drie waarden meegeven. Het is ordelijker deze zaken bij te houden in een object van klasse `Auto` als volgt:

```csharp
class Auto {
    public int Kilometers;
    public double Benzine;
    public DateTime LaatsteOnderhoud;
}
```

Al deze velden zijn voorlopig `public`. Dat hoeft niet absoluut, maar het vergemakkelijkt de presentatie. Verdere opties volgen snel. Het is ook een afspraak om publieke velden met een hoofdletter te schrijven. Met deze voorstelling kunnen we dit nu doen:

```csharp
class Program {
    public static void Main() {
        int aantalAutos = 3;
        Auto[] autos = new Auto[aantalAutos];
        for (int i = 0; i < aantalAutos; i++) {
            Auto nieuweAuto = new Auto();
            autos[i] = nieuweAuto;
            Console.WriteLine($"Kilometerstand van auto {i+1}?");
            nieuweAuto.Kilometers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Benzinepeil van auto {i+1}?");
            nieuweAuto.Benzine = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Jaar recentste onderhoud auto {i+1}?");
            int jaar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Maand recentste onderhoud auto {i+1}?");
            int maand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dag recentste onderhoud auto {i+1}?");
            int dag = Convert.ToInt32(Console.ReadLine());
            nieuweAuto.LaatsteOnderhoud = new DateTime(jaar,maand,dag);
        }
        // later in de code
        for (int i = 0; i < aantalAutos; i++) {
            PrintOnderhoudsrapport(autos[i]);
        }
    }
}
```

Je ziet hier al enkele voordelen van encapsulatie:

* je hoeft niet bij te houden hoe de informatie verspreid is over meerdere plaatsen
* als we meer informatie over auto's \(bv. het oliepeil\) in het onderhoudsrapport steken, hoeven we onze calls van `PrintOnderhoudsrapport` niet aan te passen
  * een kenmerk van goede code is dat wijzigingen typisch geen grote wijzigingen vereisen

## Beginwaarden

Een veld krijgt normaal de defaultwaarde voor zijn type. [Defaultwaarden](../../semester-1-programming-principles/h7-arrays/value-types-en-reference-types.md#defaultwaarden) hebben we reeds gezien. Het is mogelijk de beginwaarde aan te passen met de syntax voor een toekenning:

```csharp
class Auto {
    public int Kilometers = 5; // in de fabriek vinden bv. een aantal testen plaats
    public double Benzine = 10; // nieuwe auto's moeten kunnen rijden
    public DateTime LaatsteOnderhoud = DateTime.Now;
}
```

Nu hebben nieuwe auto's standaard 5 km op de teller staan, enzovoort. Merk op: deze waarde wordt voor elk nieuw object opnieuw berekend. Als je dus twee auto's aanmaakt in je programma, zullen zij beide een **verschillende** datum van het laatste onderhoud bevatten.

## `static` attributen

Iets dat `static` is, hoort niet bij de objecten, maar wel bij de hele klasse. Bijvoorbeeld: voor auto's worden de milieunormen na een paar jaar strenger. Er is een vaste set milieunormen en de te halen milieunorm wordt vastgelegd voor **alle** auto's. Daarom zouden we de milieunorm als volgt kunnen bijhouden:

```csharp
enum MilieuNormen {
    Euro1, Euro2, Euro3, Euro4, Euro5, Euro6
}

class Auto {
    public static MilieuNormen HuidigeNorm;
    // rest van de code voor Auto
}
```

{% hint style="warning" %}
Herhaal: `static` **betekent niet "onveranderlijk" of "vast"**. Het betekent dat iets op niveau van de klasse werkt en niet op niveau van de objecten van die klasse.
{% endhint %}

