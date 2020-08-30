## Strings samenvoegen
Je kan strings en variabelen samenvoegen tot een nieuwe string op verschillende manieren:
* +-operator 
* $ string interpolation 
* Of de oude manier:  ``String.Format()`` 

{% hint style='tip' %}
In dit boek prefereren we **manier 2**, de string interpolatie. Dit is de meest moderne aanpak.
{% endhint %}

In de volgende sectie gaan we van volgende informatie uit:

* Stel dat je 2 variabelen hebt ``int age=13`` en ``string name="Finkelstein"``.
* We willen de inhoud van deze variabelen samenvoegen in een nieuwe ``string result`` die zal bestaan uit de tekst: ``Ik ben Finkelstein en ik ben 13 jaar oud.``

Volgende 3 manieren tonen hoe je steeds tot voorgaande string zal komen.

### Manier 1: String samenvoegen met de +-operator
Je kan string en variabelen eenvoudig bij elkaar 'optellen' zoals we in het begin van dit boek hebben gezien. Ze worden dan achter elkaar geplakt als het ware. 

```java
string result= "Ik ben "+ name + " en ik ben "+ age+ " jaar oud.";
```

Let er op dat je tussen de aanhalingsteken (binnen de strings) spaties zet indien je het volgende deel niet tegen het vorige stringstuk wilt 'plakken'.

{% hint style='warning' %}
Toch even goed opletten hier. De volgorde van strings met andere types samenvoegen (**concateneren**) bepaalt wat de uitvoer zal zijn! Kijk zelf:

```java
Console.WriteLine("1"+1+1);
Console.WriteLine(1+1+"1");
Console.WriteLine("1" + (1 + 1));
```

Geef als uitvoer:

<!---{line-numbers:false}--->
```text
111
21
12
```

Was dit de uitvoer die je voorspeld had?

Ook in dit soort code wordt dus de volgorde van bewerkingen gerespecteerd. De **concatenatie gebeurt van links naar rechts en de linkse operand zal steeds bepalen wat het resultaat van de bewerking zal zijn indien er twijfel is**.  Dit nieuw samengevoegde deel wordt dan de linkse operand voor het volgende deel.

Kijken we dus naar ``"1"+1+1`` dan wordt dit eerst ``"11"+1`` en dus vervolgens de ``string`` ``"111"``.
Bij ``1+1+"1"`` krijgen we eerste ``2+"1"``, dit geeft vervolgens ``21`` (aangezien C# niet kan bepalen dat de string iets bevat wat een getal kan zijn, en dus besluit om beide operands als een ``string`` te zien wat altijd de veiligste oplossing is).
{% endhint %}


### Manier 2: String interpolation met $
In de oude dagen van C# gebruikten we ``String.Format()`` (zie hierna) om meerdere strings en variabelen samen te voegen tot één string. Het nadeel van de +-operator uit manier 1 is dat je strings erg lang en onleesbaar worden én je kan niet op voorhand een ``string`` aanmaken waar nadien bepaalde delen, als het ware on-the-fly, dynamisch ingevuld kunnen worden. 

Dankzij *string interpolation* kan dit wel **waarbij we het ``$``-teken gebruiken vooraan de ``string`` om aan te geven dat specifieke delen van de zin geïnterpoleerd moeten worden**

Door het $-teken **VOOR** de string te plaatsen geef je aan dat alle delen in de string die *tussen accolades staan* als code mogen beschouwd worden. Een voorbeeld maakt dit duidelijk:

```java
string result= $"Ik ben {name} en ik ben {age} jaar oud.";
```

In dit geval zal  de inhoud van de variabele ``name`` tussen de string op de plek waar nu ``{name}`` staat geplaatst worden. Idem voor ``age``.
Zoals je kan zien is dit veel meer leesbare code dan de eerste manier.

Het resultaat zal dan worden: ```Ik ben Finkelstein en ik ben 13 jaar oud.```

<!---{pagebreak} --->

#### Berekeningen doen bij string interpolatie
Je mag eender welke *expressie* tussen de accolades zetten bij string interpolation, denk maar aan:
```java
string result= $"Ik ben {name} en ik ben {age+4} jaar oud.";
```

Alle expressies tussen de accolades zullen eerst uitgevoerd worden voor ze tussen de string worden geplaatst. De uitvoer wordt nu dus:  ```Ik ben Finkelstein en ik ben 17 jaar oud.```

Eender welke expressie is toegelaten, dus je kan ook complexe berekeningen of zelfs andere methoden aanroepen:
```java
string result= $"Ik ben {age*age+(3%2)} jaar oud.";
```

{% hint style='warning' %}
Uiteraard mag je dit dus ook gebruiken wanneer je eenvoudiger zaken naar het scherm wenst te sturen gebruik makende van ``Console.WriteLine`` en interpolatie:

<!---{line-numbers:false}--->
```java
Console.WriteLine($"3 maal 9 is  {3*9}");
```
{% endhint %}


#### Mooier formatteren
Zowel bij string interpolation (manier 2) als de manier hierna kan je ook bepalen hoe de te tonen variabelen en expressies juist weergegeven moeten worden. Je geeft dit aan door na de expressie, binnen de accolades, een dubbelpunt te plaatsen gevolgd door de manier waarop moet geformatteerd worden.

Wil je bijvoorbeeld een kommagetal tonen met maar 2 cijfers na de komma dan schrijf je:

```java
double number = 12.345;
Console.WriteLine($"{number:F2}");
```

Er zal ``12.34`` op het scherm verschijnen: 

Merk op dat bij string formatting er **niet afgerond** wordt. C# zal eenvoudiger weg alle decimalen wegkappen die niet gewenst zijn, ongeacht hun waarde.

{% hint style='tip' %}
Nog enkele nuttige vormen:
* D5: toon een geheel getal als een 5 cijfer getal (``123`` wordt ``00123``) (werkt uiteraard enkel op gehele getallen!)
* E2: wetenschappelijke notatie met 2 cijfers precisie (``12000000`` wordt ``1,20E+007`` i.e. *"1 komma 2 maal tien tot de zevende"*)
* C: geldbedrag (``12,34`` wordt € 12,34: teken van valuta afhankelijk van instellingen pc). 

  
Alle overige format specifiers staan [hier opgelijst](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings).
{% endhint %}

### Manier 3: String.Format()
String interpolatie met het $-teken is een nieuwe C# aanwinst. Je zal echter nog veel documentatie en online code tegenkomen die nog met ``String.Format`` werkt (ook zijn er nog zaken waar het te prefereren is om ``String.Format`` te gebruiken i.p.v. 1 van vorige manieren). Om die reden bespreken we dit nog in dit boek.

``String.Format`` is een ingebouwde methode die string-interpolatie toelaat op een iets minder intuïtieve manier, als volgt:

```java
string result= String.Format("Ik ben {0} en ik ben {1} jaar oud.",name,age);
```

Het getal tussen de accolades geeft telkens aan de hoeveelste parameter na de string hier in de plaats moet gezet worden (0= de eerste, 1= de tweede, enz). De eerste parameter is ``name``, de tweede is ``age``.

Volgende code zal een ander resultaat geven:
```java
string result= String.Format("Ik ben {1} en ben {1} jaar.",name,age);
```

Namelijk:  ``Ik ben 13 en ik ben 13 jaar oud.``

<!---NOBOOKSTART--->
### Kennisclip
![](../assets/infoclip.png)

* [String interpolation](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=a3d572bc-f72d-4622-9875-abe300b9ecf7)
<!---NOBOOKEND--->