# Arrays en klassen

## Object arrays

In het vorige boekdeel bespraken we reeds arrays. In dit hoofdstuk tonen we dat ook arrays van objecten perfect mogelijk zijn. We weten reeds dat klassen niet meer dan zijn dan nieuwe datatypes, en dus is het ook logisch dat wat we reeds met arrays konden, we dit gewoon kunnen blijven doen, maar met objecten. **Maar**, er is één grote maar: omdat we met objecten werken moeten we rekening houden met het feit dat de individuele objecten in je array **reference** values hebben en dus mogelijk ``null`` zijn. Met andere woorden: het is van essentiëel belang dat je het hoofdstuk rond geheugenmanagement in C# goed begrijpt, want we gaan het geregeld nodig hebben.

Let's go!

### Array van objecten aanmaken

Een array van objecten aanmaken doe je als volgt:

```java
Student[] mijnKlas = new Student[20];
```

De ``new`` zorgt er echter enkel voor dat er een referentie naar een nieuwe array wordt teruggegeven, waar ooit 20 studenten-objecten in kunnen komen. **Maar: er staan dus nog géén objecten in deze array. Alle elementen in deze array zijn nu nog ``null``.**

![De referentie naar een , nu nog, lege array is aangemaakt](../assets/6_klassen/beginarraysit.png)



{% hint style='tip' %}
Je zou kunnen zeggen dat we enkel nog maar de parkeerlijnen hebben aangemaakt.

![Een parking, klaar om gevuld te worden](../assets/6_klassen/legearray.png)
{% endhint %}


Willen we nu elementen in deze array plaatsen dan moeten dit ook expliciet doen en moeten we dus objecten aanmaken en hun referentie in de array bewaren:

```java
mijnKlas[0]= new Student();
mijnKlas[2]= new Student();
```

![De referentie naar een , nu nog, lege array is aangemaakt](../assets/6_klassen/beginarraysit2.png)


Uiteraard kan dit ook in een loop indien relevant voor de opgave.

Probeer je objecten te benaderen die nog niet bestaan dan zal je uiteraard een ``NullReferenceException`` krijgen.



### Individueel object benaderen

Van zodra een object in de array staat kan je deze vanuit de array aanspreken d.m.v. de index :

```java
mijnKlas[3].Name= "Vincent Lagasse";
```


### Array initializer syntax

Je kan ook een variant op de object initializer syntax gebruiken waarbij de objecten reeds van bij de start in de array worden aangemaakt. Als extra'tje zorgt dit er ook voor dat we geen lengte moeten meegeven, de compiler zal deze zelf bepalen. Volgende voorbeeld maakt een nieuwe array aan die bestaat uit 2 nieuwe studenten, alsook 1 bestaande (``jos``):

```java
Student jos = new Student();

//...

Student[] mijnKlas = new Student[]
    {
        new Student(),
        new Student(),
        jos,
    };
```

Let op de puntkomma helemaal achteraan. Die wordt als eens vergeten.


{% hint style='tip' %}
Het kan niet genoeg benadrukt worden dat een goede kennis van de heap, stack en referenties essentieel is om te leren werken met arrays van objecten. Uit voorgaande stukje code zien we duidelijk dat een goed inzicht in referenties je van veel leed beschermen. Bekijk eens de eindsituatie van voorgaande code:

![](../assets/6_klassen/objeeindsit.png)

Zoals je merkt zal nu de student ``jos`` niet verwijderd worden indien we op gegeven moment schrijven ``jos == null`` daar het object nog steeds bestaat via de array.
We kunnen met andere woorden op 2 manieren de student ``jos`` momenteel bereiken, via de arrays of via ``jos``:

```java
jos.Naam= "Joske Vermeulen";
mijnKlas[2].Naam = "Franske Vermeulen"; //we overschrijven "Joske Vermeulen"
```

{% endhint %}



#### Null-check met ?

Ook hier kan je met ``?`` een null-check schrijven:

```java
mijnKlas?[3]?.Name= "Romeo Montague ";
```

Merk op dat het eerste vraagteken controleert of de array zelf niet ``null`` is. Het tweede vraagteken, na de index, is om te controleren of het element op die index niet ``null`` is.

### Object arrays als parameters en return

Ook arrays mag je als parameters en returntype gebruiken in methoden. De werking hiervan is identiek aan die van value-types zoals volgende voorbeeld toont: 

```java
static Student[] CreateEmptyStudentArray()
{
    return new Student[10]();
}


// Aanroep:

Student[] resultaat = CreateEmptyStudentArray();
```