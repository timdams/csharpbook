## Console-applicaties

Een console-applicatie is een  programma dat zijn in- en uitvoer via een klassiek commando/shell-scherm toont. Een console-applicatie draait  in dezelfde omgeving als wanneer we in Windows een command-prompt openen (via Start-> Uitvoeren-> ``cmd`` [enter] ). We zullen in dit boek enkel console-applicaties leren maken. Grafische frontends zoals WPF komen in dit boek niet aan bod.

### In en uit -  ReadLine en WriteLine

Een programma zonder invoer van de gebruiker is niet erg boeiend. De meeste programma's die we leren schrijven vereisen dan ook "input" (**IN**). We moeten echter ook zaken aan de gebruiker kunnen tonen (bijvoorbeeld de uitkomst van een berekening, een foutboodschap, etc) wat dus vereist dat er "output" (**UIT**) naar het scherm kan gestuurd worden.

![In het begin zullen al je applicatie deze opbouw hebben](../assets/1_csharpbasics/inuit.png)


Console-applicaties maken in C# vereist dat je minstens twee belangrijke C# methoden leert gebruiken:

* **IN**: Met behulp van **``Console.ReadLine()``** kunnen we input van de gebruiker inlezen en in ons programma verwerken.
* **UIT**: Via **``Console.WriteLine()``** kunnen we tekst op het scherm tonen.


### Je eerste console programma

Maak een nieuw console-project aan (noem het Demo1) en open het Program.cs bestand (indien het nog niet open is). 


**Veeg de code die hier reeds staat niet weg!**

Voeg onder de lijn ``Console.WriteLine("Hello World!");`` volgende code toe (vergeet de puntkomma niet):

```java
Console.WriteLine("Hoi, ik ben het!");
```

<!---{pagebreak} --->

Zodat je dus volgende code krijgt:

```java
using System;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hoi, ik ben het");
        }
    }
}
```

Compileer deze code en voer ze uit: **druk hiervoor weer op het groene driehoekje**. Of via het menu Debug en dan Start Debugging.

{% hint style='danger' %}
**Moet ik niets bewaren?**

Neen. Telkens je op de groene "build en run" knop duwt worden al je aanpassingen automatisch bewaard. Trouwens: **Kies nooit voor "save as..."!** want dan bestaat de kans dat je project niet meer compileert. Dit zal aardig wat problemen in je project voorkomen, geloof me maar.
{% endhint %}

#### Analyse van de code

We gaan nu iedere lijn code kort bespreken. Sommige lijnen code zullen lange tijd niet belangrijk zijn.  Onthoud nu alvast dat: **alle belangrijke code staat tussen de accolades onder de lijn ``static void Main(string[] args)``**!

{% hint style='warning' %}
Laat je niet afschrikken door wat er nu volgt. We gooien je even in het diepe gedeelte van het zwembad maar zal je er op tijd uithalen zodat we vervolgens terug in het babybadje rustig op de glijbaan kunnen gaan spelen en C# op een rustiger tempo kunnen ontdekken.
{% endhint %}

* **``using System;``** :  Alle ``Console``-commando's die we verderop gebruiken zitten in de ``System`` bibliotheek. Als we deze lijn (een zogenaamde **directive**) niet zouden schrijven dan moesten we ``System.Console.WriteLine`` i.p.v. ``Console.WriteLine`` schrijven verderop in de code. 
* **``namespace Demo1``**: Dit is de unieke naam waarbinnen we ons programma zullen steken, en het is niet toevallig de naam van je project. Verander dit nooit tenzij je weet wat je aan het doen bent.
* **``class Program``**: Hier start je echte programma. Alle code binnen deze Program accolades zullen gecompileerd worden naar een uitvoerbaar bestand.
* **``static void Main(string[] args)``**: Het startpunt van iedere console-applicatie. Wat hier gemaakt wordt is een **methode** genaamd ``Main``. Je programma kan meerdere methoden (of functies) bevatten, maar enkel degene genaamd ``Main`` zal door de compiler als het startpunt van het programma gemaakt worden.
* **``Console.WriteLine("Hello world");``**: Dit is een **statement** dat de WriteLine-methode aanroept van de ``Console``-klasse. Het zal alle tekst die tussen de aanhalingstekens staat op het scherm tonen. 
* **``Console.WriteLine("Hoi ik ben het");``**: en ook deze lijn komt op het scherm.
* **Accolades**: vervolgens moet voor iedere openende accolade eerder in de code nu ook een bijhorende sluitende volgen.

<!---NOBOOKSTART--->
{% hint style='tip' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)
Jawadde...Wat was dit allemaal?! We hebben al aardig wat vreemde code zien passeren en het is niet meer dan normaal dat je nu denkt "dit ga ik nooit kunnen".  Wees echter niet bevreesd: je zal sneller dan je denkt bovenstaande code als 'kinderspel' gaan bekijken. Een tip nodig? Test en experimenteer met wat je al kunt!

Laat deze info rustig inzinken en onthoud alvast volgende belangrijke zaken:

* Al je eigen code komt momenteel enkel tussen de ``Main`` accolades.
* Eindig iedere lijn code daar met een puntkomma ( ; ).

<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

{% hint style='tip' %}
De oerman verschijnt wanneer we een stevige stap gezet hebben en je mogelijk even onder de indruk bent van al die nieuwe informatie. Hij zal proberen informatie nog eens vanuit een ander standpunt toe te lichten en te herhalen waarom deze nieuwe kennis zo belangrijk is.
{% endhint %}


{% hint style='tip' %}
"Hello world" op het scherm laten verschijnen wanneer je een nieuwe programmeertaal leert is ondertussen een traditie bij programmeurs. Er is zelfs een website die dit verzamelt op [helloworldcollection.de](http://helloworldcollection.de/). Deze site toont in honderden programmeertalen hoe je "Hello world" moet programmeren.
{% endhint %}


<!---{pagebreak} --->


### WriteLine: Tekst op het scherm

De WriteLine-methode is een veelgebruikte methode in Console-applicaties. Het zorgt ervoor dat we tekst op het scherm kunnen tonen.

Voeg volgende lijn toe na de vorige WriteLine-lijn in je project:

```java
Console.WriteLine("Wie ben jij?!");
```

De WriteLine methode zal alle tekst tonen die tussen de aanhalingstekens (``"  "``) staan tussen de haakjes van de methode. **De aanhalingstekens aan het begin en einde van de tekst zijn uiterst belangrijk! Alsook het puntkomma helemaal achteraan.**

Je code binnen de ``Main`` accolades zou nu moeten zijn:

```java
Console.WriteLine("Hello World!");
Console.WriteLine("Hoi, ik ben het");
Console.WriteLine("Wie ben jij?!");
```
Kan je voorspellen wat de uitvoer zal zijn? Test het eens!

{% hint style='tip' %}
We tonen niet telkens de volledige broncode. Als we dat blijven doen dan wordt dit boek dubbel zo dik. We tonen daarom meestal enkel de code die binnen de ``Main`` (of later ook elders) moet komen.
{% endhint %}