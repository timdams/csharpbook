---
description: >-
  We gebruiken Visual Studio om een C# programma te ontwikkelen. Visual Studio
  is al geïnstalleerd. In dit onderdeel leren we hoe je een C# project opstart
  in Visual Studio.
---

# NEW Een C\# project maken in Visual Studio

## Doelstelling

Hierna weet je:

1. hoe je een mappenstructuur opzet voor de vakken die je volgt in het Graduaat Programmeren
2. hoe je een nieuw Console App project maakt in Visual Studio
3. welke mappenstructuur Visual Studio creëert wanneer je een nieuw project maakt
4. welke afspraken je volgt bij het geven van namen aan mappen en projecten

## Theorie

#### 1. Het belang van het maken van afspraken voor het geven namen

1. We kunnen niet genoeg benadrukken hoe belangrijk het is om afspraken te maken en te volgen bij het schrijven van programma's. Goede afspraken zorgen ervoor dat je:
   1. code gemakkelijk kan delen met andere programmeurs; zonder afspraken kan je niet in een team werken;
   2. veel sneller fouten in je programma zal vinden;
   3. code leesbaar blijft, ook als je maanden later opnieuw bekijkt;
   4. sneller en beter gaan leren programmeren;
2. We vinden het warm water niet opnieuw uit en volgen de richtlijnen van Microsoft:
   1. een overzicht van alle afspraken vind je op [Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)
   2. een overzicht van algemene afspraken, wat hier van toepassing is, vind je op [General Naming Conventions](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions)
3. De basis voor de naamgevingsafspraken zijn:
   1. **PascalNotatie**: geen spaties tussen de woorden en alle woorden beginnen met een hoofdletter: `EenProgrammaOmJeGoedBijTeVoelen`
   2. **camelCasenotatie**: geen spaties tussen de woorden en alle woorden, behalve het eerste, beginnen met een hoofdletter, bijvoorbeeld: `eenProgrammaOmJeGoedBijTeVoelen`

![camelCase](../../.gitbook/assets/image%20%2814%29.png)

#### 2. Rootmap

Ik raad jullie aan een rootmap te maken voor alle vakken die je op AP volgt. Je geeft die bijvoorbeeld de naam AP20-21. Daarin maak je een map met de naam Programmeren \(deze naam is verplicht, als we later met GIT beginnen, zal je begrijpen waarom\). In deze map zullen we alle projecten plaatsen die we in dit vak zullen maken. We maken een afspraak dat alle namen voor mappen in PascalNotatie worden geschreven.

![AP rootmap](../../.gitbook/assets/image%20%2820%29.png)

#### 3. **Create new project**

Als je Visual Studio opent wordt het start dialoogvenster geopend. Als je voor de eerste keer Visual Studio opent is de lijst met recent geopende projecten leeg. Vermits dit onze eerste kennismaking met C\# is, klikken we op **Create a new project**:

![Start dialoogvenster Visual Studio](../../.gitbook/assets/image%20%2813%29.png)

#### **4.** Een **`project template`** kiezen

We beginnen met een .NET Core Console App in C\#:

![Kies een project template](../../.gitbook/assets/image%20%2821%29.png)

Een console-applicatie is een programma dat zijn in- en uitvoer via een klassiek commando/shell-scherm toont. Een console-applicatie draait in dezelfde omgeving als wanneer we in Windows een command-prompt openen \(via Start-&gt; Uitvoeren-&gt; cmd \[enter\] \). We zullen in deze cursus enkel console-applicaties leren maken. Grafische frontends \(bv WPF\) komen in deze cursus niet aan bod.

![Voorbeeld van een console app](../../.gitbook/assets/image%20%2817%29.png)

#### **5.** **Je nieuw project configureren**

We maken een afspraak dat alle projectnamen in PascalNotatie worden geschreven. We geven aan ons nieuw project de naam BeginnenMetCSharp. We kiezen ervoor om een een aparte map te maken voor de projectbestanden en codebestanden. Dus we vinken het vakje **Place Solution and project in the same directory** **`NIET`** aan:

![Visual Studio Configure your new project](../../.gitbook/assets/image%20%2818%29.png)

#### 6. Resultaat

Visual Studio maakt nu het project met de naam BeginnenMetCSharp voor je aan in de map `BeginnenMetCSharp`. In het volgende onderdeel Beginnen met C\# in Visual Studio, beginnen we in C\# te programmeren.

## Oefening

Overloop samen wat we in de theorieles hebben gezien.



