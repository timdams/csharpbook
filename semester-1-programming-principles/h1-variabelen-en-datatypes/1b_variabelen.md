# Variabelen

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=22d326cf-b619-4cf0-80fc-a966007ffef5)
{% endhint %}

## Variabelen

In het vorige hoofdstuk zagen we dat er verschillende soorten datatypes bestaan. Deze types hebben we nodig om **variabelen** aan te maken. De data die we in een programma gebruiken bewaren we namelijk in een **variabele van een bepaald type**. Een variabele is een plekje in het geheugen dat in je programma zal gereserveerd worden om daarin data te bewaren van het type dat je aan de variabele hebt toegekend. Een variabele zal intern een geheugenadres hebben \(waar de data in het geheugen staat\) maar dat zou lastig programmeren zijn indien je steeds dit adres moet gebruiken. Daarom moeten we ook steeds een naam oftewel **identifier** aan de variabele geven zodat we makkelijk de geheugenplek kunnen aanduiden.

> De naam \(identifier\) van de variabele moet voldoen aan de identifier regels onder "Inleiding -&gt; Afspraken code".

## Variabelen aanmaken en gebruiken

Om een variabele te maken moeten we deze **declareren**, door een type en naam te geven. Vanaf dan zal de computer een hoeveelheid geheugen voor je reserveren waar de inhoud van deze variabele in kan bewaard worden. Hiervoor dien je minstens op te geven:

1. Het **datatype** \(bv `int`,  `double`\).
2. Een **identifier** zodat de variabele uniek kan geïdentificeerd worden \([volgens de naamgevingsregel van C\#](0_csharpessentials.md)\).
3. \(optioneel\) Een **beginwaarde** die de variabele krijgt bij het aanmaken ervan.

Een variabele declaratie heeft als syntax:

```csharp
datatype identifier;
```

Bijvoorbeeld: `int leeftijd;`

Je mag ook meerdere variabelen van het zelfde datatype in 1 enkele declaratie aanmaken door deze met komma's te scheiden:

```csharp
datatype identifier1, identifier2, identifier3;
```

Bijvoorbeeld `string voornaam, achternaam, adres;`

Indien je reeds weet wat de beginwaarde moet zijn van de variabele dan mag je de variabele ook reeds deze waarde toekennen bij het aanmaken:

```csharp
int mijnLeeftijd = 37;
```

### Waarden toekennen aan variabelen

Vanaf dit punt kunnen we dus ten allen tijde deze variabele gebruiken om een waarde aan toe te kennen, de bestaande waarde te overschrijven, of de waarde te gebruiken, zoals:

* Waarde toekennen: `mijnGetal= 15;`. **Toekenning gebeurt steeds van rechts naar links: het deel rechts van het gelijkheidsteken wordt toegewezen aan het deel links er van.**
* Waarde tonen op scherm: `Console.WriteLine(mijnGetal);`

Met de **toekennings-operator \(=\)** kan je een waarde toekennen aan een variabele. Hierbij kan je zowel een literal toekennen oftewel het resultaat van een expressie.

Je kan natuurlijk ook een waarde uit een variabele uitlezen en toewijzen aan een andere variabele:

```csharp
int eenAndereLeeftijd = mijnLeeftijd;
```

### Literal toewijzen

Literals zijn expliciet ingevoerde waarden in je code. Als je in je code expliciet de waarde 4 wilt toekennen aan een variabele dan is het getal 4 in je code een zogenaamde literal. Wanneer we echter data bijvoorbeeld eerst uitlezen of berekenen \(via bijvoorbeeld invoer van de gebruiker of als resultaat van een berekening\) en het resultaat hiervan toekennen aan een variabele dan is dit geen literal.

Voorbeelden van een literal toekennen:

```csharp
int temperatuurGisteren = 20;
int temperatuurVandaag = 25;
```

Het is belangrijk dat het type van de literal overeenstemt met dat van de variabele waaraan je deze zal toewijzen. Een string-literal \(zie verder\) stel je voor door aanhalingstekens. Volgende code zal dan ook een compiler-fout generen, daar je een string-literal aan een int-variabele wil toewijzen, en vice versa.

```csharp
string eenTekst;
int eenGetal;

eenTekst = 4;
eenGetal = "4";
```

Als je bovenstaande probeert te compileren dan krijg je volgende error-boodschappen:

![](../../.gitbook/assets/errorliteraltoekenning%20%282%29.png)

#### Literal bepaalt het datatype

De manier waarop je een literal schrijft in je code zal bepalen wat het datatype van de literal is:

* **Gehele getallen** worden standaard als `int` beschouwd, vb: `125`.
* **Kommagetallen** \(met punt `.`\) worden standaard als `double` beschouwd, vb: `12.5`.
* Via een **suffix** na het getal kan je aangeven als het om andere types gaat:
  * `U` of `u` voor `uint`, vb: `125U`.
  * `L` of `l` voor `long`, vb: `125L`.
  * `UL` of `ul` voor `ulong`, vb: `125ul`.
  * `F` of `f` voor `float`, vb: `12.5f`.
  * `M` of `m` voor `decimal`, vb: `12.5M`.
* Voor **`bool`** \(zie verder\) is dit enkel `true`  of `false`.
* Voor **`char`** \(zie verder\) wordt dit aangeduid met een enkele apostrof voor en na de literal, vb: `'q'`.
* Voor **`string`** \(zie verder\) wordt dit aangeduid met  aanhalingsteken voor en na de literal, vb: `"pikachu"`.

De overige types `sbyte`, `short` en `ushort` hebben geen literal aanduiding. Er wordt vanuit gegaan wanneer je een literal probeert toe te wijzen aan een van deze types dat dit zonder problemen zal gaan \(ze worden impliciet geconverteerd\).

### Nieuwe waarden overschrijven oude waarden

Wanneer je een reeds gedeclareerde variabele een **nieuwe waarde toekent** dan zal de oude waarde in die variabele onherroepelijk verloren zijn. Probeer dus altijd goed op te letten of je de oude waarde nog nodig hebt of niet. Wil je de oude waarde ook nog bewaren dan zal je een nieuwe, extra variabele moeten aanmaken en daarin de nieuwe waarde moeten bewaren:

```csharp
int temperatuurGisteren = 20;
temperatuurGisteren = 25;
```

In dit voorbeeld zal er dus voor gezorgd worden dat de oude waarde van temperatuurGisteren, `20`, overschreven zal worden met `25`.

Volgende code toont hoe je bijvoorbeeld eerst de vorige waarde kunt bewaren en dan overschrijven:

```csharp
int temperatuurGisteren= 20;
//Doe vanalles
//...
//1 dag later
int temperatuurEerGisteren= temperatuurGisteren; //Vorige temperatuur in eergisteren bewaren
temperatuurGisteren = 25; //temperatuur nu overschrijven
```

We hebben dus aan het einde van het programma zowel de temperatuur van eergisteren, `20`, als die van vandaag, `25`.

