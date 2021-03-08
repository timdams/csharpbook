# Uitbreidingsoefeningen

Volgende oefeningen zijn al iets stevigers. Ze gebruiken concepten die nog niet aan bod gekomen zijn in de cursus en je wordt niet verondersteld ze te kunnen maken aan het begin van het semester. Je kan ze wel bekijken als je eerder al geprogrammeerd hebt of wanneer je aan het studeren bent voor het examen.

## Oefening: H2-systeem-informatie-pro

### Leerdoelen

* gebruik van string interpolation
* gebruik van `System.IO`

### Functionele analyse

Je moet informatie over de harde schijven op je systeem weergeven.

### Technische analyse

#### UI

console applicatie

#### voorbeeldinteractie\(s\)

```text
Vrije ruimte op jouw c-schijf: 10803744768
Totale ruimte van jouw c-schijf: 159671906304

********************************************************************************
Geef met nummer 1 t/m 2 aan over welke harde schijf van jouw pc je info wenst: 1
De vrije ruimte van C:\ is 108 Gb
```

### Technische hulp

#### Programmaverloop

Ook informatie over de harde schijven kan je verkrijgen \(in bits\). Dit vereist wel dat je bovenaan je programma volgende lijn bijschrijft: `using System.IO`.

Vervolgens kan je in je programma schrijven:

```csharp
long cDriveInBytes = DriveInfo.GetDrives()[0].AvailableFreeSpace;  
long totalSize = DriveInfo.GetDrives()[0].TotalSize;
```

De lijn met `using` is om aan te geven dat we iets uit de `System.IO` bibliotheek nodig hebben, namelijk `DriveInfo`. Schrijven we dat niet dan moeten we in onze code DriveInfo aanroepen met z'n volledige path: `System.IO.DriveInfo....`

De 0 tussen rechte haakjes is de index van welke schijf je informatie wenst. 0 is de eerste harde schijf, 1 de tweede, enzovoort. \(Ter info: dit zijn arrays, zie later\)

Vraag aan de gebruiker het nummer van de harde schijf waar meer informatie over moet getoond worden.

Opgelet: sta toe dat de gebruiker 1 voor de eerste harde schijf mag gebruiken, 2 voor de tweede, enzovoort. Je zal dus in code nog manueel 1 moeten aftrekken van de invoer van de gebruiken. Bv:

```csharp
int input= Convert.ToInt32(Console.ReadLine()) - 1 ;
long totalSize = DriveInfo.GetDrives()[input].TotalSize;
```

#### Testscenario's

* wat gebeurt er wanneer je het datatype int zou wijzigen in string?

### Ondersteunend materiaal

Hou het voorlopig op de cursus.

## Oefening: H2-weerstandsberekendaar-deel3

Deze bouwt voort op H2-weerstandsberekendaar-deel2. Kan je afhankelijk van de ringwaarde het getal in de tabel in de juiste kleur zetten conform de weerstandskleuren? \(tip: je zal `Write` en `if` moeten leren gebruiken\)

