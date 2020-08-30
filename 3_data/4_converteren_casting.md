# Werken met data 


<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)

Aah, Data, een geliefkoosd personage uit Star Trek. Maar daar gaan we het niet over hebben. Het wordt tijd dat we onze werkkledij aantrekken en ons echt vuil gaan maken. 

De wereld draait op data,en dus ook de meeste applicaties die wij gaan schrijven. Echter, we hebben al gezien dat C# met verschillende datatypes werkt, dus wat gebeurt er als we data van twee verschillende datatypes willen combineren?! In Star Trek resulteerde dat 50% van de tijd in een aanval van de Borg, 20% van de tijd van de Klingons en in de overige 30% in een oersaaie aflevering (Star Wars for life!). Ahum, sorry. I got carried away.Laten we eens onderzoeken hoe we data van 'vorm' kunnen veranderen.  

*May the force be with you!* Euh, ik bedoel: *Make it so!*
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

Wanneer je de waarde van een variabele wilt toekennen aan een variabele van een ander type mag dit dus niet zomaar. 
Volgende code zal bijvoorbeeld een dikke error geven:

```java
int age = 4.3;
```

![Een zogenaamde impliciete casting error](../assets/1_csharpbasics/casterror2.jpg)


Je kan geen appelen in peren veranderen zonder magie: in het geval van C# zal je moeten **converteren of casten**. 

Dit kan op 3 manieren:
* Via **casting**: de (klassieke) manier die ook werkt in veel andere programmeertalen.
* Via de **Convert. bibliotheek** van .NET.
* Via **parsing** : Deze manier is enkel nuttig om strings om te zetten naar andere zaken.


## Casting
Het is onmogelijk om een kommagetal aan een geheel getal toe te wijzen zonder dat er informatie verloren zal gaan. Toch willen we dit soms doen. **Van zodra we een variabele van het ene type willen toekennen aan een variabele van een ander type en er dataverlies zal plaatsvinden dan moeten we aan casting doen.**


### Wat is casting
Casting heb je nodig om een variabele van een bepaald type voor een ander type te laten doorgaan. Stel dat je een complexe berekening hebt waar je werkt met verschillende types (bijvoorbeeld ``int``, ``double`` en ``float``). Door te casten voorkom je dat je vreemde resultaten krijgt. Je gaat namelijk bepaalde types even als andere types gebruiken.

Het is belangrijk in te zien dat het casten van een variabele naar een ander type enkel een gevolg heeft **tijdens** het uitwerken van de expressie waarbinnen je werkt. De variabele in het geheugen zal voor eeuwig en altijd het type zijn waarin het origineel gedeclareerd werd.

{% hint style='tip' %}
**Je dient enkel aan casting te doen wanneer je aan *narrowing* doet: een datatype omzetten naar een ander datatype dat een verlies aan data met zich zal meebrengen.** 
{% endhint %}

Casting duid je aan door voor de variabele of literal het datatype tussen haakjes te plaatsen naar wat het omgezet moet worden:

```java
int mijngetal = (int)3.5;
```

of

```java
double kommagetal = 13.8;
int kommaNietWelkom = (int)kommagetal;
```

Hierbij dien je aan de compiler te zeggen: *"Volgende variabele die van het type ]``double`` is, moet aan deze variabele van het type ``int`` toegekend worden. **Ik besef dat hierbij data verloren kan gaan (namelijk het deel na de komma), maar zet de variabele toch maar om naar het nieuwe type, ik draag alle verantwoordelijkheid voor het verlies"**.

{% hint style='tip' %}
Het is als het ware een soort Amerikaanse reflex om te voorkomen dat de compiler later door ons kan aangeklaagd worden omdat hij uiterst belangrijke data heeft doen verloren gaan tijdens de omzetting. Via casting geven we aan dat we de compiler niet zullen aanklagen.
{% endhint %}

### Narrowing
Casting doe je  wanneer je een variabele wilt toekennen aan een andere variabele van een ander type dat daar eigenlijk **niet inpast** zonder dataverlies. We moeten dan aan **narrowing** doen, letterlijk het versmallen van de data.

Bekijk eens het volgende voorbeeld:

```java
double var1;
int var2;
 
var1 = 20.4;
var2 = var1;
```

Dit zal niet gaan. Je probeert namelijk een waarde van het type double in een variabele van het type int te steken. Dat gaat enkel als je informatie weggooit (namelijk het gedeelte na de komma). Je moet aan *narrowing* doen.

Dit gaat enkel als je expliciet aan de compiler zegt: *het is goed, je mag informatie weggooien*, ik begrijp dat en zal er rekening mee houden. Dit proces van narrowing noemen we casting.

En je lost dit op door voor de variabele die tijdelijk dienst moet doen als een ander type, het nieuwe type, tussen ronde haakjes te typen, als volgt:

```java
double var1;
int var2;
 
var1 = 20.4;
var2 = (int)var1;
```
Het resultaat in `var2` zal `20` zijn (alles na de komma wordt weggegooid bij casting van een ``double`` naar een ``int`` ).

{% hint style='tip' %}
Merk op dat `var1` nooit van datatype is veranderd; enkel de inhoud ervan (`20.4`) werd eruit gehaald, omgezet ("gecast") naar `20` en dan aan ``var2`` toegewezen dat enkel `int` aanvaardt.
{% endhint %}

<!---{pagebreak} --->

### Narrowing in de praktijk

<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
Ela, die helm nog niet afzetten aub. We zijn er nog niet. Herinner je vorige keer nog dat ik je op slinkse manier de helft van m'n loon ging geven en je de volle 0 euro mee naar huis kreeg? 

Wel, dit concept gaan we hier nog eens bekijken, maar nu in combinatie met casting. Opletten dus!
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->


Stel dat ``tempGisteren`` en ``tempVandaag`` van het type ``int`` zijn, maar dat we nu de gemiddelde temperatuur willen weten. De formule voor gemiddelde temperatuur over 2 dagen is:

```java
int tempGemiddeld = (tempGisteren + tempVandaag)/2;
```

Test dit eens met de waarden 20 en 25. Wat zou je verwachten als resultaat? Inderdaad: 22,5 (omdat (20+25)/2 = 22.5) . Nochtans krijg je 22 op scherm te zien en zal de variabele ``tempGemiddeld`` ook effectief de waarde 22 bewaren en niet 22.5.

Het probleem is dat het gemiddelde van 2 getallen niet noodzakelijk een geheel getal is. **Echter, omdat de expressie enkel integers bevat (tempGisteren, tempVandaag en de literal 2) zal ook het resultaat een ``int`` zijn.** In dit geval wordt alles na de komma gewoon *weggegooid*, vandaar de uitkomst. **Dit is narrowing.**


Hoe krijgen we de correctere uitslag te zien? Eens testen wat er gebeurt als we ``tempGemiddeld`` als ``double`` declareren:

```java
double tempGemiddeld = (tempGisteren + tempVandaag)/2;
```

Als we dit testen zal nog steeds de waarde ``22`` aan ``tempGemiddeld`` toegewezen worden. De expressie rechts van de toekenning bevat nog steeds enkel integers en de computer zal dus ook de berekening en het resultaat als integer beschouwen, ongeacht dat deze in een ``double`` moet gezet worden.

We moeten dus ook de rechterkant van de toekenning als ``double`` beschouwen. *We doen dit, zoals eerder vermeld, door middel van **casting***, als volgt:

```java
double tempGemiddeld = ((double)tempGisteren + (double)tempVandaag)/2;
```
Nu zal tempGemiddeld wel de waarde 22.5 bevatten.

{% hint style='warning' %}
Er zijn ook andere oplossingen die het gewenste resultaat geven, namelijk:

```java
(tempGisteren + tempVandaag)/2.0;
((double)(tempGisteren + tempVandaag))/2;
((double)tempGisteren + tempVandaag)/2;
(tempGisteren + (double)tempVandaag)/2;
```

Let echter op dat niet alle oplossingen bij dit soort oefeningen steeds dezelfde resultaten geeft. Goed testen is de boodschap en nadenken over de volgorde van berekeningen en wat het datatype van ieder tussenresultaat zal zijn. Laten we dat eens analyseren bij voorgaande 4 voorbeelden:


1. Eerst tellen we twee integers op, wat dus een nieuwe integer geeft, die we vervolgens delen door een ``double``, wat dus een ``double`` als resultaat geeft.
2. Eerst tellen we twee integer op, wat weer een integer geeft, vervolgens zetten we dit resultaat om naar een ``double`` en delen dit door een ``int`` wat dus een ``double`` geeft.
3. Eerst zetten ``tempGisteren`` om naar een ``double``. Vervolgens tellen we een ``double`` met een ``int`` op, wat een double als tussenresultaat geeft. Dit delen we dan door een ``int`` wat een ``double`` finaal geeft.
4. Hetzelfde als de vorige stap, maar nu zetten we eerst ``tempVandaag`` om naar een ``double``.

{% endhint %}

{% hint style='warning' %}
Merk op dat er een subtiel verschil is tussen volgende 2 lijnen code:
```java
(double)(tempGisteren + tempVandaag)/2; //geeft 22.5
(double)((tempGisteren + tempVandaag))/2); //geeft 22
```
In het eerste zullen we het resultaat van de som naar `double`` omzetten. In het tweede, door de volgorde van berekeningen door de haakjes, zullen we de casting pas doen **na de deling** en zal dus 22 in plaats van 22.5 als resultaat geven.
{% endhint %}

<!---{pagebreak} --->

### Widening
Casting is  niet nodig als je aan **widening** doet: een *kleiner* type in een *groter* type steken (met groter/kleiner wordt meestal het aantal bits bedoeld die het datatype per variabele van dit type nodig heeft), als volgt:

```java
int var1;
double var2;
 
var1 = 20;
var2 = var1;  //var2 krijgt de waarde 20.0
```

Deze code zal zonder problemen werken: `var2` zal de waarde `20.0` bevatten. De inhoud van `var1` wordt *verbreed* naar een `double`, eenvoudigweg door er een kommagetal van te maken. 

Er gaat **geen** inhoud verloren echter. Je hoeft dus niet expliciet de casting-notatie zoals ``(double)var1`` te doen, de computer ziet zelf dat hij de inhoud van ``var1`` zonder dataverlies kan toekennen aan ``var2`` en is dus niet bang dat hij later aangeklaagd zal worden.

Merk op dat je perfect casting hier mag gebruiken, maar daar de conversie impliciet zonder problemen kan plaatsvinden hoeft dit dus niet. Deze code is echter even juist (en soms een veilige gewoonte om te doen, better safe than sorry):

```java
var2 = (double) var1;
```

## Conversie
Casting is de 'oldschool' manier van data omzetten die vooral zeer nuttig is daar deze compacte code geeft en ook werkt in andere C#-gerelateerde programmeertalen zoals C, C++ en Java. 

Echter, .NET heeft ook  ingebouwde conversie-methoden die je kunnen helpen om data van het ene type naar het andere te brengen. Het nadeel is dat ze iets meer typwerk (en dus meer code) vereisen dan bij casting. 

Al deze methoden zitten binnen de **Convert**-bibliotheek van .NET.

Het gebruik hiervan is zeer eenvoudig. Enkele voorbeelden:

```java
int getal= Convert.ToInt32(3.2); //double to int
double anderGetal= Convert.ToDouble(5); //int to double
bool isWaar= Convert.ToBoolean(1); //int to bool
int userAge= Convert.ToInt32("19"); //string to int
int ageOther= Convert.ToInt32(anderGetal); //double to int
```

Je plaatst tussen de ronde haakjes de variabele of literal die je wenst te converteren naar een ander type. Merk op dat naar een `int`  converteren met ``.ToInt32()`` moet gebeuren. Om naar een ``short`` te converteren is dit met behulp van ``.ToInt16()``.
 
{% hint style='tip' %}
**``Convert.ToBoolean``** verdient extra aandacht: Wanneer je een getal, eender welk, aan deze methode meegeeft zal deze altijd naar ``True`` geconverteerd worden.  

Enkel indien je ``0`` (als ``int``) of ``0.0`` (als ``double``) ingeeft, dan krijg je ``False``. In quasi alle andere gevallen krijg je ``True``.
{% endhint %}

{% hint style='warning' %}
**Opgelet**: de conversie zal zelf zo goed mogelijk de data omzetten en dus indien nodig widening of narrowing toepassen. Zeker bij het omzetten van een string naar een ander type kijk je best steeds de documentatie na om te weten wat er intern juist zal gebeuren.

Je kan [alle conversie-mogelijkheden hier bekijken](https://msdn.microsoft.com/en-us/library/system.convert.aspx).
{% endhint %}

## Parsing
{% hint style='tip' %}
Voorlopig zullen we parsing niet nodig hebben. Voor de volledigheid plaatsen we deze informatie hier echter. Ben je toch benieuwd: bekijk zeker eens de werking van ``TryParse`` in de appendix. Dit is een erg krachtige manier van werken.
{% endhint %}

Naast conversie en casting bestaat er ook nog **parsing**.

Parsing is anders dan conversie en casting. Parsing zal je in dit boek enkel nodig hebben om tekst(``string``) naar getallen om te zetten. Echter, intern zal bijna altijd ``Convert.To...`` gebruikt worden indien je een ``Parse`` methode aanroept.

Ieder ingebouwd datatype in C# heeft een ``.Parse()`` methode die je kan aanroepen om **strings om te zetten naar het gewenste type**. 

Voorbeeld van parsing:

```java
int numVal = Int32.Parse("-105");
Console.WriteLine(numVal);
```

Gebruik parsing enkel wanneer je:

1. een ``string`` hebt waarvan je weet dat deze altijd van een specifiek type zal zijn, bv een ``int``, dan kan je ``Int32.Parse()`` gebruiken.
2. input van de gebruiker vraagt (bv via ``Console.ReadLine``) en niet 100% zeker bent dat deze een getal zal bevatten, gebruik dan ``Int32.TryParse()``. (meer info in de appendix)).