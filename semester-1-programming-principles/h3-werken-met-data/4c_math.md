# Math-klasse en berekeningen

## Berekeningen

Een groot deel van je leven als ontwikkelaar zal bestaan uit het bewerken van variabelen in code. Meestal zullen die bewerkingen voorafgaan van berekeningen. De `Math` klasse zal ons hier bij kunnen helpen.

### De Math klasse

De Math klasse bevat aardig wat handige methoden. Deze klasse bevat methoden voor een groot aantal typische wiskundige methoden \(sinus, cosinus, vierkantswortel, macht, afronden, etc.\) en kan je dus helpen om leesbaardere expressies te schrijven.

Stel dat je de derde macht van een variabel `getal` wenst te berekenen. Zonder de Math-klasse zou dat er zo uitzien:

```csharp
double result = getal*getal*getal;  //SLECHTE MANIER
```

Met de klasse kunnen we schrijven:

```csharp
double result = Math.Pow(getal, 3);
```

#### De Math klasse ontdekken

Als je in Visual Studio `Math` schrijft, gevolgd door een punt `.` krijg je alles te zien wat de Math-klasse kan doen:

![](../../.gitbook/assets/methoden3%20%282%29.png)

Een doosje voor een naam wil zeggen dat het om een **methode** gaat \(zoals `Console.ReadLine()`\). Een vierkantje met twee streepjes in zijn constanten \(zoals het getal `Pi` , dat erg van pas komt in de meetkunde\).

#### Methoden gebruiken

De meeste methoden zijn zeer makkelijk in gebruik en werken op dezelfde manier. Meestal moet je 1 of meerdere waarden tussen de haken meegeven en het resultaat moet je altijd in een nieuwe variabele opvangen. Enkele voorbeelden:

```csharp
double sineHoekA = Math.Sin(345); //niet in graden maar in radialen
double DerdeMachtVan20 = Math.Pow(20, 3);
double complex = 3+ DerdeMachtVan20 * Math.Round(sineHoekA);
```

Twijfel je over de werking van een methode, gebruik dan de help als volgt:

1. Schrijf de Methode zonder argumenten. Bijvoorbeeld `Math.Pow()` \(je mag de rode error negeren\). ![](../../.gitbook/assets/math%20%282%29.png)
2. Plaats je cursor op `Pow`.
3. Druk op `F1` op je toetsenbord.
4. Je krijgt nu de help-files te zien van deze methode op MDSDN.

#### PI \(π\)

Ook het getal Pi \(`3.141...`\) is beschikbaar in de Math-library. Het witte icoontje voor PI bij Intellisense toont aan dat het hier om een ‘field’ gaat; een eenvoudige variabele met een specifieke waarde. Het woordje `const` betekent dat je deze waarde niet kan aanpassen.

```csharp
public const double PI;
```

Je kan deze als volgt gebruiken in berekeningen:

```csharp
double straal = 5.5;
double omtrek = Math.PI * 2 * straal;
```

### Lopende som

{% hint style="success" %}
[Kennisclip lopende som](https://youtu.be/jWgi_JBAoTo)
{% endhint %}

Een vaak voorkomende oefening is deze waarbij je een bepaalde variabele continue moet aanpassen. Stel bijvoorbeeld dat je aan de gebruiker de temperatuur van iedere dag vraagt om zo vervolgens het gemiddelde te berekenen. Dit kan je doen door middel van een lopende som: je gaat telkens het ingevoerde getal toevoegen aan wat je reeds hebt bewaard. Meestal dus met behulp van de `+=` operator.

```csharp
double totaal = 0.0;
Console.WriteLine("Geef temperatuur dag 1");
double inp = Convert.ToDouble(Console.ReadLine());
totaal += inp;
Console.WriteLine("Geef temperatuur dag 2");
inp = Convert.ToDouble(Console.ReadLine());
totaal += inp;
//enz
Console.WriteLine($"Gemiddelde temperatuur deze week was: {totaal/7}");
```

