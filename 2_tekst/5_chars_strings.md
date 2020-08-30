# Tekst gebruiken in code

## Tekst datatypes

In het vorige hoofdstuk werkten we vooral met getallen en haalden we maar kort het ``string`` en ``char`` datatype aan. In dit hoofdstuk gaan we dieper in deze 2 veelgebruikte datatypes in.

### Char

Een **enkel karakter** (cijfer, letter, leesteken, etc.) als 'tekst' opslaan kan je doen door het `char`-type te gebruiken. Zo kan je bijvoorbeeld een enkel karakter als volgt tonen:

```java
char eenLetter = 'X';
Console.WriteLine("eenLetter=" + eenLetter);
```

Het is belangrijk dat je de apostrof (``'``) niet vergeet voor en na het karakter dat je wenst op te slaan daar dit de literal voorstelling van `char`-literals is.

Je kan eender welk [Unicode-teken](https://en.wikipedia.org/wiki/Unicode) in een `char` bewaren, namelijk letters, cijfers en speciale tekens zoals `%`, `$`, `*`, `#`, etc. **Intern wordt de zogenaamde Unicode van het character bewaard in de variabele, zijnde een 16 bit getal**.

Merk dus op dat volgende lijn: ``char eenGetal = '7';`` weliswaar een getal als teken opslaat, maar dat intern de compiler deze variabele steeds als een character zal gebruiken. Als je dit cijfer zou willen gebruiken als effectief cijfer om wiskundige bewerkingen op uit te voeren, dan zal je dit eerst moeten converteren naar een getal.

## Unicode en Ascii

Ieder teken dat je op je toetsenbord kunt intypen is een ``char``. Je toetsenbord bevat echter maar een kleine selectie van alle mogelijkheden (vergelijk jouw toetsenbord bijvoorbeeld maar eens met dat van iemand in Rusland of China).

Unicode is een standaard die de zogenaamde Ascii-standaard opvolgt omdat die te klein (qua aantal bits) bleek te zijn om naar de toekomst toe de ontelbare nieuwe tekens in voor te stellen. De Ascii standaard kan 128 karakters voorstellen (mbv 7 bit), wat uiteraard in het niets valt in vergelijking met de meer dan 1 miljoen tekens in Unicode. Uiteraard heeft de Unicode-standaard die eerste 128 van Ascii als eerste gezet en zijn beide tabellen dus compatibel (Unicode is een superset van Ascii). 

Voor de statistieknerds onder ons: er zijn 1,111,998 Unicode karakters mogelijk. Momenteel zijn er daarvan 137,929 gedefiniëerd. We hebben dus nog wel wat plek.

![De eerste 128 karakters met hun waarden (Bron Wikipedia)](../assets/1_csharpbasics/ascii.png)

De eerste 1F karakters zijn "onzichtbare" karakters die een historische reden hebben om in de lijst te staan, maar sommige ervan zijn ondertussen niet meer erg nuttig. Origineel werd Ascii ontwikkeld als standaard om via de telegraaf te combineren. Vandaar dat vele van deze karakters commando's lijken om oude typemachines aan te sturen (line feed, bell, form feed, etc) want dat zijn ze dus ook effectief!

## String
Een ``string`` is een reeks van 0, 1 of meerdere `char`-elementen, zoals je ook kan zien als je even met je muis boven een string keyword *hovert* in je code:

![IntelliSense is de krachtige technologie in VS die je behulpzame informatie geeft tijdens het programmeren](../assets/1_csharpbasics/stringenchars.png)

We gebruiken het ``string`` datatype om tekst mee voor te stellen. Je begrijpt waarschijnlijk zelf wel waarom het ``string`` datatype een belangrijk en veelgebruikt type is in eender welke programmeertaal: er zijn maar weinig applicaties die niet minstens enkele lijnen tekst vertonen (ja, zelfs Flappy Bird had tekst, of hoe denk je dat je score werd voorgesteld op het scherm?).

{% hint style='tip' %}
In deel 2 van deze boekenreeks zullen we ontdekken dat strings eigenlijk zogenaamde arrays zijn. Wat dit juist inhoudt laten we nog even lekker mysterieus achterwege (ik probeer alles om je dat volgende deel te doen lezen nietwaar).
{% endhint %}

### Strings declareren
Merk op dat we bij een ``string`` literal gebruik maken van aanhalingstekens (`"`) terwijl bij een ``char`` literal we een apostrof gebruiken (`'`). Dit is de manier om een string van een char te onderscheiden (naast het feit dat een string uit meer dan 1 element kan bestaan uiteraard)

Volgende uiterst boeiende code geeft drie keer het cijfer 1 onder elkaar op het scherm, maar de eerste keer gaat het om het een ``char`` (enkelvoudig teken), dan een een ``string`` (reeks van tekens) en dan een ``int`` (effectief getal):

```java
char eenKarakter = '1'; 
string eenString = "1"; 
int eenGetal = 1;
 
Console.WriteLine(eenKarakter);
Console.WriteLine(eenString);
Console.WriteLine(eenGetal);
```

Het programma zal driemaal een ``1`` onder elkaar tonen. Boeiend programma hoor.