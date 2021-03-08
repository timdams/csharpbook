# Afspraken code

Voor de graduaatsopleiding volgen we een reeks afspraken \(ook "conventies" genoemd\) die bepalen welke code wel en niet aanvaardbaar is. Wanneer een groep programmeurs dezelfde afspraken volgt, is het voor iedereen makkelijker code uit te wisselen.

Als je deze pagina voor de eerste keer ziet, zullen de meeste van deze afspraken je nog niet veel zeggen. Dat is logisch. We zullen je tijdens de les wijzen op de afspraken die horen bij een nieuw concept, maar hier heb je een handig overzicht:

## naamgeving

Onderstaande richtlijnen zijn gebaseerd op [deze algemeen aanvaarde richtlijnen](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md). We beperken ons tot de zaken die we tijdens de cursus zien.

| Soort data | Notatie | Enkelvoud? | Vorm | Default zichtbaarheid |
| :--- | :--- | :--- | :--- | :--- |
| Klasse | PascalCase | altijd | \[A-z\]+\[0-9\] | `public` |
| Methode | PascalCase | meervoud toegestaan | \[A-z\]+\[0-9\] | `public` |
| Argument | camelCase | meervoud toegestaan | \[A-z\]+\[0-9\] | niet van toepassing |
| Lokale variabele | camelCase | meervoud toegestaan | \[A-z\]+\[0-9\] | niet van toepassing |
| Constante | PascalCase | altijd | \[A-z\]+\[0-9\] | `public` |
| Veld | camelCase | meervoud toegestaan | \[A-z\]+\[0-9\] | `private` |
| Property | PascalCase | meervoud toegestaan | \[A-z\]+\[0-9\] | `public` |
| Enum type | PascalCase | altijd | \[A-z\]+ | `public` |
| Waarde enum | PascalCase | altijd | \[A-z\]+ | niet van toepassing |

* We kiezen namen in het Engels. Enkel tekst die aan de gebruiker getoond wordt, schrijven we in het Nederlands.
* Merk op dat het verschil tussen PascalCase en camelCase samenhangt met de default zichtbaarheid. Wanneer afgeweken wordt van de default zichtbaarheid, kan de conventie voor de notatie ook veranderen. Wij zullen ons in deze cursussen voor de eenvoud strikt aan de default zichtbaarheid houden.
* "meervoud toegestaan" betekent dat we iets noteren als een meervoud als de data ook meerdere objecten voorstelt. Bijvoorbeeld een lokale variabele met naam `studenten` en datatype `Student[]`, maar een lokale variabele `student` met datatype `Student`.
* We beginnen niet elke identifier voor een `private` member met een underscore. Sommige programmeurs doen dit wel, maar wij volgen één richtlijn.
* Namen van klassen voor custom exceptions eindigen op `Exception`.
* Vermijd afkortingen in namen.
  * Uitzondering: algemeen aanvaarde afkortingen zoals `ID`, `HTML`,...
  * Afkortingen van één of twee letters 
* Andere talen hebben soms andere conventies!

## codeerstijl

We baseren ons op [de afspraken van Microsoft](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions). Je hoeft deze conventies niet te lezen. Hieronder volgt een vereenvoudigd overzicht van de afspraken die aan bod kunnen komen in de cursus en enkele eigen conventies:

### `using` directieven

* Deze komen alleen vooraan in het bestand voor en worden steeds gevolgd door de declaratie van de namespace.

### namespaces

* In het eerste semester groeperen we al onze code in de namespace `Programmeren`, in het tweede semester in de namespace `ObjectgerichtProgrammeren`.

### een datatype per bestand

* Elk zelf gedefinieerd datatype \(klasse, struct, interface, enum type, later ook delegate\) plaatsen we in een afzonderlijk bestand met dezelfde naam als dat datatype.

### strings bouwen

* In de eerste twee lessen mag dit met behulp van `+`.
* Gebruik stringinterpolatie om kleine aantallen strings aan elkaar te hangen of data weer te geven in stringformaat.
* Gebruik een `StringBuilder` om strings aan elkaar te hangen in een lus.

### types declareren

* Gebruik steeds een expliciet, statisch type.
  * Dat wil zeggen: geen variabelen declareren als `var`. Dat doe je pas later.
  * Dat wil zeggen: geen variabelen declareren als `dynamic`. Dat doe je pas later.

### arrays

* Gebruik de kortste syntax voor arrays van literals, dus `string[] vowels1 = { "a", "e", "i", "o", "u" };` en niet `string[] vowels2 = new string[] { "a", "e", "i", "o", "u" };`.

### `static` members

* Plaats voor een `static` member altijd uitdrukkelijk de naam van de klasse waarin dat `static` member gedefinieerd is.
* Klassen die uitsluitend `static` members bevatten \("library classes"\) maken we ook `static` met de syntax `static class`.

### vergrendelen van data

* Klassen die niet bedoeld zijn om van over te erven maken we `final`.
* Als iets een constante is voor een bepaald programme, gebruiken we ook de access modifier `const`.

### algemeen

**We gebruiken alleen zaken die in de les aan bod zijn gekomen.** We zien geen lambda's, delegates, LINQ,... dus je gebruikt deze ook niet, zelfs als je ze al ergens anders gezien hebt.

