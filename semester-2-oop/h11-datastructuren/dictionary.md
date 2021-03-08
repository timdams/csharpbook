# Dictionary

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=43e5eb65-6b40-4539-892e-ab9f0093b774)
{% endhint %}

Naast de generieke `List` collectie, zijn er nog enkele andere nuttige generieke 'collectie-klassen' die je geregeld in je projecten kan gebruiken.

In een **dictionary** wordt ieder element voorgesteld door een sleutel \(**key**\) en de waarde \(**value**\) van het element. Het idee is dat je de sleutel kan gebruiken om de waarde snel op te zoeken. De sleutel moet dan ook uniek zijn.

Enkele voorbeeldjes die het idee achter Dictionary kunnen verduidelijken:

* een papieren telefoonboek is als een Dictionary met gecombineerde namen en adressen als keys en telefoonnummers als values
* een echt woordenboek is als een Dictionary met woorden als keys en omschrijvingen als values
* een array is als een Dictionary met getallen als keys en waarden van het type van de array als values

Bij de declaratie van de `Dictionary<K,V>` dien je op te geven wat het datatype van de key zal zijn , alsook het type van de waarde \(value\). Met andere woorden, `K` en `V` komen niet letterlijk voor, maar je vervangt ze door types die je al kent.

Voor bovenstaande voorbeelden:

* een echt woordenboek stel je best voor met `string` als type van de key en `string` als type van de value, want een woord stel je voor als string en een omschrijving ook
* een array van `double` kan je nabootsen door `uint` te gebruiken als type van de key en `double` als type van de value
* het telefoonboek moeten we wat vereenvoudigen, maar als we op basis van naam meteen een telefoonnummer konden opzoeken \(zonder adresgegevens,...\), dan zou `string` \(de naam\) het type van de key zijn en `string` \(telefoonnummer\) het type van de value. Het telefoonnummer is geen getal omwille van zaken die je niet met een getaltype kan voorstellen zoals **+**32 of **0**473.

### Gebruik Dictionary <a id="gebruik-dictionary"></a>

In het volgende voorbeeld maken we een `Dictionary` van klanten aan. Iedere klant heeft een unieke ID \(de key, die we als `int` gebruiken\) alsook een naam \(die niet noodzakelijk uniek is en de waarde voorstelt\):

```csharp
Dictionary<int, string> customers = new Dictionary<int, string>();
customers.Add(123, "Tim Dams");
customers.Add(6463, "James Bond");
customers.Add(666, "The beast");
customers.Add(700, "James Bond");
```

Bij de declaratie van `customers` plaatsen we dus tussen de `< >` twee datatypes: het eerste duidt het datatype van de key aan, het tweede dat van de values.

Merk op dat je niet verplicht bent om een `int` als key te gebruiken, dit mag eender wat zijn, zelfs een klasse.

```csharp
Dictionary<int,Pokemon> pokedex;
Dictionary<Student,PuntenLijst> puntenTabel;
```

We kunnen nu met behulp van bijvoorbeeld een `foreach`-loop alle elementen tonen. Hier kunnen we de key met de `.Key`-property uitlezen en het achterliggende object of waarde met `.Value`. `Value` en `Key` hebben daarbij ieder het type dat we hebben gedefinieerd toen we het `Dictionary`-object aanmaakten, in het volgende geval is de `Key` dus van het type `int` en `Value` van het type `string`:

```csharp
foreach (var item in customers){
    Console.WriteLine($"{item.Key}\t:{item.Value}");
}
```

We kunnen echter ook een specifiek element opvragen aan de hand van de key. Stel dat we de waarde \(naam\) van de klant met key \(id\) gelijk aan 123 willen tonen:

```csharp
Console.WriteLine(customers[123]);
```

De key werkt dus net als de index bij gewone arrays, alleen heeft de key nu geen relatie meer met de positie van het element in de collectie.

