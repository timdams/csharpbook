# Smaakmaker OOP

## 1. Keuzemenuutje voor latere programma's

### Leerdoelen

* Code makkelijk toegankelijk maken 
* Vermijden heleboel piepkleine projectjes aan te maken 

### Functionele analyse

We gaan leren werken met grotere hoeveelheden code. We zullen voortaan niet meer al onze programma's in een apart project plaatsen, maar een keuzemenu gebruiken om daaruit alle andere programma's op te starten. 

### Technische analyse

Wanneer de gebruiker de `Main` van de klasse `Program` opstart, krijg je een keuzemenuutje. Hierop worden omschrijvingen getoond voor alle oefeningen die je al hebt, gevolgd door de unieke titel van de oefening in kwestie. Wanneer de gebruiker het getal intypt dat overeenstemt met een oefening, wordt de oefening opgestart.

Voorbeeldoutput:

`Wat wil je doen?   
1. Vormen tekenen (h8-vormen)   
2. Auto's laten rijden (h8-autos)   
3. Patiënten tonen (h8-patienten)   
4. Honden laten blaffen (h8-blaffende-honden)`

Wanneer de gebruiker een van deze opties kiest door het juiste getal in te typen, wordt dat programma opgestart. Als hij iets intypt dat niet kan worden uitgevoerd, komt er een boodschap `ongeldig getal!`. Wanneer je dit programma voor het eerst schrijft, kan je alleen nog maar ongeldige keuzes maken. 

## 2. Kennismaking OOP \(h8-vormen\)

Doorloop de instructies en uitleg op [ModernWays](https://www.modernways.be/myap/it/page/programming/dotnet%20core/excercise/Oefening%20OO%20code%20schrijven.html), maar let op volgende zaken:

* We werken niet in een map voor het vak "Programmeren 3", maar in een map "OOP" \(zoals de namespace die we hanteren, maar dat is geen regel die C\# oplegt\). 
* Indien je reeds een project met de naam OOP hebt, hoef je géén nieuw project aan te maken.
* Je gebruikt `ShapesBuilder.cs` in plaats van `Vormen.cs` en schrijft in het algemeen je code in het Engels.
* Je gebruikt de `namespace OOP.Geometry` in plaats van `Wiskunde.Meetkunde`.
* Als je van stap 6 naar stap 7 gaat, laat je de code voor de eigenschap `Color` staan. 
* Later zullen we deze code refactoren om nog meer gebruik te maken van objecten.

## 3. Voorbeeld met auto's \(h8-autos\)

### Doelstelling

* Kennismaking met OOP 

### Functionele analyse

We bouwen een simulatie van rijdende auto's. We voorzien deze van een kilometerteller, een huidige snelheid, een methode om de gaspedaal te simuleren en om de rem te simuleren. 

### Technische analyse

* We starten vanaf de klasse `Auto` uit de cursus \(maar noemen deze `Car`\). 
* We voegen eigenschappen `Odometer` en `Speed` toe, beide `doubles`. 
* We zorgen dat de snelheid nooit onder de 0km/u kan gaan en nooit boven de 120km/u door de eigenschap aan te passen. 
* We schrijven **klassikaal** een methode `Gas()` die de snelheid met 10km/u verhoogt en de auto verplaatst met zijn gemiddelde snelheid / 60 \(om één minuut rijden te simuleren\). De gemiddelde snelheid is het gemiddelde van de snelheid voor en na het verhogen. 
* We schrijven **individueel** een methode `Brake` die gelijkaardig werkt, maar die de snelheid met 10 km/u verlaagt. 
* We schrijven een methode `Main` 
  * die twee auto's aanmaakt 
  * de eerste vijf keer laat versnellen, drie keer laat remmen 
  * de tweede tien keer laat versnellen en een keer laat remmen 
  * in onderstaand formaat de snelheid en afgelegde weg afprint: `auto 1: km/u, afgelegde weg km  auto 2: km/u, afgelegde weg km`

## 4. Refactoren van deze code \(met allerlei arrays voor eigenschappen\) die een verslag produceert met info \(h8patienten\)

### Doelstelling

* Kennismaking met OOP
* Kennismaking met refactoring 
* Toepassing van encapsulatie 

### Functionele analyse

We hebben al wat code, maar we vinden deze moeilijk te onderhouden omdat we allerlei variabelen moeten onderhouden. We **refactoren** deze om zo een meer objectgericht en beter onderhoudbaar programma te bekomen. 

### Technische analyse

* Introduceer een klasse `Patient` 
* Vervang alle arrays door één array van objecten van de klasse `Patient` 
* Zorg dat het afgeprinte verslag er identiek uitziet aan het oorspronkelijke verslag

Code om van te starten:

```csharp
using System; 
 
namespace OOP {     
   class PatientProgram {         
      public static void Main() {             
         Console.WriteLine("Hoe veel patiënten zijn er?"); // aanmaken van de nodige variabelen
         int numberOfPatients = int.Parse(Console.ReadLine());
         string[] patientNames = new string[numberOfPatients];
         string[] patientGenders = new string[numberOfPatients];
         string[] patientLifestyles = new string[numberOfPatients];
         int[] patientDays = new int[numberOfPatients];
         int[] patientMonths = new int[numberOfPatients];
         int[] patientYears = new int[numberOfPatients];
        
         // invullen van de rijen
         for(int i = 0; i < numberOfPatients; i++) {
            patientNames[i] = Console.ReadLine();
            patientGenders[i] = Console.ReadLine();
            patientLifestyles[i] = Console.ReadLine();
            patientDays[i] = int.Parse(Console.ReadLine());
            patientMonths[i] = int.Parse(Console.ReadLine());
            patientYears[i] = int.Parse(Console.ReadLine());
         }
         
         // afprinten van het verslag
         // variabele in twee keer toegekend om code niet te breed te maken
         for(int i = 0; i < numberOfPatients; i++) {
            string info = $"{patientNames[i]} ({patientGenders[i]}, {patientLifestyles[i]})";
            info += $", geboren {patientDays[i]}-{patientMonths[i]}{patientYears[i]}";
            Console.WriteLine(info);
         }
      }
   }
}
```

## 5. Voorbeeld abstractie \(h8-honden\)

### Doelstelling

* Kennismaking met OOP Kennismaking met refactoring 
* Toepassing van abstractie 

### Functionele analyse

We krijgen een programma dat al objecten bevat, maar dit programma moet zelf nog veel rekening houden met hoe deze objecten in elkaar zitten. We refactoren het om zo een meer objectgericht en beter onderhoudbaar programma te bekomen. 

### Technische analyse

Je krijgt volgende twee files. De bestandsnamen volgen de afspraak:

```csharp
using System; 
 
namespace OOP {
   class BarkingProgram {
      // nu maken we onze randomgenerator *buiten* Main
      public static Random rng = new Random();
      public static void Main() {
         BarkingDog dog1 = new BarkingDog();
         BarkingDog dog2 = new BarkingDog();
         dog1.Name = "Swieber";
         dog2.Name = "Misty";
         dog1BreedNumber = rng.Next(0,3);
         dog2BreedNumber = rng.Next(0,3);
         if(dog1BreedNumber == 0) {
            dog1.Breed = "German Shepherd";
         }             
         else if(dog1BreedNumber == 1) {
            dog1.Breed = "Wolfspitz";
         }
         else {
            dog1.Breed = "Chihuahua";
         }
         if(dog2BreedNumber == 0) {
            dog2.Breed = "German Shepherd";
         }
         else if(dog2BreedNumber == 1) {
            dog2.Breed = "Wolfspitz";
         }
         else {
            dog2.Breed = "Chihuahua";
         }
         while(true) {
            Console.WriteLine(dog1.Bark());
            Console.WriteLine(dog2.Bark());
         }
      }
   }
} 
```

en

```csharp
namespace OOP {
    class BarkingDog {
        public string Name;
        public string Breed;
        
        public string Bark() {
            if(Breed == "German Shepherd") {
                return "RUFF!";
            }
            else if(Breed == "Wolfspitz") {
                return "AwawaWAF!";
            }
            else if(Breed == "Chihuahua") {
                return "ARF ARF ARF!";
            }
            // dit zou nooit mogen gebeuren
            // maar als de programmeur van Main iets fout doet, kan het wel
            else {
                return "Euhhh... Miauw?";
            }
        }
    }
} 
```

Volg hierbij volgende stappen: 

* Maak de random generator statisch onderdeel van de klasse `BarkingDog`. 
* Voeg volgende code toe binnen de klasse `BarkingDog`:

```csharp
public BarkingDog() {
    // bepaal hier met de randomgenerator het ras van de hond
    // stel hier `Breed` in
    // maak van `Breed` een eigenschap zoals we dat bij de geometrische vormen hebben gedaan
}
```

## 6. Controleren dat alles kan worden opgestart via keuzemenu.

## 7. Alles in Git plaatsen en delen met de lector. Eerst controleren dat juiste files genegeerd worden met `git status -u`!

