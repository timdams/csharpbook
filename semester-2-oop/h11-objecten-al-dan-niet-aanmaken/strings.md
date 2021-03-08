# Spelen met strings

{% hint style="success" %}
[Kennisclip voor alles tot en met strings vergelijken](https://youtu.be/L2uNdNxdJ8s)
{% endhint %}

We gebruiken het einde van klassen en objecten om iets dieper in de `String` klasse te duiken en aan te tonen dat er tal van nuttige zaken bestaan om met strings te werken. We zullen ook zien dat je objecten kan aanmaken door een omschrijving ervan in tekst om te zetten naar een constructoroproep.

{% hint style="danger" %}
Strings zijn onveranderlijk. Dat wil zeggen dat alle bewerkingen met strings ons een nieuwe string als resultaat leveren. Ze passen nooit de oorspronkelijke string aan.
{% endhint %}

### Splitsen en samenvoegen

#### Split

Aan het einde van dit hoofdstuk willen we een csv-bestand \(comma separated value\) splitsen. De `Split` methode laat toe een string te splitsen op een bepaald teken. Het resultaat is steeds een **array van strings**.

```csharp
string data= "12,13,20";
string[] gesplitst= data.Split(',');

for(int i=0; i<gesplitst.Length; i++)
{
    Console.WriteLine(gesplitst[i]);
}
```

Uiteraard kan je dit dus gebruiken om op eender welk `char` te splitsen en dus niet enkel op een `','` \(komma\).

#### Join

Via `Join` kunnen we array van string terug samenvoegen. Het resultaat is een nieuwe string.

Volgende voorbeeld zal de eerder array van het vorige voorbeeld opnieuw samenvoegen maar nu met telkens een `;` tussen iedere string:

```csharp
string joined = String.Join(";", gesplitst);
```

Voorgaande methode is `static` en moet je dus via de klasse `String` doen en niet via de objecten zelf.

### Andere nuttige methoden

Volgende methoden/properties kan je rechtstreeks op de string-objecten aanroepen \(i.e. niet `static` methoden\)

* `int Length`: property, geeft totaal aantal karakters in de string
* `IndexOf(string para)`: geeft `int` terug die de index bevat waar de string die je als parameter meegaf begint. Bijvoorbeeld: `"hello".IndexOf("lo")` is 3
* `Trim()`: verwijdert alle onnodige spaties vooraan en achteraan de string en geeft de opgekuiste string terug
* `ToUpper()`: zal de meegegeven string naar ALLCAPS omzetten en geeft de nieuwe string als resultaat terug
* `ToLower()`: idem maar dan naar kleine letters
* `Replace(string old, string news)`: zal in de string alle substring die gelijk zijn aan `old` vervangen door de meegegeven `news` string. Bijvoorbeeld `"hello world".Replace("hello","goodbye")` geeft als resultaat `"goodbye world"`

### Strings vergelijken

De correcte manier om strings te vergelijken is met de `s1.CompareTo(string s2)` methode. Deze zal een `int` terug geven:

* -1 : de string `s1` komt voor de string`s2` indien je ze lexicografisch zou sorteren \(dit is ongeveer hetzelfde als alfabetisch, maar maakt bijvoorbeeld een onderscheid tussen kleine letters en hoofdletters\).
* 0: beide strings zijn identiek
* 1: de string `s2` komt voor `s1`

## Tekst files uitlezen

{% hint style="success" %}
[Kennisclip verbatim](https://youtu.be/UeEG2hfhYtM)
{% endhint %}

### Verbatim character

Door een `@` \(verbatim character\) voor een string te plaatsen zeggen we concreet: "de hele string die nu volgt moet je beschouwen zoals hij er staat. Je mag alle escape karakters negeren en er mogen line breaks voorkomen in deze string."

Dit wordt vaak gebruikt om een filepath iets leesbaarder te maken.

* Zonder verbatim: `string path= "c:\\Temp\\myfile.txt";`
* Met verbatim: `string path= @"c:\Temp\myfile.txt";`

{% hint style="warning" %}
Bovenstaande strings zijn identiek voor C\#! De @ geeft geen enkele extra functionaliteit, maar zorgt gewoon dat we dezelfde tekst \(meerbepaald: backslashes en line breaks\) wat makkelijker kunnen intypen.
{% endhint %}

### Text files lezen algemeen

{% hint style="success" %}
[Text files lezen](https://youtu.be/315ztFID6NE)
{% endhint %}

De `System.IO` namespace bevat tal van nuttige methoden en klassen om met bestanden te werken. Om gebruik hiervan te maken plaats je bovenaan je file:

```csharp
using System.IO;
```

Via `System.File.ReadAllLines()` kunnen we een tekstbestand uitlezen. De methode geeft een array van string terug. Per lijn die eindigt met een newline \(onder Windows `\r\n`\) zal een nieuwe string aan de array toegevoegd worden.

```csharp
string[] lines = File.ReadAllLines(@"C:\mypoem.txt");
for (int i = 0; i < lines.Length; i++)
{
    Console.WriteLine(lines[i]);
    Console.WriteLine("----------");
}
```

### CSV uitlezen

{% hint style="success" %}
[Kennisclip deserializatie](https://youtu.be/1h0ai7SyvCY)
{% endhint %}

Dankzij `ReadAllLines` en `Split` hebben we nu alle bouwstenen om eenvoudig een csv-bestand te verwerken.

Stel je voor dat een bestand `soccer.csv` volgende tekst bevat:

```text
Dams;Tim;1981
Hamdaoui;Mounir;1984
Stoffels;José;1950
```

Volgende code zal dit bestand uitlezen en de individuele data op het scherm tonen:

```csharp
string[] lijnen = File.ReadAllLines(@"C:\soccerstars.csv");
for (int i = 0; i < lijnen.Length; i++)
{
    string[] kolomwaarden = lijnen[i].Split(';');
    Console.WriteLine($"Voornaam speler {i}= {kolomwaarden[1]}" );
    Console.WriteLine($"Achternaam speler {i}= {kolomwaarden[0]}");
    Console.WriteLine($"Geboortejaar speler {i}= {kolomwaarden[2]}");
}
```

### Objecten deserializeren met CSV

CSV wordt vaak gebruikt om objecten tussen programma's te verplaatsen. Een object inlezen vanaf een CSV bestand heet deserializeren.

```csharp
string[] lijnen = File.ReadAllLines(@"C:\soccerstars.csv");
Speler[] spelers = new Speler[lines.Length];
for (int i = 0; i < lijnen.Length; i++)
{
    string[] kolomwaarden = lijnen[i].Split(';');
    spelers[i] = new Speler(kolomwaarden[1],kolomwaarden[0],Convert.ToInt32(kolomwaarden[2]);
}
```

### CSV wegschrijven

{% hint style="info" %}
Voor dit onderdeel is geen videomateriaal voorzien. Probeer het laatste stukje zelf te begrijpen aan de hand van de kennis die je eerder in dit hoofdstuk hebt opgedaan.
{% endhint %}

Je kan tekst uit een bestand lezen, maar uiteraard kan je ook naar een bestand wegschrijven. De 2 eenvoudigste manieren zijn:

* `File.WriteAllText`: deze gebruik je als je 1 enkele string wilt wegschrijven
* `File.WriteAllLines`: deze is de omgekeerde van `ReadAllLines()` en zal een array van strings wegschrijven.

Een voorbeeld:

```csharp
string[] stringArray = new string[]
    {
        "cat",
        "dog",
        "arrow"
    };


File.WriteAllLines("file.txt", stringArray);
```

**Opgelet met het schrijven naar bestanden: dit zal onherroepelijk het target bestand overschrijven.** .Gebruik `if(File.Exists(pathtofile))` om te controleren of een bestand bestaat of niet. Eventueel kan je dan aan de gebruiker bevestiging vragen of je deze effectief wilt overschrijven.

Wil je CSV-bestand maken dan zal je eerst met `String.Join` of met stringinterpolatie een komma-separated lijst maken, bijvoorbeeld:

```csharp
string[] namen = { "Tim", "Jos", "Mo" };
int[] leeftijden = { 34, 76, 23 };

string[] lines = new string[namen.Length];
for (int i = 0; i < lines.Length; i++)
{
    // met stringinterpolatie
    lines[i] = $"{i},{namen[i]},{leeftijden[i]}";
    /* alternatief met Join
    string[] components = {Convert.ToString(i), namen[i], Convert.ToString(leeftijden[i])};
    lines[i] = String.Join(",",components);
    */
    
}

System.IO.File.WriteAllLines("ages.csv", lines);
```

