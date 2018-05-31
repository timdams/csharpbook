# Basistypen voor getallen

De belangrijkste basistypen van C\# om getallen weer te geven zijn

* Voor gehele getallen: `sbyte, byte, short, ushort, int, uint, long`
* Voor kommagetallen: `double, float, decimal`

## Bereik van datatypes

Deze datatypes hebben allemaal een bepaald bereik, wat een rechtstreeks gevolg is van de hoeveelheid geheugen die ze innemen.

Voor de gehele getallen (voordeel in vet):

| **Type** | **Geheugen** | **Range** |
| :--- | :--- | :--- |
| `sbyte` | 8 bits | -128 tot 127 |
| `byte` | 8 bits | 0 tot 255 |
| `short` | 16 bits | -32768 tot 32767 |
| `ushort` | 16 bits | 0 tot 65535 |
| `int` | 32 bits | -2147483658 tot +2147483657 |
| `uint` | 32 bits | 0 tot 4294967295 |
| `long` | 64 bits | Zie boek |
| `char` | 16 bits | 0 tot 65535 |

Voor de kommagetallen:

| **Type** | **Geheugen** | **Range** | **Precisie** |
| :--- | :--- | :--- | :--- |
| `float` | **32 bits** | 1,5\*10^-45 tot 3,4\*10^48 | 7 digits |
| `double` | 64 bits | **5\*10^-324 tot 1,7\*10^308** | 15 digits |
| `decimal` | 128 bits | 1\*10^-28 tot 7,9\*10^28 | **28-29 digits** |

### Bereik in code weten

Het bereik van deze typen is weliswaar opgegeven in het handboek. Maar het is belangrijk om weten dat deze ook in de compiler gekend is. Het volgende voorbeeld toont dit aan:

```csharp
string zinnetje = "Het bereik van het type double is:";
Console.WriteLine(zinnetje + double.MinValue + " en " + double.MaxValue);
```

Je kan met andere woorden met `int.MaxValue` en `int.MinValue` het minimum- en maximumbereik van het type int verkrijgen. Wil je dit van een double, dan gebruik je `double.MaxValue` etc.

## Variabelen aanmaken en gebruiken

Telkens wanneer je een variabele wenst aan te maken, om te gebruiken als werkgeheugen in je programma, dan dien je eerst deze variabele te definiëren.

Hiervoor dien je minstens op te geven:

1. Het datatype \(bv int, double\)
2. Een identifier zodat de variabele uniek kan geïdentificeerd worden
3. \(optioneel\) Een beginwaarde die de variabele krijgt bij het aanmaken ervan

Voorbeeld:

```csharp
int mijnLeeftijd;
```

We maken variabele van het type ‘int’ \(geheel getal\) dat als identifier ‘eenVariabele’ heeft.

Indien je reeds weet wat de beginwaarde moet zijn van de variabele dan mag je de variabele ook reeds deze waarde toekennen bij het aanmaken:

```csharp
int mijnLeeftijd = 37;
```

## Waarden toekennen aan variabelen

Vanaf dit punt kunnen we dus ten allen tijde deze variabele gebruiken om een waarde aan toe te kennen, de bestaande waarde te overschrijven, of de waarde te gebruiken:

* Waarde toekennen: `mijnGetal = 15;`
* Waarde tonen op scherm: `Console.WriteLine(mijnGetal);`

Met de** toekennings-operator \(=\)** kan je een waarde toekennen aan een variabele. Hierbij kan je zowel een literal toekennen oftewel het resultaat van een expressie.

Je kan natuurlijk ook een waarde uit een variabele uitlezen en toewijzen aan een andere variabele:

```csharp
int eenAndereLeeftijd= mijnLeeftijd;
```

## Literal toewijzen

Literals zijn expliciet ingevoerde waarden in je code. Als je in je code expliciet de waarde 4 wilt toekennen aan een variabele dan is het getal 4 in je code een zogenaamde literal. Wanneer we echter data bijvoorbeeld eerst uitlezen of berekenen \(via bijvoorbeeld invoer van de gebruiker of als resultaat van een berekening\) en het resultaat hiervaan toekennen aan een variabele dan is dit geen literal.

Voorbeelden van een literal toekennen:

```csharp
int temperatuurGisteren = 20;
int temperatuurVandaag = 25;
```

Het is belangrijk dat het type van de literal overeenstemt met dat van de variabele waaraan je deze zal toewijzen. Een string-literal stel je voor door aanhalingstekens. Volgende code zal dan ook een compiler-fout generen, daar je een string-literal aan een int-variabele wil toewijzen, en vice versa.

```csharp
string eenTekst;
int eenGetal;

eenTekst = 4;
eenGetal = "4";
```

Als je bovenstaande probeert te compileren dan krijg je volgende error-boodschappen krijgen:

![](/assets/0intro/errorliteraltoekenning.png)

### Nieuwe waarden overschrijven oude waarden

Wanneer je een reeds gedeclareerde variabele een **nieuwe waarde toekent **dan zak de oude waarde in die variabele onherroepelijk verloren zijn. Probeer dus altijd goed op te letten of je de oude waarde nog nodig hebt of niet. Wil je de oude waarde ook nog bewaren dan zal je een nieuwe, extra variabele moeten aanmaken en daarin de nieuwe waarde moeten bewaren:

```csharp
int temperatuurGisteren = 20;
temperatuurGisteren = 25;
```

In dit voorbeeld zal er dus voor gezorgd worden dat de oude waarde van temperatuurGisteren, 20, zal worden overschreven met 25.

Volgende code toont hoe je bijvoorbeeld eerst de vorige waarde kunt bewaren:

```csharp
int temperatuurEerGisteren = temperatuurGisteren;
temperatuurGisteren = 25;
```