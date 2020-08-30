### ReadLine: Input van de gebruiker verwerken

Met de console kan je met een handvol methoden reeds een aantal interessante dingen doen.

Zo kan je bijvoorbeeld input van de gebruiker inlezen en bewaren in een variabele als volgt:

```java
string result;
result = Console.ReadLine();
```

Wat gebeurt er hier juist?

De eerste lijn code: 
* Concreet zeggen we hiermee aan de compiler: maak in het geheugen een plekje vrij waar enkel data van het type string in mag bewaard worden (wat deze zin exact betekent komt later. Onthoud nu dat geheugen van het type ``string`` enkel "tekst" kan bevatten).
* Noem deze geheugenplek ``result``  zodat we deze later makkelijk kunnen in en uitlezen.

<!---{pagebreak} --->

Tweede lijn code:
* Vervolgens roepen we de ``ReadLine`` methode aan. Deze methode zal de invoer van de gebruiker uitlezen tot de gebruiker op enter drukt.
* Het resultaat van de ingevoerde tekst wordt bewaard in de variabele ``result``.

{% hint style='tip' %}
Merk op dat de toekenning in C# van rechts naar links gebeurt. Vandaar dat ``result`` dus links van de toekenning (``=``) staat en de waarde krijgt van het gedeelte rechts ervan.
{% endhint %}

Je programma zou nu moeten zijn:

```java

Console.WriteLine("Hello World!");
Console.WriteLine("Hoi, ik ben het!");
Console.WriteLine("Wie ben jij?!");
string result;
result = Console.ReadLine();
```

Start nogmaals je programma. Je zal merken dat je programma nu een cursor toont en wacht op invoer. Je kan nu eender wat intypen en van zodra je op enter duwt gaat het programma verder (in dit geval stopt het programma hierna dus).

### Input gebruiker verwerken en gebruiken

We kunnen nu invoer van de gebruiker, die we hebben bewaard in de variabele ``result``,  gebruiken en tonen op het scherm. 

```java
Console.WriteLine("Dag ");
Console.WriteLine(result);
Console.WriteLine(" hoe gaat het met je?");
```

In de tweede lijn hier gebruiken we de variabele ``result`` (waar de invoer van de gebruiker in bewaard wordt) als parameter in de ``WriteLine``-methode. 

Met andere woorden: de ``WriteLine`` methode zal op het scherm tonen wat de gebruiker even daarvoor heeft ingevoerd.

<!---{pagebreak} --->

Je volledige programma ziet er dus nu zo uit:

```java
Console.WriteLine("Hello World!");
Console.WriteLine("Hoi, ik ben het!");
Console.WriteLine("Wie ben jij?!");

string result;
result = Console.ReadLine();

Console.WriteLine("Dag");
Console.WriteLine(result);
Console.WriteLine("hoe gaat het met je?");

```

Test het programma en voer je naam in wanneer de cursor knippert.

Voorbeelduitvoer (lijn 3 is wat de gebruiker heeft ingetypt)

```text
Hoi, ik ben het!
Wie ben jij?!
tim [enter]
Dag
tim
hoe gaat het met je?
```

{% hint style='tip' %}
**Aanhalingsteken of niet?**

Wanneer je de inhoud van een variabele wil gebruiken in een methode zoals  ``WriteLine()`` dan plaats je deze zonder aanhalingsteken!
Bekijk zelf eens wat het verschil wordt wanneer je volgende lijn code ``Console.Write(result);`` vervangt door ``Console.Write("result");``.

De uitvoer wordt dan (merk het verschil op op lijn 5):

```text
Hoi, ik ben het!
Wie ben jij?!
tim [enter]
Dag
result
hoe gaat het met je?
```
{% endhint %}

<!---{pagebreak} --->

### Write en WriteLine

Naast ``WriteLine`` bestaat er ook ``Write``.

De ``WriteLine``-methode zal steeds een line break (een 'enter') aan het einde van de lijn zetten zodat de cursor naar de volgende lijn springt.

De ``Write``-methode zal geen enter aan het einde van de lijn toevoegen. Als je dus vervolgens iets toevoegt (met een volgende ``Write`` of ``WriteLine``) **dan zal dit aan dezelfde lijn toegevoegd worden.**

Vervang daarom eens in de laatste 3 lijnen code in je project alle ``WriteLine`` door ``Write``:

```java
Console.Write("Dag");
Console.Write(result);
Console.Write("hoe gaat het met je?");
```

Voer je programma uit en test het resultaat. Je krijgt nu:

```java
Hoi, ik ben het!
Wie ben jij?!
tim [enter]
Dagtimhoe gaat het met je?
```

Wat is er verkeerd gelopen? Al je tekst van de laatste lijn plakt zo dicht bij elkaar? Inderdaad, we zijn spaties vergeten toe te voegen. Spaties zijn ook tekens die op scherm moeten komen (ook al zien we ze niet) en je dient dus binnen de aanhalingstekens spaties toe  te voegen. Namelijk:

```java
Console.Write("Dag ");
Console.Write(result);
Console.Write(" hoe gaat het met je?");
```

Je uitvoer wordt nu:

```java
Hoi, ik ben het!
Wie ben jij?!
tim [enter]
Dag tim hoe gaat het met je?
```

<!---{pagebreak} --->

### Witregels in C#

C# trekt zich niets aan van witregels (zowel spaties, enters en tabs) die niét binnen aanhalingstekens staan. Met andere woorden: je kan het voorgaande programma perfect in één lange lijn code typen, zonder enters. Dit is echter niet aangeraden want het maakt je code een pak onleesbaarder.

<!--- {width:90%} --->
![Voorgaande programma in exact 1 lijn. Cool? Ja, in sommige kringen. Dom en onleesbaar? Ook ja.](../assets/1_csharpbasics/online.png)

{% hint style='tip' %}
**Opletten met spaties**

Let goed op hoe je spaties gebruikt bij ``WriteLine`` Indien je dus spaties buiten de aanhalingstekens plaatst dan heeft dit geen effect. *In volgend voorbeeld zijn de spaties aangegeven als liggende streepjes ( _ )*.

Hier een fout gebruik van spaties (de code zal werken maar je spaties worden genegeerd):

```java
Console.Write("Dag"_);
Console.Write(result_);
Console.Write("hoe gaat het met je?");
```

En een correct gebruik:

```java
Console.Write("Dag_");
Console.Write(result);
Console.Write("_hoe gaat het met je?");
```
{% endhint %}

<!---{pagebreak} --->

### Zinnen aan elkaar plakken

We kunnen dit allemaal nog een pak korter tonen zonder dat de code onleesbaar wordt. De plus-operator (``+``) in C# kan je namelijk gebruiken om tekst aan elkaar te plakken. De laatste 3 lijnen code kunnen dan korter geschreven worden  als volgt:

```java
Console.WriteLine("Dag " + result + " hoe gaat het met je?");
```

Merk op dat result dus NIET tussen aanhalingstekens staat, in tegenstelling tot de andere stukken zin. Waarom is dit? Aanhalingstekens in C# duiden aan dat een stuk tekst moet beschouwd worden als tekst van het type string. Als je geen aanhalingsteken gebruikt dan zal C# de tekst beschouwen als een variabele met die naam.

Bekijk zelf eens wat het verschil wordt wanneer je volgende lijn code:
```java
Console.WriteLine("Dag "+ result + " hoe gaat het met je?");
```
Vervangt door: 
```java
Console.Write("Dag "+ "result" + " hoe gaat het met je?");
```

#### Meer input vragen

Als je  meerdere inputs van de gebruiker tegelijkertijd wenst te bewaren dan zal je meerdere geheugenplekken nodig hebben om de invoer te bewaren. Bijvoorbeeld:

```java
Console.WriteLine("Geef leeftijd");
string leeftijd;  //eerste geheugenplekje aanmaken
leeftijd = Console.ReadLine();
Console.WriteLine("Geef adres");
string adres; //tweede geheugenplekje aanmaken
adres = Console.ReadLine();
```

Je mag echter ook de geheugenplekken al vroeger maken. In C# zet men de geheugenplek creatie zo dicht mogelijk bij de code waar je die plek gebruikt (zoals vorig voorbeeld), maar dat is geen verplichting. Dit mag dus ook:


```java
string leeftijd;  //eerste geheugenplekje aanmaken
string adres; //tweede geheugenplekje aanmaken
Console.WriteLine("Geef leeftijd");
leeftijd = Console.ReadLine();
Console.WriteLine("Geef adres");
adres = Console.ReadLine();
```

{% hint style='tip' %}
Je zal vaak ``Console.WriteLine`` moeten schrijven als je dit boek volgt. We hebben echter goed nieuws voor je: er zit een ingebouwde "snippet" in VS om sneller ``Console.WriteLine op het scherm te toveren. We gaan je niet langer in spanning houden...of toch... nog even. Ben je benieuwd?  Spannend he!

Hier gaan we: ``cw [tab] [tab]``

Als je dus ``cw`` schrijft en dan twee maal op de tab-toets van je toetsenbord duwt verschijnt daar automagisch een verse lijn met ``Console.WriteLine();``.

Wil je dit ook voor ``Console.ReadLine();``? Dan zal je een eigen, custom, snippet aan VS moeten toevoegen. [Dit wordt hier uitgelegd](https://stackoverflow.com/questions/32229103/keyboard-shortcut-for-c-sharp-console-class).
{% endhint %}

<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)

* [WriteLine, Write en ReadLine](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=645c1bae-c84d-47c4-89d6-abe3009410c3)
<!---NOBOOKEND--->