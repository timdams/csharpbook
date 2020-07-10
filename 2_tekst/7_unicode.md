## Vreemde tekens in console tonen

Niets is zo leuk als de vreemdste tekens op het scherm tonen. In oude console-games werden deze tekens vaak gebruikt om *complexe* tekeningen op het scherm te tonen. Om je ietwat saaie applicaties dus wat toffer te maken leggen we daarom uit hoe je dit kan doen.

<!--- {width:50%} --->
![Dwarf fortress: een van de bekendste (én meest complexe) console-games waar nog steeds aan ontwikkeld wordt](../assets/0_intro/kerosenethunder_mockup.png)

### Unicode karakters tonen

Je toetsenbord heeft maar een beperkt aantal toetsen. Er zijn echter tal van andere tekens gedefinieerd die console-applicaties ook kunnen gebruiken. Al deze tekens, UNICODE-karakters, hebben een eigen unieke code die je kan opzoeken om vervolgens dat tekens in je code te gebruiken. Dit gaat als volgt in z'n werk:

1. Zoek het teken\(s\) dat je nodig hebt in een UNICODE-tabel \([deze is handig](https://unicode-table.com/en/)\)
2. Plaats bovenaan je Main: `Console.OutputEncoding = System.Text.Encoding.UTF8;`
3. Je kan nu op 2 manieren dit teken in console plaatsen

#### Manier 1: copy/paste

Kopieer het karakter zelf en plaats het in je code waar je het nodig hebt, bijvoorbeeld:

```csharp
Console.WriteLine("˧");
```

#### Manier 2: hexadecimale code casten naar char

Noteer de hexadecimale code van het karakter dat in de tabel staat.

<!--- {height:50%} --->
![Een handig teken als je een huis wilt tekenen in de console](../assets/0_intro/letter.jpg)

In dit geval is de code 0x02e7.

Om dit teken te tonen schrijf je dan:

```csharp
char blokje = (char)0x02e7;
Console.WriteLine(blokje);
```

In C\# schrijf je hexadecimale getallen als volgt als je ze rechtsreeks in een string wilt plaatsen: \u02e7

Wil je dus bovenstaande teken schrijven dan kan dan ook als volgt:

```csharp
Console.WriteLine("\u02e7");
```

### Ascii-art tonen

Soms zou je multiline ASCII-art willen tonen in je C# applicatie. Dit kan je eenvoudig oplossen door gebruik te maken van het ``@`` teken voor een string.

Stel dat je een toffe titel of tekening via een van volgende sites hebt gemaakt:
* [Asciiflow.Com](http://asciiflow.com/)
* [Ascii title generator](http://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20)
* [Ascii generator](http://www.network-science.de/ascii/)

Je kan het resultaat eenvoudig naar je klembord kopiëren en vervolgens in je C#-code integraal copy pasten als literal voor een ``string`` op voorwaarde dat je het laat voorafgaan door ``@"`` en uiteraard eindigt met ``";``.

{% hint style='tip' %}
Het apenstaartje voor een ``string`` literal plaatsen is zeggen "beschouw alles binnen de aanhalingstekens als effectieve karakters die deel uitmaken van de inhoud van de tekst. **Escape characters zullen dus genegeerd worden.** Dit is vooral handig als je bijvoorbeeld een netwerkadres wilt schrijven en niet iedere ``\`` wilt escapen:

```csharp
string zonderAt = "C\\Temp\\Myfile.txt";
string metaAt = @"C\Temp\Myfile.txt";
```

Merk op dat aanhalingstekens nog steeds ge-escape'd moeten worden. Heb je dus een stuk tekst met een aanhalingsteken in dan zal je zonder het apenstaartje moeten werken.
{% endhint %}


Bijvoorbeeld:

```csharp
string myname=@"
___________________   
\__    ___/\______ \  
  |    |    |    |  \ 
  |    |    |    `   \
  |____|   /_______  /
                   \/ ";

Console.WriteLine(myname);

```

{% hint style='tip' %}
Zowel de $-notatie (voor string interpolatie) als het  @-teken kan je gecombineerd gebruiken bij een string:

```csharp
Console.WriteLine($@"1/1={1+1}. \tGeen tab");
```

Dit geeft als output (``\t`` wordt door het apenstaartje genegeerd):

<!---{line-numbers:false}--->
```text
1/1=2. \tGeen tab
```
{% endhint %}