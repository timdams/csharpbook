# Labo

## SchoolAdmin project

Als je alles eerder mee hebt kunnen volgen, werk dan vanaf je recentste commit. Anders is er een modeloplossing voorzien waarvan je kan verder werken.

### `StudyProgram.GetOverview` en `Course.GetOverview` met `foreach` en `var`

Pas je ShowOverview methodes aan zodat er geen gebruik wordt gemaakt van een klassieke `for`, maar wel van een foreach. Gebruik `var` voor je iteratieveriabele. Om het gebruik van een index te vermijden, zal je de array van `string` ook moeten vervangen door een `List<string>`.

### Alle studenten in het systeem bijhouden

Voorzie de klasse Student van een statische property `Students`. Deze is van het type `List<Student>` en bevat altijd elke student die in het systeem aanwezig is. Dit gebeurt door bij de constructie van elk `Student`-object de lijst uit te breiden.

### Lijst van studenten

Vervang alle properties van `StudyProgram`, `Course` en `Student` van een array type naar een `List` type.

### Lijst van studenten, zonder dubbels

Verbeter je vernieuwde property `Students` van `StudyProgram` zodat er geen dubbels meer in de lijst met alle studenten in een studieprogramma voorkomen. Maak hierbij gebruik van de methode `Contains` van de klasse `List<T>`.

### Flexibelere punten

Het is op termijn niet houdbaar om elke student een veld voor het cijfer per vak te geven \(bijvoorbeeld `MarkCommunication`\). Niet alle studenten volgen dezelfde vakken en puur technisch is het geen goed ontwerp dat je de `Student` klasse moet aanpassen omdat er rekening gehouden moet worden met een nieuw object van de `Course` klasse.

Een betere optie bestaat erin de cijfers van een student bij te houden als een `Dictionary<Course,byte>`. Geef `Student` een `private` attribuut `Grades` van dit type. Voorzie ook een methode `SetGrade(Course course, byte grade)` om het cijfer voor een bepaald vak in te stellen. Op deze manier kan je voorkomen dat een cijfer hoger dan 20 wordt ingesteld.





