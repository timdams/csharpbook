# Introductie tot C\#

## Introductie tot programmeren met C-Sharp

[Kennisclip voor deze inhoud](https://youtu.be/YWnKYFyCkUA)

### Het algoritme

De essentie van een computerprogramma is het zogenaamde **algoritme** \(het "recept" zeg maar\). Dit is de reeks instructies die het programma moet uitvoeren telkens het wordt opgestart. Het algoritme van een programma moet je zelf verzinnen. De volgorde waarin de instructies worden uitgevoerd zijn uiteraard zeer belangrijk. Dit is exact hetzelfde als in het echte leven: een algoritme om je fiets op te pompen kan zijn:

```text
1. Haal dop van het ventiel
2. Plaats pomp op ventiel
3. Begin te pompen
```

Eender welke andere volgorde van bovenstaande algoritme zal vreemde \(en soms fatale\) fouten geven.

### C-Sharp

Om een algoritme te schrijven dat onze computer begrijpt dienen we een programmeertaal te gebruiken. Net zoals er ontelbare spreektalen in de wereld zijn, zijn er ook vele programmeertalen. **C\#** \(spreek uit _'siesjarp'_\) is er een van de vele. In tegenstelling tot onze spreektalen moet een computertaal 'exact' zijn en moet het op ondubbelzinnige manier door de computer verstaan worden. C\# is een taal die deel uitmaakt van de .NET \(spreek uit _'dotnet'_\) omgeving die meer dan 15 jaar geleden door Microsoft werd ontwikkeld \(juli 2000\).

> Deze cursus werd geschreven in [Markdown](https://en.wikipedia.org/wiki/Markdown). Helaas ondersteunt deze geen \# in titels. Daardoor heet dit hoofdstuk "C-Sharp" en niet "C\#". Niets aan te doen.

De geschiedenis en de hele .NET-wereld vertellen zou een cursus op zich betekenen en gaan we hier niet doen. Het is nuttig om weten dat er een gigantische bron aan informatie over .NET en C\# online te vinden is, beginnende met [docs.microsoft.com](https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/).

## Microsoft .NET

Bij de geboorte van .NET in 2000 zat dus ook de taal C\#. .NET is een zogenaamd **framework**. Dit framework bestaat uit een grote groep van bibliotheken \(**class libraries**\) en een _virtual execution system_ genaamd de **Common Language Runtime \(CLR\)**. De CLR zal ervoor zorgen dat C\#, of andere .NET talen \(F\#, VB.NET, etc.\), kunnen samenwerken met de vele bibliotheken.

Om een uitvoerbaar bestand te maken \(**executable**, vandaar de extensie .exe bij uitvoerbare programma's in windows\) zal de broncode die je hebt geschreven in C\# worden omgezet naar **Intermediate Language** \(IL\) code. Op zich is deze IL code nog niet uitvoerbaar, maar dat is niet ons probleem. Wanneer een gebruiker een in IL geschreven bestand wil uitvoeren dan zal, achter de schermen, de CLR deze code ogenblikkelijk naar machine code omzetten \(**Just -In-Time** of JIT compilatie\) en uitvoeren. De gebruiker zal dus nooit dit proces merken \(tenzij er geen .NET framework werd geïnstalleerd op het systeem\).

![Compiler process](../../.gitbook/assets/compiler%20%282%29.png)

[\(Bron afbeelding\)](https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework)

Merk op dat we veel details van de compiler achterwege laten hier. De compiler is een uitermate complex element, maar in deze fase van je \(prille\) programmeursleven hoeven we enkel de kern van de compiler te begrijpen: **het omzetten van C\# code naar een uitvoerbaar bestand geschreven in IL code**.

## .NET Core 3.1

.NET Core is het vervolg op het .NET Framework en is hiermee in veel opzichten vergelijkbaar. .NET Core is een open-source computersoftwareframework. Het grote verschil met het .NET Framework is dat .NET Core niet alleen op Windows werkt, maar ook op Linux en MacOS. .NET Core is m.a.w. cross-platform. Het werkt zelfs op een [Raspberry Pi](https://www.raspberrypi.org/).

Met .NET Core kun je zowel webapplicaties, desktopapplicaties, microservices en Internet of Things toepassingen ontwikkelen.

> Deze cursus heeft als doel om je de programmeertaal C\# aan te leren binnen het .NET Core platform.



