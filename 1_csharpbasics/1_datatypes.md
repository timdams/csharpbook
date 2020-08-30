## Datatypes

Een essentieel onderdeel van C# is kennis van datatypes. Binnen C# zijn een aantal types gedefinieerd die je kan gebruiken om data in op te slaan. Wanneer je data wenst te bewaren in je applicatie dan zal je je moeten afvragen wat voor soort data het is. Gaat het om een getal, een geheel getal, een kommagetal, een stuk tekst of misschien een binaire reeks? Ieder datatype in C# kan één welbepaald soort data bewaren en dit zal telkens een bepaalde hoeveelheid computergeheugen vereisen. 

{% hint style='warning' %}
Datatypes zijn een belangrijk concept in C# omdat deze taal een zogenaamde **"strongly typed language"** is (in tegenstelling dat bijvoorbeeld Javascript). Wanneer je in C# data wenst te bewaren (in een variabele) zal je van bij de start moeten aangeven wat voor data dit zal zijn. Vanaf dan zal de data op die geheugenplek op dezelfde manier verwerkt worden en niet zo maar van 'vorm' kunnen veranderen zonder extra input van de programmeur. 
{% endhint %}

Er zijn tal basistypes in C# gedeclareerd (zogenaamde **primitieve datatypes**). In dit boek leren we werken met datatypes voor:
* Gehele getallen: `sbyte, byte, short, ushort, int, uint, long`
* Kommagetallen: `double, float, decimal`
* Tekst: `char, string`
* Booleans: `bool`
* Enums (een speciaal soort datatype dat een beetje een combinatie van meerdere datatypes is én dat je zelf deels kan definiëren.)


Ieder datatype wordt gedefinieerd door minstens volgende eigenschappen:
* **Soort data** dat in het datatype kan bewaard worden (tekst, getal, etc.)
* **Geheugengrootte**: de hoeveelheid bits dat 1 element van dit datatype inneemt in het geheugen. Dit kan belangrijk zijn wanneer je met véél data gaat werken en je niet wilt dat de gebruiker drie miljoen gigabyte RAM nodig heeft.
* **Schrijfwijze van de literals**:  hoe weet C# of 2 een komma getal (2.0) of een geheel getal (2) is? Hiervoor gebruiken we specifieke schrijfwijzen van deze waarden (**literals**) wat we verderop uiteraard uitgebreid zullen bespreken.

{% hint style='tip' %}
Het datatype ``string`` heb je al gezien in het vorig hoofdstuk. Je hebt toen een variabele aangemaakt van het type string door de zin ``string result;``. 

Verderop plaatsten we dan iets waar de gebruiker iets kan intypen in die variabele: 

```java
result = Console.ReadLine();
```
{% endhint %}


### Basistypen voor getallen
Alhoewel een computer digitaal werkt en enkel 0'n en 1'n bewaard zou dat voor ons niet erg handig werken. C# heeft daarom een hoop datatypes gedefinieerd om te werken met getallen zoals wij ze kennen, gehele en kommagetallen. Intern zullen deze getallen nog steeds binair bewaard worden, maar dat is tijdens het programmeren zelden een probleem.

De basistypen van C\# om getallen in op te slaan zijn:

* Voor gehele getallen: `sbyte, byte, short, ushort, int, uint, long`
* Voor kommagetallen: `double, float, decimal`

Deze datatypes hebben allemaal een verschillend bereik, wat een rechtstreekse invloed heeft op de hoeveelheid geheugen die ze innemen.

{% hint style='warning' %}
Ieder type hierboven heeft een bepaald bereik en hoeveelheid geheugen nodig. Je zal dus steeds moeten afwegen wat je wenst. Op een high-end pc met ettelijke gigabytes aan werkgeheugen (RAM) is geheugen zelden een probleem waar je rekening mee moet houden...Of toch: wat met real-time first person shooters die miljoenen berekeningen per seconde moeten uitvoeren? Daar zal iedere bit en byte tellen. Op andere apparaten (smartphone, arduino, smart fridges, etc.) is iedere byte geheugen nog kostbaarder. **Kortom: kies steeds bewust het datatype dat het beste 'past' voor je probleem qua bereik, precisie en geheugengebruik.**
{% endhint %}



#### Gehele getallen
Voor de gehele getallen zijn er volgende datatypes:

| **Type** | **Geheugen** | **Bereik** | 
| :--- | :--- | :--- | :--|
| `sbyte` | 8 bits | -128 tot 127 | 
| `byte` | 8 bits | 0 tot 255 | 
| `short` | 16 bits | -32768 tot 32767 | 
| `ushort` | 16 bits | 0 tot 65535 |
| `int` | 32 bits | -2 147 483 648 tot 2 147 483 647 |
| `uint` | 32 bits | 0 tot 4294967295 | 
| `long` | 64 bits | -9 223 372 036 854 775 808 tot 9 223 372 036 854 775 807 | 
| `ulong` | 64 bits | 0 tot 18 446 744 073 709 551 615 | 
| `char` | 16 bits | 0 tot 65535 | 

Enkele opmerkingen bij deze tabel:
* De `s` vooraan `sbyte` staat voor ``signed``: m.a.w. 1 bit wordt gebruikt om het + of - teken te bewaren. 
* De `u` vooraan `ushort`, `uint` en `ulong` staat voor `unsigned`. Het omgekeerde van signed dus. Kwestie van het ingewikkeld te maken. Deze twee datatypes hebben dus geen teken en zijn **altijd positief**.
* `char` bewaard karakters. We zullen verderop dit datatype uitspitten en ontdekken dat karakters (alle tekens op het toetsenbord, inclusief getallen, leesteken, etc.) als gehele, binaire getallen worden bewaard. Daarom staat `char` in deze lijst.
* Het grootste getal bij `long` is 2 tot de 63ste (negen triljoen tweehonderddrieëntwintig biljard driehonderd tweeënzeventig biljoen zesendertig miljard achthonderdvierenvijftig miljoen zevenhonderdvijfenzeventigduizend achthonderd en zeven). Dit zijn maar 63 bits?! Inderaad, de laatste bit wordt gebruikt om het teken te bewaren.

<!---NOBOOKSTART--->
{% hint style='tip' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/care.png)

"Wow. Moet je al die datatypes uit het hoofd kennen? Ik was al blij dat ik tekst op het scherm kon tonen."

Uiteraard kan het geen kwaad dat je de belangrijkste datatypes onthoud, anderzijds zul je zelf merken dat door gewoon veel te programmeren je vanzelf wel zult ontdekken welke datatypes je waar kunt gebruiken. Laat je dus niet afschrikken door de ellenlange tabellen met datatypes in dit hoofdstuk, we gaan er maar een handvol effectief van gebruiken.
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->

#### Kommagetallen
Voor de kommagetallen zijn er maar 3 mogelijkeden. Ieder datatype heeft een 'voordeel' tegenover de 2 andere, dit voordeel staat vet in de tabel:

| **Type** | **Geheugen** | **Bereik** | **Precisie** |
| :--- | :--- | :--- | :--- |
| `float` | **32 bits** | gemiddeld | 7 digits |
| `double` | 64 bits | **meeste** | 15 digits |
| `decimal` | 128 bits | minste | **28-29 digits** |

Zoals je ziet moet je bij kommagetallen een afweging maken tussen 3 even belangrijke criteria.  Heb je ongelooflijk grote precisie nodig dan ga je voor een ``decimal``.  Wil je vooral erg grote of erg kleine getallen kies je voor ``double``.   Zoals je merkt zal je dus zelden ``decimal`` nodig hebben, deze zal vooral nuttig zijn in financiële en wetenschappelijke programma's waar met erg exacte cijfers moet gewerkt worden. 

{% hint style='tip' %}
Bij twijfel opteren we meestal voor kommagetallen om het **``double``** datatype te gebruiken. Bij gehele getallen kiezen we meestal voor  **``int``**.
{% endhint %}


{% hint style='tip' %}
De precisie van een getal is het aantal beduidende of significante cijfers. 2.2345 (precisie van 5) heeft bijvoorbeeld een hogere precisie dan 2.23 (precisie van 3).
{% endhint %}

<!---{pagebreak} --->

### Boolean datatype

``bool`` (**boolean**) is het eenvoudigste datatype van C#. Het kan maar 2 mogelijke waarden bevatten: ``true`` of ``false``. 0 of 1 met andere woorden. 

We zullen het ``bool`` datatype erg veel nodig hebben wanneer we met beslissingen zullen werken in een later hoofdstuk, specifiek de ``if`` statements die afhankelijk van de waarde van een ``bool`` bepaalde code wel of niet zullen doen uitvoeren.

{% hint style='tip' %}
Het gebeurt vaak dat beginnende programmeurs een ``int`` variabele gebruiken terwijl ze toch weten dat de variabele maar 2 mogelijke waarden zal hebben. Om dus geen onnodig geheugen te verbruiken is het aan te raden om in die gevallen steeds met een ``bool`` variabele te werken.
{% endhint %}

### Tekst/String datatype
We besteden verderop een heel apart hoofdstuk aan tonen hoe je een enkel karakter of volledige flarden tekst kan bewaren in variabelen. 

Hier alvast een sneakpreview: 
* Tekst kan bewaard worden in het ``string`` datatype
* Een enkel karakter wordt bewaard in het ``char`` datatype dat we ook hierboven al even hebben zien passeren.


<!---NOBOOKSTART--->
{% hint style='warning' %}
<!---NOBOOKEND--->
<!---{aside}--->
<!--- {float:right, width:50%} --->
![](../assets/attention.png)
Wat een gortdroge tekst was me dat nu net? Waarom moeten we al deze datatypes kennen? Wel, we hebben deze nodig om **variabelen** aan te maken. En variabelen zijn het hart van ieder programma. Zonder variabelen ben je aan het programmeren aan een programma dat een soort vergevorderde vorm van dementie heeft en hoegenaamd niets kan onthouden. 
<!---{/aside}--->
<!---NOBOOKSTART--->
{% endhint %}
<!---NOBOOKEND--->
