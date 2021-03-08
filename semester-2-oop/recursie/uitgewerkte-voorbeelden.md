# Uitgewerkte voorbeelden

## Voorbeeld: stack overflows bij fout gebruik properties

{% hint style="success" %}
[Kennisclip](https://youtu.be/X_DeD2mWSJY)
{% endhint %}

Wij volgen de afspraak dat we full properties schrijven met een publieke getter met een hoofdletter en met een achterliggend privaat attribuut met een kleine letter. Deze getter geeft normaal het achterliggend attribuut terug. Beginners schrijven vaak code zoals de volgende:

```csharp
class VoorbeeldKlasse {

    private string naam;
    public string Naam {
        get {
            return Naam;
        }
    }
    
    public static void Main() {
        VoorbeeldKlasse voorbeeld = new VoorbeeldKlasse();
        Console.WriteLine(voorbeeld.Naam);
    }

}
```

Deze code is recursief, maar ze mist een basisgeval. We vragen `Naam` \(met hoofdletter\) op en als gevolg daarvan vragen we opnieuw `Naam` \(met hoofdletter\) op. Elke recursieve call gebruikt wat ruimte op de stack, totdat deze volledig vol is.

{% hint style="warning" %}
Een belangrijke les: als je stack overflow krijgt, is dit bijna altijd omdat je recursieve code hebt geschreven zonder basisgeval of waarvan het basisgeval niet correct wordt gedetecteerd.
{% endhint %}

Deze code is niet meer recursief als je het juist doet: `return naam`.

## Voorbeeld: een bestand met een bepaalde naam opzoeken

{% hint style="success" %}
[Kennisclip](https://youtu.be/E-Loo3iGgEU)
{% endhint %}

Bestanden opzoeken kan je doen met ingebouwde programma's voor de shell. Maar we kunnen dit ook zelf implementeren. Hiervoor moeten we werken met de [`FileInfo`](https://docs.microsoft.com/en-us/dotnet/api/system.io.fileinfo?view=net-5.0) klasse en met de klasse [`DirectoryInfo`](https://docs.microsoft.com/en-us/dotnet/api/system.io.directoryinfo?view=net-5.0). Dit zijn allebei kindklassen van de algemenere `FileSystemInfo` klasse.

Een object van deze klasse bevat info over een bepaald bestand, respectievelijk directory. Je kan een dergelijk object aanmaken door een locatie mee te geven aan de constructor, bv.: `DirectoryInfo myDirectory = new DirectoryInfo(@"C:");`.  Je kan een opsomming van kinddirectories krijgen via `myDirectory.EnumerateDirectories()` en een opsomming van de bestanden rechtstreeks onder C: via `myDirectory.EnumerateFiles()`.

Als we een bestand met een bepaalde naam zoeken, kunnen we dus volgende code gebruiken:

```csharp
using System.IO;

class FileSearcher {
        public static void SearchFile(DirectoryInfo dir, string fileName)
        {
            foreach (FileInfo fi in dir.EnumerateFiles())
            {
                if (fi.Name == fileName)
                {
                    Console.WriteLine($"File is aanwezig in {fi.DirectoryName}");
                }
            }
            foreach (DirectoryInfo di in dir.EnumerateDirectories())
            {
                try
                {
                    SearchFile(di, fileName);
                }
                catch(System.UnauthorizedAccessException e)
                {
                    // goed, dan slaan we deze map over
                }
                
            }
        }
    public static void Main() {
        Console.WriteLine("Hoe heet het bestand dat je zoekt?");
        string fileName = Console.ReadLine();
        Console.WriteLine("Vanaf waar wil je zoeken?");
        DirectoryInfo topLevel = new DirectoryInfo(Console.ReadLine());
        FileSearcher.SearchFile(topLevel, fileName);
    }
}
```

## Voorbeeld: XML nodes met een `Render()` methode

{% hint style="success" %}
[Kennisclip](https://youtu.be/hMVZy4WD3HM)
{% endhint %}

XML-documenten verwerken is iets dat je voortdurend moet doen in het bedrijfsleven. Omwille van de recursieve structuur van XML gaat dit vaak het best met recursieve methodes. Hieronder zie je hoe je een voorstelling van een XML-document terug kan vertalen naar tekst via de methode `Render`.

Veronderstel eerst dat je volgende code hebt:

```markup
<shipment>
  <sender>Thomann.de</sender>
  <weight>2kg</weight>
</shipment>
```

Dan zou je deze als volgt kunnen voorstellen \(met broncode die iets verder gegeven wordt\):

```csharp
IXML shipment = new XMLTree("shipment", new List<IXML>(){
new XMLTree("sender", new List<IXML>(){new XMLLeaf("Thomann.de")}),
new XMLTree("weight", new List<IXML>(){new XMLLeaf("2kg")})});
```

Dit hoef je niet noodzakelijk met de hand te doen. Dit wordt normaal gedaan door een XML-parser.

De gebruikte klassen krijg je hieronder.

{% hint style="info" %}
We gebruiken een IXML interface omdat een XML-element een reeks andere XML-elementen \(tags of tekst\) bevat. Je kan geen `List<string of XMLTree>` aanmaken, dus we gebruiken een "wrapper"-klasse voor string in de vorm van `XMLLeaf`. Als `XMLLeaf` een interface IXML implementeert, kunnen we een `List<IXML>` gebruiken. Dit is een klasse die zelf niets anders doet dan bepaalde data te verpakken in een bruikbare interface.
{% endhint %}

```csharp
interface IXML {
    string Render();
}

class XMLTree : IXML {

    private List<IXML> children;
    private string tag;
    public List<IXML> Children {
        get {
            return children;
        }
    }
    public XMLTree(string tag, List<IXML> children) {
        this.tag = tag;
        this.children = children;
    }
    public string Render() {
        string childRenders = "";
        foreach(IXML child in this.Children) {
            childRenders += child.Render();
        }
        return $"<{this.tag}>{childRenders}</{this.tag}>";
    }
}

class XMLLeaf : IXML {
    private string text;
    public XMLLeaf(string text) {
        this.text = text;
    }
    public string Render() {
        return this.text;
    }
}
```

Terug omzetten naar tekst met `Render` is één mogelijkheid. Het voordeel van deze omzetting naar objecten is dat je nu allerlei methodes kan schrijven om het element in een programma te doorzoeken, data aan te passen,... op een manier die meer rekening kan houden met de structuur dan als je het document puur als een string tekst zou beschouwen \(en bv. aanpassingen zou doen met alleen `string.Replace` en dergelijke\).

