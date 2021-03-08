# Oefeningen

## Oefening: H2-string-interpolation

### Leerdoelen

* gebruik van string interpolation

### Functionele analyse

Oefening H1-maaltafels en H1-ruimte dienen we te herschrijven volgens de principes van string interpolation.

### Technische analyse

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

Zie oefening H1-maaltafels en H1-ruimte.

### Technische hulp

#### Programmaverloop

Pas string interpolatie mbv `$` \(manier 2\) toe.

#### Testscenario's

* Zie oefening H1-maaltafels en H1-ruimte.

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

## Oefening: H2-systeem-informatie

### Leerdoelen

* gebruik van string interpolation
* gebruik van `Environment` class

### Functionele analyse

Maak een applicatie die de belangrijkste computer-informatie \(geheugen, etc\) aan de gebruiker toont.

### Technische analyse

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Uw computer heeft een 64-bit besturingssysteem: True
De naam van uw pc is: LAPTOP
Uw pc heeft 4 processorkernen.
ikke is uw gebruikersnaam.
Je gebruikt 11 megabytes aan geheugen
```

### Technische hulp

#### Programmaverloop

Pas string interpolatie mbv `$` \(manier 2\) toe.  
De computerinformatie kan je verkrijgen mbv de Environment-klasse. Hier enkele voorbeelden \(kijk zelf of er nog nuttige properties over je computer in staan en voorzie deze ook binnen jouw code\):

```csharp
bool is64bit = Environment.Is64BitOperatingSystem;
string pcName = Environment.MachineName;
int procCount = Environment.ProcessorCount;
string userName = Environment.UserName;
long memory = Environment.WorkingSet; //zal ongeveer 11 MB teruggeven.
```

> **WorkingSet** geeft terug hoeveel geheugen het programma van windows toegewezen krijgt. Als je dus op 'run' klikt om je code te runnen dan zal dit programma geheugen krijgen en via WorkingSet kan het programma dus zelf zien hoeveel het krijgt. \(wat een vreemde lange zin\).

Zoals je ziet wordt het geheugen in bytes teruggegeven. Zorg ervoor dat het geheugen steeds in mega of gigabytes op het scherm wordt getoond.

**Formatteer de informatie met behulp van de $-notatie zodat deze deftig getoond worden en de gebruiker snel de belangrijke informatie over z'n systeem te zien krijgt.**

#### Testscenario's

* wat gebeurt er wanneer je het datatype string zou wijzigen in int?

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

## Oefening: H2-weerstandberekenaar-deel1

### Leerdoelen

* gebruik van math class

### Functionele analyse

Stel dat je in het labo een weerstand vastneemt en je kent de kleurcodes van de streepjes wel, maar niet hoe je die kunt omzetten naar de effectieve weerstandswaarde. In dit programma kunnen we de gebruiker helpen.

![](../../.gitbook/assets/colors.jpg)

\(Bron afbeelding: [https://www.esdsite.nl](https://www.esdsite.nl)\)

### Technische analyse

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Geef de waarde (uitgedrukt in een getal van 0 tot 9) van de eerste ring: 2
Geef de waarde (uitgedrukt in een getal van 0 tot 9) van de tweede ring: 2
Geef de waarde (uitgedrukt in een getal van -2 tot 7) van de derde ring (exponent): 2
Resultaat is 2200 Ohm, ofwel 22x100.
```

### Technische hulp

#### Programmaverloop

Maak een programma dat de weerstandwaarde berekent gebaseerd op:

* Ring 1: die de tientallen voorstelt
* Ring 2: die de eenheden voorstel
* Ring 3: die de exponent \(10 tot de macht\) voorstelt. \(tip:`Math.Pow(10,ring3`\)\)

Gebruik drie variabelen van het type `int`. \(we veronderstellen dus dat de gebruiker de kleurcode heeft omgezet naar een getal en dat toewijst aan de variabele\)

Test dat je "formule/berekening" klopt om gebaseerd op 2 \(of 3\) ringen de weerstandswaarde te berekenen.

#### Testscenario's

* wat gebeurt er wanneer je een hoger getal dan 9 zou invoeren?

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

## Oefening: H2-weerstandberekenaar-deel2

### Leerdoelen

* gebruik van UNICODE

### Functionele analyse

Zie deel 1.

### Technische hulp

#### Programmaverloop

Zie deel 1 en plaats het geheel in een mooie UNICODE-tabel.

Hier enkele nuttige tekens:

```text
╔═══════════════╦═══════════════╗
║ 
╟───────────────╫───────────────╢
║ 
╚═══════════════╩═══════════════╝
```

Gebruik $-string interpolatie om de informatie in de tabel te tonen zodat je volgende uitvoer kunt genereren: ![](../../.gitbook/assets/tabel.png)

of:

![](../../.gitbook/assets/tabel2.png)

#### Testscenario's

* wat gebeurt er wanneer je een waarde van circle 1, 2 of 3 uit meer dan twee cijfers bestaat?

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

## Oefening: H2-shell-starter

### Leerdoelen

* gebruik van `Process.Start()`
* verwerken van uitvoer

### Functionele analyse

Je kan de output van een `Process.Start()` programma naar je console scherm sturen. Dit vereist wat meer code. Volgende voorbeeld zal de output van het commando `ipconfig /all` op het scherm tonen:

```csharp
System.Diagnostics.Process process = new System.Diagnostics.Process();
process.StartInfo.FileName = "ipconfig";
process.StartInfo.Arguments = "/all"; 
process.StartInfo.UseShellExecute = false;
process.StartInfo.RedirectStandardOutput = true;
process.StartInfo.RedirectStandardError = true;
process.Start(); //start process

// Read the output (or the error)
string output = process.StandardOutput.ReadToEnd();
Console.WriteLine(output);
string err = process.StandardError.ReadToEnd();
Console.WriteLine(err);
//Continue
Console.WriteLine("Klaar");
```

Onder macOS heb je een ander commando nodig. Gebruik daar `"ifconfig"` voor het \(uitvoerbaar\) bestand en geef een lege string mee voor de argumenten.

### Technische hulp

#### Programmaverloop

Maak enkele kleine C\# programma's die bepaalde shell-commando's zullen uitvoeren en die de uitvoer in hoofdletters weergeven in plaats van in de gewone vorm. Enkele nuttige shell-commando's in de netwerk-sfeer zijn bijvoorbeeld:

```text
hostname
arp -a
getmac (enkel onder Windows)
nslookup google.com
```

#### Testscenario's

* Probeer van bovenstaande programma's al die, die compatibel zijn met je besturingssysteem.

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

