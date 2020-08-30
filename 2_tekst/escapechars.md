## Escape characters

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)

De voorman hier! Escape characters zijn niet de boeiendste materie om te bespreken. Je zou nog kunnen hopen dat het een opvolger is van Prison Break of zo. Helaas is dat niet zo. Echter: als je escape characters beheerst zal je veel eenvoudiger én mooier tekst op je scherm kunnen toveren. Let dus even goed op a.u.b.
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

Naast letters en tekens mogen in string en chars ook escape characters staan.  In C# hebben bepaalde tekens namelijk een speciale functie, zoals de dubbele aanhalingstekens (`"`) om het begin of einde van een string-literal aan te geven. We hebben dus een manier nodig om aan te duiden wanneer de compiler het eerstvolgende teken als een ``char`` moet beschouwen, of als een teken dat deel uitmaakt van de code zelf.

Zonder aan te geven dat we letterlijk dat teken willen tonen, en het niet in z’n C# functie gebruiken, zouden we problemen krijgen.  **Escape characters worden met een backslash (`\`) aangeduid, gevolgd door het karakter dat we wensen te tonen.**

### Voorbeeld van escape chars

Laten we eens kijken naar de werking van het afkappingsteken als voorbeeld (de zogenaamde apostrof, gebruik in om bijvoorbeeld ``'s avonds`` te schrijven)
Volgende code zal de compiler verkeerd interpreteren, daar hij denkt dat we een leeg karakter wensen op te slaan:

```java
char apostrof= ''';
```

Het gevolg is een litanie aan vreemde foutboodschappen omdat er na de sluitende apostrof (het tweede) plots nog een apostrof (het derde) verschijnt. VS is volledig in de war zo!

<!--- {width:35%} --->
![Hulp! VS snapt er niets van](../assets/1_csharpbasics/escape.png)

De juiste manier is om dus een escape character te gebruiken. We gaan met de backslash aanduiden dat het volgende teken (de tweede apostrof) een ``char`` voorstelt en niet het sluitende teken in de code.

```java
char apostrof= '\'';
```

### Veel gebruikte escape chars

Er zijn echter nog een heleboel andere escape characters die je geregeld zal moeten gebruiken, waaronder ``\n``  om een nieuwe lijn aan te geven en ``\t`` om een tab in de tekst te plaatsen.

Er zijn verschillende escape characters in C# toegelaten, we lijsten hier de belangrijkste op (voor een totaal overzicht kijk [hier](https://blogs.msdn.microsoft.com/csharpfaq/2004/03/12/what-character-escape-sequences-are-available/)):

* `\'` : de apostrof zoals zonet besproken
* `\"` : een aanhalingsteken zodat je dat ook in je string kunt gebruiken zonder deze af te sluiten
* `\\` : een backslash in je tekst tonen. Hoe toon je dan twee backslashes? ``"\\\\"``.
* `\n` : New line (zogenaamde 'enter')
* `\t` : Horizontal tab 
* `\uxxxx` – Unicode escape sequence for character with hex value xxxx


### Escape characters in strings

Aangezien strings eigenlijk bestaan uit 1 of meerdere char-elementen, is het logisch dat je ook in een string met escape characters kunt werken. Het woord "'s avonds" schrijf je bijvoorbeeld als volgt:

```java
string woord= "\'s avonds";
```

Idem met aanhalngstekens. Stel je voor dat je een programma wilt schrijven dat C# code op het scherm toont. Dat doe je dan met volgende, nogal Inception-achtige, manier:

```java
string inceptionCode= "Console.WriteLine(\"Cool he\");";
Console.WriteLine(inceptionCode);
```

Merk op dat we voorgaande code nog meer Inception-like kunnen maken door de string ineens in de WriteLine methode te plaatsen:

```java
Console.WriteLine("Console.WriteLine(\"Cool he\");");
```

Beide voorbeelden zullen dus volgende tekst op het scherm geven: ``Console.WriteLine("Cool he");``

<!---{pagebreak} --->

### Witregels en tabs

We gebruiken vooral escape characters in strings om bijvoorbeeld witregels (`\n`) en tabulaties(`\t`) aan te geven. Test bijvoorbeeld volgende lijn code eens:

```java
string eenString = "Een zin.\t na een tab \nDan eentje op een nieuwe regel";
Console.WriteLine(eenString);
```

Dit zal als output geven:

```java
Een zin.         na een tab
Dan eentje op een nieuwe regel
```

### Over tabstops

Als je het niet gewoon bent de tab-toets op je toetsenbord te gebruiken dan is de eerste werking van ``\t`` mogelijk verwarrend. Nochtans is ``\t`` in een string gebruiken exact hetzelfde als op de tab-toets te duwen. 

In je console-scherm zijn de tab stops vooraf bepaald. Wanneer je dus een tab invoegt zal de cursor zich verplaatsen naar de eerstvolgende tab stop. 

In volgende tekstuitvoer zie je de tabstops op de tweede lijn "gevisualiseerd":

<!---{line-numbers:false}--->
```text
01234567890123456789012345678901234567890123456789
        1       2       3       4       5
```

Bovenstaande uitvoer werd als volgt gemaakt:

```java
Console.WriteLine("01234567890123456789012345678901234567890123456789");
Console.WriteLine("\t1\t2\t3\t4\t5");
```



### Biep biep

``\a`` mag je enkel gebruiken als je een koptelefoon op hebt daar dit het escape character is om de computer een biep te laten doen (mogelijk doet dit niets bij jou, dit hangt van de je computerinstellingen af).

Volgende codevoorbeeld zal, als alles goed gaat, een zin op het scherm tonen en dan ogenblikkelijk erna een biepje:

```java
Console.WriteLine("Een zin en dan nu de biep\a");
```

<!---{pagebreak} --->

### Het apenstaartje om escape characters te negeren

Het apenstaartje voor een ``string`` literal plaatsen is zeggen "beschouw alles binnen de aanhalingstekens als effectieve karakters die deel uitmaken van de inhoud van de tekst. **Escape characters zullen dus genegeerd worden.** Dit is vooral handig als je bijvoorbeeld een netwerkadres wilt schrijven en niet iedere ``\`` wilt escapen:

```java
string zonderAt = "C\\Temp\\Myfile.txt";
string metaAt = @"C\Temp\Myfile.txt";
```

Merk op dat aanhalingstekens nog steeds *ge-escape'd* moeten worden. Heb je dus een stuk tekst met een aanhalingsteken in dan zal je zonder het apenstaartje moeten werken.

## Optellen van char variabelen

We hebben al gezien dat intern een ``char`` als een geheel getal (de Unicode) wordt voorgesteld. Stel dat we volgende char-variabelen aanmaken. 

```java
char letter1 = 'A';
char letter2 = 'B';
```

Bij string mogen we de +-operator gebruiken om 2 strings aan elkaar te plakken. **Bij char mag dat niet!** Of beter, dit mag maar zal niet het resultaat geven dat je mogelijk verwacht wanneer je voor het eerst hiermee leert werken. Oordeel zelf:

```java
Console.WriteLine(letter1 + letter2);
```

**Wanneer je deze code uitvoert dan krijg je `131` te zien** (en dus niet "AB" zoals je misschien had verwacht).

Had je dit verwacht? Herinner je  dat het char-type z’n waarde als getallen bijhoudt, de zogenaamde Unicode-voorstelling van het karakter. Als de compiler het volgende ziet staan:

``letter1 + letter2`` 

dan zal de compiler deze twee waarden letterlijk optellen en het nieuw verkregen getal als resultaat geven:

* De Unicode-voorstelling van `A` is 0X041 oftewel **`65`**. In het geheugen staat dus het geheel getal ``65``.
* `B` wordt voorgesteld door **`66`**.
* Als we dus de variabelen ``letter1`` en ``letter2`` optellen geeft dit **131**. 


{% hint style='tip' %}
Je zou misschien verwachten dat C# vervolgens het element op plaats 131 in de Unicode tabel zou tonen. Dat is niet zo: omdat de ``+`` operator niet is gedefinieerd voor het ``char`` datatype maar wel voor het ``int`` datatype, besluit de compiler om de twee operanden (``letter1`` en ``letter2``) als ``int`` operanden te hanteren. Aangezien ``int+int`` een ``int`` als resultaat geeft, krijgen we dus ``131`` op het scherm en niet het Unicode element 131 ``ƒ`` (we zien verderop hoe je dit wel kunt doen).
{% endhint %}

