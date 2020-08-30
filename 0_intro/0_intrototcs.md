# De eerste stappen

Wel, wel, wie we hier hebben?! Iemand die de edele kunst van het programmeren wil leren? Dan ben je op de juiste plaats gekomen. Je gelooft het misschien niet, maar reeds aan het einde van dit hoofdstuk zal je je eerste eigen computer-applicaties kunnen maken. De weg naar eeuwige roem, glorie, véél vloeken en code herbruiken ligt voor je. Ben je er klaar voor? 

De eerste stappen zijn nooit eenvoudig. We gaan proberen het aantal dure woorden, vreemde afkortingen en ingewikkelde schema's tot een minimum te houden. Maar toch, als je een nieuwe kunst wil leren zal je je handen (én toetsenbord) vuil moeten maken. Wat er ook gebeurt de komende hoofdstukken: blijf volhouden. Leren programmeren is een beetje als een berg leren beklimmen waarvan je nooit de top lijkt te kunnen bereiken. Wat ook zo is. Er is geen "top", en dat is net het mooie van dit alles. Er valt altijd iets nieuws te leren! De zaken waar je de komende pagina's op gaat vloeken zullen over enkele hoofdstukken al kinderspel lijken. Hou dus vol, blijf oefenen, vloek gerust af en toe en vooral: geniet van nieuwe dingen ontdekken! 


## Wat is programmeren?

Je hoort de termen geregeld: softwareontwikkelaar, programmeur, app-developer, etc. Allen zijn beroepen die in essentie kunnen herleid worden tot hetzelfde: programmeren. Programmeurs hebben geleerd hoe ze computers opdrachten kunnen geven (**programmeren**) zodat deze hopelijk doen wat je ze vraagt.

{% hint style='tip' %}
In de 21e eeuw is de term *computer* erg breed. Quasi ieder apparaat dat op elektriciteit werkt tegenwoordig bevat een computertje. Gaande van slimme lampen, tot de servers die het Internet draaiende houden of de smartwatch aan je pols. Zelfs aardig wat ijskasten en wasmachines beginnen (kleine) computers te bevatten.
{% endhint %}



Het grote probleem van computers, ongeacht hun grootte of kracht, is dat het in essentie ongelooflijk domme dingen zijn. Ze zullen altijd **exact** doe wat jij hen verteld dat ze moeten doen. Als je hen dus de opdracht geeft om te ontploffen, schrik dan niet dat je even later naar de 101 kunt bellen.

**Programmeren houdt in dat je leert praten met die domme computers zodat ze doen wat jij wilt dat ze doen.**

### Het algoritme

> First, solve the problem. Then, write the code.

Deze quote van John Johnson wordt door veel beginnende programmeurs soms met een scheef hoofd aanhoort. "Ik wil gewoon code schrijven!" Het is een mythe dat programmeurs constant code schrijven. Integendeel, een goed programmeur zal veel meer tijd in de "voorbereiding" tot code schrijven steken: het maken van een goed **algoritme**. 

Het algoritme is de essentie van een computerprogramma en kan je beschouwen als het recept dat je aan de computer gaat geven zodat deze jouw probleem op de juiste manier oplost. Het algoritme bestaat uit een reeks instructies die het computer moet uitvoeren telkens jouw programma wordt uitgevoerd. 

Het algoritme van een programma moet je zelf verzinnen. De volgorde waarin de instructies worden uitgevoerd zijn echter zeer belangrijk. Dit is exact hetzelfde als in het echte leven: een algoritme om je fiets op te pompen kan zijn:

```text
Haal dop van het ventiel
Plaats pomp op ventiel
Begin te pompen
```

Eender welke andere volgorde van bovenstaande algoritme zal vreemde (en soms fatale) fouten geven.

Wil je dus leren programmeren, dan zal je logisch moeten leren denken en analytische geest hebben. Als je eerst tegen een bal trapt voor je kijkt waar de goal staat dan zal de edele kunst van het programmeren voor jou een...speciale aangelegenheid worden. 

{% hint style='tip' %}
Vanaf nu ben je trouwens gemachtigd om naar de nieuwsdiensten te mailen telkens ze foutief het woord "logaritme" gebruiken in plaats van "algoritme". Het logaritme is iets wat bij sommige nachtmerries uit de lessen wiskunde opwekt en heeft  hoegenaamd niets met programmeren te maken. Uiteraard kan het wel zjn dat je ooit een algoritme moet schrijven om een logaritme te berekenen. Hopelijk moet een journalist nooit voorgaande zin in een nieuwsbericht gebruiken.
{% endhint %}

### Programmeertaal

Om een algoritme te schrijven dat onze computer begrijpt dienen we een programmeertaal te gebruiken. Computers hebben hun eigen taaltje dat programmeurs moeten kennen voor ze hun algoritme aan de computer kunnen *voeden*. Er zijn tal van computertalen, de ene al wat obscuurder dan de andere. Maar wat al deze talen gelijk hebben is dat ze meestal:
* **ondubbelzinnig** zijn: iedere opdracht of woord kan door de computer maar op exact één manier geïnterpreteerd worden. Dit in tegenstelling tot bijvoorbeeld het Nederlands waar "wat een koele kikker" zowel een letterlijke, als een figuurlijke betekenis heeft die niets met elkaar te maken heeft.
* bestaan uit **woordenschat**: net zoals het Nederlands heeft ook iedere programmeertaal een , meestal beperkte, lijst woorden die je kan gebruiken. Je gaat ook niet in het Nederlands zelf woorden verzinnen in de hoop dat je partner je kan begrijpen.
* bestaan uit **grammaticaregels**: Enkel Yoda mag Engels in een verkeerde volgorde gebruiken. Iedereen anders houdt zich best aan de grammatica-afspraken die een taal heeft. "bal rood is" lijkt nog begrijpbaar, maar als we zeggen "bal rood jongen is gooit veel"?

### De C# taal

Net zoals er ontelbare spreektalen in de wereld zijn, zijn er ook vele programmeertalen. **C#** (spreek uit *'siesjarp'*) is er een van de vele. C# is een taal die deel uitmaakt van de .NET (spreek uit  *'dotnet'*) omgeving die 20 jaar geleden door Microsoft werd ontwikkeld (juli 2000). Het fijne van C# is dat deze een zogenaamde **hogere programmeertaal** is. Hoe "hoger" de programmeertaal, hoe leesbaarder deze wordt voor leken omdat hogere programmeertalen dichter bij onze eigen taal aanleunen. 

De geschiedenis van de hele .NET-wereld vertellen zou een boek op zich betekenen en gaan we hier niet doen. Het is nuttig om weten dat er een gigantische bron aan informatie over .NET en C# online te vinden is, beginnende met [docs.microsoft.com](https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/).

{% hint style='tip' %}
Het fijne van leren programmeren is dat je binnenkort op een bepaald punt gaat komen waarbij de keuze van programmeertaal er minder toe doet. Vergelijk het met het leren van het Frans. Van zodra je Frans onder knie hebt is het veel eenvoudiger om vervolgens Italiaans of Spaans te leren. Zo ook met programmeertalen. De C# taal bijvoorbeeld lijkt bijvoorbeeld als twee druppels water op Java, alsook op de talen waar ze van afstamt, C en C++. 

Zelfs Javascript, Python en veel andere moderne talen zullen weinig geheimen voor jou hebben wanneer je aan het einde van dit boek bent.
{% endhint %}

### De compiler

Rechtstreeks onze algoritmen tegen de computer vertellen vereist dat we machinetaal kunnen. Deze is echter zo complex dat we tientallen lijnen machinetaal nodig hebben om nog maar gewoon 1 letter op het scherm te krijgen. Er werden daarom dus hogere programmeertalen ontwikkeld die aangenamer zijn dan deze zogenaamde machinetalen om met computers te praten.

Uiteraard hebben we een vertaler nodig die onze code zal vertalen naar de machinetaal van het apparaat waarop ons programma moet draaien. Deze vertaler is de **compiler** die aardig wat complex werkt op zich neemt, maar dus in essentie onze code gebruiksklaar maakt voor de computer.

<!--- {width:80%} --->
![Vereenvoudigd compiler overzicht](../assets/1_csharpbasics/compilersimple.png)

Merk op dat we hier veel details van de compiler achterwege laten. De compiler is een uitermate complex element, maar in deze fase van je (prille) programmeursleven hoeven we enkel de kern van de compiler te begrijpen: **het omzetten van C# code naar een uitvoerbaar bestand geschreven in IL code**.

{% hint style='tip' %}
**Microsoft .NET**

Bij de geboorte van .NET in 2000 zat ook de taal C#.

.NET is een zogenaamd **framework**. Dit framework bestaat uit een grote groep van bibliotheken (*class libraries*) en een *virtual execution system* genaamd de **Common Language Runtime (CLR)**. De CLR zal ervoor zorgen dat C#, of andere .NET talen (F#, VB.NET, etc.), kunnen samenwerken met de vele bibliotheken.

Om een uitvoerbaar bestand te maken (**executable**, vandaar de extensie .exe bij uitvoerbare programma's in windows) zal de broncode die je hebt geschreven in C# worden omgezet naar **Intermediate Language** (IL) code. Op zich is deze IL code nog niet uitvoerbaar, maar dat is niet ons probleem. Wanneer een gebruiker een in IL geschreven bestand wil uitvoeren dan zal, achter de schermen, de CLR deze code ogenblikkelijk naar machine code omzetten (**Just -In-Time** of JIT compilatie) en uitvoeren. De gebruiker zal dus nooit dit proces opmerken (tenzij er geen .NET framework werd geïnstalleerd op het systeem).
{% endhint %}