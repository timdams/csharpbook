# Datatypes

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=d04cb0f0-0fdf-48ab-8dac-acdd00a45b16)
{% endhint %}

Een essentieel onderdeel van C\# is kennis van datatypes. Binnen C\# zijn een aantal types gedefinieerd die je kan gebruiken om data in op te slaan. Wanneer je data wenst te bewaren in je applicatie dan zal je je moeten afvragen wat voor soort data het is. Gaat het om een getal, een geheel getal, een kommagetal, een stuk tekst of misschien een binaire reeks? Ieder datatype in C\# kan één welbepaald soort data bewaren en dit zal telkens een bepaalde hoeveelheid computergeheugen vereisen.

Er zijn tal basistypes in C\# gedeclareerd \(zogenaamde **built-in datatypes**\). Dit semester leren we werken met datatypes voor:

* Gehele getallen: `sbyte, byte, short, ushort, int, uint, long`
* Kommagetallen: `double, float, decimal`
* Tekst: `char, string`
* Booleans: `bool`

{% hint style="info" %}
Het datatype `string` heb je al gezien in het vorig hoofdstuk. Je hebt toen al een variabele aangemaakt van het type string door de zin `string result;`.

Verderop plaatsten we dan iets waar de gebruiker iets kan intypen in die variabele \(toekenning in C\# gaat van rechts naar links\):

```csharp
result = Console.ReadLine();
```
{% endhint %}

## Basistypen voor getallen

Alhoewel een computer digitaal werkt en enkel 0'n en 1'n bewaard zou dat voor ons niet erg handig werken. C\# heeft daarom een hoop datatypes gedefinieerd om te werken met getallen zoals wij ze kennen, gehele en kommagetallen. Intern zullen deze getallen nog steeds binair bewaard worden, maar dat is tijdens het programmeren zelden een probleem.

{% hint style="info" %}
Onthoud echter dat onderaan je programma steeds hardware zal draaien die binair werkt.
{% endhint %}

De basistypen van C\# om getallen in op te slaan zijn:

* Voor gehele getallen: `sbyte, byte, short, ushort, int, uint, long`
* Voor kommagetallen: `double, float, decimal`

&gt;

{% hint style="warning" %}
Ieder type hierboven heeft een bepaald bereik en hoeveelheid geheugen nodig. Je zal dus steeds moeten afwegen wat je wenst. Op een high-end pc met ettelijke gigabytes aan werkgeheugen \(RAM\) is geheugen zelden een probleem waar je rekening mee moet houden...Of toch: zoals met real-time shooters die miljoenen berekeningen \(3D\) per seconde moeten uitvoeren. Daar zal iedere byte tellen. Op andere apparaten \(smartphone, arduino, smart fridges, etc.\) is iedere byte geheugen nog kostbaarder. **Kortom: kies steeds bewust het datatype dat het beste 'past' voor je probleem qua bereik, precisie en geheugengebruik.**
{% endhint %}

Deze datatypes hebben allemaal een bepaald bereik, wat een rechtstreeks gevolg is van de hoeveelheid geheugen die ze innemen.

### Gehele getallen

Voor de gehele getallen:

| **Type** | **Geheugen** | **Bereik** | **Meer info** |
| :--- | :--- | :--- | :--- |
| `sbyte` | 8 bits | -128 tot 127 | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sbyte) |
| `byte` | 8 bits | 0 tot 255 | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/byte) |
| `short` | 16 bits | -32768 tot 32767 | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/short) |
| `ushort` | 16 bits | 0 tot 65535 | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ushort) |
| `int` | 32 bits | -2 147 483 648 tot 2 147 483 647 | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/int) |
| `uint` | 32 bits | 0 tot 4294967295 | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/uint) |
| `long` | 64 bits | -9 223 372 036 854 775 808 tot 9 223 372 036 854 775 807 | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/long) |
| `ulong` | 64 bits | 0 tot 18 446 744 073 709 551 615 | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/long) |
| `char` | 16 bits | 0 tot 65535 | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/char) |

{% hint style="info" %}
**We raden aan dat je de 'info' urls bekijkt om te ontdekken hoe je de literals van datatypes moet schrijven in C\#.**
{% endhint %}

Enkele opmerkingen bij deze tabel:

* De `s` vooraan `sbyte` types staat voor `signed`: m.a.w. 1 bit wordt gebruikt om het + of - teken te bewaren. 
* De `u` vooraan `ushort`, `uint` en `ulong` staat voor `unsigned`. Het omgekeerde van signed dus. Kwestie van het ingewikkeld te maken. Deze twee datatypes hebben dus geen teken en zijn **altijd positief**.
* `char` bewaard karakters. We zullen verderop dit datatype uitspitten en ontdekken dat karakters \(alle tekens op het toetsenbord, inclusief getallen, leesteken, etc.\) als gehele, binaire getallen worden bewaard. Daarom staat `char` in deze lijst.
* Het grootste getal bij `long` is 2 tot de 63ste \(

  negen triljoen tweehonderddrieëntwintig biljard driehonderd tweeënzeventig biljoen zesendertig miljard achthonderdvierenvijftig miljoen zevenhonderdvijfenzeventigduizend achthonderd en zeven\). Dit zijn maar 63 bits?! Inderaad, de laatste bit wordt gebruikt om het teken te bewaren.

### Kommagetallen

Voor de kommagetallen zijn er maar 3 mogelijkeden. Ieder datatype heeft een 'voordeel' tegenover de 2 andere, dit voordeel staat vet in de tabel:

| **Type** | **Geheugen** | **Bereik** | **Precisie** |  |
| :--- | :--- | :--- | :--- | :--- |
| `float` | **32 bits** | $$±1.5 \cdot 10^{-45} \space to\space ±3.4 \cdot 10^{38}$$  | 7 digits | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/float) |
| `double` | 64 bits | $$\bold{±5.0 \cdot 10^{-324} \space to\space ±1.7 \cdot 10^{308}}$$ | 15 digits | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/double) |
| `decimal` | 128 bits | $$±1.0 \cdot 10^{-28}\space to\space ±7.9228 \cdot 10^{28}$$  | **28-29 digits** | [info](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/decimal) |

Zoals je ziet moet je bij kommagetallen een afweging maken tussen 3 even belangrijke criteria. Heb je ongelooflijk grote precisie nodig dan ga je voor een `decimal`. Wil je vooral erg grote of erg kleine getallen kies je voor `double`. De precisie van een getal is het aantal beduidende of significante cijfers. Het getal 12,45 heeft een precisie van 4. Zoals je merkt zal je dus zelden `decimal` nodig hebben, deze zal vooral nuttig zijn in wetenschappelijke programma's waar met erg exacte cijfers moet gewerkt worden.

{% hint style="info" %}
Bij twijfel opteren we meestal voor kommagetallen om het **`double`** datatype te gebruiken. Bij gehele getallen kiezen we meestal voor **`int`**.
{% endhint %}

## Boolean datatype

Het `bool` \(**boolean**\) is het eenvoudigste datatype van C\#. Het kan maar 2 mogelijke waarden bevatten: `true` of `false`. 0 of 1 met andere woorden.

Het gebeurt vaak dat beginnende programmeurs een `int` variabele gebruiken terwijl ze toch weten dat de variabele maar 2 mogelijke waarden zal hebben. Om dus geen onnodig geheugen te verbruiken is het aan te raden om in die gevallen steeds met een `bool` variabele te werken.

We zullen het `bool` datatype erg veel nodig hebben wanneer we met [beslissingen](../h4-beslissingen/0_beslissingen_intro.md) zullen werken, specifiek de [if statements](../h4-beslissingen/0_if.md) die afhankelijk van de uitslag van een `bool` bepaalde code wel of niet zullen doen uitvoeren.

## Tekst/String datatype

We besteden verderop een heel apart hoofdstuk aan tonen hoe je tekst en enkele karakters kan bewaren in variabelen. Sneak preview:

* Tekst kan bewaard worden in het `string` datatype
* Een enkel karakter wordt bewaard in het `char` datatype dat we ook hierboven al even hebben zien passeren.

Meer info vind je later in [dit hoofdstuk](../h2-tekst-in-code/5_chars_strings.md).

