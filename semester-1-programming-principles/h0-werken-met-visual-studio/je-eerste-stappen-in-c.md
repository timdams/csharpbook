---
description: >-
  In dit onderdeel analyseren we het standaard programma dat Visual Code voor
  ons in het bestand program.cs gemaakt heeft. Verder zetten we de eerste
  stappen in het leren programmeren.
---

# Je eerste stappen in C\#

{% hint style="success" %}
[Kennisclip voor deze inhoud](https://youtu.be/Qzd8K96mRj4)
{% endhint %}

## Doelstelling

1. weet je hoe de basisstructuur van een C\# programma in elkaar steekt
2. ken je de basiselementen van het programmeren:
   1. **declaratie**: gegevens en variabelen
   2. **statement**: één instructie
   3. **functie** of **methode**: een reeks instructies om één specifiek doel te realiseren, bijvoorbeeld voor het bereken van de oppervlakte van een cirkel In Object Oriented jargon spreekt men van een methode en vermits C\# een OO taal is, zullen we in deze cursus verder het woord methode gebruiken. Als jullie JavaScript leren ga je het niet over een methode hebben maar over een functie omdat JavaScript geen strikte OO taal is.

## De basisstructuur van een C\# programma

### **Schema**

![orde in .NET](../../.gitbook/assets/image%20%2842%29.png)

### **Detail**

![Basisstructuur van een CSharp programma](../../.gitbook/assets/image%20%2832%29.png)

### Beschrijving van bovenstaande basisstructuur

1. **sleutelwoorden** \(keywords\) In de editor zie je dat sommige woorden in blauw worden weergegeven. Visual Studio geeft alle sleutelwoorden in het blauw weergeven. Sleutelwoorden zijn vooraf gedefinieerde, gereserveerde woorden die een speciale betekenis hebben voor de C\# compiler. Je kan ze niet als namen \(identifiers\) in je programma gebruiken. Een lijst van alle gereserveerde sleutelwoorden vind je op [C\# Keywords](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/). 
2. **bibliotheek** een bibliotheek \(Engels: **library**\) is een verzameling code \(namespaces, klassen en methoden\) die je kan gebruiken zonder dat je zelf die code moet schrijven voor bepaalde algemene bewerkingen. Je kan simpelweg de methode aanroepen die zich in de bibliotheek bevindt. In het voorbeeld hierboven gebruiken. 
3. **namespace** Letterlijk vertaald is dat een naamruimte. Deze structuur biedt de mogelijkheid om namen van o.a. klassen en methode - in programmeerjargon spreekt men van identifiers - in een naamspace te groeperen. Je moet er dan enkel voor zorgen dat deze namen uniek zijn binnen de namespace. De regels en afspraken voor het geven van namen aan namespaces vind je op [Names of Namespaces](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-namespaces).  Je kan een namespace vergelijken met een familienaam. Binnen de 'naamruimte' van een familienaam moeten de voornamen uniek zijn. Maar dezelfde voornaamen kunnen in verschillende familienamen gebruikt worden: De namespace in het voorbeeld hierboven is `BeginnenMetCSharp`. Visual Studio gebruikt de naam van het project voor het benoemen van deze namespace.  
4. **klasse** Gegevens \(data\) en algoritmes \(programma's\) worden ondergebracht in klassen. Dit maakt een programma overzichtelijker. In het tweede semester gaan we dieper in op klassen en objecten \('exemplaren' van een klasse\). In het eerste semester gebruiken we klassen alleen om code te ordenen.  De klassenaam in het voorbeeld hierboven is `Program`. Deze klassenaam wordt door Visual Studio standaard gebruikt wanneer je een nieuw project aanmaakt.  De regels en afspraken voor het geven van namen aan klassen vind je op [Names of Classes, Structs, and Interfaces](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-classes-structs-and-interfaces). 
5. **methode** In C\# staat code altijd in een methode. Je kan geen statement schrijven zonder eerst een methode te hebben gemaakt. Hier moeten enkele zaken worden opgemerkt: 
   1. **naamgeving** De namen van methoden worden in pascalnotatie geschreven, meer info op [Names of Methods](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-type-members#names-of-methods). 
   2. **static** Het sleutelwoord static is een _modifier_. Met een modifier geven we aan hoe we de methode willen gebruiken. Vermits we in het eerste semester klassen enkel en alleen gaan gebruiken om code te ordenen en niet om objecten te maken en te gebruiken, gaan we meestal de modifier static vóór de methode naam plaatsen, zoals in het voorbeeld hierboven. Met static bedoelen we dan deze methode tot de klasse behoort en niet tot de objecten die op basis van die klasse worden gemaakt. 
   3. **void** In C\# spreken we van methoden. Maar een methode is eigenlijk een functie. Een functie retourneert meestal een waarde. Is dat niet zo moet je aangegeven dat de methode geen waarde retourneert door er void vóór de plaatsen zoals de Main methode in het voorbeeld hierboven. 
   4. **Main** Dit is de naam van de methode. De moeder aller methoden in een C\# programma draagt de naam Main methode. Elk programma dat je ooit gaat schrijven in C\# moet een Main methode bevatten. Het is bovendien de enige methode die zal worden uitgevoerd als je het programma runt. Alle andere methode worden niet automatisch uitgevoerd. Wil je een bepaalde methode laten uitvoeren moet je die in de Main methode oproepen. 
   5. **\(string\[\] args\)** Na de naam staan twee ronde haakjes. Tussen de ronde haken kan je _parameters_ plaatsen. In deze parameters worden de argumenten die bij het oproepen van de methode worden meegegeven opgevangen. In het voorbeeld hierboven is dat string\[\] args. Dat wil zeggen dat je de Main methode kan oproepen en een reeks van argumenten kan meegeven. We komen hier later op terug. Je mag deze parameter gerust verwijderen vermits we pas later leren werken array's. De Main methode hierboven bevat slechts 1 statement. 
6. **statement**  
   Er is maar 1 statement. In het statement roepen we de `WriteLine` methode op die in de klasse `Console` staat. De klasse `Console` staat in de namespace met de naam `System`. Bovenaan, op regel 1, geven we aan dat we die bibliotheek in ons programma zullen gebruiken met het statement `using System;`  
  
   Het statement ziet er zo uit:

   ```text
   Console.WriteLine("Hello World!");
   ```

   Het eerste wat we opmerken is dat een **statement eindigt met een ;** \(een puntkomma\).  
   In dit statement roepen we de methode `WriteLine` op en geven als _argument_ de tekst "Hello World" mee. De methode `WriteLine` beschikt over 1 parameter die deze tekst aanneemt en voor ons in de console zal tonen.

{% hint style="danger" %}
**Let erop dat je iedere 'zin' eindigt met een puntkomma.**
{% endhint %}

{% hint style="danger" %}
### Moet ik niets bewaren?

Neen. Telkens je op de groene "build en run" knop duwt worden al je aanpassingen bewaard. Trouwens: **Kies nooit voor "save as..."**!!!! \(Als je dit toch doet, zal het zal aardig wat problemen in je project veroorzaken!\)
{% endhint %}



