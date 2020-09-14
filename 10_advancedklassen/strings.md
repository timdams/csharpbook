## Spelen met strings

We gebruiken het einde van klassen en objecten om iets dieper in de ``String`` klasse te duiken en aan te tonen dat er tal van nuttige zaken bestaan om met strings te werken.

### Verbatim character

Door een ``@`` (verbatim character) voor een string te plaatsen zeggen we concreet: "de hele string die nu volgt moet je beschouwen zoals hij er staat. Je mag alle escape karakters negeren.

Dit wordt vaak gebruikt om een filepath iets leesbaarder te maken.

* Zonder verbatim: ``string path= "c:\\Temp\\myfile.txt";``
* Met verbatim: ``string path= @"c:\Temp\myfile.txt";``

### Splitsen en samenvoegen

#### Split

Aan het einde van dit hoofdstuk willen we een csv-bestand (comma separated value) splitsen. De ``Split`` methode laat toe een string te splitsen op een bepaald teken. Het resultaat is steeds een **array van strings**.

```java
string data= "12,13,20";
string[] gesplitst= data.Split(',');

for(int i=0; i<gesplitst.Length;i++)
{
    Console.WriteLine(gesplitst[i]);
}
```

Uiteraard kan je dit dus gebruiken om op eender welk ``char`` te splitsen en dus nit enkel een ``','`` (komma).

#### Join

Via ``Join`` kunnen we array van string terug samenvoegen. Het resultaat is een nieuwe string.

Volgende voorbeeld zal de eerder array van het vorige voorbeeld opnieuw samenvoegen maar nu met telkens een ``;`` tussen iedere string:

```java
string joined = String.Join(";", gesplitst);
```

Voorgaande methoden zijn ``static`` en moet je dus via de klasse ``String`` doen en niet via de objecten zelf.


### Arrays vergelijken

De correcte manier om strings te vergelijken is met de ``Compare(string s1, string s2)`` methode. Deze zal een ``int terug geven:

* -1 : de string ``s1`` komt voor de string``s2`` indien je ze alfabetisch zou sorteren.
* 0: beide strings zijn identiek
* 1: de string ``s2`` komt voor ``s1``

### Tekst files uitlezen

De ``System.IO`` namespace bevat tal van nuttige methoden en klassen om met bestanden te werken.
Om gebruik hiervan te maken plaats je bovenaan je file:

```java
using System.IO;
```

Via ``System.File.ReadAllLines()`` kunnen we een tekstbestand uitlezen. De methode geeft een array van string terug. Per lijn die eindigt met een newline (``\r\n``) zal een nieuwe string aan de array toegevoegd worden.

```java
string[] lines = File.ReadAllLines(@"c:\mypoem.txt");
for (int i = 0; i < lines.Length; i++)
{
    Console.WriteLine(lines[i]);
}
```

#### CSV uitlezen

Dankzij ``ReadAllLines`` en ``Split`` hebben we nu alle bouwstenen om eenvoudig een csv-bestand te verwerken.

Stel je voor dat een bestand ``soccer.csv`` volgende tekst bevat:

<!---{line-numbers:false}--->
```text
Dams;Tim;1981
Hamdaoui;Mounir;1984
Stoffels;José;1950
```

Volgende code zal dit bestand uitlezen en de individuele data op het scherm tonen:

```java
string[] lines = File.ReadAllLines(@"c:\soccerstars.csv");
for (int i = 0; i < lines.Length; i++)
{
    string[] splitted = lines[i].Split(';');

    Console.WriteLine($"Voornaam speler {i}= {splitted[1]}" );
    Console.WriteLine($"Achternaam speler {i}= {splitted[0]}");
    Console.WriteLine($"Geboortejaar speler {i}= {splitted[2]}");
}
```

#### CSV downloaden

Vaak zal je een online bestand willen verwerken. De ``WebClient`` klasse heeft tal van manieren om met online bronnen te werken. Deze klasse bevindt zich in de ``System.Net`` namespace en vereist dus dat je bovenaan je code volgende lijn toevoegt:

```java
using System.Net
```

Volgende code toont hoe we een bestand van een specifieke locatie kunnen downloaden:

```java
WebClient wc = new WebClient();
string csv = wc.DownloadString("www.fakeaddress.com/mydata.csv");
```

Dit bestand is 1 platte tekst. Willen we deze vervolgens verwerken dan moeten we deze splitsen in lijnen:

```java
string[] split = csv.Split('\n');
```

We hebben nu een ``for`` nodig die lijn per lijn zal splitsen:

```java
for (int i = 1; i < splitted.Length; i++)
{
    string[] lijnsplit = splitted[i].Split(',');
    Console.WriteLine("Data 1="+lijnsplit[0]);
    Console.WriteLine("Data 2=" + lijnsplit[1]);
}
```

In dit voorbeeld gaan we er vanuit dat de eerste lijn in het bestand een "header" bevat, die we dus moeten overslaan. Daarom starten we de loop vanaf lijn 1.

##  WebClient

We hebben maar een héél klein stukje van ``WebClient`` bekeken. Deze hoort niet bij de leerstof, maar is toch voor de geïnteresseerden en zeer nuttige klasse. Kijk bijvoorbeeld eens naar volgende [voorbeelden](https://www.dotnetperls.com/webclient).

### CSV wegschrijven

Je kan tekst uit een bestand lezen, maar uiteraard kan je ook naar een bestand wegschrijven. De 2 eenvoudigste manieren zijn:

* ``File.WriteAllText``: deze gebruik je als je 1 enkele string wilt wegschrijven
* ``File.WriteAllLines``: deze is de omgekeerde van ``ReadAllLines()`` en zal een array van strings wegschrijven.

Een voorbeeld:

```java
string[] stringArray = new string[]
    {
        "cat",
        "dog",
        "arrow"
    };


File.WriteAllLines("file.txt", stringArray);
```

**Opgelet met het schrijven naar bestanden: dit zal onherroepelijk het target bestand overschrijven.** .Gebruik ``if(File.Exists(pathtofile))`` om te controleren of een bestand bestaat of niet. Eventueel kan je dan aan de gebruiker bevestiging vragen of je deze effectief wilt overschrijven.

Wil je CSV-bestand maken dan zal je eerst met ``String.Join`` een komma-separated lijst maken, bijvoorbeeld:

```java
string[] namen = { "Tim", "Jos", "Mo" };
int[] leeftijden = { 34, 76, 23 };

string[] lines = new string[namen.Length];
for (int i = 0; i < lines.Length; i++)
{
    lines[i] = $"{i},{namen[i]},{leeftijden[i]}";

}

System.IO.File.WriteAllLines("ages.csv", lines);
            ```

# Uitgewerkt met Pokémon


```java
System.Net.WebClient wc = new System.Net.WebClient();
string downloaded = wc.DownloadString("https://bit.ly/2tE4CB0"); //laatste is een nul
string[] lines = downloaded.Split('\n');
//string[] lines = File.ReadAllLines("pokemon.csv");
List<Pokemon> pokedex = new List<Pokemon>(); //zien we verderop in dit boek

for (int i = 1; i < lines.Length-1; i++)
{
    string singlePoke_Line = lines[i];

    /*
        * #,Name,Type 1,Type 2,Total,HP,Attack,Defense,Sp. Atk,Sp. Def,Speed,Generation,Legendary
        * 1,Bulbasaur,Grass,Poison,318,45,49,49,65,65,45,1,False
    */

    string[] data = singlePoke_Line.Split(',');
    Pokemon poketemp = new Pokemon()
    {
        Naam = data[1],
        Nummer = Convert.ToInt32(data[0]),
        HP_Base = Convert.ToInt32(data[5]),
        Attack_Base = Convert.ToInt32(data[6])
    };

    pokedex.Add(poketemp);
}


for (int i = 0; i < pokedex.Count; i++)
{
    Console.WriteLine(pokedex[i].Naam);
}
```

## CSV uitlezen naar klasse

We herbekijken het voorbeeld van de csv-parser.

We maken nu een klasse Speler:

```java
class Speler
{
    public string Voornaam { get;set;}
    public string Achternaam { get;set;}
    public int GebJaar { get;set;}
}
```

We herschrijven dan het parsen naar:

```java
string[] lines = File.ReadAllLines(@"c:\soccerstars.csv");
Speler[] spelers= new Speler[lines.Length];

for (int i = 0; i < lines.Length; i++)
{
    string[] splitted = lines[i].Split(';');

    Speler temp=new Speler();
    temp.Voornaam= splitted[1];
    temp.Achternaam= splitted[0];
    temp.GebJaar= splitted[2]:

    spelers[i]= temp;
}
```

###  CSVHelper 

De opensource bibliotheek ``csvhelper`` is een nuttige toevoeging om vorige zaken een deel te automatiseren. Je kan deze eenvoudig als een ``nuget`` installeren. Alle uitleg en werking vind je op de website: [https://joshclose.github.io/CsvHelper/](https://joshclose.github.io/CsvHelper/).