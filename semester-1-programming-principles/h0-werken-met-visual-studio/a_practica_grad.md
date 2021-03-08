# Oefeningen

## Basisconcept

### Methode maken

De methode `SayHello` maken.  
We hebben al gezien dat alleen de statements die in de `Main` methode staan worden uitgevoerd. We gaan in deze cursus heel wat code schrijven en dus is het geen goed idee al die code in de `Main` te plaatsen of voor elke voorbeeld of oefening, die we gaan maken, een eigen project te creëren. Vandaar dat we vanaf de eerste les met methoden leren werken. Later in de cursus gaan we dieper in op methoden \(functies\) maar nu zien we al één van de belangrijkste voordelen van het gebruik van methoden, namelijk de code ordenen in kleinere stukjes.

![SayHello methode](../../.gitbook/assets/image%20%2829%29.png)

1. We halen dus het statement uit de `Main` methode en plaatsen die in een eigen methode. Een methode moet in een klasse staan. We plaatsen voorlopig de `SayHello` methode in dezelfde klasse als de `Main` methode, namelijk de `Program` klasse.
2. We roepen de `SayHello` methode op in de `Main` methode.
3. In de toekomst zullen we sterk verwante methoden bijhouden in één klasse, maar we zullen verschillende klassen maken voor groepjes oefeningen.

### Nog een methode maken

De `Say` methode maken en oproepen.

1. De methode is `static` omdat we alleen met klassen werken en niet met objecten of exemplaren van klassen. Met objecten werken we pas later.
2. Het gegevenstype van de methode is `void` omdat die methode niets retourneert. Deze methode toont een tekst op het scherm.
3. De statements in een methode staan tussen accolades { }. Dat heet een codeblok.
4. Het statement die de tekst weergeeft in de console. Een statement eindigt met een ; \(puntkomma\)!
5. We roepen de eerste keer de `Say` methode op in de `Main` methode.

### **Een console programma met invoer en uitvoer**

Open het console-project met de naam BeginnenMetCSharp dat we in de vorige les gemaakt hebben.  
We gaan een methode toevoegen die goedendag wenst aan de persoon die zijn naam heeft ingetypt:

![Visual Studio Editor Code methode ZegGoedendag](../../.gitbook/assets/image%20%2852%29.png)

1. Open het Program.cs bestand in de editor van de IDE.
2. de methode is `static` omdat we in deze cursus alleen met klassen werken en niet met objecten \(OO\)
3. de methode geeft geen waarde terug en is dus van het gegevenstype `void`;
4. de naam van de methode is `ZegGoedendag` \(de naam van de methode in pascalnotatie, en de naam is in het Nederlands om duidelijk te maken dat we naam van een methode zelf kiezen; later in de cursus maken we de afspraak dat we namen \(identifiers\) in het Engels schrijven, een afspraak die in de meeste bedrijven geldt\);
5. de methode heeft geen parameters, dus staan er twee ronde haken met niets tussen;
6. we openen en sluiten de accolades om een codeblok te maken;
7. we schrijven een label in de console "Hoe heet je?"; Tekst, die van het gegevenstype string is, wordt tussen dubbele aanhalingstekens geplaatst;
8. we geven de mogelijkheid aan de gebruiker om zijn naam in te typen;
9. de ingetypte naam stoppen we in een variabele \(in C\# spreekt men van een veld\):
   1. de naam van de variabele schrijven we in camelcasenotatie;
   2. de ingetypte naam is tekst en dus geven we op dat het gegevenstype van de variabele string is;
10. we schrijven de naam die in de variabele invoer is opgeslagen naar de console;
11. gevolgd door de tekst ", ik wens je een goedendag!";
12. spaties zijn ook tekens die op scherm moeten komen \(ook al zien we ze niet\) en je dient dus binnen de dubbeke aanhalingstekens spaties toe te voegen. Indien je deze erbuiten plaats dan heeft dit geen effect. C\# negeert alle spaties die niet tussen aanhalingstekens staan.
13. Roep de methode `ZegGoedenDag` op in de `Main` methode van de `Program` klasse.
14. We gaan het programma uitproberen, selecter **Debug** en druk op het groene pijltje bovenaan.
15. En dat is het resultaat:

![ZegGoedendag runt in de console](../../.gitbook/assets/image%20%2858%29.png)

### Debuggen

Voer je programma uit en probeer het met verschillende namen als invoer.

## Oefening: H1-MijnEersteProgramma

### **Leerdoelen**

* een eigen programma kunnen uitvoeren
* input en output via `Console.ReadLine` en `Console.WriteLine`

### **Functionele analyse**

Binnen een zgn. dos-box wordt een titel weergegeven, nl. dit is mijn eerste c\# programma.  
Vervolgens wordt gevraagd je naam te noteren.  
Wanneer je je naam hebt genoteerd en op enter hebt gedrukt, verschijnt de tekst “hallo \[en je ingegeven naam\]”.

### **Technische analyse**

#### voorbeeldinteractie\(s\)

![MijnEersteProgramma runt in de console](../../.gitbook/assets/image%20%2856%29.png)

### Technische hulp

maak een methode met de naam `MijnEersteProgramma`

#### Programmaverloop

Wat het lezen en schrijven van tekst betreft moet gebruik gemaakt worden `Console.WriteLine` en `Console.ReadLine`.

#### Testscenario's

* Probeer meer dan 200 tekens in te voeren
* Probeer geen tekst in te voeren

## Oefening: H1-MijnEerste**Klasse**

### **Leerdoelen**

Een klasse maken om de oefeningen en opdrachten van deze les in onder te brengen.

### Functionele analyse

Eén van de voordelen van het gebruik van klassen bestaat erin dat je je code kan ordenen per thema. We gaan dit hier toepassen en een klasse maken voor alle oefeningen en opdrachten van één of meerdere hoofdstukken:

### Technische analyse

### Technische hulp

1. We beginnen met een klassenbestand **toe te voegen**:

![Visual Studio Een klassenbestand toevoegen](../../.gitbook/assets/image%20%2850%29.png)

* rechtermuisklik op de naam van het project in de verkenner;
* selecteer **add**;
* selecteer **class**;

2. Een klassenbestand **maken**:

![Visual Studio Een klassenbestand maken](../../.gitbook/assets/image%20%2855%29.png)

* we kiezen een **Visual C\# item**;
* we zelecteren een **Class**;
* we geven de naam de van de les waarin de oefening staat aan de klasse; we volgen de richtlijnen van .NET en geven er een lange betekenisvolle naam aan: EenProgrammaSchrijvenInCSharp;

3. Open Program.cs in de editor en kopiëer de methode `ZegGoedendag` naar het bestand EenProgrammaSchrijvenInCSharp.cs. 

Het belangrijkse is hier dat je de methode moet `public` maken. Je moet die immers kunnen oproepen vanuit een andere klasse. Zoals je hieronder zal zien, zullen we die methode oproepen vanuit de `Program` klasse:

![Visual Studio De methode ZegGoedendag verplaatsen naar eigen klasse](../../.gitbook/assets/image%20%2849%29.png)

## Oefening: H1-MijnEerste**KlasseOproep**

### **Leerdoelen**

Klasse gebruiken.

### Functionele analyse

De methode oproepen in de `Main` methode van `Program` klasse.

### Technische analyse

### Technische hulp

Open Program.cs in de editor. Vermits we de `ZegGoedendag` methode naar een andere klasse verplaatst hebben moeten we in de `Main` methode van de `Program` klasse opgeven in welke klasse zich de `ZegGoedendag` methode zich bevindt. 

Dat doen we door de naam van de klasse ervoor te plaatsen, gevolgd door een punt:

![Visual Studio Roep ZegGoedendag op in Program](../../.gitbook/assets/image%20%2848%29.png)

## Oefening: H1-rommelzin

### Leerdoelen

* een eigen programma kunnen uitvoeren
* input en output via `Console.ReadLine` en `Console.WriteLine`
* de computer leren zien als "domme verwerker"

### Functionele analyse

Dit programma verwerkt tekst die door de gebruiker wordt ingetypt. Het print nieuwe berichten die deze tekst bevatten uit. Het print niet de berichten die je verwacht: het zal de antwoorden door elkaar halen en je favoriete kleur tonen wanneer het beweert je favoriete eten te tonen, enzovoort. De verbanden worden duidelijk uit de voorbeeldinteractie.

### Technische analyse

#### Organisatie van de code

Schrijf dit programma als een methode met de naam `Rommelzin` binnen de klasse `EenProgrammaSchrijvenInCSharp`. Test uit door deze methode op te roepen binnen de `Main` methode.

#### voorbeeldinteractie\(s\)

```text
Wat is je favoriete kleur?
> blauw
Wat is je favoriete eten?
> spaghetti
Wat is je favoriete auto?
> Toyota Aygo
Wat is je favoriete film?
> Robocop 2
Wat is je favoriete boek?
> The Gone-Away World
Je favoriete kleur is spaghetti. Je eet graag Toyota Aygo. Je lievelingsfilm is The Gone-Away World en je favoriete boek is Robocop 2.
```

### Technische hulp

#### Programmaverloop

Per regel die getoond wordt op het scherm, maak je gebruik van `Console.WriteLine`. Per regel die je zelf intypt, maak je gebruik van `Console.ReadLine`. Zorg zelf voor de juiste ondersteunende code.

#### Testscenario's

* Test uit met een héél lang stuk tekst \(meer dan 200 tekens\) voor je favoriete kleur.
* Test uit met tekst met internationale karakters, bijvoorbeeld de ç.
* Ga na wat er gebeurt als je een lege regel invoert, dus als je meteen op ENTER duwt wanneer gevraagd wordt om invoer.

## Oefening: H1-gekleurde-rommelzin

### Leerdoelen

* de kleur van tekst in de console aanpassen
* herhaling van de leerdoelen uit H1-rommelzin

### Functionele analyse

Dit programma werkt net als H1-rommelzin, maar elke regel die aan de gebruiker wordt getoond, krijgt een andere kleur. De namen van de kleuren die je gebruikt \(in deze volgorde\) zijn:

1. `DarkGreen`
2. `DarkRed`
3. `DarkYellow`
4. `Blue`
5. `Cyan`
6. `Red`

### Technische analyse

#### Organisatie van de code

Schrijf deze oefening als een nieuwe methode met de naam `GekleurdeRommelzin` in de klasse `EenProgrammaSchrijvenInCSharp`. Test uit door deze methode op te roepen binnen de `Main` methode.

#### voorbeeldinteractie\(s\)

![De eerste regel behoort niet tot het programma. De rest moet er bij jou hetzelfde uitzien.](../../.gitbook/assets/gekleurde-rommelzin.png)

### Technische hulp

#### Programmaverloop

Voor elke regel die in kleur getoond wordt, wissel je de voorgrondkleur. Op de juiste plaatsen in de code herstel je de oorspronkelijke kleuren van de terminal.

#### Testscenario's

* Test opnieuw uit met een kleur, maaltijd, auto, film en boek naar keuze.

