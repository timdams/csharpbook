# DateTime: leren werken met objecten

{% hint style="success" %}
[Kennisclip. Klein verschil met de pagina tot de twee oranje checkboxes, dus lees die goed.](https://youtu.be/vWtra7AF-g4)
{% endhint %}

## DateTime

Het .NET gegevenstype `DateTime` is de ideale manier om te leren werken met objecten. Het is een nuttig en toegankelijk gegevenstype. Je kan er je iets bij voorstellen, maar het is ook een beetje abstract.

{% hint style="warning" %}
Waarom spreken we hier over "gegevenstype" en niet over "klasse"? Omdat klassen in .NET reference types zijn. `DateTime` is echter een value type, dus technisch gezien is het een "struct" en geen "klasse". Wij zullen zelf geen structs schrijven, maar het verschil met klassen is uiterst klein in C\#. Instanties van zowel klassen als structs zijn objecten.
{% endhint %}

{% hint style="warning" %}
Zegt het verschil tussen value types en reference types je niets meer? Kijk dan terug naar [deze pagina](../../semester-1-programming-principles/h7-arrays/value-types-en-reference-types.md).
{% endhint %}

## DateTime objecten aanmaken

Er zijn 2 manieren om `DateTime` objecten aan te maken:

1. Door aan de klasse de huidige datum en tijd te vragen via `DateTime.Now`
2. Door manueel de datum en tijd in te stellen via de **constructor** 

### DateTime.Now

Volgend voorbeeld toont hoe we een object kunnen maken dat de huidige datum tijd van het systeem bevat. Vervolgens printen we dit op het scherm:

```csharp
DateTime currentTime = DateTime.Now;
Console.WriteLine(currentTime);
```

`DateTime` op het begin van regel 1 is het type van de variabele. Dit type drukt uit met wat voor data we te maken hebben. Dit is net dezelfde redenering als bij het gebruik van `string` in `string mijnTekst = "hello world";`

### Met constructor

Via de constructor kunnen we beginwaarden meegeven bij het maken van een nieuw object. Er zijn 11 manieren waarop dit kan zoals je [hier kan zien](https://docs.microsoft.com/en-us/dotnet/api/system.datetime.-ctor?view=netframework-4.7.2).

Enkele voorbeelden:

```csharp
DateTime birthday = new DateTime(1982, 3, 18); //year, month, day
DateTime someMomentInTime = new DateTime(2017, 1, 18, 10, 16,34 ); //year, month, day, hour, min, sec
```

{% hint style="info" %}
Je hebt eerder al met constructoren gewerkt: herinner je `new Random()`. Hiermee maakte je eigenlijk een object aan dat willekeurige getallen kon genereren.
{% endhint %}

## DateTime methoden

Ieder `DateTime` object dat je aanmaakt heeft een hoop nuttige methoden.

### Add Methods

Deze methoden kan je gebruiken om een bepaalde aantal dagen, uren, minuten en zo voort aan je huidige object toe te voegen. Al deze methoden geven steeds een **nieuw DateTime object** terug dat je moet bewaren wil je er iets mee doen:

* `AddDays`
* `AddHours`
* `AddMilliseconds`
* `AddMinutes`
* `AddMonths`
* `AddSeconds`
* `AddTicks`
* `AddYears`

Een voorbeeld:

```csharp
DateTime timeNow= DateTime.Now;
DateTime nextWeek= timeNow.AddDays(7);
```

\(voorgaande kan ook in 1 lijn: `DateTime nextWeek= DateTime.Now.AddDays(7)`\)

Uiteraard mag je ook een bestaand object overschrijven met het resultaat van deze methoden:

```csharp
DateTime someTime= new DateTime(2019, 4, 1);
// much later...
someTime = someTime.AddYears(10);
Console.WriteLine(someTime);
```

## DateTime properties

**Properties** zijn een zeer uniek aspect van C\#. Ze geven toegang tot de data van een object, maar op een gecontroleerde manier. We zullen deze nog tot in den treure leren maken.

Enkele nuttige properties van `DateTime` zijn:

* `Date`
* `Day`
* `DayOfWeek`
* `DayOfYear`
* `Hour`
* `Millisecond`
* `Minute`
* `Month`
* `Second`
* `Ticks`
* `TimeOfDay`
* `Today`
* `UtcNow`
* `Year`

### Properties gebruiken

**Alle properties van DateTime zijn read-only**. Je kan een bestaande datum dus niet aanpassen \(maar je kan wel een nieuwe datum baseren op een bestaande datum\).

Een voorbeeld:

```csharp
DateTime moment = new DateTime(1999, 1, 13, 3, 57, 32, 11);
// Year gets 1999.
int year = moment.Year;
// Month gets 1 (January).
int month = moment.Month;
// Day gets 13.
int day = moment.Day;
// Hour gets 3.
int hour = moment.Hour;
// Minute gets 57.
int minute = moment.Minute;
// Second gets 32.
int second = moment.Second;
// Millisecond gets 11.
int millisecond = moment.Millisecond;
```

Uiteraard mag je ook deze properties gebruiken om direct naar het scherm te schrijven:

```csharp
DateTime now = DateTime.Now;
Console.WriteLine($"The current day is {now.DayOfWeek}");
```

## Datum en tijd formatteren

Je hebt een invloed op hoe `DateTime` objecten naar `string` worden opgezet. Omzetten naar een string is functionaliteit van het object. Je doet dit dus via een **objectmethode**. Deze gebruik je zoals de statische methoden van eerder, maar je roept ze op voor een specifiek object.

Je kan bepalen hoe de omzetting naar `string` moet gebeuren door extra _formatter syntax_ mee te geven. Dit zie je in volgende voorbeeld:

```csharp
DateTime now = DateTime.Now;
WriteLine(now.ToString("d")); // short date 
WriteLine(now.ToString("D")); // long date
WriteLine(now.ToString("F")); // full date and time
WriteLine(now.ToString("M")); // month and day
WriteLine(now.ToString("o")); // date en time separated by T and time zone at the end
WriteLine(now.ToString("R")); // RFC1123 date and time
WriteLine(now.ToString("t")); // short time
WriteLine(now.ToString("T")); // long time
WriteLine(now.ToString("Y")); // year and month
```

{% hint style="info" %}
### Custom format

Wil je nog meer controle over de output dan kan je ook zelf je formaat specifieren.

[Dit wordt hier volledig uit de doeken gedaan.](https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1)
{% endhint %}

### Localized time

De manier waarop `DateTime` objecten worden getoond \(via `ToString`\) is afhankelijk van de landinstellingen van je systeem. Soms wil je dit echter op een andere manier tonen. Je doet dit door mee te geven volgens welke **culture** de tijd en datum getoond moet worden.

Dit vereist dat je eerst een `CultureInfo` object aanmaakt en dat je dan meegeeft:

```csharp
DateTime now = DateTime.Now;
CultureInfo russianCI = new CultureInfo("ru-RU");
Console.WriteLine($"Current time in Russian style is: {now.ToString("F", russianCI)}");
```

{% hint style="info" %}
#### Culture names

Een lijst van alle cultures in .NET kan je [hier terugvinden](http://www.csharp-examples.net/culture-names/).

**Opgelet, enkel indien een specifieke culture op je computer staat geïnstalleerd zal je deze kunnen gebruiken.**
{% endhint %}

`CultureInfo` is een klasse waar je je misschien al iets minder bij kan voorstellen dan `DateTime`. Een `CultureInfo` stelt een aantal afspraken voor een bepaalde cultuur voor. De data is de combinatie van taal en regio. De functionaliteit bestaat er dan in om zaken zoals de munt, het gebruikte formaat voor datums,... in die taal en die regio te produceren. Ook hier geldt dus het black box principe: je kan code schrijven die bijvoorbeeld het juiste datumformaat voor Rusland gebruikt wanneer je zelf niet weet wat dat formaat is.

## Static method

Sommige methoden zijn `static` dat wil zeggen dat je ze enkel rechtstreeks op de klasse kunt aanroepen. Vaak zijn deze methoden hulpmethoden waar de individuele objecten niets aan hebben.

### Parsing time

Parsen laat toe dat je strings omzet naar `DateTime`. Dit is handig als je bijvoorbeeld de gebruiker via `ReadLine` tijd en datum wilt laten invoeren:

```csharp
string date_string = "8/11/2016"; //dit zou dus ook door gebruiker kunnen ingetypt zijn
DateTime dt = DateTime.Parse(date_string);
Console.WriteLine(dt);
```

Zoals je ziet roepen we `Parse` aan op `DateTime` en dus niet op een specifiek object. Dit is logisch omdat je geen bestaande datum nodig hebt om een nieuwe datum te parsen.

### IsLeapYear

Deze nuttige methode geeft een `bool` terug om aan te geven het meegegeven object eens schrikkeljaar is of niet:

```csharp
DateTime today = DateTime.Now;
bool isLeap = DateTime.IsLeapYear(today.Year);
if(isLeap == true) {
    Console.WriteLine("This year is a leap year");
}
```

Dit is logisch omdat je geen volledige bestaande datum nodig hebt. Je wil gewoon iets zeggen over een jaartal, terwijl een `DateTime` ook een dag, maand, uur,... heeft. Dus dit heeft niet veel te maken met een specifieke `DateTime`, maar heeft duidelijk wel met de klasse te maken.

{% hint style="info" %}
Af en toe is het een kwestie van smaak van de auteurs of een methode statisch is of niet. Maar meestal is er een duidelijke "beste" keuze.
{% endhint %}

## TimeSpan

Je kan DateTime objecten ook bij mekaar optellen en aftrekken. Deze bewerking geeft echter **geen** `DateTime` object terug, maar een `TimeSpan` object. Dit is een object dat dus aangeeft hoe groot het verschil is tussen de 2 `DateTime` objecten:

```csharp
DateTime today = DateTime.Today;
DateTime borodino_battle = new DateTime(1812, 9, 7);
TimeSpan diff = today - borodino_battle;
WriteLine("{0} days have passed since the Battle of Borodino.", diff.TotalDays);
```

## Oefening

### Klokje

Maak een applicatie die bestaat uit een oneindige loop. De loop zal iedere seconde pauzeren: `System.Threading.Thread.Sleep(1000);`. Vervolgens wordt het scherm leeg gemaakt en wordt de huidige tijd getoond. Merk op dat ENKEL de tijd wordt getoond, niet de datum.

### Verjaardag

Maak een applicatie die aan de gebruiker vraagt op welke dag hij jarig is. Toon vervolgens over hoeveel dagen z'n verjaardag dan zal zijn.

