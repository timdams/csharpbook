# Prijzen met foreach

```java
int[] prijzen = new int[20];
for (int i = 0; i < prijzen.Length; i++)
{
    Console.WriteLine($"Geef prijs {i}:");
    prijzen[i] = Convert.ToInt32(Console.ReadLine());
}

int som = 0;
Console.WriteLine("Prijzen groter of gelijk aan 5:");
foreach (var prijs in prijzen)
{
    som += prijs;

    if(prijs>=5)
    {
        Console.WriteLine(prijs);
    }
}
Console.WriteLine($"Gemiddelde is {((double)som)/prijzen.Length}");
```

# Speelkaarten

Main:
```java
List<Speelkaart> BoekKaarten = new List<Speelkaart>();
for (int i = 0; i < 4; i++)
{
    for (int j = 1; j < 14; j++)
    {
        Speelkaart toAdd = new Speelkaart() { Getal=j, Suite=(Suit)i  };
        BoekKaarten.Add(toAdd);
    }
}
Random r = new Random();
while (BoekKaarten.Count > 0)
{
    int totrek = r.Next(0, BoekKaarten.Count);
    Console.WriteLine("Getrokken kaart=");
    Console.WriteLine(BoekKaarten[totrek].Suite + " "+ BoekKaarten[totrek].Getal);
    BoekKaarten.RemoveAt(totrek);
    Console.ReadKey();
}
```

Speelkaart klasse:

```java
enum Suit {Schoppen, Harten, Klaveren, Ruiten}

class Speelkaart
{
    public int Getal { get; set; }
    public Suit Suite { get; set; }

}
```

# Student Organizer

Bounty: wie wil z'n oplossing hier? ;)

# Bookmark Manager

Merk het (her)gebruik van methoden op, alsook het gebruik van enum om de leesbaarheid van de code te verbeteren in de ``ToonHoofdMenu`` switch

```java
 enum Keuzes { List,Show,Edit,Delete}

static void Main(string[] args)
{
    List<BookMark> sites = VraagEnVulBookmarkList();
    Console.Clear();
    ToonHoofdMenu(sites);
}

private static void ToonHoofdMenu(List<BookMark> sites)
{
    while (true)
    {
        Console.WriteLine("Wat wil je doen? 0=list,1=show, 2=edit, 3=remove");
        Keuzes inp = (Keuzes)Convert.ToInt32(Console.ReadLine());
        switch (inp)
        {
            case Keuzes.List:
                ShowAll(sites);
                break;
            case Keuzes.Show:
                OpenSite(sites);
                break;
            case Keuzes.Edit:
                EditSite(sites);
                break;
            case Keuzes.Delete:
                RemoveSite(sites);
                break;
            default:
                break;
        }
        Console.WriteLine("Druk op een toets om verder te gaan.");
        Console.ReadKey();
        Console.Clear();
    }
}

private static List<BookMark> VraagEnVulBookmarkList()
{
    Console.WriteLine("Geef je favoriete sites:");
    List<BookMark> sites = new List<BookMark>();
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"Geef site {i} in:");
        Console.WriteLine("Naam?");
        string naam = Console.ReadLine();
        Console.WriteLine("URL?");
        string url = Console.ReadLine();

        BookMark siteToAdd = new BookMark()
        {
            Naam = naam,
            URL = url
        };
        sites.Add(siteToAdd);
    }

    return sites;
}

private static void RemoveSite(List<BookMark> sites)
{
    int keuze = AskAction(sites, "verwijderen");
    sites.RemoveAt(keuze);
}

private static void EditSite(List<BookMark> sites)
{
    int keuze = AskAction(sites,"editeren");
    Console.WriteLine("Geef nieuwe naam [leeglaten= niet veranderen]");
    string newna = Console.ReadLine();
    if (newna != "")
        sites[keuze].Naam = newna;

    Console.WriteLine("Geef nieuwe url [leeglaten= niet veranderen]");
    string newurl = Console.ReadLine();
    if (newurl != "")
        sites[keuze].URL = newurl;

}

private static void OpenSite(List<BookMark> sites)
{
    int keuze=AskAction(sites, "openen");
    sites[keuze].OpenSite();
}

private static void ShowAll(List<BookMark> sites)
{
    for (int i = 0; i < sites.Count; i++)
    {
        Console.WriteLine($"{i}.{sites[i].Naam} ({sites[i].URL})");
    }
}

private static int AskAction(List<BookMark> sites, string action)
{
    Console.WriteLine($"Welke wil je {action}?");
    ShowAll(sites);
    int keuze = Convert.ToInt32(Console.ReadLine());
    return keuze;
}

```