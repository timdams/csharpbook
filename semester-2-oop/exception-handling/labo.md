# Labo

## Opstarten

Om ons gebruik van exceptions te kaderen, breiden we eerst het SchoolAdmin project verder uit. We starten vanaf [de modeloplossing](https://youtu.be/wuZz0RBksEA) van de eerste tussentijdse evaluatie. Concreet doen we volgende zaken:

1. toevoegen functionaliteit om personen uit een CSV-file in te lezen
2. exception handling toevoegen voor het geval de file niet bestaat
3. exception handling toevoegen voor het geval de eigenschappen van aangemaakte objecten niet geldig zijn
4. de `Equals` methode van `Person` overschrijven om dubbels te kunnen herkennen
5. een waarschuwing bieden bij dubbele data

Dit wordt allemaal toegelicht in [deze kennisclip](https://youtu.be/k7t480u7hfs).

## Uitbreidingen

### Dubbels overslaan

Je kan dubbele data over personen overslaan zonder je programma te laten crashen. Wij zullen hier exception handling bij gebruiken. Meerbepaald zullen we een nieuw soort exception maken, namelijk een `DuplicateDataException`. Definieer zelf deze exception zoals uitgelegd op [deze pagina](zelf-uitzonderingen-maken.md#een-eigen-exception-ontwerpen). De exception heeft niet veel speciale eigenschappen nodig, je moet ze gewoon kunnen gooien en voorzien van een boodschap.

* vooraleer de persoon wordt toegevoegd aan de lijst met personen, controleer je of hij al voorkomt in de lijst \(tip: gebruik het sleutelwoordje `this`\)
* indien dit het geval is: gooi een `DuplicateDataException` met het bericht dat een persoon met die naam en leeftijd al aanwezig is in het systeem. Let op: dit is het bericht van de exception, dit is geen tekst die op het scherm wordt geprint.
* voorzie zelf de nodige structuur om te zorgen dat het systeem niet crasht in geval van een DuplicateDataException, maar gewoon het bericht van de nieuwe exception afprint.

### Nog potentiële problemen

Voorzie in je eigen file Personen.txt een regel waarin volgende regels voorkomen:

* `3` \(dus een leeftijd zonder naam\)
* `Emilie` \(dus een naam zonder leeftijd\)
* `17; Geraldo` \(dus in de omgekeerde volgorde\)
* \(een blanco regel\)

Probeer de file nu in te lezen. Je programma zal crashen. Voorzie de nodige extra exception handling om te melden wat er is fout gelopen. Zoals eerder worden deze foutieve records overgeslagen, maar wordt er een waarschuwing getoond.

### Cursussen inlezen uit CSV

Breid de klasse `Course` uit met een statische lijst van `Course` objecten en een `ReadFromCSV` methode. Het CSV-formaat voor cursussen is `Titel;Studiepunten`. Cursussen worden aangemaakt met een lege lijst studenten \(niet `null`, maar een lege lijst\). Je eigen `ReadFromCSV`-methode moet voorzien zijn op alle soorten exceptions waarop die van `Person` voorzien is, inclusief dubbele data. Cursussen zijn identiek als ze dezelfde titel en aantal studiepunten hebben. Ook hier geldt dat je een waarschuwing toont en naar het volgende record gaat als er een foutief record aanwezig is in de data.

