## Bestaande methoden en bibliotheken

Je herkent een methode aan de ronde haakjes na de methodenaam. Je hebt dus reeds een aantal methoden gebruikt zonder dat je het wist, denk maar aan ``WriteLine()``, ``ReadLine()`` en ``Convert.ToInt32()``.

Dit zijn dus alle 3 methoden: stukken code die een specifieke taak uitvoeren.

Sommige methoden, zoals ``WriteLine()``, vereisen dat je een aantal parameters meegeeft. De parameters dien je tussen de ronde haakjes te zetten. Hierbij is het uiterst belangrijk dat je de volgorde respecteert die de ontwikkelaar van de methode heeft gebruikt. 

Indien je niet weet wat deze volgorde is kan je altijd Intellisense gebruiken. Typ gewoon de methode in je code en stop met typen na het eerste ronde haakje, vervolgens verschijnen alle mogelijke manieren waarop je deze methoden kan oproepen (met de pijltjes kan je alle mogelijke manieren bekijken)


![Dit soort popups bevat een schat aan informatie.](../assets/4_methoden/methoden1.png)

We zien telkens duidelijke de methode-signatuur: het return type (in dit geval ``void`` gevolgd door de naam van de methode en dan de parameters en hun datatype(s). Zoals al herhaardelijk aangehaald: de naam van de parameters doet er niet toe! 

Merk trouwens op dat je de WriteLine-methode ook mag aanroepen zonder parameters, dit zal resulteren in een lege lijn in de console.

Met behulp van de F1-toets kunnen meer info over de methode in kwestie tonen. Hiervoor dien je je cursor op de Methode in je code te plaatsen, en vervolgens op F1 te drukken. Je komt dan op de online documentatie van de methode waar erg veel informatie terug te vinden is over het gebruik ervan. Scroll naar de *overload list* , daar zien we de verschillende manieren waarop je de methode in kwestie kan aanroepen (het concept *overloaden* bespreken we in de volgende sectie). Je kan vervolgens op iedere methode klikken voor meer informatie en een codevoorbeeld.

<!---NOBOOKSTART--->
<!--- {width:75%} --->
![De online documentatie voor WriteLine: laat je niet overdonderen door dit soort pagina's. Er staat op deze pagina bijna niets dat niet in dit boek werd, of zal worden, behandeld](../assets/4_methoden/methoden2.png)
<!---NOBOOKEND--->


### Intellisense
*Wat kan deze .NET bibliotheek eigenlijk?* is een veelgestelde vraag. Zeker wanneer je de basis van C# onder knie hebt en je stilletjes aan met bestaande .NET bibliotheken wilt gaan werken. Wat volgt is een essentieel onderdeel van VS dat veel gevloek en tandengeknars zal voorkomen.

De online documentatie van VS is zeer uitgebreid en dankzij **IntelliSense** krijg je ook aardig wat informatie tijdens het typen van de code zelf. IntelliSense is de achterliggende technologie in VS die ervoor zorgt dat je minder moet typen. Als een soort assistent probeert IntelliSense een beetje te voorspellen wat je gaat typen en je daar mee helpen. 

<!---{pagebreak} --->

Type eens het volgende in:

```java
System.Console.
```

Wacht nu even en er zal na het punt (``.``) een lijst komen van methoden en fields die beschikbaar zijn. Dit is IntelliSense in actie. Als er niets verschijnt of iets at je niet had verwacht, dan is de kans groot dat er een (schrijf)fout staat in hetgene je net schreef. 

Je kan door deze lijst met de muis doorheen scrollen en zo zien welke methoden allemaal bij de ``Console`` bibliotheek horen. Indien gewenst kan je vervolgens de gewenste methode selecteren en op spatie duwen zodat deze in je code verschijnt.


![De icoontjes geven aan of het om een methode (kubus), een eigenschap (engelse sleutel) of een "event" (bliksem) gaat. Events behandelen we niet in dit boek](../assets/4_methoden/methoden4.png)
